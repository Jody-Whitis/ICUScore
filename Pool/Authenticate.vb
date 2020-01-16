Imports System.Security.Cryptography
Imports Pool
Imports Pool.Games
Public Class Authenticate : Implements ILogin

#Region "Props/Constr"
    Public Property User As String
    Public Property Password As String

    Public Sub New()
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
        Dim saltFromDB = Convert.FromBase64String(hashpwdfromDB.Split(":")(1))
        Dim hashFromDB = Convert.FromBase64String(hashpwdfromDB.Split(":").Last)
        Dim lengthFromDB = hashpwdfromDB.Split(":").First

        'Generate hash from passed password
        Dim hashtool As New Rfc2898DeriveBytes(Password, saltFromDB)
        hashtool.IterationCount = lengthFromDB
        Dim hashBytefromForm = hashtool.GetBytes(24)

        'Compare until we find an incorrect byte
        'If we make it to the end, then it's good
        isLoginCreds = CompareHash(hashBytefromForm, hashFromDB)

        Debug.WriteLine(isLoginCreds)
        Return isLoginCreds
    End Function


    ''' <summary>
    ''' Update or create password
    ''' Generate salt and hash the string
    ''' Insert colon delimited base64 string into DB
    ''' </summary>
    ''' <returns></returns>
    Private Function ILogin_UpdatePassword() As Boolean Implements ILogin.UpdatePassword
        'Get Salt for inserting
        Dim saltCrpto As New RNGCryptoServiceProvider
        Dim hashedPasswordDS As New Games
        Dim saltyByteFromForm = New Byte(7) {}
        saltCrpto.GetBytes(saltyByteFromForm)

        'Produce the salt/hashed password for db
        ''''''''''''''''''''''''''''''''''''''''
        Dim hashtool As New Rfc2898DeriveBytes(Password, saltyByteFromForm)
        hashtool.IterationCount = 1500
        Dim hashBytefromForm = hashtool.GetBytes(24)

        'Hashed string for DB inserstion/login
        Dim hashedPasswordfromForm As String = $"1500:{Convert.ToBase64String(saltyByteFromForm)}:{Convert.ToBase64String(hashBytefromForm)}"

        'Insert hash password/update
        hashedPasswordDS.GetAllResults("")
        Return String.Empty
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
