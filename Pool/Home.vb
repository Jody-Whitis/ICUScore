Imports Microsoft.VisualBasic.ApplicationServices
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
            'Log in after two step auth
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

        'Check step one login has passed
        userAuthenticate.isLoggedIn = userAuthenticate.GetLogin()
        If userAuthenticate.isLoggedIn.Equals(True) Then
            Dim userOptionsDS As New DataSet
            userOptionsDS = userAuthenticate.SelUserOptions
            If userOptionsDS.Tables(0).Rows.Count > 0 Then SetLoginUserSettings(userOptionsDS.Tables(0))
#Region "Two Factor Authentication"
            'Pull this users options and check two factor settings and if they have not pass it yet.
            If CurrentSession.TwoFactorEnabled.Equals(True) AndAlso CurrentSession.isTwoFactorCodeAuthenticate.Equals(False) Then
                'If they pass step one, then go to step two
                If userAuthenticate.GetLogin Then
                    CurrentSession.PreviousForm = Me
                    TwoFactorLogin.SelectedEmail = txtUser.Text
                    LoadNextFormClose(Me, TwoFactorLogin)
                    Exit Sub
                End If
            End If
#End Region
            SetUserloginScreen()
        Else
            userAuthenticate.isLoggedIn = False
#Region "Controls Menu"
            With EditPlayerToolStripMenuItem
                .Enabled = False
                .Visible = False
            End With
            With ProfileEditingToolStripMenuItem
                .Enabled = False
                .Visible = False
            End With
            With EditPasswordToolStripMenuItem
                .Visible = False
                .Enabled = False
            End With
#End Region
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
        ProfileEditingToolStripMenuItem.Visible = True
        EditToolStripMenuItem.Visible = True
        lblHome.Text = $"Welcome {CurrentSession.DisplayName}!"
        btnLogout.Location = btnGuest.Location
        Me.Text = "Home"
    End Sub

    Private Sub ProfileEditingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfileEditingToolStripMenuItem.Click
        If CurrentSession.IsLoggedIn.Equals(True) Then
            ScoreTheme.LoadNextFormHide(Me, ProfileEditing)
        End If
    End Sub

    ''' <summary>
    ''' Gets the login/attempted login's settings
    ''' and set them in CurrentSession
    ''' </summary>
    ''' <param name="settingsDt"></param>
    Private Sub SetLoginUserSettings(settingsDt As DataTable)
        Dim twoFactorSettingBit As Integer = 0, subscribedBit As Integer = 0, registeredBit As Integer = 0
        Integer.TryParse(settingsDt.Rows(0).Item("twoFactorAuth").ToString(), twoFactorSettingBit)
        Integer.TryParse(settingsDt.Rows(0).Item("subscribed").ToString(), subscribedBit)
        Integer.TryParse(settingsDt.Rows(0).Item("registered").ToString(), registeredBit)

        CurrentSession.TwoFactorEnabled = Convert.ToBoolean(twoFactorSettingBit)
        CurrentSession.Subscribed = Convert.ToBoolean(subscribedBit)
        CurrentSession.Registered = Convert.ToBoolean(registeredBit)
    End Sub
End Class