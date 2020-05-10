Imports System.Security.Cryptography
Imports System.Text

Public Class PasswordRecover
    Inherits Authenticate

    Public Function GeneratePassword() As String

        Return String.Empty
    End Function

    ''' <summary>
    ''' Set to temporary password sent to this user.
    ''' </summary>
    ''' <param name="newPassword"></param>
    ''' <returns></returns>
    Public Overloads Function ILogin_UpdatePassword(newPassword As String) As Boolean
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

End Class
