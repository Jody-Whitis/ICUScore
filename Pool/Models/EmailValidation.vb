Imports System.Text.RegularExpressions
Namespace Models.Validation
    Public Class EmailValidation
        Inherits ValidationBase
        Private emailPattern As String = "\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"

        Public Overrides Function isValid(emailAddress As String) As Boolean
            Dim emailRegex As Regex = New Regex(emailPattern)
            If emailRegex.IsMatch(emailAddress) Then
                Return True
            Else
                Return False
            End If
        End Function

    End Class
End Namespace

