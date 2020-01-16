Imports System.Security.Cryptography
Imports System.Text
Imports Pool
Imports Pool.Games
Public Class Authenticate : Implements ILogin

#Region "Props/Constr"
    Private Structure HashFormat
        Public length As Integer
        Public salt As Byte()
        Public hash As Byte()
    End Structure

    Public Enum PermissioninApp
        Debug = -1
        Admin = 0
        User = 1
        Unregister = 2
    End Enum

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
    Public Function GetLogin() As Boolean Implements ILogin.GetLogin
        Dim isLoginCreds As Boolean = False
        Dim hashedPasswordDS As New Games

        'Get hashed string from db
        Dim pwdHashDS = hashedPasswordDS.GetAllResults($"exec [selUserPwdHashed] @user='{User}'")
        Dim hashpwdfromDB As String = pwdHashDS.Tables(0).Rows(0).Item("password")

        'Split to get length:salt:hash
        Dim hashfromDB As New HashFormat
        With hashfromDB
            .length = hashpwdfromDB.Split(":").First
            .salt = Convert.FromBase64String(hashpwdfromDB.Split(":")(1))
            .hash = Convert.FromBase64String(hashpwdfromDB.Split(":").Last)
        End With

        'Generate hash from passed password
        Dim hashtool As New Rfc2898DeriveBytes(Password, hashfromDB.salt)
        hashtool.IterationCount = hashfromDB.length
        Dim hashBytefromForm = hashtool.GetBytes(24)

        'Compare until we find an incorrect byte
        'If we make it to the end, then it's good
        isLoginCreds = CompareHash(hashBytefromForm, hashfromDB.hash)

        'If their login, then put a timestamp
        If isLoginCreds.Equals(True) Then
            Dim insertLoginSQl As New StringBuilder
            With insertLoginSQl
                .Append("exec [insLoginUser] ")
                .Append($"@user = '{User}',")
                .Append($"@lastLogin = '{Now.ToString}',")
                .Append($"@loginDevice = '{Environment.MachineName.ToString}',")
                .Append($"@hashMatch = {Convert.ToInt32(isLoginCreds)},")
                .Append($"@Success = {Convert.ToInt32(isLoginCreds)}")
            End With
            Debug.WriteLine(hashedPasswordDS.GetAllResults(insertLoginSQl.ToString))
        End If
        Debug.WriteLine(isLoginCreds)
        Return isLoginCreds
    End Function


    ''' <summary>
    ''' Update or create password
    ''' Generate salt and hash the string
    ''' Insert colon delimited base64 string into DB
    ''' </summary>
    ''' <returns></returns>
    Public Function ILogin_UpdatePassword(newPassword As String) As Boolean Implements ILogin.UpdatePassword
        'Get Salt for inserting
        Dim saltCrpto As New RNGCryptoServiceProvider
        Dim hashedPasswordDS As New Games
        Dim updatedDS As New DataSet
        Dim saltyByteFromForm = New Byte(7) {}
        saltCrpto.GetBytes(saltyByteFromForm)

        'Produce the salt/hashed password for db
        ''''''''''''''''''''''''''''''''''''''''
        Dim hashtool As New Rfc2898DeriveBytes(newPassword, saltyByteFromForm)
        hashtool.IterationCount = 1500
        Dim hashBytefromForm = hashtool.GetBytes(24)

        'Hashed string for DB inserstion/login
#Region "Compute Comparsion of new/old password hashes"
        Dim hashedPasswordfromForm As String = $"1500:{Convert.ToBase64String(saltyByteFromForm)}:{Convert.ToBase64String(hashBytefromForm)}"
        Dim compareHashesDS As DataSet = hashedPasswordDS.GetAllResults($"exec [selUserPwdHashed] @user='{User}'")
        Dim compareHashString As String = compareHashesDS.Tables(0).Rows(0).Item("password")
        Dim compareHashesForUpdate As New HashFormat
        With compareHashesForUpdate
            .length = compareHashString.Split(":").First
            .salt = Convert.FromBase64String(compareHashString.Split(":")(1))
            .hash = Convert.FromBase64String(compareHashString.Split(":").Last)
        End With
#End Region

        Dim hashtoolCompare As New Rfc2898DeriveBytes(newPassword, compareHashesForUpdate.salt)
        hashtoolCompare.IterationCount = compareHashesForUpdate.length
        Dim hashCompareByte = hashtoolCompare.GetBytes(24)

        If CompareHash(hashCompareByte, compareHashesForUpdate.hash).Equals(False) Then
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
    ''' Compare two hashes
    ''' if we reach the end it's a match,
    ''' or we keep going till until it doesn't match
    ''' and exit
    ''' </summary>
    ''' <param name="hashBytefromForm"></param>
    ''' <param name="hashFromDB"></param>
    ''' <returns></returns>
    Private Function CompareHash(hashBytefromForm As Byte(), hashFromDB As Byte()) As Boolean Implements ILogin.CompareHash
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

    Public Function GetPermissions(userType As Integer, isLogin As Boolean) As Boolean Implements ILogin.GetPermissions
        Throw New NotImplementedException()
    End Function

End Class
