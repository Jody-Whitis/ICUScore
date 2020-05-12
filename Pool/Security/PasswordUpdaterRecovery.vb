Imports System.Security.Cryptography
Imports System.Text

Public Class PasswordUpdaterRecovery
    Inherits Authenticate

    ''' <summary>
    ''' Set to temporary password sent to this user.
    ''' </summary>
    ''' <param name="newPassword"></param>
    ''' <returns></returns>
    Public Overloads Function ILogin_UpdatePassword(newPassword As String, tempPassword As Integer) As Boolean
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
        Dim hashedPasswordfromForm As String = $"1500:{Convert.ToBase64String(saltyByteFromForm)}:{Convert.ToBase64String(hashBytefromForm)}"

        'Insert hash password/update
        Dim updPassword As New StringBuilder
        With updPassword
            .Append($"exec [updPassword] ")
            .Append($"@user = '{User}',")
            .Append($"@newPassword = '{$"1500:{Convert.ToBase64String(saltyByteFromForm)}:{Convert.ToBase64String(hashBytefromForm)}"}',")
            .Append($"@isLogin = '{Convert.ToInt32(isLoggedIn)}', ")
            .Append($"@tempPassword={tempPassword},")
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

        Return False
    End Function


    ''' <summary>
    ''' Compare temp password
    ''' </summary>
    ''' <returns></returns>
    Public Overrides Function GetLogin() As Boolean
        Dim isLoginCreds As Boolean = False
        Dim hashedPasswordDS As New Games
        Dim hashpwdFromDB As String = String.Empty
        'Get hashed string from db
        Dim pwdHashDS = hashedPasswordDS.GetAllResults($"exec [selUserPwdHashedTemp] @user='{User}'")
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

End Class
