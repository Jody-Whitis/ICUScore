Imports System.Text
Imports System.Linq
Imports Pool.Logging
Imports Pool.Models.Validation

Public Class HighScores
#Region "Global to form"
    Dim player As New PlayerStats
    Dim games As New Games
    Dim allPlayers As New Hashtable
    Dim allGames As New Hashtable
    Dim highScores As New DataSet
    Dim userPermissions As New Permissions
    Dim inputValidation As New ValidationBase
#End Region

    ''' <summary>
    ''' Load data to hashtables and fill controls
    ''' if we're good, change state
    ''' get location and sizes for nav
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub HighScores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        ScoreTheme.SetControl(New Control() {btnSubmit, lstScores}, False)
        CurrentScreen = AppState.Start
        If Permissions.IsAdmin.Equals(True) Then
            allPlayers = player.IDBConnect_GetAllPlayers()
        Else
            allPlayers = player.GetAllPlayersRegistered(False)
        End If
        ScoreTheme.FillBoxfromHT(cbPlayers, allPlayers)
        allGames = games.GetAllPlayers()
        ScoreTheme.FillBoxfromHT(cbGames, allGames)
        highScores = games.GetAllResults("exec selAllScores @output=0")
        lblError.Visible = False
        cbGames.SelectedItem = "Choose"
        If Permissions.IsUser.Equals(True) Then
            cbPlayers.SelectedItem = CurrentSession.DisplayName
        End If
        If CurrentScreen = AppState.NoPlayerEx Then
            lblError.Visible = True
        Else
            CurrentScreen = AppState.Switch
        End If
        ProcessEmailStatbyWeek()
        If Not Permissions.IsUser AndAlso Not userPermissions.isLoggedIn Then
            ScoreTheme.GuestDisplay(New Control() {btnAdd, btnSubmit, cbPlayers, txtScore,
                                        lblSelectedPlayer, lblScore, btnPlayerEditing}, False)
            EditPasswordToolStripMenuItem1.Visible = False
            PlayerEditingToolStripMenuItem.Visible = False
            EditToolStripMenuItem.Visible = False
        End If
    End Sub

