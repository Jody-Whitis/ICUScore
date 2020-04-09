Public Class TwoFactorAuthenication
    Inherits Authenticate
    Private _generatedCode As Integer = 0
    Public Property GeneratedCode As Integer
        Get
            If _generatedCode > 0 Then Return _generatedCode Else Return GetCode()
        End Get
        Set(value As Integer)
            _generatedCode = value
        End Set
    End Property

    Public Function GetCode() As Integer
        Return 404
    End Function

    Public Function Authenticate(userInput As Integer) As Boolean
        If userInput = GeneratedCode Then
            Return True
        Else
            Return False
        End If
    End Function

End Class
