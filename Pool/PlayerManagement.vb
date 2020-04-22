Public Class PlayerManagement
    Dim selectedPlayer As New PlayerStats
    Dim playerTable As New Hashtable
    Dim nonRegisterdPlayers As New Hashtable

    Private Sub PlayerEditing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ScoreTheme.SetControl(New Control() {btnBack, btnEdit, btnDelete}, True)
        tbEdit.Visible = False
        Me.CenterToScreen()
        GetPlayers()
        CurrentScreen = AppState.Start
        cbPlayerNames.SelectedItem = "Choose"
    End Sub

    Private Sub GetPlayers()
        If Permissions.IsAdmin Then
            playerTable = selectedPlayer.IDBConnect_GetAllPlayers()
            ScoreTheme.FillBoxfromHT(cbPlayerNames, playerTable)
        ElseIf Permissions.IsUser Then
            playerTable = selectedPlayer.GetAllPlayersRegistered(False)
            ScoreTheme.FillBoxfromHT(cbPlayerNames, playerTable)
        End If
    End Sub

#Region "Event Handler"
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Select Case CurrentScreen
            Case AppState.Edit
                ScoreTheme.SetControl(New Control() {btnDelete, btnAdd, btnEdit, cbPlayerNames, lblSelectedName}, True)
                tbEdit.Visible = False
                lblNewName.Visible = False
                CurrentScreen = AppState.SelectPlayer
                GetPlayers()
                cbPlayerNames.SelectedItem = "Choose"
                btnBack.Text = "Home"
            Case AppState.Delete
                CurrentScreen = AppState.SelectPlayer
                ScoreTheme.SetControl(New Control() {btnEdit, btnAdd, btnDelete, cbPlayerNames, lblSelectedName}, True)
                GetPlayers()
                cbPlayerNames.SelectedItem = "Choose"
                btnBack.Text = "Home"
            Case AppState.Add
                CurrentScreen = AppState.SelectPlayer
                ScoreTheme.SetControl(New Control() {btnEdit, btnDelete, btnAdd, cbPlayerNames, lblSelectedName}, True)
                tbEdit.Visible = False
                lblNewName.Visible = False
                GetPlayers()
                cbPlayerNames.SelectedItem = "Choose"
                btnBack.Text = "Home"
            Case Else
                ScoreTheme.LoadNextFormClose(Me, Home)
        End Select
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If CurrentScreen = AppState.Edit Then
            Dim newName As String = tbEdit.Text
            'grab player obj from cbox
            Try
                Integer.TryParse((From row As DictionaryEntry In playerTable
                                  Where row.Value Like selectedPlayer.PlayerName1 Select row.Key).ToArray.First, selectedPlayer.PID)
            Catch ex As Exception
                Dim exceptionLog As New Logging(Now, "Edit Players: ", ex.ToString)
                exceptionLog.LogAction()
                lblError.Text = "Error: Select a player to Change"
                ScoreTheme.SetErrorLabel(lblError)
                lblNewName.Visible = False
                Exit Sub
            End Try

            Dim editSQL As String = $"exec [insNewPlayer_v1.2] @pID = {selectedPlayer.PID}, @newPlayer='{newName}',@result=0"
            If Not String.IsNullOrEmpty(selectedPlayer.PID) AndAlso Not String.IsNullOrEmpty(newName) Then
                Dim editAlert As DialogResult = MessageBox.Show($"Are you sure you want to change {selectedPlayer.PlayerName1} to {newName}?",
        "Change Name", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                'are you sure??????????
                If editAlert.Equals(DialogResult.Yes) Then
                    selectedPlayer.GetAllResults(editSQL)
                    playerTable = selectedPlayer.IDBConnect_GetAllPlayers()
                    tbEdit.ResetText()
                    btnBack_Click(Nothing, Nothing)
                End If
            Else
                Dim editEmptyAlert As DialogResult = MessageBox.Show($"{selectedPlayer.PlayerName1} needs a new name!",
   "Change Name", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If

        Else
            CurrentScreen = AppState.Edit
            tbEdit.Visible = True
            lblNewName.Visible = True
            cbPlayerNames.Enabled = False
            ScoreTheme.SetControl(New Control() {btnDelete, btnAdd}, False)
            btnBack.Text = "Back"
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If CurrentScreen.Equals(AppState.Delete) Then
            'grab player obj from cbox
            Try
                selectedPlayer.PlayerName1 = cbPlayerNames.SelectedItem.ToString
                Integer.TryParse((From row As DictionaryEntry In playerTable
                                  Where row.Value Like selectedPlayer.PlayerName1 Select row.Key).ToArray.First, selectedPlayer.PID)
            Catch ex As Exception
                Dim exceptionLog As New Logging(Now, "Delete Player: ", ex.ToString)
                exceptionLog.LogAction()
                lblError.Text = "Error: Select a player to Delete!!!!!!"
                ScoreTheme.SetErrorLabel(lblError)
                Exit Sub
            End Try

            Dim deleteSQL As String = $"exec [delPlayer] @playerID = {selectedPlayer.PID}, @result=0"

            If Not String.IsNullOrEmpty(selectedPlayer.PID) Then
                Dim deletionAlert As DialogResult = MessageBox.Show($"Are you sure you want to erase {selectedPlayer.PlayerName1}?",
    "Erase Player", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                'are you sure??????????
                If deletionAlert.Equals(DialogResult.Yes) Then
                    selectedPlayer.GetAllResults(deleteSQL)
                    playerTable = selectedPlayer.IDBConnect_GetAllPlayers()
                    tbEdit.Text = String.Empty
                    cbPlayerNames.SelectedItem = Nothing
                    cbPlayerNames.Enabled = True
                    btnBack_Click(Nothing, Nothing)
                End If
            End If
        Else
            ScoreTheme.SetControl(New Control() {btnEdit, btnAdd}, False)
            CurrentScreen = AppState.Delete
            cbPlayerNames.Enabled = False
            btnBack.Text = "Back"
        End If
    End Sub

    Private Sub cbPlayerNames_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPlayerNames.SelectedIndexChanged
        If cbPlayerNames.SelectedItem IsNot Nothing AndAlso Not cbPlayerNames.SelectedItem.Equals("Choose") Then
            ScoreTheme.SetControl(New Control() {btnEdit, btnDelete, btnAdd}, True)
            With selectedPlayer
                .PlayerName1 = cbPlayerNames.SelectedItem
            End With
        Else
            ScoreTheme.SetControl(New Control() {btnEdit, btnDelete}, False)
            selectedPlayer.PlayerName1 = String.Empty
        End If
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        ScoreTheme.LogOutUser()
    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'If players have names, then update cbox and add them to db
        If CurrentScreen = AppState.Add Then
            If Not String.IsNullOrEmpty(tbEdit.Text) Then
                selectedPlayer.PlayerName1 = tbEdit.Text.ToString
                If Not String.IsNullOrEmpty(selectedPlayer.PlayerName1) Then
                    Dim addAlert As DialogResult = MessageBox.Show($"Are you sure you want to add {selectedPlayer.PlayerName1}?",
        "Add Player", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                    'are you sure??????????
                    If addAlert.Equals(DialogResult.Yes) Then
                        selectedPlayer.InsertPlayer()
                        tbEdit.ResetText()
                        lblError.Visible = True
                        cbPlayerNames.SelectedItem = Nothing
                        lblNewName.Visible = False
                        btnBack_Click(Nothing, Nothing)
                    End If
                End If
            Else
                Dim RequiredField As DialogResult = MessageBox.Show($"You gotta give it a name!",
       "Missing Requirement", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            End If
        Else
            CurrentScreen = AppState.Add
            ScoreTheme.SetControl(New Control() {tbEdit, lblNewName}, True)
            ScoreTheme.SetControl(New Control() {cbPlayerNames, btnEdit, btnDelete, lblEditing, lblSelectedName}, False)
            btnBack.Text = "Back"
        End If
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        AboutThis.Activate()
        AboutThis.Show()
    End Sub

    Private Sub EditPasswordToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EditPasswordToolStripMenuItem1.Click
        ScoreTheme.LoadNextFormClose(Me, PasswordChange)
    End Sub


#End Region

End Class