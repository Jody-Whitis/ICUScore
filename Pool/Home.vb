Imports Pool.ScoreTheme
Public Class Home

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        CurrentScreen = AppState.Start
        ScoreTheme.SetControl(New Button() {btnPvP, btnHS, btnLogout}, False)
        ScoreTheme.SetControl(New Button() {btnLogin, btnQuit}, True)
        lblHome.Visible = False
        Me.ShowIcon = True
        'Check if they a logged in user nagivates to here from outside, two-factor auth, etc
        If CurrentSession.IsLoggedIn Then
            'Check if they have two factor enabled and they passed it
            'Log im after two step auth
            If CurrentSession.TwoFactorEnabled AndAlso CurrentSession.isTwoFactorCodeAuthenticate Then
                SetUserloginScreen()
            End If
        End If
    End Sub

    Private Sub btnPvP_Click(sender As Object, e As EventArgs) Handles btnPvP.Click
        LoadNextFormHide(Me, PvP)
    End Sub

    Private Sub btnHS_Click(sender As Object, e As EventArgs) Handles btnHS.Click
        LoadNextFormHide(Me, HighScores)
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click, quitMnu.Click
        Application.Exit()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim userAuthenticate As New Authenticate

        With userAuthenticate
            .User = txtUser.Text.ToString
            .Password = txtPassword.Text.ToString
        End With
        'Check if inputs are entered
        If Not String.IsNullOrEmpty(userAuthenticate.User) AndAlso Not String.IsNullOrWhiteSpace(userAuthenticate.Password) Then
            Dim userOptionsDS As New DataSet
            userOptionsDS = userAuthenticate.SelUserOptions
            Dim twoFactorSettingBit As Integer = 0
            Integer.TryParse(userOptionsDS.Tables(0).Rows(0).Item("twoFactorAuth").ToString(), twoFactorSettingBit)
            If Not String.IsNullOrEmpty(twoFactorSettingBit) Then CurrentSession.TwoFactorEnabled = Convert.ToBoolean(twoFactorSettingBit)

#Region "Two Factor Authentication"
            'Pull this users options and check two factor settings and if they have not pass it yet.
            If CurrentSession.TwoFactorEnabled.Equals(True) AndAlso CurrentSession.isTwoFactorCodeAuthenticate.Equals(False) Then
                    userAuthenticate.isLoggedIn = userAuthenticate.GetLogin()
                    'If they pass step one, then go to step two
                    If userAuthenticate.GetLogin Then
                        CurrentSession.PreviousForm = Me
                        TwoFactorLogin.SelectedEmail = txtUser.Text
                        LoadNextFormClose(Me, TwoFactorLogin)
                        Exit Sub
                    Else
                        Dim incorrectAlert As DialogResult = MessageBox.Show($"Incorrect Email and/or/also/maybe Password",
    "Incorrect Creditials", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                        txtPassword.ResetText()
                    End If

                End If
#End Region

                userAuthenticate.isLoggedIn = userAuthenticate.GetLogin()
            Else
                userAuthenticate.isLoggedIn = False
            With EditPlayerToolStripMenuItem
                .Enabled = False
                .Visible = False
            End With
        End If
        If userAuthenticate.isLoggedIn.Equals(True) Then
            SetUserloginScreen()
        Else
            Dim incorrectAlert As DialogResult = MessageBox.Show($"Incorrect Email and/or/also/maybe Password",
    "Incorrect Creditials", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End If
        txtPassword.ResetText()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click, logOutMnu.Click
        ScoreTheme.LogOutUser()
        Me.Text = "Login"
    End Sub

    Private Sub btnNewUser_Click(sender As Object, e As EventArgs) Handles btnNewUser.Click
        CurrentSession.PreviousForm = Me
        LoadNextFormHide(Me, Register)
    End Sub

    Private Sub btnGuest_Click(sender As Object, e As EventArgs) Handles btnGuest.Click
        Dim guestDialog As DialogResult = MessageBox.Show($"Do you want to continue as a Guest? This will give you read-only access to view stats.",
    "Guest", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If guestDialog.Equals(DialogResult.Yes) Then
#Region "Guest Login Screen"
            CurrentSession.DisplayName = String.Empty
            CurrentSession.ID = -1
            CurrentSession.IsLoggedIn = False
            CurrentSession.Permissions = Permissions.UserStatus.Guest
            ScoreTheme.SetControl(New Control() {btnHS, btnPvP, btnLogout, btnNewUser}, True)
            ScoreTheme.SetControl(New Control() {btnLogin, btnNewUser, btnGuest, txtUser, txtPassword}, False)
            EditPasswordToolStripMenuItem.Visible = False
            EditToolStripMenuItem.Visible = False
            lblUser.Visible = False
            lblPassword.Visible = False
            lblHome.Visible = True
            logOutMnu.Visible = True
            lblHome.Text = $"Welcome Guest!"
            btnLogout.Location = btnGuest.Location
            Me.Text = "Home"
#End Region
        End If
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        CurrentSession.PreviousForm = Me
        AboutThis.Activate()
        AboutThis.Show()
    End Sub

    Private Sub EditPasswordToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles EditPasswordToolStripMenuItem.Click
        If CurrentSession.IsLoggedIn.Equals(True) Then
            CurrentSession.PreviousForm = Me
            LoadNextFormHide(Me, PasswordChange)
        End If
    End Sub

    Private Sub EditPlayerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditPlayerToolStripMenuItem.Click
        If Permissions.IsUser.Equals(True) Then
            CurrentSession.PreviousForm = Me
            LoadNextFormHide(Me, PlayerEditing)
        End If
    End Sub

    ''' <summary>
    ''' Set the screen when user has been authenticated.
    ''' </summary>
    Private Sub SetUserloginScreen()
        ScoreTheme.SetControl(New Button() {btnHS, btnPvP, btnLogout, btnNewUser}, True)
        ScoreTheme.SetControl(New Control() {btnLogin, btnNewUser, btnGuest, txtUser, txtPassword}, False)
        lblUser.Visible = False
        lblPassword.Visible = False
        lblHome.Visible = True
        EditPasswordToolStripMenuItem.Visible = True
        logOutMnu.Visible = True
        EditPlayerToolStripMenuItem.Visible = True
        EditPlayerToolStripMenuItem.Enabled = True
        EditToolStripMenuItem.Visible = True
        lblHome.Text = $"Welcome {CurrentSession.DisplayName}!"
        btnLogout.Location = btnGuest.Location
        Me.Text = "Home"
    End Sub

End Class