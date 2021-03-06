﻿Imports System.IO
Imports Pool.Logging
Public Class PvP
    'Dim connectionString As String = ("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & Path.GetDirectoryName(Application.StartupPath) & "\LocalResults.mdf;Integrated Security=True").Replace("\bin", "")
    'Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jwhitis\source\repos\Pool\Pool\LocalResults.mdf;Integrated Security=True"
#Region "Global to form"
    Dim player1 As New PlayerStats
    Dim player2 As New PlayerStats
    Dim game As Integer = -1
    Dim isRiv As Boolean = False
    Dim allplayers As New Hashtable
    Dim nonRegisterdPlayers As New Hashtable
    Dim allWins As New DataSet
    Dim gamesHT As New Hashtable
    Dim gamePvP As New DataSet
    Dim games As New Games
    Dim totalGamesPvP As Integer = 0
    Dim pvpID As Integer = -1
    Dim pvpID2 As Integer = -1
    Dim pvpSet1 As New DataSet
    Dim pvpSet2 As New DataSet
#End Region

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LocalResultsDataSet1.Players' table. You can move, or remove it, as needed.
        'Me.PlayersTableAdapter1.Fill(Me.LocalResultsDataSet1.Players)
        'TODO: This line of code loads data into the 'PlayerNames.Players' table. You can move, or remove it, as needed.
        'Me.PlayersTableAdapter.Fill(Me.PlayerNames.Players)
#Region "Load all current Players into cbox"
        allWins = player1.GetAllResults($"exec [selAllWins_v1] @gID={game},@output=0")
        allplayers = player1.IDBConnect_GetAllPlayers()
        gamePvP = player1.GetAllResults($"[dbo].[selGamesPvP]")
        gamesHT = games.GetAllPlayers()
        GetHighScores()
        ScoreTheme.FillBoxfromHT(cbPlayer1, allplayers)
        ScoreTheme.FillBoxfromHT(cbPlayer2, allplayers)
        ScoreTheme.FillBoxfromHT(cbGames, gamesHT)
        If gamesHT.Count > 0 Then
            cbGames.SelectedItem = "Choose"
        End If
#End Region
        Me.CenterToScreen()
        lblError.Text = String.Empty
        If Not String.IsNullOrEmpty(CurrentSession.UserEmail) Then
            cbPlayer1.SelectedItem = CurrentSession.DisplayName
            If Permissions.IsAdmin.Equals(False) Then cbPlayer1.Enabled = False
        Else
            cbPlayer1.SelectedItem = "Choose"
        End If
        CurrentScreen = AppState.Start
        cbPlayer2.SelectedItem = "Choose"
        cbGames.SelectedItem = "Choose"
        If Not Permissions.IsUser Then
            ScoreTheme.GuestDisplay(New Control() {btnSave, cbPlayer1, cbPlayer2, lblPlayer1, lblPlayer2, lblTotalAgainst,
                                  lblWinsAgainst1, lblWinsAgainst2, lblTotalWins1, lblTotalWins2, btnRegisterTest}, False)
            PlayerEditToolStripMenuItem1.Visible = False
            EditPasswordToolStripMenuItem.Visible = False
            EditToolStripMenuItem.Visible = False
        Else
            SetControlsbyCbPlayers()
            SetScoreControlsScreen(cbGames, New Control() {lblScoreBoard, lstAllWins})
        End If
    End Sub

#Region "SETS"
    ''' <summary>
    ''' Set player related controls based on choices
    ''' 1. if that player is selected, then show their wins and label
    ''' 2. if they are both selected then show total wins against
    ''' 2a. if they selected a game then show the Save button.
    ''' </summary>
    Private Sub SetControlsbyCbPlayers()
        If CurrentSession.IsLoggedIn Then
            'Player 1          
            SetScoreControlsScreen(cbPlayer1, New Control() {txtWins, lblTotalWins1})
            'Player2
            SetScoreControlsScreen(cbPlayer2, New Control() {txtWins2, lblTotalWins2})
            'Both Players selected    
            If ScoreTheme.ValidateCBox(cbPlayer1) AndAlso ScoreTheme.ValidateCBox(cbPlayer2) AndAlso Not cbPlayer1.SelectedItem.Equals(cbPlayer2.SelectedItem) Then
                ScoreTheme.SetControl(New Control() {lblWinsAgainst1, txtWinsagainst, lblWinsAgainst2, txtWinsAgainst2, txtTotalAgainst, lblTotalAgainst}, True)
                'Both Players and a game is selected
                SetScoreControlsScreen(cbGames, New Control() {btnSave, lblWinsAgainst1, txtWinsagainst, lblWinsAgainst2, txtWinsAgainst2, lblTotalAgainst, txtTotalAgainst, btnSave})
                CurrentScreen = AppState.Switch
            Else
                ScoreTheme.SetControl(New Control() {lblWinsAgainst1, txtWinsagainst, lblWinsAgainst2, txtWinsAgainst2, lblTotalAgainst, txtTotalAgainst, btnSave}, False)
                CurrentScreen = AppState.SelectPlayer
            End If
        End If
    End Sub


    ''' <summary>
    ''' Sets the controls passed by which combox was selected
    ''' </summary>
    ''' <param name="cBox"></param>
    ''' <param name="controlsToToggle"></param>
    Private Sub SetScoreControlsScreen(cBox As ComboBox, controlsToToggle As Control())
        If CurrentSession.IsLoggedIn AndAlso ScoreTheme.ValidateCBox(cBox) Then
            If ScoreTheme.ValidateCBox(cBox) Then
                ScoreTheme.SetControl(controlsToToggle, True)
            Else
                ScoreTheme.SetControl(controlsToToggle, False)
            End If
        End If
    End Sub

    ''' <summary>
    ''' Resets p1 vs p2 stats and set those tBoxes
    ''' </summary>
    Private Sub ResetWinsAgainst()
        totalGamesPvP = 0
        player1.WinsAgainst1 = 0
        player2.WinsAgainst1 = 0
        txtTotalAgainst.Text = totalGamesPvP
        txtWinsagainst.Text = player1.WinsAgainst1
        txtWinsAgainst2.Text = player2.WinsAgainst1
    End Sub

    ''' <summary>
    ''' Set Controls when selecting
    ''' </summary>
    ''' <param name="selectedPlayer"></param>
    ''' <param name="selectedCBox"></param>
    ''' <param name="opposingCbox"></param>
    Private Sub SetSelectedDisplay(selectedPlayer As Integer, selectedCBox As ComboBox, opposingCbox As ComboBox)
        Dim isRivarly As Boolean = False
        lblError.Visible = False
        ResetWinsAgainst()
