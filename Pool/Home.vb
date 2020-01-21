Imports Pool.ScoreTheme

Public Class Home
    Dim homeTheme As New ScoreTheme(Me)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        homeTheme.Screen = AppState.Start
        homeTheme.SetBackground(Me)
        homeTheme.SetButtons(New Button() {btnPvP, btnHS, btnQuit, btnLogin, btnLogout})
        homeTheme.SetVisibiltyButton(New Button() {btnPvP, btnHS, btnLogout}, False)
        homeTheme.SetVisibiltyButton(New Button() {btnLogin, btnQuit}, True)
        homeTheme.SetTBox(New TextBox() {txtUser, txtPassword})
        mnuHome.ForeColor = Color.Aquamarine
        lblHome.ForeColor = Color.Aquamarine
        lblHome.ForeColor = Color.Aquamarine
        lblHome.ForeColor = Color.Aquamarine
        lblHome.Font = New Font("Gill Sans Ultra", 15, FontStyle.Bold)
        lblHome.Visible = False
        Me.ShowIcon = True
    End Sub

    Private Sub btnPvP_Click(sender As Object, e As EventArgs) Handles btnPvP.Click
        PvP.Activate()
        PvP.Show()
        Me.Hide()
    End Sub

    Private Sub btnHS_Click(sender As Object, e As EventArgs) Handles btnHS.Click
        HighScores.Activate()
        HighScores.Show()
        Me.Hide()
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click, quitMnu.Click
        Application.Exit()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim userAuthenticate As New Authenticate
        Dim loggedIn As Boolean
        'Password123
        With userAuthenticate
            .User = txtUser.Text.ToString
            .Password = txtPassword.Text.ToString
        End With
        If Not String.IsNullOrEmpty(userAuthenticate.User) AndAlso Not String.IsNullOrWhiteSpace(userAuthenticate.Password) Then
            loggedIn = userAuthenticate.GetLogin()
            userAuthenticate.isLoggedIn = loggedIn
        Else
            loggedIn = False
        End If
        If loggedIn.Equals(True) Then
            UserMod.UserEmail = userAuthenticate.User
            UserMod.IsLoggedIn = userAuthenticate.isLoggedIn
            homeTheme.SetVisibiltyButton(New Button() {btnHS, btnPvP, btnLogout}, True)
            homeTheme.SetVisibiltyButton(New Button() {btnLogin}, False)
            homeTheme.SetVisiblityTxtBox(New TextBox() {txtUser, txtPassword}, False)
            lblHome.Visible = True
            editPasswordMnu.Visible = True
            logOutMnu.Visible = True
        Else
            Dim incorrectAlert As DialogResult = MessageBox.Show($"Incorrect Email and/or/also/maybe Password",
    "Incorrect Creditials", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End If
        txtPassword.ResetText()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click, logOutMnu.Click
        UserMod.UserEmail = String.Empty
        UserMod.IsLoggedIn = False
        homeTheme.SetVisibiltyButton(New Button() {btnHS, btnPvP, btnLogout}, False)
        homeTheme.SetVisibiltyButton(New Button() {btnLogin}, True)
        homeTheme.SetVisiblityTxtBox(New TextBox() {txtUser, txtPassword}, True)
        lblHome.Visible = False
        editPasswordMnu.Visible = False
        logOutMnu.Visible = False
    End Sub

    Private Sub EditPasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles editPasswordMnu.Click
        If UserMod.IsLoggedIn.Equals(True) Then
            PasswordChange.Show()
        End If
    End Sub
End Class