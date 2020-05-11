Imports System.Security.Cryptography
Imports System.Text
Imports Pool
Imports Pool.Games
Public Class Authenticate : Implements ILogin

#Region "Props/Constr"
    Protected Structure HashFormat
        Public length As Integer
        Public salt As Byte()
        Public hash As Byte()
    End Structure

    Public Property User As String
    Public Property Password As String
    Public Property isLoggedIn As Boolean
    Public Sub New()
    End Sub
    Public Sub New(user As String, password As String, isloggedIn As Boolean)
        Me.User = user
        Me.Password = password
        Me.isLoggedIn = isloggedIn
    End Sub
    Public Sub New(user As String, password As String)
        Me.User = user
        Me.Password = password
    End Sub
#End Region

    ''' <summary>
    ''' Get hashed password for that user
    ''' Generate hash from salt and lenght from DB
    ''' Compare and return login status
    ''' </summary>
    Public Overridable Function GetLogin() As Boolean Implements ILogin.GetLogin
        Dim isLoginCreds As Boolean = False
        Dim hashedPasswordDS As New Games
        Dim hashpwdFromDB As String = String.Empty
        'Get hashed string from db
        Dim pwdHashDS = hashedPasswordDS.GetAllResults($"exec [selUserPwdHashed] @user='{User}'")
        Dim hashFormatSplit = New String() {}
        Try
            hashpwdFromDB = pwdHashDS.Tables(0).Rows(0).Item("password")
            hashFormatSplit = hashpwdFromDB.Split(":")
        Catch ex As Exception
            Dim logHashSplitFail As New Logging(Now, "Hash Split Failed", ex.ToString)
            logHashSplitFail.LogAction()
            'logHashSplitFail.LogActionEmail()
            Return False
        End Try

        Dim lastTimeupdated As New DateTime
        Try
            DateTime.TryParse(pwdHashDS.Tables(0).Rows(0).Item("LastUpdated"), lastTimeupdated)
        Catch ex As Exception
            Debug.WriteLine("first time password")
        End Try

        'Split to get length:salt:hash
        Dim hashfromDB As New HashFormat
        Try
            With hashfromDB
                .length = hashFormatSplit.First
                .salt = Convert.FromBase64String(hashFormatSplit(1))
                .hash = Convert.FromBase64String(hashFormatSplit.Last)
            End With
        Catch ex As Exception
            Dim logHashSplitFail As New Logging(Now, "Hash Split Failed", ex.ToString)
            logHashSplitFail.LogAction()
            logHashSplitFail.LogActionEmail()
            Return False
        End Try

        'Generate hash from passed password      
        Dim hashBytefromForm = CalculateHash(hashfromDB.salt, Password)
        'Compare until we find an incorrect byte
        'If we make it to the end, then it's good
        isLoginCreds = CompareHash(hashBytefromForm, hashfromDB.hash)

        'If their login, then put a timestamp
        If isLoginCreds.Equals(True) Then
            CurrentSession.Password = hashpwdFromDB
            Dim insertLoginSQl As New StringBuilder
            With insertLoginSQl
                .Append("exec [insLoginUser] ")
                .Append($"@user = '{User}',")
                .Append($"@lastLogin = '{Now.ToString}',")
                .Append($"@loginDevice = '{Environment.MachineName.ToString}',")
                .Append($"@hashMatch = {Convert.ToInt32(isLoginCreds)},")
                .Append($"@Success = {Convert.ToInt32(isLoginCreds)}")
            End With
            CheckLastUpdated(lastTimeupdated)
            Debug.WriteLine(hashedPasswordDS.GetAllResults(insertLoginSQl.ToString))
            SetUser(hashedPasswordDS, isLoginCreds)
        End If
        Debug.WriteLine(isLoginCreds)
        Return isLoginCreds
    End Function

    ''' <summary>
    ''' Check if it's been 6 months or more
    ''' Update Password
    ''' </summary>
    ''' <param name="lastimeUpdated"></param>
    Protected Sub CheckLastUpdated(ByVal lastimeUpdated)
        If DateDiff(DateInterval.Month, lastimeUpdated, Now) >= 6 Then
            Dim emailChangePassword As New Email(New String() {User}.ToList)
            Dim reminderSent As Boolean = emailChangePassword.SendPasswordReminder(User, lastimeUpdated)
        End If
    End Sub

    Protected Sub SetUser(ByVal userLogged As Games, ByVal isLoggedCred As Boolean)
        Dim getUserSQL As New StringBuilder
        With getUserSQL
            .Append($"exec [selUserData] @userEmail='{User}',")
            .Append($"@isLogged={Convert.ToInt32(isLoggedCred)}")
        End With
        Dim userDS As New DataSet
        userDS = userLogged.GetAllResults(getUserSQL.ToString)
        Try
            CurrentSession.UserEmail = userDS.Tables(0).Rows(0).Item("emailAddress")
            CurrentSession.ID = userDS.Tables(0).Rows(0).Item("iD")
            CurrentSession.IsLoggedIn = True
            CurrentSession.DisplayName = userDS.Tables(0).Rows(0).Item("PlayerName")
            CurrentSession.Permissions = userDS.Tables(0).Rows(0).Item("permissionLevel")
        Catch ex As Exception
            Debug.WriteLine(ex.ToString)
            Dim setUser As New Logging(Now, "User Log set error: ", ex.ToString)
        End Try
    End Sub

    ''' <summary>
    ''' Returns a dataset of the user's
    ''' options.
    ''' </summary>
    ''' <returns></returns>
    Public Function SelUserOptions() As DataSet
        Dim userOptions As New PlayerStats
        Dim getUserSql As New StringBuilder
        With getUserSql
            .Append($"exec [selUserOptions] @userEmail='{User}'")
        End With
        Dim userDS As New DataSet
        userDS = userOptions.GetAllResults(getUserSql.ToString)
        Return userDS
    End Function

    ''' <summary>
    ''' Update or create password
    ''' Generate salt and hash the string
    ''' Insert colon delimited base64 string into DB
    ''' </summary>
    ''' <returns></returns>
    Public Overridable Function ILogin_UpdatePassword(newPassword As String, currentPassword As String) As Boolean Implements ILogin.UpdatePassword
        'Get Salt for inserting
        Dim saltCrpto As New RNGCryptoServiceProvider
        Dim hashedPasswordDS As New Games
        Dim updatedDS As New DataSet
        Dim saltyByteFromForm = New Byte(7) {}
        saltCrpto.GetBytes(saltyByteFromForm)

        'Produce the salt/hashed password for db
        ''''''''''''''''''''''''''''''''''''''''
        Dim hashBytefromForm = CalculateHash(saltyByteFromForm, newPassword)

        'Hashed string for DB inserstion/login
