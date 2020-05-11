Public Class PasswordChange
    Dim passwordUpdate As New Authenticate(CurrentSession.UserEmail, CurrentSession.Password, CurrentSession.IsLoggedIn)
    Private Sub PasswordChange_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        CurrentScreen = AppState.Edit
        If CurrentSession.IsUsingTempPassword Then
            ScoreTheme.SetControl(New Control() {txtCurrentPassword}, False)
        End If
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

    Private Sub SetAlerts(isUpdated)
        If isUpdated.Equals(True) Then
            Dim RequiredField As DialogResult = MessageBox.Show($"Password is Updated!",
    "Updated Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ScoreTheme.LoadNextFormClose(Me, Home)
        Else
            Dim RequiredField As DialogResult = MessageBox.Show($"Incorrect Password!",
    "Incorrect Password", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

#End Region

#Region "Event Handlers"
    Private Sub btnUpdatePassword_Click(sender As Object, e As EventArgs) Handles btnUpdatePassword.Click
        Dim isUpdated As Boolean = False
        lblUpdate.ForeColor = Color.Aquamarine

        If CurrentSession.IsUsingTempPassword Then
            If isValidatedEntry(New Control() {txtNewPassword, txtNewPasswordConfirm}).Equals(True) AndAlso txtNewPassword.Text.Equals(txtNewPasswordConfirm.Text) Then
                Dim tempPasswordUser As New PasswordUpdaterRecovery With {.User = CurrentSession.UserEmail, .isLoggedIn = True}
                isUpdated = tempPasswordUser.ILogin_UpdatePassword(txtNewPassword.Text)
                CurrentSession.IsUsingTempPassword = False
            End If
        Else
            If isValidatedEntry(New Control() {txtCurrentPassword, txtNewPassword, txtNewPasswordConfirm}).Equals(True) AndAlso txtNewPassword.Text.Equals(txtNewPasswordConfirm.Text) Then
                isUpdated = passwordUpdate.ILogin_UpdatePassword(txtNewPassword.Text, txtCurrentPassword.Text)
            End If
        End If
        SetAlerts(isUpdated)
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