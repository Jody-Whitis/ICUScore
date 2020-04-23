Public Class ValidationBase : Implements IValidation

    Public Overridable Function isValid(input As String) As Boolean Implements IValidation.isValid
        Return True
    End Function

    Public Function SQLValidation(input As String) As String Implements IValidation.SQLValidation
        Return input.Replace("'", "''").Trim
    End Function

End Class