#Region "Compute Comparsion of new/old password hashes"
        Dim hashedPasswordfromForm As String = $"1500:{Convert.ToBase64String(saltyByteFromForm)}:{Convert.ToBase64String(hashBytefromForm)}"
        'Dim compareHashesDS As DataSet = hashedPasswordDS.GetAllResults($"exec [selUserPwdHashed] @user='{User}'")
        'Dim compareHashString As String = compareHashesDS.Tables(0).Rows(0).Item("password")
        Dim compareHashString As String = CurrentSession.Password
        Dim compareHashFormatSplit = New String() {}


        Try
            compareHashFormatSplit = compareHashString.Split(":")
        Catch ex As Exception
            Dim logHashSplitFail As New Logging(Now, "Hash Split Fail", ex.ToString)
            logHashSplitFail.LogAction()
            'logHashSplitFail.LogActionEmail()
            Return False
        End Try
        Dim compareHashesForUpdate As New HashFormat
        Try
            With compareHashesForUpdate
                .length = compareHashFormatSplit.First
                .salt = Convert.FromBase64String(compareHashFormatSplit(1))
                .hash = Convert.FromBase64String(compareHashFormatSplit.Last)
            End With
        Catch ex As Exception
            Dim logHashSplitFail As New Logging(Now, "Hash Split Failed", ex.ToString)
            logHashSplitFail.LogAction()
            logHashSplitFail.LogActionEmail()
        End Try

