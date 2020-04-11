Public Class TwoFactorAuthenication
    Inherits Authenticate
    Private _generatedCode As Integer = 0
    Public Property GeneratedCode As Integer
        Get
            Return _generatedCode
        End Get
        Set(value As Integer)
            _generatedCode = value
        End Set
    End Property

    Public Function GetCode() As Integer
        Try
            Dim generateNumber As New Random()
            GeneratedCode = generateNumber.Next(1000, 9999)
        Catch ex As Exception
            Dim pinLogError As New Logging(Now.ToString, "Pin Generation", ex.ToString)
        End Try
        Return GeneratedCode
    End Function

    Public Function Authenticate(userInput As Integer) As Boolean
        If userInput = GeneratedCode Then
            Return True
        Else
            Return False
        End If
    End Function

End Class
