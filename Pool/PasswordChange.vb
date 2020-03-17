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
        lblUpdate.ForeColor = Color.Lime
        If isValidatedEntry(New Control() {txtCurrentPassword, txtNewPassword, txtNewPasswordConfirm}).Equals(True) Then
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
        Else
            Dim missingRequirements As String = ScoreTheme.GetMissingFieldNames(New Control() {txtCurrentPassword, txtNewPassword, txtNewPasswordConfirm})
            Dim RequiredField As DialogResult = MessageBox.Show($"Missing required fields {missingRequirements}",
        "Missing Requirement", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If CurrentSession.PreviousForm IsNot Nothing Then
            CurrentSession.PreviousForm.Show()
        Else
            Home.Refresh()
            Home.Activate()
            Home.Show()
        End If
        Me.Close()
    End Sub
#End Region

End Class