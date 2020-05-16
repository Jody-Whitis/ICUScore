Imports System.Text.RegularExpressions

Namespace Models.Validation
    Public Class PasswordValidation
        Inherits ValidationBase

        Private upperCase As New Regex("[A-Z]")
        Private lowerCase As New Regex("[a-z]")
        Private digits As New Regex("[0-9]")
        Private special As New Regex("[^A-Za-z0-9]")

        ''' <summary>
        ''' Valids the type of password to be created.
        ''' Must contain at least one of the following:
        ''' (Uppercase,lowercase,digit)
        ''' Must be at least 6 characters long.
        ''' </summary>
        ''' <param name="input"></param>
        ''' <returns>isValidPassword</returns>
        Public Overrides Function isValid(input As String) As Boolean

            If upperCase.Matches(input).Count < 1 Then Return False
            If lowerCase.Matches(input).Count < 1 Then Return False
            If digits.Matches(input).Count < 1 Then Return False
            If input.Length < 6 Then Return False

            Return True
        End Function

    End Class

End Namespace
