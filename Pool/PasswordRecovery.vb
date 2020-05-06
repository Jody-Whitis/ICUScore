Public Class PasswordRecovery


    Private Sub PasswordRecovery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ScoreTheme.LoadNextFormClose(Me, Home)
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

        ''if password matches the temporary then
        ''set session and prompt a change
        Dim passwordAlert As DialogResult = MessageBox.Show($"Do you want to set a new password now? *Temporary password expires in 30 mins*",
"Update Password", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If passwordAlert.Equals(DialogResult.Yes) Then
            ScoreTheme.LoadNextFormClose(Me, PasswordChange)
        Else
            btnCancel_Click(Nothing, Nothing)
        End If

    End Sub
End Class