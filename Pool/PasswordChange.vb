Public Class PasswordChange
    Dim passwordUpdate As New Authenticate(CurrentSession.UserEmail, CurrentSession.Password, CurrentSession.IsLoggedIn)
    Private Sub PasswordChange_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        CurrentScreen = AppState.Edit
    End Sub

#Region "Functions/Subs"
    Private Function isValidatedEntry(ByRef fields As Control()) As Boolean
        For Each field In fields
            If String.IsNullOrEmpty(field.Text) Then
                Return False
            End If
        Next
        Return True
    End Function
#End Region

#Region "Event Handlers"
    Private Sub btnUpdatePassword_Click(sender As Object, e As EventArgs) Handles btnUpdatePassword.Click
        Dim isUpdated As Boolean = False
        lblUpdate.ForeColor = Color.Aquamarine
        If isValidatedEntry(New Control() {txtCurrentPassword, txtNewPassword, txtNewPasswordConfirm}).Equals(True) Then
            If txtNewPassword.Text.Equals(txtNewPasswordConfirm.Text) Then
                isUpdated = passwordUpdate.ILogin_UpdatePassword(txtNewPassword.Text, txtCurrentPassword.Text)
            End If
            If isUpdated.Equals(True) Then
                ScoreTheme.LoadNextFormClose(Me, Home)
            Else
                lblUpdate.ForeColor = Color.Red
                lblUpdate.Text = "Incorrect Current/New Password"
            End If
        Else
            Dim RequiredField As DialogResult = MessageBox.Show($"Missing required fields",
        "Missing Requirement", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ScoreTheme.LoadNextFormClose(Me, Home)
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        AboutThis.Activate()
        AboutThis.Show()
    End Sub

    Private Sub LogOutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        ScoreTheme.LogOutUser()
    End Sub

    Private Sub QuitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        Application.Exit()
    End Sub

#End Region

End Class