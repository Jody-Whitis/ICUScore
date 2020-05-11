Imports Pool.Models.Validation
Public Class PasswordRecovery
    Dim userLogin As New PasswordUpdaterRecovery
    Dim emailValidation As New EmailValidation
    Private Sub PasswordRecovery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ScoreTheme.LoadNextFormClose(Me, Home)
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        userLogin.User = tbEmailAddress.Text.Trim
        userLogin.Password = tbPassword.Text.Trim

        If userLogin.GetLogin Then
            ''if password matches the temporary then
            ''set session and prompt a change
            CurrentSession.IsUsingTempPassword = True
            Dim passwordAlert As DialogResult = MessageBox.Show($"You will need to change your password now!",
    "Update Password", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ScoreTheme.LoadNextFormClose(Me, PasswordChange)
        Else
            Dim passwordAlert As DialogResult = MessageBox.Show($"You creditials are incorrect!",
          "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Dim tempPassword As New Email(New List(Of String) From {tbEmailAddress.Text})
        Dim generatedPassword As New PasswordGenerator
        Dim generatePassword As String = String.Empty
        Dim passwordUpdated As Boolean = False
        If emailValidation.isValid(tbEmailAddress.Text) Then
            'generate temp password
            'update for that email
            userLogin.User = tbEmailAddress.Text.Trim
            userLogin.isLoggedIn = True
            generatePassword = generatedPassword.GeneratedPassword
            passwordUpdated = userLogin.ILogin_UpdatePassword(generatePassword)
            userLogin.Password = generatePassword
            'Password sent
            If passwordUpdated AndAlso tempPassword.SendTempPassword(tbEmailAddress.Text, generatePassword, Now.ToString) Then
                Dim passwordAlert As DialogResult = MessageBox.Show($"Enter your password sent to this email",
"Temporary Password Send", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Dim passwordAlert As DialogResult = MessageBox.Show($"Your Temporary Password is not sent!",
"Error sending Password", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If

    End Sub
End Class