#Region "Gets and Email"

    ''' <summary>
    ''' Gets a list of recipents from db
    ''' Get a stats from recent stats the past week without timestamps
    ''' Pass in the email obj and call send function
    ''' Using the stats just grabed, get their IDs and update timestamps
    ''' </summary>
    Private Sub ProcessEmailStatbyWeek()
        Try
            Dim emailRecipents As New List(Of String)
            emailRecipents = ScoreTheme.getSubs(games)
            Dim recentStats As IEnumerable = GetRecentStats(highScores.Tables(0))
            Dim emailSet As New Email(emailRecipents, recentStats)
            emailSet.SendWeekEmail()
            Dim sentID As String = GetStatsSent(recentStats)
            If sentID.Length > 0 Then
                games.InsertGame($"exec [updEmailSent] @hid='{sentID}',@timesent='{Now.ToString("")}'")
            End If
        Catch ex As Exception
            Dim exceptionLog As New Logging(Now, "Process Email from HighScore", ex.ToString)
            exceptionLog.LogAction()
            Debug.Write(ex.ToString)
        End Try
    End Sub

    ''' <summary>
    ''' Filter the stats by the lastest in the past week
    ''' </summary>
    ''' <param name="allStats"></param>
    ''' <returns></returns>
    Public Function GetRecentStats(allStats As DataTable) As IEnumerable
        Try
            Dim recentScore As IEnumerable = (From row As DataRow In allStats.AsEnumerable
                                              Where DateDiff(DateInterval.Day, row.Field(Of Date)("lastUpdated"), Now) <= 7 AndAlso
                                                   row.Field(Of Date?)("lastSent").ToString.Count <= 0
                                              Order By row.Field(Of Integer)("highscore") Descending).ToArray
            Return recentScore
        Catch ex As Exception
            Dim exceptionLog As New Logging(Now, "Get Recent Stats Filter: ", ex.ToString)
            exceptionLog.LogAction()
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Takes the list and get IDs from the email sent
    ''' </summary>
    ''' <param name="recents"></param>
    ''' <returns></returns>
    Private Function GetStatsSent(recents As IEnumerable) As String
        Dim updateSent As New StringBuilder
        For Each stat In recents
            updateSent.Append(stat(5) & ",")
        Next
        Return updateSent.ToString.TrimEnd(",")
    End Function


    ''' <summary>
    ''' Using the selected item, run a Linq for that one.
    ''' Then add to display
    ''' </summary>
    ''' <param name="gameMode"></param>
    Private Sub GetHighScores(ByVal gameMode As String)
        If highScores.Tables(0).Rows.Count > 0 Then
            lstScores.Items.Clear()
            Try
                Dim scores = (From r In highScores.Tables(0).AsEnumerable Where r.Item("gameMode").Equals(gameMode)
                              Select r)
                For Each score In scores
                    Dim playerNameScore As String = score.Item("playerName")
                    Dim playerScore As String = score.Item("highScore")
                    Dim lastUpdated As Date = score.Item("LastUpdated")
                    lstScores.Items.Add($"{playerNameScore} scored [{playerScore}] on {lastUpdated.ToString("MM/dd/yyyy")}")
                Next
                ScoreTheme.SetControl(New Control() {lstScores, lblScoreBoard}, True)
                lstScores.Refresh()
            Catch ex As Exception
                Dim exceptionLog As New Logging(Now, "Get High Score", ex.ToString)
                exceptionLog.LogAction()
                Debug.WriteLine(ex.ToString)
                lblError.Text = ex.Message.ToString
                ScoreTheme.SetErrorLabel(lblError)
            End Try
        Else
            lstScores.Items.Clear()
            lstScores.Items.Add("No games yet played ")
            ScoreTheme.SetControl(New Control() {lstScores, lblScoreBoard}, True)
            lstScores.Refresh()
        End If
    End Sub

#End Region

#Region "Event Handlers"

    ''' <summary>
    ''' To submit new entry. If we're are not in start state,
    ''' check if selected item is not nothing, then if entry is numberic and set both object's prop
    ''' Get the ids from the hash table key
    ''' Search for existing stat to update, add if not found
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        lblError.Visible = False
        Dim score As Integer = -1
        If Permissions.IsUser.Equals(True) AndAlso CurrentScreen > AppState.Start Then
            'got a player

            If ScoreTheme.ValidateCBox(cbPlayers).Equals(True) Then
                'got a new score                
                If Integer.TryParse(txtScore.Text.Trim, score) Then
                    Dim submittedAlert As DialogResult = MessageBox.Show($"Are you sure you want to save this score?",
"New Highscore Submission", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If submittedAlert.Equals(DialogResult.Yes) Then

                        CurrentScreen = AppState.Winner
                        With player
                            .PlayerName1 = cbPlayers.SelectedItem.ToString
                            .Wins1 = score
                            .PID = ScoreTheme.GetKey(.PlayerName1, allPlayers)
                        End With
                        With games
                            .GameMode = cbGames.SelectedItem.ToString
                            .Score = txtScore.Text
                            .GameID = ScoreTheme.GetKey(.GameMode, allGames)
                        End With

                        'Search for game to update
                        Dim searchGames = $"exec [dbo].[selScores_v1.1] @playerId={player.PID},@gameID = {games.GameID},@results=0"
                        Dim foundScoreResult = games.GetGames(searchGames)
                        'Update a score or add a new one
                        Try
                            If foundScoreResult.Tables(0).Rows.Count > 0 Then
                                player.IsFound = 1
                            Else
                                player.IsFound = 0
                            End If
                        Catch ex As Exception
                            Dim exceptionLog As New Logging(Now, "Player HS Found: ", ex.ToString)
                            exceptionLog.LogAction()
                            player.IsFound = 0
                        End Try

                        Dim sqlString = $"exec [dbo].[insScore_v1.1] @pid={player.PID},@score={games.Score},@gID={games.GameID},@result={player.IsFound}, @lastUpdated='{Now.ToString}'"
                        lblError.Text = games.InsertGame(sqlString)
                        ScoreTheme.SetErrorLabel(lblError)
                        highScores.Clear()
                        highScores = games.GetAllResults("exec selAllScores @output=0")
                        GetHighScores(games.GameMode)
                        Refresh()
                        txtScore.Text = String.Empty
                    Else
                        Exit Sub
                    End If

                Else
                    CurrentScreen = AppState.Switch
                    txtScore.Text = String.Empty
                    Dim nanAlert As DialogResult = MessageBox.Show($"You must enter a valid number!",
"Invalid Score", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    CurrentScreen = AppState.SelectPlayer
                End If
            Else
                Dim selectionAlert As DialogResult = MessageBox.Show($"You must select a game mode!",
"Invalid Game Mode", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ScoreTheme.LoadNextFormClose(Me, Home)
    End Sub

    ''' <summary>
    ''' Set object if we're in this state
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cbPlayers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPlayers.SelectedIndexChanged
        If Permissions.IsUser.Equals(True) Then
            player.PlayerName1 = cbPlayers.SelectedItem
            If ScoreTheme.ValidateCBox(cbGames).Equals(True) AndAlso ScoreTheme.ValidateCBox(cbPlayers).Equals(True) Then
                CurrentScreen = AppState.SelectPlayer
                With btnSubmit
                    .Visible = True
                    .Enabled = True
                End With
            Else
                CurrentScreen = AppState.Switch
                With btnSubmit
                    .Visible = False
                    .Enabled = False
                End With
            End If
        End If

    End Sub

    ''' <summary>
    ''' Set the mode on this item, them get all and display them
    ''' set error label if any
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cbGames_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbGames.SelectedIndexChanged
        games.GameMode = cbGames.SelectedItem
        If ScoreTheme.ValidateCBox(cbGames).Equals(True) Then
            GetHighScores(games.GameMode)
            ScoreTheme.SetErrorLabel(lblError)
            ScoreTheme.SetControl(New Control() {lstScores, lblScoreBoard}, True)
            If lstScores.Items.Count = 0 Then
                lstScores.Items.Add("No games yet played")
            End If
        Else
            ScoreTheme.SetControl(New Control() {lstScores, lblScoreBoard}, False)
        End If
        cbPlayers_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    ''' <summary>
    ''' Adding new mode
    ''' If we're not in this state, then enable controls to add
    ''' If we're in this state and have text, we'll added it or go back
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If Permissions.IsUser.Equals(True) Then
            ScoreTheme.LoadNextFormClose(Me, GameModeEditing)
        End If
    End Sub

    ''' <summary>
    ''' Go to this screen and close this one
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnPvP_Click(sender As Object, e As EventArgs) Handles btnPvP.Click
        ScoreTheme.LoadNextFormClose(Me, PvP)
    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        ScoreTheme.LogOutUser()
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        AboutThis.Activate()
        AboutThis.Show()
    End Sub

    Private Sub EditPasswordToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EditPasswordToolStripMenuItem1.Click
        If CurrentSession.IsLoggedIn.Equals(True) Then
            ScoreTheme.LoadNextFormClose(Me, PasswordChange)
        End If
    End Sub

    Private Sub PlayerEditingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlayerEditingToolStripMenuItem.Click, btnPlayerEditing.Click
        If Permissions.IsUser.Equals(True) Then
            ScoreTheme.LoadNextFormClose(Me, PlayerManagement)
        End If
    End Sub

    Private Sub ProfileEditingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfileEditingToolStripMenuItem.Click
        If Permissions.IsUser.Equals(True) Then
            ScoreTheme.LoadNextFormClose(Me, ProfileEditing)
        End If
    End Sub

#End Region

#Region "Old logic moved to new Form - 1.9.3.2"
    '    If CurrentScreen <> AppState.Add Then
    '            'transition to adding item
    '            CurrentScreen = AppState.Add
    '            ScoreTheme.SetControl(New Control() {lblScore, lblScoreBoard, lblSelectedPlayer, lblSelectedMode, cbGames, cbPlayers, txtScore, lstScores}, False)
    '            ScoreTheme.SetControl(New Control() {txtNewGM, lblNewGameMode}, True)
    '            btnBack.Text = "Back"
    '            ScoreTheme.SetControl(New Control() {btnSubmit}, False)

    '        ElseIf CurrentScreen = AppState.Add Then
    '    If Not String.IsNullOrEmpty(txtNewGM.Text) Then
    '    Dim submittedAlert As DialogResult = MessageBox.Show($"Are you sure you want to add this game?",
    '"New Game Mode Submission", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
    '    If submittedAlert.Equals(DialogResult.Yes) Then
    '    'try to insert if not blank
    '    Dim newGM As String = $"[dbo].[insNewGame] @gameMode = '{inputValidation.SQLValidation(txtNewGM.Text)}'"
    '                    games.InsertGame(newGM)
    '                    allGames = games.GetAllPlayers()
    '                    ScoreTheme.FillBoxfromHT(cbGames, allGames)
    '                    highScores = games.GetAllResults("exec selAllScores @output=0")
    '                    txtNewGM.ResetText()
    '                    ScoreTheme.SetControl(New Control() {txtNewGM, lblNewGameMode}, False)
    '                    ScoreTheme.SetControl(New Control() {lblScore, lblNewGameMode, lblScoreBoard, lblSelectedPlayer, lblSelectedMode, btnSubmit, txtScore, cbPlayers, cbGames, lstScores}, True)
    '                    CurrentScreen = AppState.SelectPlayer
    '                    btnBack.Text = "Home"
    '                Else
    '    Exit Sub
    '    End If
    '    Else
    '    Dim incorrectAlert As DialogResult = MessageBox.Show($"You got to name it first",
    '  "No Name", MessageBoxButtons.OK, MessageBoxIcon.Hand)
    '    End If
    '    End If
#End Region

End Class