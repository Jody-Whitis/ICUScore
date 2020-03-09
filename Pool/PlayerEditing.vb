Public Class PlayerEditing
    Dim selectedPlayer As New PlayerStats
    Dim allplayers As New Hashtable
    Dim nonRegisterdPlayers As New Hashtable
    Dim userPermissions As New Permissions()

    Private Sub PlayerEditing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ScoreTheme.SetControl(New Control() {btnBack, btnEdit, btnDelete}, True)
        tbEdit.Visible = False
        Me.CenterToScreen()

        If Permissions.IsAdmin Then
            allplayers = selectedPlayer.IDBConnect_GetAllPlayers()
            ScoreTheme.FillBoxfromHT(cbPlayerNames, allplayers)
        ElseIf Permissions.IsUser Then
            nonRegisterdPlayers = selectedPlayer.GetAllPlayersRegistered(False)
            ScoreTheme.FillBoxfromHT(cbPlayerNames, nonRegisterdPlayers)
        End If
        CurrentScreen = AppState.Start
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ScoreTheme.SetControl(New Control() {cbPlayerNames, tbEdit}, False)
        cbPlayerNames.SelectedValue = String.Empty
        'move out
        Select Case CurrentScreen
            Case AppState.Edit
                ScoreTheme.SetControl(New Control() {btnDelete, cbPlayerNames}, True)
                CurrentScreen = AppState.SelectPlayer
            Case AppState.Delete
                CurrentScreen = AppState.SelectPlayer
                ScoreTheme.SetControl(New Control() {btnEdit, cbPlayerNames}, True)
            Case Else
                If PreviousForm IsNot Nothing Then
                    With PreviousForm
                        .Activate()
                        .Show()
                    End With
                Else
                    With Home
                        .Activate()
                        .Show()
                    End With
                End If
                Me.Close()
        End Select
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If CurrentScreen = AppState.Edit Then
            Dim newName As String = tbEdit.Text
            'grab player obj from cbox
            Try
                Integer.TryParse((From row As DictionaryEntry In allplayers
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
        "Erase Player", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                'are you sure??????????
                If editAlert.Equals(DialogResult.Yes) Then
                    selectedPlayer.GetAllResults(editSQL)
                    allplayers = selectedPlayer.IDBConnect_GetAllPlayers()
                    tbEdit.ResetText()
                    lblError.Text = $"{selectedPlayer.PlayerName1} is now {newName}"
                    lblError.Visible = True
                    btnDelete.Visible = True
                    cbPlayerNames.SelectedItem = Nothing
                    tbEdit.Visible = False
                    cbPlayerNames.Enabled = True
                    CurrentScreen = AppState.SelectPlayer
                    lblNewName.Visible = False
                    btnBack_Click(Nothing, Nothing)
                End If
            End If

        Else
            CurrentScreen = AppState.Edit
            tbEdit.Visible = True
            lblNewName.Visible = True
            cbPlayerNames.Enabled = False
            With btnDelete
                .Visible = False
                .Enabled = False
            End With
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If CurrentScreen.Equals(AppState.Delete) Then
            'grab player obj from cbox
            Try
                selectedPlayer.PlayerName1 = cbPlayerNames.SelectedItem.ToString
                Integer.TryParse((From row As DictionaryEntry In allplayers
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
                    allplayers = selectedPlayer.IDBConnect_GetAllPlayers()
                    tbEdit.Text = String.Empty
                    lblError.Text = $"{selectedPlayer.PlayerName1} is gone"
                    lblError.Visible = True
                    btnDelete.Visible = True
                    cbPlayerNames.SelectedItem = Nothing
                    tbEdit.Visible = False
                    cbPlayerNames.Enabled = True
                    btnBack_Click(Nothing, Nothing)
                End If
            End If
        Else
            With btnEdit
                .Visible = False
                .Enabled = False
            End With
            CurrentScreen = AppState.Delete
            cbPlayerNames.Enabled = False
        End If
    End Sub

    Private Sub cbPlayerNames_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPlayerNames.SelectedIndexChanged
        If cbPlayerNames.SelectedItem IsNot Nothing Then
            ScoreTheme.SetControl(New Control() {btnEdit, btnDelete}, True)
            With selectedPlayer
                .PlayerName1 = cbPlayerNames.SelectedItem
            End With
        Else
            ScoreTheme.SetControl(New Control() {btnEdit, btnDelete}, False)
            selectedPlayer.PlayerName1 = String.Empty
        End If
    End Sub

    Private Sub EditPasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditPasswordToolStripMenuItem.Click
        With PasswordChange
            .Activate()
            .Show()
        End With
        CurrentSession.PreviousForm = Me
        Me.Hide()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        ScoreTheme.LogOutUser()
    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class