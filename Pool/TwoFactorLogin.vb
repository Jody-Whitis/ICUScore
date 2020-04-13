Public Class TwoFactorLogin
    Private _selectedEmail As String
#Region "Vars/Properties"
    Public Property SelectedEmail As String
        Get
            Return _selectedEmail
        End Get
        Set(value As String)
            _selectedEmail = value
        End Set
    End Property

    Dim twoFactorUser As New TwoFactorAuthenication
    Dim code As Integer = 0
#End Region

    Private Sub TwoFactorAuth_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        twoFactorUser.User = SelectedEmail
        SendCode(code)
        Me.CenterToScreen()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim userInputCode As Integer = 0
        Integer.TryParse(tbCode.Text.Trim, userInputCode)
        If userInputCode > 0 AndAlso twoFactorUser.Authenticate(userInputCode) Then
            CurrentSession.isTwoFactorCodeAuthenticate = True
            ScoreTheme.LoadNextFormClose(Me, Home)
            Me.Close()
        Else
            Dim incorrectAlert As DialogResult = MessageBox.Show($"The pin you entered is incorrect",
                "Incorrect Pin", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End If
    End Sub

    Private Sub btnResend_Click(sender As Object, e As EventArgs) Handles btnResend.Click
        Dim previousCode As Integer = code

        'In case of a memory issue, catch it and default the pin
        'Prompt for a retry
        Try
            SendCode(previousCode)
        Catch ex As Exception
            Dim generateUnquieErorr As New Logging(Now.ToString("MM/dd/yyy hh:mm:ss"), "Unique pin", ex.ToString)
            generateUnquieErorr.LogAction()
            code = 0
        End Try

        If code > 0 AndAlso code <> previousCode Then
            Dim resendCode As DialogResult = MessageBox.Show($"A new code is sent to your inbox.",
                "New code sent!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim incorrectAlert As DialogResult = MessageBox.Show($"Your code was not sent! Try again.",
                "New code failed to send!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'Reset user's attempted creds on canceling auth
        ScoreTheme.LogOutUser()
        ScoreTheme.LoadNextFormClose(Me, Home)
    End Sub

    ''' <summary>
    ''' Get generated pin and emails it to user's inbox
    ''' </summary>
    Private Sub SendCode(ByVal previousCode As Integer)
        code = twoFactorUser.GetCode()
        If previousCode > 0 AndAlso previousCode = code Then
            While previousCode = code
                code = twoFactorUser.GetCode()
            End While
        End If
        Dim twoFactorEmail As New Email(New List(Of String) From {SelectedEmail})
        twoFactorEmail.SentTwoFactorCodeEmail(SelectedEmail, Now.ToString("MM/dd/yyyy"), code)
    End Sub
End Class