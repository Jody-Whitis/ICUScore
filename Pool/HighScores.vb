﻿Imports System.Text
Imports System.Linq
Imports Pool.Logging
Public Class HighScores
#Region "Global to form"
    Dim player As New PlayerStats
    Dim games As New Games
    Dim allPlayers As New Hashtable
    Dim allGames As New Hashtable
    Dim highScores As New DataSet
    Dim userPermissions As New Permissions
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
        btnSubmit.Visible = False
        lstScores.Visible = False
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
            CurrentScreen = AppState.SelectPlayer
        End If
        ProcessEmailStatbyWeek()
        If Not Permissions.IsUser AndAlso Not userPermissions.isLoggedIn Then
            ScoreTheme.GuestDisplay(New Control() {btnAdd, btnSubmit, cbPlayers, txtScore, txtNewGM,
                                        lblSelectedPlayer, lblScore, lblNewGameMode, btnPlayerEditing}, False)
            EditPasswordToolStripMenuItem1.Visible = False
            PlayerEditingToolStripMenuItem.Visible = False
            EditToolStripMenuItem.Visible = False
            btnPvP.Location = btnAdd.Location
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
                lstScores.Visible = True
                lblScoreBoard.Visible = True
                lstScores.Refresh()
            Catch ex As Exception
                Dim exceptionLog As New Logging(Now, "Get High Score", ex.ToString)
                exceptionLog.LogAction()
                Debug.WriteLine(ex.ToString)
                lblError.Text = ex.Message.ToString
                ScoreTheme.SetErrorLabel(lblError)
            End Try
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
        If CurrentScreen > 0 Then
            'got a player

            If ScoreTheme.ValidateCBox(cbPlayers).Equals(True) Then
                'got a new score
                If Not String.IsNullOrEmpty(txtScore.Text) Then
                    If Integer.TryParse(txtScore.Text.Trim, score) Then
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
                    Else
                        lblError.Text = "Error: nan"
                        ScoreTheme.SetErrorLabel(lblError)
                    End If

                Else
                    CurrentScreen = AppState.SelectPlayer
                    Try
                        txtScore.Text = String.Empty
                    Catch ex As Exception
                        Dim exceptionLog As New Logging(Now, "Select Player from Empty score: ", ex.ToString)
                        exceptionLog.LogAction()
                        lblError.Text = "error"
                    End Try
                    ScoreTheme.SetErrorLabel(lblError)
                End If
            End If
        Else
            lblError.Text = "Error"
            ScoreTheme.SetErrorLabel(lblError)
            CurrentScreen = AppState.Register
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If CurrentScreen = AppState.Add Then
            'Go back to prev
            txtNewGM.ResetText()
            txtNewGM.Visible = False
            lstScores.Visible = True
            cbGames.Visible = True
            cbPlayers.Visible = True
            txtScore.Visible = True
            lblNewGameMode.Visible = False
            ScoreTheme.SetControl(New Control() {lblScore, lblScoreBoard, lblSelectedPlayer, lblSelectedMode, btnSubmit}, True)
            CurrentScreen = AppState.SelectPlayer
            btnBack.Text = "Home"
            ScoreTheme.SetErrorLabel(lblError)
        Else
            ScoreTheme.LoadNextFormClose(Me, Home)
        End If

    End Sub

    ''' <summary>
    ''' Set object if we're in this state
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cbPlayers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPlayers.SelectedIndexChanged
        If Permissions.IsUser.Equals(True) Then
            If CurrentScreen = AppState.SelectPlayer Then
                player.PlayerName1 = cbPlayers.SelectedItem
                ScoreTheme.SetErrorLabel(lblError)
                If ScoreTheme.ValidateCBox(cbGames).Equals(True) AndAlso ScoreTheme.ValidateCBox(cbPlayers).Equals(True) Then
                    btnSubmit.Visible = True
                Else
                    btnSubmit.Visible = False
                End If
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
            lstScores.Visible = True
            lblScoreBoard.Visible = True
        Else
            lstScores.Visible = False
            lblScoreBoard.Visible = False
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
        If CurrentScreen <> AppState.Add Then
            'transition to adding item
            CurrentScreen = AppState.Add
            cbGames.Visible = False
            cbPlayers.Visible = False
            txtScore.Visible = False
            lstScores.Visible = False
            ScoreTheme.SetControl(New Control() {lblScore, lblScoreBoard, lblSelectedPlayer, lblSelectedMode}, False)
            txtNewGM.Visible = True
            lblNewGameMode.Visible = True
            btnBack.Text = "Back"
            ScoreTheme.SetControl(New Control() {btnSubmit}, False)

        ElseIf CurrentScreen = AppState.Add Then
            If Not String.IsNullOrEmpty(txtNewGM.Text) Then
                'try to insert if not blank
                Dim newGM As String = $"[dbo].[insNewGame] @gameMode = '{txtNewGM.Text}'"
                games.InsertGame(newGM)
                allGames = games.GetAllPlayers()
                ScoreTheme.FillBoxfromHT(cbGames, allGames)
                highScores = games.GetAllResults("exec selAllScores @output=0")
                txtNewGM.ResetText()
                txtNewGM.Visible = False
                lstScores.Visible = True
                cbGames.Visible = True
                cbPlayers.Visible = True
                txtScore.Visible = True
                lblNewGameMode.Visible = False
                ScoreTheme.SetControl(New Control() {lblScore, lblNewGameMode, lblScoreBoard, lblSelectedPlayer, lblSelectedMode, btnSubmit}, True)
                CurrentScreen = AppState.SelectPlayer
                btnBack.Text = "Home"
            Else
                Dim incorrectAlert As DialogResult = MessageBox.Show($"You got to name it first",
  "No Name", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            End If
        Else
            lblError.Text = "Error: This new game mode needs a name"
            ScoreTheme.SetErrorLabel(lblError)
            lblError.Visible = True
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

End Class