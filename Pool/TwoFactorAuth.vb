Public Class TwoFactorAuth
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
        code = twoFactorUser.GeneratedCode()
        Dim twoFactorEmail As New Email(New List(Of String) From {SelectedEmail})
        twoFactorEmail.SentTwoFactorCodeEmail(SelectedEmail, Now.ToString("MM/dd/yyyy"), code)
        Me.CenterToScreen()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If tbCode.Text = code Then
            CurrentSession.isTwoFactorCode = True
            ScoreTheme.LoadNextFormClose(Me, Home)
            Me.Close()
        Else
            Dim incorrectAlert As DialogResult = MessageBox.Show($"The pin you entered is incorrect",
                "Incorrect Pin", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End If
    End Sub

    Private Sub btnResend_Click(sender As Object, e As EventArgs) Handles btnResend.Click
        code = twoFactorUser.GeneratedCode() * 2
        Dim twoFactorEmail As New Email(New List(Of String) From {SelectedEmail})
        twoFactorEmail.SentTwoFactorCodeEmail(SelectedEmail, Now.ToString("MM/dd/yyyy"), code)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'Reset user's attempted creds on canceling auth
        ScoreTheme.LogOutUser()
        ScoreTheme.LoadNextFormClose(Me, Home)
    End Sub
End Class