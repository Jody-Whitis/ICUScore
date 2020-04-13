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

    ''' <summary>
    ''' Make a 4-6 digit code to set it
    ''' to GeneratedCode property
    ''' </summary>
    ''' <returns></returns>
    Public Function GetCode() As Integer
        Try
            Dim generateNumber As New Random()
            GeneratedCode = generateNumber.Next(1000, 9999)
        Catch ex As Exception
            Dim pinLogError As New Logging(Now.ToString, "Pin Generation", ex.ToString)
            pinLogError.LogAction()
        End Try
        Return GeneratedCode
    End Function

    ''' <summary>
    ''' Check against the user's input with the 
    ''' last set generated code.
    ''' </summary>
    ''' <param name="userInput"></param>
    ''' <returns></returns>
    Public Function Authenticate(userInput As Integer) As Boolean
        If userInput = GeneratedCode Then
            Return True
        Else
            Return False
        End If
    End Function

End Class
