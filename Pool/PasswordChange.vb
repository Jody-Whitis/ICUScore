Public Class PasswordChange
    Dim passwordUpdate As New Authenticate(CurrentSession.UserEmail, CurrentSession.Password, CurrentSession.IsLoggedIn)
    Private Sub PasswordChange_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        CurrentScreen = AppState.Edit
    End Sub

    Private Sub btnUpdatePassword_Click(sender As Object, e As EventArgs) Handles btnUpdatePassword.Click
        Dim isUpdated As Boolean = False
        lblUpdate.ForeColor = Color.Lime
        If txtNewPassword.Text.Equals(txtNewPasswordConfirm.Text) Then
            isUpdated = passwordUpdate.ILogin_UpdatePassword(txtNewPassword.Text, txtCurrentPassword.Text)
        End If
        If isUpdated.Equals(True) Then
            CurrentSession.PreviousForm.Show()
            Me.Close()
        Else
            lblUpdate.ForeColor = Color.Red
            lblUpdate.Text = "Incorrect Current/New Password"
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If CurrentSession.PreviousForm IsNot Nothing Then
            CurrentSession.PreviousForm.Show()
        Else
            Home.Activate()
            Home.Show()
        End If
        Me.Close()
    End Sub
End Class