#Region "Case for which cBox is selected"
        Select Case selectedPlayer
            Case 1
                player1 = New PlayerStats
                player1.PlayerName1 = cbPlayer1.SelectedItem
                If player1.PlayerName1 Is Nothing OrElse player1.PlayerName1.Contains("Choose") Then
                    player1.PID = -1
                Else
                    Integer.TryParse((From row As DictionaryEntry In allplayers
                                      Where row.Value Like player1.PlayerName1 Select row.Key).ToArray.First, player1.PID)
                    lblError.Text = player1.GetPlayers()
                End If

                ScoreTheme.SetErrorLabel(lblError)
                txtWins.Text = player1.Wins1

                If cbPlayer2.SelectedItem IsNot Nothing Then
                    CurrentScreen = AppState.SelectPlayer
                    If player2.PID > 0 Then
                        SetPVPSets()
                    End If
                End If
                If player1.PID > 0 AndAlso player2.PID > 0 AndAlso pvpSet2.Tables(0).Rows.Count > 0 Then
                    SetWinsAgainst()
                    isRiv = player1.getRivarly(player2.WinsAgainst1)
                End If
            Case 2
                player2 = New PlayerStats
                player2.PlayerName1 = cbPlayer2.SelectedItem
                If player2.PlayerName1 Is Nothing OrElse player2.PlayerName1.Contains("Choose") Then
                    player2.PID = -1
                Else
                    Integer.TryParse((From row As DictionaryEntry In allplayers
                                      Where row.Value Like player2.PlayerName1 Select row.Key).ToArray.First, player2.PID)
                    lblError.Text = player2.GetPlayers()
                End If
                ScoreTheme.SetErrorLabel(lblError)
                txtWins2.Text = player2.Wins1
                If ScoreTheme.ValidateCBox(cbPlayer1).Equals(True) Then
                    CurrentScreen = AppState.SelectPlayer
                    If player1.PID > 0 Then
                        SetPVPSets()
                    End If
                Else
                    CurrentScreen = AppState.Start
                End If
                If player2.PID > 0 AndAlso player1.PID > 0 AndAlso pvpSet1.Tables(0).Rows.Count > 0 Then
                    SetWinsAgainst()
                    isRiv = player2.getRivarly(player1.WinsAgainst1)
                End If
        End Select

        If isRiv Then
            lblError.Text = "Rivarly"
            ScoreTheme.SetErrorLabel(lblError)
        End If
#End Region

        If CurrentSession.IsLoggedIn.Equals(False) Then Exit Sub

        'Choose a valid 1 and 2
        If ScoreTheme.ValidateCBox(selectedCBox) AndAlso ScoreTheme.ValidateCBox(opposingCbox) AndAlso Not selectedCBox.SelectedItem.Equals(opposingCbox.SelectedItem) Then
            SetControlsbyCbPlayers()
            SetScoreControlsScreen(cbGames, New Control() {lblScoreBoard, lstAllWins})
            lblError.Visible = False
            'Don't play yourself
        ElseIf selectedCBox.SelectedItem.Equals(opposingCbox.SelectedItem) Then
            SetControlsbyCbPlayers()
            With lblError
                .Text = "Don't Play Yourself!"
                .Visible = True
            End With
            CurrentScreen = AppState.SelectPlayer
            'not valid, hide save button
        Else
                With btnSave
                .Enabled = False
                .Visible = False
            End With
            lblError.Visible = False
            CurrentScreen = AppState.SelectPlayer
            SetControlsbyCbPlayers()
        End If

        If CurrentScreen <> AppState.Winner Then
            btnPlayer1win.Visible = False
            btnPlayer2Wins.Visible = False
        End If

    End Sub

    ''' <summary>
    ''' Sets tBoxes and controls after we find pvp stats
    ''' </summary>
    Private Sub SetWinsAgainst()
        If pvpID > -1 Or pvpID2 > -1 Then
            totalGamesPvP = player1.WinsAgainst1 + player2.WinsAgainst1
            txtWinsagainst.Text = player1.WinsAgainst1.ToString
            txtWinsAgainst2.Text = player2.WinsAgainst1.ToString
            txtTotalAgainst.Text = totalGamesPvP.ToString
        Else
            ResetWinsAgainst()
        End If
    End Sub

    ''' <summary>
    ''' Search for a record for ID1 and ID2, get those datasets
    ''' Try to get the ID from those sets
    ''' Try to parse from those, or if none then return -1 and reset against on every index change
    ''' </summary>
    Public Sub SetPVPSets()
        pvpSet1 = player1.SearchPvPStats(player2.PID, game)
        pvpID = GetPvPID(pvpSet1)
        If pvpID > -1 Then
            Integer.TryParse(pvpSet1.Tables(0).Rows(0).Item("Wins"), player1.WinsAgainst1)
        Else
            player1.WinsAgainst1 = 0
        End If
        pvpSet2 = player2.SearchPvPStats(player1.PID, game)
        pvpID2 = GetPvPID(pvpSet2)
        If pvpID2 > -1 Then
            Integer.TryParse(pvpSet2.Tables(0).Rows(0).Item("Wins"), player2.WinsAgainst1)
        Else
            player2.WinsAgainst1 = 0
        End If
    End Sub

