Imports System.Security.Cryptography
Imports Pool.Games
Public Class Test

    Public Sub GetL(ByRef txt As String, ByRef pws As String)
        Dim user As String = txt
        Dim salts As New RNGCryptoServiceProvider
        Dim salty = New Byte(7) {}
        salts.GetBytes(salty)

        Dim hashtool As New Rfc2898DeriveBytes(pws, salty)
        hashtool.IterationCount = 1500
        Dim hash = hashtool.GetBytes(24)
        Dim testdbhashed As New Games

        Dim dbstring As String = $"1500:{Convert.ToBase64String(salty)}:{Convert.ToBase64String(hash)}"
        Dim sucess = testdbhashed.GetAllResults($"exec [insLoginUser] @user = '{txt}',@password='{dbstring}',@lastlogin ='{Now.ToString}' ")

        Dim stringfromdb As String = testdbhashed.GetAllResults("select top 1 password from Login").Tables(0).Rows(0).Item("password")

        Dim hashparts As String() = stringfromdb.ToString.Split(":")
        Dim iterations As Integer = Convert.ToInt32(hashparts.First)
        Dim orgSalt As Byte() = Convert.FromBase64String(hashparts(1))
        Dim orgHash As Byte() = Convert.FromBase64String(hashparts.Last)



        Dim rfc2 As New Rfc2898DeriveBytes(hash.ToString, orgSalt)
        hashtool.IterationCount = 1500
        Dim testHash As Byte() = hashtool.GetBytes(orgHash.Length)






        For i = 0 To testHash.Length - 1
            If Not testHash(i).Equals(hash(i)) Then
                Dim isLog As Boolean = False
            End If
        Next

        'insert hashed
        'pull up and compute it against what is always entered

    End Sub

End Class
