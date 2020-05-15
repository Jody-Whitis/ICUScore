Imports System.Text.RegularExpressions

Namespace Models.Validation
    Public Class PasswordValidation
        Inherits ValidationBase
        Private passwordPattern As String = "([a-zA-Z]){6,}\d"

        ''' <summary>
        ''' Valids the type of password to be created.
        ''' Runs through Password generation too.
        ''' </summary>
        ''' <param name="input"></param>
        ''' <returns></returns>
        Public Overrides Function isValid(input As String) As Boolean
            Dim emailRegex As Regex = New Regex(passwordPattern)
            If emailRegex.IsMatch(passwordPattern) Then
                Return True
            Else
                Return False
            End If
        End Function

    End Class

End Namespace