#End Region
#Region "GETS"

    ''' <summary>
    ''' Go through the dataset for the ID
    ''' if we don't find one then return -1 to add a new one
    ''' </summary>
    ''' <param name="pvpStats"></param>
    ''' <returns></returns>
    Private Function GetPvPID(ByVal pvpStats As DataSet) As Integer
        Dim pvpID As Integer = -1
        Try
            For i = 0 To pvpStats.Tables(0).Rows.Count - 1
                If Integer.TryParse(pvpStats.Tables(0).Rows(i).Item("PvPID"), pvpID) > -1 Then
                    Return pvpID
                End If
            Next
        Catch ex As Exception
            Dim exceptionLog As New Logging(Now, "Get PvP ID : ", ex.ToString)
            exceptionLog.LogAction()
            Return pvpID
        End Try
        Return pvpID
    End Function

    ''' <summary>
    ''' Get the columns and set the board
    ''' </summary>
    Private Sub GetHighScores()
        If allWins.Tables(0).Rows.Count > 0 Then
            Try
                Dim scores = (From r In allWins.Tables(0).AsEnumerable Where r.Item("gID") = game Select r)
                If scores.Count > 0 Then
                    lstAllWins.Items.Clear()
                    For Each score In scores
                        Dim playerNameScore As String = score.Item("playerName")
                        Dim playerScore As String = score.Item("winAgainst")
                        Dim opponentID As Integer = score.Item("opponentID")
                        Dim lastGame As Date = score.Item("lastMatch")
                        If Not String.IsNullOrEmpty(allplayers.Item(opponentID)) Then
                            lstAllWins.Items.Add($"{playerNameScore} has beaten {allplayers.Item(opponentID)} [{playerScore}] time(s) since {lastGame.ToString("MM/dd/yyyy")}")

                        End If
                    Next
                    lstAllWins.SelectedItem = lstAllWins.Items.Item(0)
                    lstAllWins.Enabled = True
                End If
            Catch ex As Exception
                Dim exceptionLog As New Logging(Now, "GetHighScores : ", ex.ToString)
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
    ''' If we are not in start state and both names are there, then if wins are theres, set objs and add
    ''' If no new wins, just display
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim player1String As String = String.Empty
        Dim wins As Integer = 0
        Dim isRivarly As Boolean = False
        lblError.Visible = False

        If ScoreTheme.ValidateCBox(cbPlayer1).Equals(True) AndAlso ScoreTheme.ValidateCBox(cbPlayer2).Equals(True) Then
            CurrentScreen = AppState.Winner
            With player1
                .PlayerName1 = cbPlayer1.SelectedItem.ToString
                .Wins1 = txtWins.Text
            End With
            With player2
                .PlayerName1 = cbPlayer2.SelectedItem.ToString
                .Wins1 = txtWins2.Text
            End With
            btnPlayer1win.Text = Me.player1.PlayerName1 & "  WINS! "
            btnPlayer2Wins.Text = player2.PlayerName1 & "  WINS!"
            ScoreTheme.SetControl(New Button() {btnSave}, False)
            ScoreTheme.SetControl(New Control() {btnPlayer1win, btnPlayer2Wins}, True)
            btnBack.Text = "Back"
            CurrentScreen = AppState.Winner
        Else
            Dim selectionAlert As DialogResult = MessageBox.Show($"You must select both players?",
 "Missing Player", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            CurrentScreen = AppState.SelectPlayer
        End If
    End Sub

    ''' <summary>
    ''' If we are in this state, new obj and try to parse the Linq key from the hashtable
    ''' if the other selected item is not nothing, then we have both. Set that state and get the pvpStats
    ''' If we have both and the other pvpSet, then set those stats on the objs
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cbPlayer1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPlayer1.SelectedIndexChanged
        SetSelectedDisplay(1, cbPlayer1, cbPlayer2)
#Region "Beta select"
        'Dim isRivarly As Boolean = False
        ''tbEdit.Visible = False
        'lblError.Visible = False

        'player1.WinsAgainst1 = 0
        'player2.WinsAgainst1 = 0
        'txtWinsagainst.Text = player1.WinsAgainst1
        'txtWinsAgainst2.Text = player2.WinsAgainst1
        'If CurrentScreen <> AppState.Register Then
        '    If cbPlayer1.SelectedItem.Equals("Choose Something") Then Exit Sub
        '    player1 = New PlayerStats
        '    If cbPlayer1.SelectedItem.Equals("Choose Something") Then Exit Sub
        '    ScoreTheme.SetControl(New Control() {txtWins, txtWins2, lblPlayer1, lblPlayer2,
        '                    lblTotalAgainst, lblTotalWins1, lblTotalWins2}, True)
        '    player1.PlayerName1 = cbPlayer1.SelectedItem
        '    Integer.TryParse((From row As DictionaryEntry In allplayers
        '                      Where row.Value Like player1.PlayerName1 Select row.Key).ToArray.First, player1.PID)
        '    lblError.Text = player1.GetPlayers()
        '    ScoreTheme.SetErrorLabel(lblError)

        '    txtWins.Text = player1.Wins1

        '    If cbPlayer2.SelectedItem IsNot Nothing Then
        '        CurrentScreen = AppState.Switch
        '        ScoreTheme.SetControl(New Button() {btnSave}, True)
        '        If player2.PID > 0 Then
        '            SetPVPSets()
        '        End If
        '    Else
        '        CurrentScreen = AppState.Start
        '    End If
        '    If player1.PID > 0 AndAlso player2.PID > 0 AndAlso pvpSet2.Tables(0).Rows.Count > 0 Then
        '        'Integer.TryParse(pvpSet1.Tables(0).Rows(0).Item("Wins"), player1.WinsAgainst1)
        '        totalGamesPvP = player1.WinsAgainst1 + player2.WinsAgainst1
        '        txtWinsagainst.Text = player1.WinsAgainst1.ToString
        '        txtWinsAgainst2.Text = player2.WinsAgainst1.ToString
        '        txtTotalAgainst.Text = totalGamesPvP.ToString
        '        isRiv = player1.getRivarly(player2.WinsAgainst1)
        '        ScoreTheme.SetControl(New Control() {txtWinsagainst, txtWinsAgainst2, txtTotalAgainst, lblWinsAgainst1, lblWinsAgainst2, lblTotalAgainst, lblTotalWins1, lblTotalWins2}, True)
        '    Else
        '        ScoreTheme.SetControl(New Control() {txtWinsagainst, txtWinsAgainst2, txtTotalAgainst, lblWinsAgainst1, lblWinsAgainst2, lblTotalAgainst}, False)
        '    End If
        '    If isRiv Then
        '        lblError.Text = "Rivarly"
        '        ScoreTheme.SetErrorLabel(lblError)
        '    End If
        'End If
#End Region
    End Sub

    ''' <summary>
    ''' If we are in this state, new obj and try to parse the Linq key from the hashtable
    ''' if the other selected item is not nothing, then we have both. Set that state and get the pvpStats
    ''' If we have both and the other pvpSet, then set those stats on the objs
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cbPlayer2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPlayer2.SelectedIndexChanged
        SetSelectedDisplay(2, cbPlayer2, cbPlayer1)
#Region "Beta Select"
        'Dim isRivarly As Boolean = False
        ''tbEdit.Visible = False
        'lblError.Visible = False
        'ScoreTheme.SetControl(New TextBox() {txtWins, txtWins2}, True)
        'player1.WinsAgainst1 = 0
        'player2.WinsAgainst1 = 0
        'txtWinsagainst.Text = player1.WinsAgainst1
        'txtWinsAgainst2.Text = player2.WinsAgainst1
        'If CurrentScreen <> AppState.Register Then
        '    player2 = New PlayerStats
        '    player2.PlayerName1 = cbPlayer2.SelectedItem
        '    If cbPlayer2.SelectedItem.Equals("Choose Something") Then Exit Sub
        '    Integer.TryParse((From row As DictionaryEntry In allplayers
        '                      Where row.Value Like player2.PlayerName1 Select row.Key).ToArray.First, player2.PID)
        '    lblError.Text = player2.GetPlayers()
        '    ScoreTheme.SetErrorLabel(lblError)
        '    txtWins2.Text = player2.Wins1
        '    If ScoreTheme.ValidateCBox(cbPlayer1).Equals(True) Then
        '        CurrentScreen = AppState.Switch
        '        ScoreTheme.SetControl(New Button() {btnSave}, True)
        '        If player1.PID > 0 Then
        '            SetPVPSets()
        '        End If
        '    Else
        '        CurrentScreen = AppState.Start
        '    End If
        '    If player2.PID > 0 AndAlso player1.PID > 0 AndAlso pvpSet1.Tables(0).Rows.Count > 0 Then
        '        'Integer.TryParse(pvpSet1.Tables(0).Rows(0).Item("Wins"), player1.WinsAgainst1)
        '        totalGamesPvP = player1.WinsAgainst1 + player2.WinsAgainst1
        '        txtWinsagainst.Text = player1.WinsAgainst1.ToString
        '        txtWinsAgainst2.Text = player2.WinsAgainst1.ToString
        '        txtTotalAgainst.Text = totalGamesPvP.ToString
        '        isRiv = player2.getRivarly(player1.WinsAgainst1)
        '        ScoreTheme.SetControl(New Control() {txtWinsagainst, txtWinsAgainst2, txtTotalAgainst, lblWinsAgainst1, lblWinsAgainst2, lblTotalAgainst, lblTotalWins1, lblTotalWins2}, True)
        '    Else
        '        ScoreTheme.SetControl(New Control() {txtWinsagainst, txtWinsAgainst2, txtTotalAgainst, lblWinsAgainst1, lblWinsAgainst2, lblTotalAgainst}, False)
        '    End If
        '    If isRiv Then
        '        lblError.Text = "Rivarly"
        '        ScoreTheme.SetErrorLabel(lblError)
        '    End If
        'End If
#End Region
    End Sub

    ''' <summary>
    ''' Go to state, and increment from the obj to add new value
    ''' Repopulate stats, set pvp set. If we have them, parse this against prop then check rivarly and enable controls.
    ''' Insert new record on -1 PvPID or update the existing one
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnPlayer1win_Click(sender As Object, e As EventArgs) Handles btnPlayer1win.Click
        CurrentScreen = AppState.Winner
        Dim submittedAlert As DialogResult = MessageBox.Show($"Are you sure you want to submit this win for {player1.PlayerName1}?",
"New Win Submittion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If submittedAlert.Equals(DialogResult.Yes) Then
            Dim gameResults As String = String.Empty
#Region "Beta sql"
            'adapter = New SqlDataAdapter("exec dbo.[insWins_v1.1] @newPlayer = '" & playerStats1.PlayerName1 & "',@wins = " & playerStats1.Wins1, sqlConnection)
#End Region
            gameResults = player1.InsertGame("")
            If (gameResults).Contains("Error") Then
                lblError.Text = gameResults
            Else
                txtWins.Text = gameResults
            End If
            allWins = player1.GetAllResults($"exec [selAllWins_v1] @gID={game},@output=0")
            GetHighScores()
            SetPVPSets()
            If pvpSet1.Tables(0).Rows.Count > 0 Then
                Integer.TryParse(pvpSet1.Tables(0).Rows(0).Item("Wins"), player1.WinsAgainst1)
                isRiv = player1.getRivarly(player2.WinsAgainst1)
            End If
            SetWinsAgainst()
            player1.WinsAgainst1 += 1
            txtWinsagainst.Text = player1.WinsAgainst1
            lblError.Text = player1.InsertPvPStats(player2.PID, pvpID, game)
            totalGamesPvP = player1.WinsAgainst1 + player2.WinsAgainst1
            txtTotalAgainst.Text = totalGamesPvP.ToString
            ScoreTheme.SetErrorLabel(lblError)
            allWins = player1.GetAllResults($"exec [selAllWins_v1] @gID={game},@output=0")
            GetHighScores()
            SetControlsbyCbPlayers()
            SetScoreControlsScreen(cbGames, New Control() {lblScoreBoard, lstAllWins})
            ScoreTheme.SetControl(New Button() {btnPlayer1win, btnPlayer2Wins}, False)
            CurrentScreen = AppState.Switch
            btnBack.Text = "Home"
        End If
    End Sub

    ''' <summary>
    ''' Go to state, and increment from the obj to add new value
    ''' Repopulate stats, set pvp set. If we have them, parse this against prop then check rivarly and enable controls.
    ''' Insert new record on -1 PvPID or update the existing one
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnPlayer2Wins_Click(sender As Object, e As EventArgs) Handles btnPlayer2Wins.Click
        CurrentScreen = AppState.Winner
        Dim submittedAlert As DialogResult = MessageBox.Show($"Are you sure you want to submit this win for {player2.PlayerName1}?",
"New Win Submittion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If submittedAlert.Equals(DialogResult.Yes) Then
            Dim gameResults As String = String.Empty
#Region "beta sql"
            'playerStats2.Wins1 += 1
            'adapter = New SqlDataAdapter("exec dbo.[insWins_v1.1] @newPlayer = '" & playerStats2.PlayerName1 & "',@wins = " & playerStats2.Wins1, sqlConnection)
            'End Try
#End Region
            gameResults = player2.InsertGame("")
            If (gameResults).Contains("Error") Then
                lblError.Text = gameResults
            Else
                txtWins2.Text = gameResults
            End If
            allWins = player1.GetAllResults($"exec [selAllWins_v1] @gID={game},@output=0")
            GetHighScores()
            SetPVPSets()
            If pvpSet2.Tables(0).Rows.Count > 0 Then
                Integer.TryParse(pvpSet2.Tables(0).Rows(0).Item("Wins"), player2.WinsAgainst1)
                SetWinsAgainst()
                isRiv = player2.getRivarly(player1.WinsAgainst1)
            End If
            player2.WinsAgainst1 += 1
            txtWinsAgainst2.Text = player2.WinsAgainst1
            lblError.Text = player2.InsertPvPStats(player1.PID, pvpID2, game)
            totalGamesPvP = player1.WinsAgainst1 + player2.WinsAgainst1
            txtTotalAgainst.Text = totalGamesPvP.ToString
            ScoreTheme.SetErrorLabel(lblError)
            allWins = player1.GetAllResults($"exec [selAllWins_v1] @gID={game},@output=0")
            GetHighScores()
            SetControlsbyCbPlayers()
            SetScoreControlsScreen(cbGames, New Control() {lblScoreBoard, lstAllWins})
            ScoreTheme.SetControl(New Button() {btnPlayer1win, btnPlayer2Wins}, False)
            btnBack.Text = "Home"
            CurrentScreen = AppState.Switch
        End If
    End Sub

    Private Sub btnHighScore_Click(sender As Object, e As EventArgs) Handles btnHighScore.Click
        ScoreTheme.LoadNextFormClose(Me, HighScores)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If CurrentScreen = AppState.Winner Then
            ScoreTheme.SetControl(New Control() {btnPlayer1win, btnPlayer2Wins}, False)
            With btnSave
                .Enabled = True
                .Visible = True
            End With
            btnBack.Text = "Home"
            CurrentScreen = AppState.Switch
        Else
            ScoreTheme.LoadNextFormClose(Me, Home)
        End If

    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        ScoreTheme.LogOutUser()
    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub cbGames_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbGames.SelectedIndexChanged
        ResetWinsAgainst()
        If CurrentScreen = AppState.Winner Then
            CurrentScreen = AppState.SelectPlayer
        End If
        For Each gameEntry As DictionaryEntry In gamesHT
            If gameEntry.Value.Equals(cbGames.SelectedItem) Then
                game = gameEntry.Key
                Exit For
            End If
        Next
        allWins = player1.GetAllResults($"exec [selAllWins_v1] @gID={game},@output=0")

        If allWins IsNot Nothing AndAlso allWins.Tables(0).Rows.Count > 0 AndAlso ScoreTheme.ValidateCBox(cbGames) Then
            GetHighScores()
            lstAllWins.Visible = True
            lblScoreBoard.Visible = True
            If Permissions.IsUser.Equals(True) Then
                btnSave.Visible = True
                btnSave.Enabled = True
                SetPVPSets()
                SetWinsAgainst()
            End If
        ElseIf cbGames.SelectedItem.Equals("Choose") Then
            lstAllWins.Items.Clear()
            ScoreTheme.SetControl(New Control() {btnSave, lblScoreBoard, lstAllWins}, False)
        Else
            If Permissions.IsUser.Equals(True) AndAlso CurrentScreen = AppState.Switch Then
                With btnSave
                    .Visible = True
                    .Enabled = True
                End With
            Else
                With btnSave
                    .Visible = False
                    .Enabled = False
                End With
            End If
            lstAllWins.Items.Clear()
            lstAllWins.Items.Add("No games yet played")
        End If
        SetControlsbyCbPlayers()
        SetScoreControlsScreen(cbGames, New Control() {lblScoreBoard, lstAllWins})
        If CurrentScreen <> AppState.Winner Then
            btnPlayer1win.Visible = False
            btnPlayer2Wins.Visible = False
        End If
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        AboutThis.Activate()
        AboutThis.Show()
    End Sub

    Private Sub PlayerEditToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PlayerEditToolStripMenuItem1.Click, btnRegisterTest.Click
        If Permissions.IsUser.Equals(True) Then
            ScoreTheme.LoadNextFormClose(Me, PlayerManagement)
        End If
    End Sub

    Private Sub EditPasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditPasswordToolStripMenuItem.Click
        If CurrentSession.IsLoggedIn.Equals(True) Then
            ScoreTheme.LoadNextFormClose(Me, PasswordChange)
        End If
    End Sub

    Private Sub ProfileEditingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfileEditingToolStripMenuItem.Click
        If Permissions.IsUser.Equals(True) Then
            ScoreTheme.LoadNextFormClose(Me, ProfileEditing)
        End If
    End Sub


#End Region


#Region "Editing logic moved to PlayerEditing.vb - ver 1.8.2"
    '''' <summary>
    '''' If we're in this state, try to parse key from hashtable to object
    '''' If we have a number in the obj and they confirm, then remove and repopulate
    '''' Do nothing on blank text in this state, if out of the state go to prev.
    '''' </summary>
    '''' <param name="sender"></param>
    '''' <param name="e"></param>
    'Private Sub btnDelete_Click(sender As Object, e As EventArgs)
    '    '    If pvpTheme.Screen.Equals(ScoreTheme.AppState.Delete) Then
    '    '        'grab player obj from cbox
    '    '        Try
    '    '            deletedPlayer.PlayerName1 = cbDelete.SelectedItem.ToString
    '    '            Integer.TryParse((From row As DictionaryEntry In allplayers
    '    '                              Where row.Value Like deletedPlayer.PlayerName1 Select row.Key).ToArray.First, deletedPlayer.PID)
    '    '        Catch ex As Exception
    '    '            Dim exceptionLog As New Logging(Now, "Delete Player: ", ex.ToString)
    '    '            exceptionLog.LogAction()
    '    '            lblError.Text = "Error: Select a player to Delete!!!!!!"
    '    '            pvpTheme.SetErrorLabel(lblError)
    '    '            Exit Sub
    '    '        End Try

    '    '        Dim deleteSQL As String = $"exec [delPlayer] @playerID = {deletedPlayer.PID}, @result=0"

    '    '        If Not String.IsNullOrEmpty(deletedPlayer.PID) Then
    '    '            Dim deletionAlert As DialogResult = MessageBox.Show($"Are you sure you want to erase {editPlayer.PlayerName1}?",
    '    '"Erase Player", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
    '    '            'are you sure??????????
    '    '            If deletionAlert.Equals(DialogResult.Yes) Then
    '    '                player1.GetAllResults(deleteSQL)
    '    '                allWins = player1.GetAllResults($"exec [selAllWins_v1] @gID={game},@output=0")
    '    '                GetHighScores()
    '    '                allplayers = deletedPlayer.IDBConnect_GetAllPlayers()
    '    '                pvpTheme.FillBoxfromHT(cbPlayer1, allplayers)
    '    '                pvpTheme.FillBoxfromHT(cbPlayer2, allplayers)
    '    '                pvpTheme.FillBoxfromHT(cbDelete, allplayers)
    '    '                cbDelete.Visible = False
    '    '                cbDelete.SelectedItem = Nothing
    '    '                pvpTheme.Screen = ScoreTheme.AppState.Register
    '    '                lblError.Text = $"{deletedPlayer.PlayerName1} is gone"
    '    '                lblError.Visible = True
    '    '                cbDelete.SelectedItem = Nothing
    '    '                btnEdit.Visible = True
    '    '                btnReg.Text = "Register"
    '    '                cbDelete.Visible = False
    '    '            Else
    '    '                pvpTheme.Screen = ScoreTheme.AppState.Delete
    '    '                btnEdit.Visible = False
    '    '            End If
    '    '        End If
    '    '    Else
    '    '        btnReg.Text = "Back"
    '    '        btnEdit.Visible = False
    '    '        cbDelete.Visible = True
    '    '        cbDelete.SelectedText = String.Empty
    '    '        pvpTheme.Screen = ScoreTheme.AppState.Delete
    '    '        cbDelete.Visible = True
    '    '    End If
    'End Sub

    'Private Sub btnReg_Click(sender As Object, e As EventArgs)
    '    '        pvpTheme.SetVisiblityTxtBox(New TextBox() {txtWins, txtWins2, txtTotalAgainst, txtWinsAgainst2, txtWinsagainst}, False)
    '    '        btnReg.Text = "Register"
    '    '        lblError.Visible = False
    '    '        cbDelete.SelectedItem = String.Empty
    '    '        Dim retVal As String = String.Empty
    '    '        pvpTheme.SetVisibiltyButton(New Button() {btnSave, btnDelete, btnEdit}, False)
    '    '        'If players have names, then update cbox and add them to db
    '    '        If pvpTheme.Screen = ScoreTheme.AppState.Register AndAlso Not String.IsNullOrEmpty(tbEdit.Text) Then
    '    '            pvpTheme.Screen = ScoreTheme.AppState.Register
    '    '            cbPlayer1.BeginUpdate()
    '    '            cbPlayer2.BeginUpdate()

    '    '            player1 = New PlayerStats
    '    '            player1.PlayerName1 = tbEdit.Text

    '    '            Try
    '    '                If userPermissions.IsUser Then
    '    '                    lblError.Text = player1.InsertPlayer()
    '    '                End If
    '    '            Catch ex As Exception
    '    '                Dim exceptionLog As New Logging(Now, "Add Players: ", ex.ToString)
    '    '                exceptionLog.LogAction()
    '    '                lblError.Text = ex.ToString
    '    '            End Try
    '    '            pvpTheme.SetErrorLabel(lblError)


    '    '            cbPlayer1.EndUpdate()
    '    '            cbPlayer2.EndUpdate()
    '    '            allplayers = player1.IDBConnect_GetAllPlayers()
    '    '            allWins = player1.GetAllResults($"exec [selAllWins_v1] @gID={game},@output=0")
    '    '            GetHighScores()
    '    '            allplayers = player1.IDBConnect_GetAllPlayers()
    '    '            pvpTheme.FillBoxfromHT(cbPlayer1, allplayers)
    '    '            pvpTheme.FillBoxfromHT(cbPlayer2, allplayers)
    '    '            pvpTheme.FillBoxfromHT(cbDelete, allplayers)
    '    '#Region "Controls"

    '    '            'With cbPlayer1.Items
    '    '            '    .Add(tbEdit.Text)
    '    '            'End With

    '    '            'With cbPlayer2.Items
    '    '            '    .Add(tbEdit.Text)
    '    '            'End With
    '    '            btnReg.Text = "Register"
    '    '            lblError.Text = "New Players Added"
    '    '            lblError.Visible = True
    '    '            tbEdit.ResetText()
    '    '            tbEdit.Visible = False
    '    '            cbPlayer1.Visible = True
    '    '            cbPlayer2.Visible = True
    '    '            cbDelete.Visible = False
    '    '            'btnSave.Visible = True
    '    '            pvpTheme.SetVisibiltyButton(New Button() {btnDelete, btnEdit, btnSave}, False)
    '    '            'btnDelete.Visible = False
    '    '            btnBack.Visible = True
    '    '            cbPlayer1.SelectedItem = Nothing
    '    '            cbPlayer2.SelectedItem = Nothing
    '    '            pvpTheme.Screen = ScoreTheme.AppState.Start
    '    '#End Region
    '    '        Else
    '    '            If pvpTheme.Screen = ScoreTheme.AppState.Register Then
    '    '#Region "Controls"
    '    '                lblError.Text = "Back"
    '    '                lblError.Visible = True
    '    '                tbEdit.ResetText()
    '    '                tbEdit.Visible = False
    '    '                cbPlayer1.Visible = True
    '    '                cbPlayer2.Visible = True
    '    '                pvpTheme.SetVisiblityTxtBox(New TextBox() {txtWins, txtWins2}, True)
    '    '                'txtWins.Visible = True
    '    '                'txtWins2.Visible = True
    '    '                'btnSave.Visible = True
    '    '                cbPlayer1.Refresh()
    '    '                cbPlayer2.Refresh()
    '    '                pvpTheme.SetVisibiltyButton(New Button() {btnDelete, btnEdit, btnSave}, False)
    '    '                'btnDelete.Visible = False
    '    '                cbDelete.Visible = False
    '    '                btnBack.Visible = True
    '    '                cbGames.Visible = True
    '    '                cbPlayer1.SelectedItem = Nothing
    '    '                cbPlayer2.SelectedItem = Nothing
    '    '                pvpTheme.Screen = ScoreTheme.AppState.Start
    '    '#End Region
    '    '            Else
    '    '                tbEdit.Visible = True
    '    '                cbPlayer1.Visible = False
    '    '                cbPlayer2.Visible = False
    '    '                cbDelete.Visible = False
    '    '                cbGames.Visible = False
    '    '                If userPermissions.IsAdmin() Then
    '    '                    pvpTheme.SetVisibiltyButton(New Button() {btnDelete, btnEdit}, True)
    '    '                ElseIf userPermissions.IsUser() Then
    '    '                    'Delete only for Admins
    '    '                    pvpTheme.SetVisibiltyButton(New Button() {btnEdit}, True)
    '    '                End If
    '    '                btnSave.Visible = False
    '    '                btnBack.Visible = False
    '    '                tbEdit.ResetText()
    '    '                pvpTheme.Screen = ScoreTheme.AppState.Register
    '    '            End If

    '    '        End If
    '    '        Refresh()
    'End Sub

    '''' <summary>
    '''' Editing names, if we're in that state, try to parse this key into the ID
    '''' If we have text, display dialog box to confirm, then add and repopulate the controls
    '''' If empty do nothing, if not inthis state then go to prev.
    '''' </summary>
    '''' <param name="sender"></param>
    '''' <param name="e"></param>
    'Private Sub btnEdit_Click(sender As Object, e As EventArgs)
    '    '    If pvpTheme.Screen = ScoreTheme.AppState.edit Then
    '    '        Dim newName As String = tbEdit.Text
    '    '        'grab player obj from cbox
    '    '        Try
    '    '            Integer.TryParse((From row As DictionaryEntry In allplayers
    '    '                              Where row.Value Like editPlayer.PlayerName1 Select row.Key).ToArray.First, editPlayer.PID)
    '    '        Catch ex As Exception
    '    '            Dim exceptionLog As New Logging(Now, "Edit Players: ", ex.ToString)
    '    '            exceptionLog.LogAction()
    '    '            lblError.Text = "Error: Select a player to Change"
    '    '            pvpTheme.SetErrorLabel(lblError)
    '    '            Exit Sub
    '    '        End Try

    '    '        Dim editSQL As String = $"exec [insNewPlayer_v1.2] @pID = {editPlayer.PID}, @newPlayer='{newName}',@result=0"
    '    '        If Not String.IsNullOrEmpty(editPlayer.PID) AndAlso Not String.IsNullOrEmpty(newName) Then
    '    '            Dim editAlert As DialogResult = MessageBox.Show($"Are you sure you want to change {editPlayer.PlayerName1} to {newName}?",
    '    '"Erase Player", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
    '    '            'are you sure??????????
    '    '            If editAlert.Equals(DialogResult.Yes) Then
    '    '                player1.GetAllResults(editSQL)
    '    '                allWins = player1.GetAllResults($"exec [selAllWins_v1] @gID={game},@output=0")
    '    '                GetHighScores()
    '    '                allplayers = editPlayer.IDBConnect_GetAllPlayers()
    '    '                pvpTheme.FillBoxfromHT(cbPlayer1, allplayers)
    '    '                pvpTheme.FillBoxfromHT(cbPlayer2, allplayers)
    '    '                pvpTheme.FillBoxfromHT(cbDelete, allplayers)
    '    '                tbEdit.ResetText()
    '    '                cbDelete.Visible = False
    '    '                cbDelete.SelectedItem = Nothing
    '    '                pvpTheme.Screen = ScoreTheme.AppState.Register
    '    '                lblError.Text = $"{editPlayer.PlayerName1} is now {newName}"
    '    '                lblError.Visible = True
    '    '                btnReg.Text = "Register"
    '    '                btnDelete.Visible = True
    '    '                cbDelete.SelectedItem = Nothing
    '    '                cbDelete.Visible = False
    '    '            Else
    '    '                btnDelete.Visible = False
    '    '                pvpTheme.Screen = ScoreTheme.AppState.edit
    '    '            End If
    '    '        End If
    '    '    Else
    '    '        btnReg.Text = "Back"
    '    '        cbDelete.SelectedText = String.Empty
    '    '        cbDelete.Visible = True
    '    '        tbEdit.Visible = True
    '    '        btnDelete.Visible = False
    '    '        pvpTheme.Screen = ScoreTheme.AppState.edit
    '    '    End If
    'End Sub

    ''''' <summary>
    ''''' Set object from selected item and enable controls
    ''''' </summary>
    ''''' <param name="sender"></param>
    ''''' <param name="e"></param>
    ''Private Sub cbDelete_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDelete.SelectedIndexChanged
    ''    editPlayer = New PlayerStats
    ''    If pvpTheme.ValidateCBox(cbDelete).Equals(True) Then
    ''        editPlayer.PlayerName1 = cbDelete.SelectedItem.ToString
    ''    End If
    ''    If pvpTheme.Screen = ScoreTheme.AppState.Delete Then
    ''        btnDelete.Visible = True
    ''        btnEdit.Visible = False
    ''    ElseIf pvpTheme.Screen = ScoreTheme.AppState.edit Then
    ''        btnDelete.Visible = False
    ''        btnEdit.Visible = True
    ''    End If
    ''End Sub
#End Region

End Class
