Public Class ProfileEditing

#Region "Props and InitialSettings"
    Private Structure InitialSettings
        Public subscribed As Boolean
        Public twoFactor As Boolean
        Public registered As Boolean
        Public emailAddress As String
        Public displayName As String
    End Structure

    Dim intialUserSettings As New InitialSettings
#End Region

    Private Sub ProfileEditing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        If CurrentSession.IsLoggedIn.Equals(True) Then
            Try
                SetCurrentUserSettings()
                SetIntitialSettings()
            Catch ex As Exception
                Dim optionsErrorLog As New Logging(Now.ToLongDateString, "Profile Options Error", ex.ToString)
                optionsErrorLog.LogAction()
            End Try

        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ScoreTheme.LoadNextFormClose(Me, Home)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim updateUser As New PlayerStats With {.PID = CurrentSession.ID}
        Dim sqlString As String = String.Empty
        Dim results As New DataSet

        'Prompt to selected if nothing was changed
        If isChanged.Equals(False) Then
            Dim nothingSelected As DialogResult = MessageBox.Show($"Selected a setting to change!",
                "No settings selected", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        'Ask again to be safe
        Dim warningSave As DialogResult = MessageBox.Show($"Are you sure you want to save?",
                "Saving Settings", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        If warningSave.Equals(DialogResult.Yes) Then
            sqlString = GetUpdateSQL(intialUserSettings)
            results = updateUser.GetAllResults(sqlString)
            SetUpdatedSettings()
        Else
            Exit Sub
        End If

        ScoreTheme.LoadNextFormClose(Me, Home)
    End Sub

    ''' <summary>
    ''' Check if the user changed a value when the form loaded
    ''' </summary>
    ''' <returns></returns>
    Private Function isChanged() As Boolean
        Dim valuesChanged As Boolean = False
        If intialUserSettings.registered <> cbDeactivate.Checked Then valuesChanged = True
        If intialUserSettings.twoFactor <> cbTwoFactorEnabled.Checked Then valuesChanged = True
        If intialUserSettings.subscribed <> cbSubscribed.Checked Then valuesChanged = True
        If intialUserSettings.displayName <> tbDisplayName.Text Then valuesChanged = True
        If intialUserSettings.emailAddress <> tbEmailAddress.Text Then valuesChanged = True
        Return valuesChanged
    End Function

    ''' <summary>
    ''' Get this sessions settings and set them to controls
    ''' </summary>
    Private Sub SetCurrentUserSettings()
        cbTwoFactorEnabled.Checked = CurrentSession.TwoFactorEnabled
        cbSubscribed.Checked = CurrentSession.Subscribed
        tbEmailAddress.Text = CurrentSession.UserEmail
        tbDisplayName.Text = CurrentSession.DisplayName
        lblTitle.Text += CurrentSession.DisplayName
    End Sub

    ''' <summary>
    ''' Set inital user's settings on load
    ''' </summary>
    Private Sub SetIntitialSettings()
        intialUserSettings.twoFactor = cbTwoFactorEnabled.Checked
        intialUserSettings.subscribed = cbSubscribed.Checked
        intialUserSettings.registered = cbDeactivate.Checked
        intialUserSettings.displayName = tbDisplayName.Text
        intialUserSettings.emailAddress = tbEmailAddress.Text
    End Sub

    ''' <summary>
    ''' Builds sp params
    ''' only pass what has changed
    ''' </summary>
    ''' <param name="initialSettings"></param>
    ''' <returns></returns>
    Private Function GetUpdateSQL(initialSettings As InitialSettings) As String
        Dim updUserSettings As New System.Text.StringBuilder

        With updUserSettings
            .Append("exec updUserSettings ")
            .Append($"@id={CurrentSession.ID},")
            If (initialSettings.subscribed <> cbSubscribed.Checked) Then .Append($"@subscribed={Convert.ToInt16(cbSubscribed.Checked)},")
            If (initialSettings.twoFactor <> cbTwoFactorEnabled.Checked) Then .Append($"@twoFactor={Convert.ToInt16(cbTwoFactorEnabled.Checked)},")
            If (initialSettings.registered <> cbDeactivate.Checked) Then .Append($"@active={Convert.ToInt16(cbDeactivate.Checked)}")
            If (initialSettings.displayName <> tbDisplayName.Text) Then .Append($"@displayName={tbDisplayName.Text}")
            If (initialSettings.emailAddress <> tbEmailAddress.Text) Then .Append($"@emailAddress={tbEmailAddress.Text}")
        End With

        Return updUserSettings.ToString.TrimEnd(",")
    End Function

    ''' <summary>
    ''' Set sessions updated settings
    ''' </summary>
    Private Sub SetUpdatedSettings()
        Dim settingsDS As New DataSet
        Dim updatedSettings As New TwoFactorAuthenication With {.User = tbEmailAddress.Text}
        settingsDS = updatedSettings.SelUserOptions()
        Try
            CurrentSession.TwoFactorEnabled = Convert.ToBoolean(Convert.ToInt16(settingsDS.Tables(0).Rows(0).Item("twoFactorAuth").ToString))
            CurrentSession.Subscribed = Convert.ToBoolean(Convert.ToInt16(settingsDS.Tables(0).Rows(0).Item("subscribed").ToString))
            CurrentSession.DisplayName = settingsDS.Tables(0).Rows(0).Item("PlayerName").ToString
            CurrentSession.UserEmail = settingsDS.Tables(0).Rows(0).Item("emailAddress").ToString

            'If they just went to two factor and vice versa, then keep them logged in
            If CurrentSession.TwoFactorEnabled.Equals(True) Then
                CurrentSession.isTwoFactorCodeAuthenticate = True
            ElseIf CurrentSession.TwoFactorEnabled.Equals(False) Then
                CurrentSession.isTwoFactorCodeAuthenticate = False
            End If
        Catch ex As Exception
            Dim updateLog As New Logging(Now.ToLongTimeString, "Updated User Settings", ex.ToString)
            updateLog.LogAction()
        End Try
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        AboutThis.Activate()
        AboutThis.Show()
    End Sub

    Private Sub LogOutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        ScoreTheme.LogOutUser()
    End Sub

    Private Sub QuitMenuItem1_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        Application.Exit()
    End Sub


End Class