#End Region

        Dim hashCompareByte = CalculateHash(compareHashesForUpdate.salt, newPassword)
        Dim confirmByte = CalculateHash(compareHashesForUpdate.salt, currentPassword)
        If CompareHash(hashCompareByte, compareHashesForUpdate.hash).Equals(False) AndAlso CompareHash(confirmByte, compareHashesForUpdate.hash) Then
            'Insert hash password/update
            Dim updPassword As New StringBuilder
            With updPassword
                .Append($"exec [updPassword] ")
                .Append($"@user = '{User}',")
                .Append($"@newPassword = '{$"1500:{Convert.ToBase64String(saltyByteFromForm)}:{Convert.ToBase64String(hashBytefromForm)}"}',")
                .Append($"@isLogin = '{Convert.ToInt32(isLoggedIn)}', ")
                .Append($"@timestamp = '{Now.ToString}'")
            End With
            Try
                updatedDS = hashedPasswordDS.GetAllResults(updPassword.ToString)
                If updatedDS.Tables(0).Rows(0).Item("emailaddress").ToString.Length > 0 Then
                    Return True
                End If
            Catch ex As Exception
                Return False
            End Try

        End If

        Return False
    End Function

    ''' <summary>
    ''' Calulcate hash bytes
    ''' </summary>
    ''' <param name="saltyBytes"></param>
    ''' <param name="vanillaString"></param>
    ''' <returns></returns>
    Protected Function CalculateHash(saltyBytes As Byte(), vanillaString As String) As Byte()
        Dim hashedPasswordDS As New Games
        Dim updatedDS As New DataSet
        'Produce the salt/hashed password for db
        ''''''''''''''''''''''''''''''''''''''''
        Dim hashtool As New Rfc2898DeriveBytes(vanillaString, saltyBytes)
        hashtool.IterationCount = 1500
        Dim hashBytefromForm = hashtool.GetBytes(24)

        Return hashBytefromForm
    End Function

    ''' <summary>
    ''' Compare two hashes
    ''' if we reach the end it's a match,
    ''' or we keep going till until it doesn't match
    ''' and exit
    ''' </summary>
    ''' <param name="hashBytefromForm"></param>
    ''' <param name="hashFromDB"></param>
    ''' <returns></returns>
    Protected Function CompareHash(hashBytefromForm As Byte(), hashFromDB As Byte()) As Boolean Implements ILogin.CompareHash
        For j = 0 To hashBytefromForm.Length - 1
            If Not hashBytefromForm(j).Equals(hashFromDB(j)) Then
                Return False
                Exit For
            ElseIf j = hashBytefromForm.Length - 1 Then
                Return True
            Else
                Continue For
            End If
        Next
        Return False
    End Function

    Public Function GetEncriptedString() As String
        Dim saltCrpto As New RNGCryptoServiceProvider
        Dim saltyByteForForm = New Byte(7) {}
        Dim hashedPassword As String = String.Empty
        Try
            saltCrpto.GetBytes(saltyByteForForm)
            Dim newHash As Byte() = CalculateHash(saltyByteForForm, Password)
            hashedPassword = $"1500:{Convert.ToBase64String(saltyByteForForm)}:{Convert.ToBase64String(newHash)}"
            Return hashedPassword
        Catch ex As Exception
            Return String.Empty
            Dim hashError As New Logging(Now, "Hashing error: ", ex.ToString)
        End Try
        Return hashedPassword
    End Function

End Class
