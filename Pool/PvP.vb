Imports System.IO

Public Class PvP
    Dim pvpTheme As New ScoreTheme(Me)
    'Dim connectionString As String = ("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & Path.GetDirectoryName(Application.StartupPath) & "\LocalResults.mdf;Integrated Security=True").Replace("\bin", "")
    'Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jwhitis\source\repos\Pool\Pool\LocalResults.mdf;Integrated Security=True"
#Region "Global to form"
    Dim player1 As New PlayerStats
    Dim player2 As New PlayerStats
    'Dim screen As New Test.AppState
    Dim isRiv As Boolean = False
    Dim allplayers As New Hashtable
    Dim allWins As New DataSet
    Dim deletedPlayer As New PlayerStats
    Dim editPlayer As New PlayerStats
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
#Region "Beta select all SQL"
        'Dim adapter As New SqlDataAdapter
        'Dim ds As New DataSet
        'Dim dbCommand As New SqlCommand
        'Dim sqlConnection As New SqlConnection
        'With sqlConnection
        '    .ConnectionString = connectionString
        '    .Open()
        'End With

        'adapter = New SqlDataAdapter("Select Playername from Players", sqlConnection)
        'adapter.Fill(ds)

        'Try
        '    For i = 0 To ds.Tables(0).Rows.Count - 1
        '        cbPlayer1.Items.Add(ds.Tables(0).Rows(i).Item(0))
        '        cbPlayer2.Items.Add(ds.Tables(0).Rows(i).Item(0))
        '    Next
        'Catch ex As Exception
        '    sqlConnection.Close()
        '    lblError.Text = "can't fetch data source Player Names"
        '    lblError.Visible = True
        'Finally
        '    sqlConnection.Close()
        'End Try
#End Region
        allWins = player1.GetAllResults("exec selAllWins @output=0")
        allplayers = player1.IDBConnect_GetAllPlayers()
        GetHighScores()
        pvpTheme.FillBoxfromHT(cbPlayer1, allplayers)
        pvpTheme.FillBoxfromHT(cbPlayer2, allplayers)
        pvpTheme.FillBoxfromHT(cbDelete, allplayers)
#End Region
        Me.CenterToScreen()
        Dim background = Me.BackColor.ToString
        Dim font = Me.btnEdit.Font
        Dim buttonColor = Me.btnEdit.BackColor.ToString
        pvpTheme.SetVisiblityTxtBox(New TextBox() {txtWins, txtWins2, txtWinsagainst, txtTotalAgainst, txtWinsAgainst2}, False)
        pvpTheme.SetVisibiltyButton(New Button() {btnSave}, False)
        Dim results As String = String.Empty
        lblError.Visible = False
        If pvpTheme.Screen = -1 Then
            lblError.Visible = True
            lstAllWins.Visible = True
        Else
            pvpTheme.Screen = ScoreTheme.AppState.Start
        End If
    End Sub
    ''' <summary>
    ''' Get the columns and set the board
    ''' </summary>
    Private Sub GetHighScores()
        If allWins.Tables(0).Rows.Count > 0 Then
            lstAllWins.Items.Clear()
            Try
                Dim scores = (From r In allWins.Tables(0).AsEnumerable Select r)
                For Each score In scores
                    Dim playerNameScore As String = score.Item("playerName")
                    Dim playerScore As String = score.Item("wins")
                    lstAllWins.Items.Add(playerNameScore & "".PadRight(10) & ":" & "".PadRight(5) & playerScore)
                Next
            Catch ex As Exception
                Debug.WriteLine(ex.ToString)
                lblError.Text = ex.Message.ToString
                pvpTheme.SetErrorLabel(lblError)
            End Try
        End If
    End Sub

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
        pvpTheme.SetVisiblityTxtBox(New TextBox() {tbEdit}, False)
        pvpTheme.SetVisiblityTxtBox(New TextBox() {txtWins, txtWins2}, True)
        'tbPlayer1.Visible = False
        lblError.Visible = False
        'txtWins.Visible = True
        'txtWins2.Visible = True

        If pvpTheme.Screen > ScoreTheme.AppState.Start Then
            If Not String.IsNullOrEmpty(cbPlayer1.SelectedItem.ToString) And Not String.IsNullOrEmpty(cbPlayer2.SelectedItem.ToString) Then
#Region "if wins are not empty then add new game, else display wins"
                If Not String.IsNullOrEmpty(txtWins.Text) AndAlso Not String.IsNullOrEmpty(txtWins2.Text) Then
                    pvpTheme.Screen = ScoreTheme.AppState.Winner
#Region "beta get games SQL"
                    'With sqlConnection
                    '    .ConnectionString = connectionString
                    '    .Open()
                    'End With

                    'adapter = New SqlDataAdapter("Select wins from Players where playerName In ('" & cbPlayer1.SelectedItem.ToString & "','" & cbPlayer2.SelectedItem.ToString & "')", sqlConnection)
                    'adapter.Fill(ds)

                    ''save new wins if null txtbox wins, else then insert new game results.
                    'Try
                    '    txtWins.Text = ds.Tables(0).Rows(0).Item(0).ToString
                    '    txtWins2.Text = ds.Tables(0).Rows(1).Item(0).ToString
                    'Catch ex As Exception
                    '    sqlConnection.Close()
                    '    lblError.Text = "Name not found"
                    '    lblError.Visible = True
                    'Finally
                    '    sqlConnection.Close()

                    'End Try
#End Region
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
                    pvpTheme.SetVisibiltyButton(New Button() {btnReg, btnSave, btnEdit, btnDelete}, False)
                    btnPlayer1win.Visible = True
                    btnPlayer2Wins.Visible = True
                    'btnReg.Visible = False
                    'btnSave.Visible = False
                    btnBack.Text = "Back"
                    pvpTheme.Screen = ScoreTheme.AppState.Switch
                Else 'we'll open current wins
#Region "beta games SQL"
                    'With sqlConnection
                    '    .ConnectionString = connectionString
                    '    .Open()
                    'End With

                    'adapter = New SqlDataAdapter("Select wins from Players where playerName In ('" & cbPlayer1.SelectedItem.ToString & "','" & cbPlayer2.SelectedItem.ToString & "')", sqlConnection)
                    'adapter.Fill(ds)

                    ''save new wins if null txtbox wins, else then insert new game results.
                    'Try
                    '    txtWins.Text = ds.Tables(0).Rows(0).Item(0).ToString
                    '    txtWins2.Text = ds.Tables(0).Rows(1).Item(0).ToString
                    'Catch ex As Exception
                    '    sqlConnection.Close()
                    '    lblError.Text = "Name not found"
                    '    lblError.Visible = True
                    'Finally
                    '    sqlConnection.Close()

                    'End Try
#End Region
                    pvpTheme.Screen = ScoreTheme.AppState.SelectPlayer
                    Dim currentWins As String() = Nothing
                    Dim winResult = Me.player1.GetAllResults($"exec [selPlayers_v1.1] @playerId={Me.player1.PID}")
                    Dim winResult2 = Me.player1.GetAllResults($"exec [selPlayers_v1.1] @playerId={Me.player2.PID}")
                    Try
                        txtWins.Text = $"{winResult.Tables(0).Rows.Item(0).Item("wins").ToString}"
                        txtWins2.Text = $"{winResult2.Tables(0).Rows.Item(0).Item("wins").ToString}"
                    Catch ex As Exception
                        lblError.Text = "Error"
                    End Try
                    pvpTheme.SetErrorLabel(lblError)
                End If
#End Region
            End If
        Else
            lblError.Text = "Error: Select Both Players"
            pvpTheme.SetErrorLabel(lblError)
            pvpTheme.Screen = -1
        End If
    End Sub

    Private Sub btnReg_Click(sender As Object, e As EventArgs) Handles btnReg.Click
        pvpTheme.SetVisiblityTxtBox(New TextBox() {txtWins, txtWins2, txtTotalAgainst, txtWinsAgainst2, txtWinsagainst}, False)
        btnReg.Text = "Register"
        'txtWins.Visible = False
        'txtWins2.Visible = False
        lblError.Visible = False
        cbDelete.SelectedItem = String.Empty
        Dim retVal As String = String.Empty
        pvpTheme.SetVisibiltyButton(New Button() {btnSave, btnDelete, btnEdit}, False)
        'If players have names, then update cbox and add them to db
        If pvpTheme.Screen = ScoreTheme.AppState.Register AndAlso Not String.IsNullOrEmpty(tbEdit.Text) Then
            pvpTheme.Screen = ScoreTheme.AppState.Register
            cbPlayer1.BeginUpdate()
            cbPlayer2.BeginUpdate()

            player1 = New PlayerStats
            player1.PlayerName1 = tbEdit.Text

            Try
                lblError.Text = player1.InsertPlayer()
            Catch ex As Exception
                lblError.Text = ex.ToString
            End Try
            pvpTheme.SetErrorLabel(lblError)

#Region "Beta add player sql"
            'With sqlConnection
            '    .ConnectionString = connectionString
            '    .Open()
            'End With

            'Try
            '    With dbCommand
            '        .Connection = sqlConnection
            '        .CommandText = command
            '        .ExecuteNonQuery()

            '    End With
            'Catch ex As Exception
            '    sqlConnection.Close()
            '    lblError.Text = "Name not found"
            '    lblError.Visible = True
            'Finally
            '    sqlConnection.Close()
            'End Try
#End Region

            cbPlayer1.EndUpdate()
            cbPlayer2.EndUpdate()
            'allplayers = New Hashtable
            allplayers = player1.IDBConnect_GetAllPlayers()
            allWins = player1.GetAllResults("exec selAllWins @output=0")
            GetHighScores()
            allplayers = player1.IDBConnect_GetAllPlayers()
            pvpTheme.FillBoxfromHT(cbPlayer1, allplayers)
            pvpTheme.FillBoxfromHT(cbPlayer2, allplayers)
            pvpTheme.FillBoxfromHT(cbDelete, allplayers)
#Region "Controls"

            'With cbPlayer1.Items
            '    .Add(tbEdit.Text)
            'End With

            'With cbPlayer2.Items
            '    .Add(tbEdit.Text)
            'End With
            btnReg.Text = "Register"
            lblError.Text = "New Players Added"
            lblError.Visible = True
            tbEdit.ResetText()
            tbEdit.Visible = False
            cbPlayer1.Visible = True
            cbPlayer2.Visible = True
            cbDelete.Visible = False
            'btnSave.Visible = True
            pvpTheme.SetVisibiltyButton(New Button() {btnDelete, btnEdit, btnSave}, False)
            'btnDelete.Visible = False
            btnBack.Visible = True
            cbPlayer1.SelectedItem = Nothing
            cbPlayer2.SelectedItem = Nothing
            pvpTheme.Screen = ScoreTheme.AppState.Start
#End Region
        Else
            If pvpTheme.Screen = ScoreTheme.AppState.Register Then
#Region "Controls"
                lblError.Text = "Back"
                lblError.Visible = True
                tbEdit.ResetText()
                tbEdit.Visible = False
                cbPlayer1.Visible = True
                cbPlayer2.Visible = True
                pvpTheme.SetVisiblityTxtBox(New TextBox() {txtWins, txtWins2}, True)
                'txtWins.Visible = True
                'txtWins2.Visible = True
                'btnSave.Visible = True
                cbPlayer1.Refresh()
                cbPlayer2.Refresh()
                pvpTheme.SetVisibiltyButton(New Button() {btnDelete, btnEdit, btnSave}, False)
                'btnDelete.Visible = False
                cbDelete.Visible = False
                btnBack.Visible = True
                cbPlayer1.SelectedItem = Nothing
                cbPlayer2.SelectedItem = Nothing
                pvpTheme.Screen = ScoreTheme.AppState.Start
#End Region
            Else
                tbEdit.Visible = True
                cbPlayer1.Visible = False
                cbPlayer2.Visible = False
                pvpTheme.SetVisibiltyButton(New Button() {btnDelete, btnEdit}, True)
                btnSave.Visible = False
                btnBack.Visible = False
                tbEdit.ResetText()
                pvpTheme.Screen = ScoreTheme.AppState.Register
            End If

        End If
        Refresh()
    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.PlayersTableAdapter.FillBy(Me.PlayerNames.Players)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillBy1ToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.PlayersTableAdapter.FillBy1(Me.PlayerNames.Players)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    ''' <summary>
    ''' If we are in this state, new obj and try to parse the Linq key from the hashtable
    ''' if the other selected item is not nothing, then we have both. Set that state and get the pvpStats
    ''' If we have both and the other pvpSet, then set those stats on the objs
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cbPlayer1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPlayer1.SelectedIndexChanged
        Dim isRivarly As Boolean = False
        tbEdit.Visible = False
        lblError.Visible = False
        'txtWins.Visible = True
        'txtWins2.Visible = True
        pvpTheme.SetVisiblityTxtBox(New TextBox() {txtWins, txtWins2}, True)
        player1.WinsAgainst1 = 0
        player2.WinsAgainst1 = 0
        txtWinsagainst.Text = player1.WinsAgainst1
        txtWinsAgainst2.Text = player2.WinsAgainst1
        If pvpTheme.Screen <> ScoreTheme.AppState.Register Then
            player1 = New PlayerStats
            player1.PlayerName1 = cbPlayer1.SelectedItem
            Integer.TryParse((From row As DictionaryEntry In allplayers
                              Where row.Value Like player1.PlayerName1 Select row.Key).ToArray.First, player1.PID)
            lblError.Text = player1.GetPlayers()
            pvpTheme.SetErrorLabel(lblError)
#Region "beta sql"
            'With sqlConnection
            '    .ConnectionString = connectionString
            '    .Open()
            'End With

            ''save new wins if null txtbox wins, else then insert new game results.
            'Try
            '    adapter = New SqlDataAdapter("Select wins from Players where playerName In ('" & cbPlayer1.SelectedItem & "')", sqlConnection)
            '    adapter.Fill(ds)
            '    txtWins.Text = ds.Tables(0).Rows(0).Item(0).ToString
            '    playerStats1.Wins1 = txtWins.Text
            '    If (Not String.IsNullOrEmpty(txtWins.Text) AndAlso Not String.IsNullOrEmpty(txtWins2.Text)) Then
            '        If playerStats1.getRivarly(txtWins2.Text) Then
            '            lblError.Text = "Rivarly Game"
            '            lblError.Text = Visible
            '            lblError.ForeColor = Color.Black
            '        End If
            '    End If


            'Catch ex As Exception
            '    sqlConnection.Close()
            '    lblError.Text = "Name not found"
            '    lblError.Visible = True
            'Finally
            '    sqlConnection.Close()

            'End Try
#End Region
            txtWins.Text = player1.Wins1

            If cbPlayer2.SelectedItem IsNot Nothing Then
                pvpTheme.Screen = ScoreTheme.AppState.Switch
                pvpTheme.SetVisibiltyButton(New Button() {btnSave}, True)
                If player2.PID > 0 Then
                    SetPVPSets()
                End If
            Else
                pvpTheme.Screen = ScoreTheme.AppState.Start
            End If
            If player1.PID > 0 AndAlso player2.PID > 0 AndAlso pvpSet2.Tables(0).Rows.Count > 0 Then
                'Integer.TryParse(pvpSet1.Tables(0).Rows(0).Item("Wins"), player1.WinsAgainst1)
                totalGamesPvP = player1.WinsAgainst1 + player2.WinsAgainst1
                txtWinsagainst.Text = player1.WinsAgainst1.ToString
                txtWinsAgainst2.Text = player2.WinsAgainst1.ToString
                txtTotalAgainst.Text = totalGamesPvP.ToString
                isRiv = player1.getRivarly(player2.WinsAgainst1)
                pvpTheme.SetVisiblityTxtBox(New TextBox() {txtWinsagainst, txtWinsAgainst2, txtTotalAgainst}, True)
            Else
                pvpTheme.SetVisiblityTxtBox(New TextBox() {txtWinsagainst, txtWinsAgainst2, txtTotalAgainst}, False)
            End If
            If isRiv Then
                lblError.Text = "Rivarly"
                pvpTheme.SetErrorLabel(lblError)
            End If
        End If

    End Sub

    ''' <summary>
    ''' If we are in this state, new obj and try to parse the Linq key from the hashtable
    ''' if the other selected item is not nothing, then we have both. Set that state and get the pvpStats
    ''' If we have both and the other pvpSet, then set those stats on the objs
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cbPlayer2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPlayer2.SelectedIndexChanged
        Dim isRivarly As Boolean = False
        tbEdit.Visible = False
        lblError.Visible = False
        pvpTheme.SetVisiblityTxtBox(New TextBox() {txtWins, txtWins2}, True)
        'txtWins.Visible = True
        'txtWins2.Visible = True
        player1.WinsAgainst1 = 0
        player2.WinsAgainst1 = 0
        txtWinsagainst.Text = player1.WinsAgainst1
        txtWinsAgainst2.Text = player2.WinsAgainst1
        If pvpTheme.Screen <> ScoreTheme.AppState.Register Then
            player2 = New PlayerStats
            player2.PlayerName1 = cbPlayer2.SelectedItem
            Integer.TryParse((From row As DictionaryEntry In allplayers
                              Where row.Value Like player2.PlayerName1 Select row.Key).ToArray.First, player2.PID)
            lblError.Text = player2.GetPlayers()
            pvpTheme.SetErrorLabel(lblError)
            txtWins2.Text = player2.Wins1
            If cbPlayer1.SelectedItem IsNot Nothing Then
                pvpTheme.Screen = ScoreTheme.AppState.Switch
                pvpTheme.SetVisibiltyButton(New Button() {btnSave}, True)
                If player1.PID > 0 Then
                    SetPVPSets()
                End If
            Else
                pvpTheme.Screen = ScoreTheme.AppState.Start
            End If
            If player2.PID > 0 AndAlso player1.PID > 0 AndAlso pvpSet1.Tables(0).Rows.Count > 0 Then
                'Integer.TryParse(pvpSet1.Tables(0).Rows(0).Item("Wins"), player1.WinsAgainst1)
                totalGamesPvP = player1.WinsAgainst1 + player2.WinsAgainst1
                txtWinsagainst.Text = player1.WinsAgainst1.ToString
                txtWinsAgainst2.Text = player2.WinsAgainst1.ToString
                txtTotalAgainst.Text = totalGamesPvP.ToString
                isRiv = player2.getRivarly(player1.WinsAgainst1)
                pvpTheme.SetVisiblityTxtBox(New TextBox() {txtWinsagainst, txtWinsAgainst2, txtTotalAgainst}, True)
            Else
                pvpTheme.SetVisiblityTxtBox(New TextBox() {txtWinsagainst, txtWinsAgainst2, txtTotalAgainst}, False)
            End If
            If isRiv Then
                lblError.Text = "Rivarly"
                pvpTheme.SetErrorLabel(lblError)
            End If
        End If
    End Sub

    ''' <summary>
    ''' Search for a record for ID1 and ID2, get those datasets
    ''' Try to get the ID from those sets
    ''' Try to parse from those, or if none then return -1
    ''' </summary>
    Public Sub SetPVPSets()
        pvpSet1 = player1.SearchPvPStats(player2.PID)
        pvpID = GetPvPID(pvpSet1)
        If pvpID > -1 Then
            Integer.TryParse(pvpSet1.Tables(0).Rows(0).Item("Wins"), player1.WinsAgainst1)
        End If
        pvpSet2 = player2.SearchPvPStats(player1.PID)
        pvpID2 = GetPvPID(pvpSet2)
        If pvpID2 > -1 Then
            Integer.TryParse(pvpSet2.Tables(0).Rows(0).Item("Wins"), player2.WinsAgainst1)
        End If
    End Sub

    Private Sub FillByToolStripButton_Click_1(sender As Object, e As EventArgs)
        Try
            Me.PlayersTableAdapter1.FillBy(Me.LocalResultsDataSet1.Players)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

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
            Return pvpID
        End Try
        Return pvpID
    End Function

    ''' <summary>
    ''' Go to state, and increment from the obj to add new value
    ''' Repopulate stats, set pvp set. If we have them, parse this against prop then check rivarly and enable controls.
    ''' Insert new record on -1 PvPID or update the existing one
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnPlayer1win_Click(sender As Object, e As EventArgs) Handles btnPlayer1win.Click
        pvpTheme.Screen = ScoreTheme.AppState.Winner
        Dim gameResults As String = String.Empty
#Region "Beta sql"
        'With SqlConnection
        '    .ConnectionString = connectionString
        '    .Open()
        'End With

        'playerStats1.Wins1 += 1
        'adapter = New SqlDataAdapter("exec dbo.[insWins_v1.1] @newPlayer = '" & playerStats1.PlayerName1 & "',@wins = " & playerStats1.Wins1, sqlConnection)
        'adapter.Fill(ds)

        'Try
        '    adapter = New SqlDataAdapter("select wins from Players where playerName in ('" & cbPlayer1.SelectedItem & "')", sqlConnection)
        '    adapter.Fill(ds)
        '    txtWins.Text = ds.Tables(0).Rows(0).Item(0).ToString
        'Catch ex As Exception
        '    SqlConnection.Close()
        '    lblError.Text = "Game not saved"
        '    lblError.Visible = True
        'Finally
        '    btnPlayer1win.Visible = False
        '    btnPlayer2Wins.Visible = False
        '    btnReg.Visible = True
        '    btnSave.Visible = True
        '    sqlConnection.Close()
        'End Try
#End Region
        gameResults = player1.InsertGame("")
        If (gameResults).Contains("Error") Then
            lblError.Text = gameResults
        Else
            txtWins.Text = gameResults
        End If
        allWins = player1.GetAllResults("exec selAllWins @output=0")
        GetHighScores()
        SetPVPSets()
        If pvpSet1.Tables(0).Rows.Count > 0 Then
            Integer.TryParse(pvpSet1.Tables(0).Rows(0).Item("Wins"), player1.WinsAgainst1)
            totalGamesPvP = player1.WinsAgainst1 + player2.WinsAgainst1
            txtWinsagainst.Text = player1.WinsAgainst1.ToString
            txtWinsAgainst2.Text = player2.WinsAgainst1.ToString
            txtTotalAgainst.Text = totalGamesPvP.ToString
            isRiv = player1.getRivarly(player2.WinsAgainst1)
            pvpTheme.SetVisiblityTxtBox(New TextBox() {txtWinsagainst, txtWinsAgainst2, txtTotalAgainst}, True)
        End If
        player1.WinsAgainst1 += 1
        txtWinsagainst.Text = player1.WinsAgainst1
        lblError.Text = player1.InsertPvPStats(player2.PID, pvpID)
        totalGamesPvP = player1.WinsAgainst1 + player2.WinsAgainst1
        txtTotalAgainst.Text = totalGamesPvP.ToString
        pvpTheme.SetErrorLabel(lblError)
        pvpTheme.SetVisibiltyButton(New Button() {btnReg, btnSave}, True)
        pvpTheme.SetVisibiltyButton(New Button() {btnPlayer1win, btnPlayer2Wins}, False)
        pvpTheme.SetVisiblityTxtBox(New TextBox() {txtWinsagainst, txtWinsAgainst2, txtTotalAgainst}, True)
        'btnPlayer1win.Visible = False
        'btnPlayer2Wins.Visible = False
        'btnReg.Visible = True
        'btnSave.Visible = True
    End Sub

    ''' <summary>
    ''' Go to state, and increment from the obj to add new value
    ''' Repopulate stats, set pvp set. If we have them, parse this against prop then check rivarly and enable controls.
    ''' Insert new record on -1 PvPID or update the existing one
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnPlayer2Wins_Click(sender As Object, e As EventArgs) Handles btnPlayer2Wins.Click
        pvpTheme.Screen = ScoreTheme.AppState.Winner
        Dim gameResults As String = String.Empty
#Region "beta sql"
        'With sqlConnection
        '    .ConnectionString = connectionString
        '    .Open()
        'End With

        'playerStats2.Wins1 += 1
        'adapter = New SqlDataAdapter("exec dbo.[insWins_v1.1] @newPlayer = '" & playerStats2.PlayerName1 & "',@wins = " & playerStats2.Wins1, sqlConnection)
        'adapter.Fill(ds)

        'Try
        '    adapter = New SqlDataAdapter("select wins from Players where playerName in ('" & cbPlayer2.SelectedItem.ToString & "')", sqlConnection)
        '    adapter.Fill(ds)

        '    txtWins2.Text = ds.Tables(0).Rows(0).Item(0).ToString
        'Catch ex As Exception
        '    sqlConnection.Close()
        '    lblError.Text = "Game not saved"
        '    lblError.Visible = True
        'Finally
        '    btnPlayer1win.Visible = False
        '    btnPlayer2Wins.Visible = False
        '    btnReg.Visible = True
        '    btnSave.Visible = True
        '    sqlConnection.Close()
        'End Try
#End Region
        gameResults = player2.InsertGame("")
        If (gameResults).Contains("Error") Then
            lblError.Text = gameResults
        Else
            txtWins2.Text = gameResults
        End If
        allWins = player1.GetAllResults("exec selAllWins @output=0")
        GetHighScores()
        SetPVPSets()
        If pvpSet2.Tables(0).Rows.Count > 0 Then
            Integer.TryParse(pvpSet2.Tables(0).Rows(0).Item("Wins"), player2.WinsAgainst1)
            totalGamesPvP = player1.WinsAgainst1 + player2.WinsAgainst1
            txtWinsagainst.Text = player1.WinsAgainst1.ToString
            txtWinsAgainst2.Text = player2.WinsAgainst1.ToString
            txtTotalAgainst.Text = totalGamesPvP.ToString
            isRiv = player2.getRivarly(player1.WinsAgainst1)
            pvpTheme.SetVisiblityTxtBox(New TextBox() {txtWinsagainst, txtWinsAgainst2, txtTotalAgainst}, True)
        End If
        player2.WinsAgainst1 += 1
        txtWinsAgainst2.Text = player2.WinsAgainst1
        lblError.Text = player2.InsertPvPStats(player1.PID, pvpID2)
        totalGamesPvP = player1.WinsAgainst1 + player2.WinsAgainst1
        txtTotalAgainst.Text = totalGamesPvP.ToString
        pvpTheme.SetErrorLabel(lblError)
        pvpTheme.SetVisibiltyButton(New Button() {btnReg, btnSave}, True)
        pvpTheme.SetVisibiltyButton(New Button() {btnPlayer1win, btnPlayer2Wins}, False)
        pvpTheme.SetVisiblityTxtBox(New TextBox() {txtWinsagainst, txtWinsAgainst2, txtTotalAgainst}, True)
        'btnPlayer1win.Visible = False
        'btnPlayer2Wins.Visible = False
        'btnReg.Visible = True
        'btnSave.Visible = True
        btnBack.Text = "Back"
    End Sub

    Private Sub btnHighScore_Click(sender As Object, e As EventArgs) Handles btnHighScore.Click
        Dim myForm As New HighScores
        Me.Hide()
        myForm.Show()
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'If test.Screen = ScoreTheme.AppState.Switch Then
        '    Application.Restart()
        '    test.Screen = ScoreTheme.AppState.Start
        'Else
        '    Application.Exit()
        'End If
        Home.Show()
        HighScores.Close()
        Me.Close()
    End Sub

    ''' <summary>
    ''' If we're in this state, try to parse key from hashtable to object
    ''' If we have a number in the obj and they confirm, then remove and repopulate
    ''' Do nothing on blank text in this state, if out of the state go to prev.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If pvpTheme.Screen.Equals(ScoreTheme.AppState.Delete) Then
            'grab player obj from cbox
            Try
                deletedPlayer.PlayerName1 = cbDelete.SelectedItem.ToString
                Integer.TryParse((From row As DictionaryEntry In allplayers
                                  Where row.Value Like deletedPlayer.PlayerName1 Select row.Key).ToArray.First, deletedPlayer.PID)
            Catch ex As Exception
                lblError.Text = "Error: Select a player to Delete!!!!!!"
                pvpTheme.SetErrorLabel(lblError)
                Exit Sub
            End Try

            Dim deleteSQL As String = $"exec [delPlayer] @playerID = {deletedPlayer.PID}, @result=0"

            If Not String.IsNullOrEmpty(deletedPlayer.PID) Then
                Dim deletionAlert As DialogResult = MessageBox.Show($"Are you sure you want to erase {player1.PlayerName1}?",
    "Erase Player", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                'are you sure??????????
                If deletionAlert.Equals(DialogResult.Yes) Then
                    player1.GetAllResults(deleteSQL)
                    allWins = player1.GetAllResults("exec selAllWins @output=0")
                    GetHighScores()
                    allplayers = deletedPlayer.IDBConnect_GetAllPlayers()
                    pvpTheme.FillBoxfromHT(cbPlayer1, allplayers)
                    pvpTheme.FillBoxfromHT(cbPlayer2, allplayers)
                    pvpTheme.FillBoxfromHT(cbDelete, allplayers)
                    cbDelete.Visible = False
                    cbDelete.SelectedItem = Nothing
                    pvpTheme.Screen = ScoreTheme.AppState.Register
                    lblError.Text = $"{deletedPlayer.PlayerName1} is gone"
                    lblError.Visible = True
                    cbDelete.SelectedItem = Nothing
                    btnEdit.Visible = True
                    btnReg.Text = "Register"
                Else
                    pvpTheme.Screen = ScoreTheme.AppState.Delete
                    btnEdit.Visible = False
                End If
            End If
        Else
            btnReg.Text = "Back"
            pvpTheme.Screen = ScoreTheme.AppState.Delete
            cbDelete.SelectedItem = Nothing
            cbDelete.Visible = True
        End If
    End Sub

    ''' <summary>
    ''' Set object from selected item and enable controls
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cbDelete_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDelete.SelectedIndexChanged
        editPlayer = New PlayerStats
        editPlayer.PlayerName1 = cbDelete.SelectedItem.ToString
        pvpTheme.SetVisibiltyButton(New Button() {btnEdit, btnDelete}, True)
    End Sub

    ''' <summary>
    ''' Editing names, if we're in that state, try to parse this key into the ID
    ''' If we have text, display dialog box to confirm, then add and repopulate the controls
    ''' If empty do nothing, if not inthis state then go to prev.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If pvpTheme.Screen = ScoreTheme.AppState.edit Then
            Dim newName As String = tbEdit.Text
            'grab player obj from cbox
            Try
                Integer.TryParse((From row As DictionaryEntry In allplayers
                                  Where row.Value Like editPlayer.PlayerName1 Select row.Key).ToArray.First, editPlayer.PID)
            Catch ex As Exception
                lblError.Text = "Error: Select a player to Change"
                pvpTheme.SetErrorLabel(lblError)
                Exit Sub
            End Try

            Dim editSQL As String = $"exec [insNewPlayer_v1.2] @pID = {editPlayer.PID}, @newPlayer='{newName}',@result=0"
            If Not String.IsNullOrEmpty(editPlayer.PID) Then
                Dim editAlert As DialogResult = MessageBox.Show($"Are you sure you want to change {editPlayer.PlayerName1} to {newName}?",
    "Erase Player", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                'are you sure??????????
                If editAlert.Equals(DialogResult.Yes) Then
                    player1.GetAllResults(editSQL)
                    allWins = player1.GetAllResults("exec selAllWins @output=0")
                    GetHighScores()
                    allplayers = editPlayer.IDBConnect_GetAllPlayers()
                    pvpTheme.FillBoxfromHT(cbPlayer1, allplayers)
                    pvpTheme.FillBoxfromHT(cbPlayer2, allplayers)
                    pvpTheme.FillBoxfromHT(cbDelete, allplayers)
                    tbEdit.ResetText()
                    cbDelete.Visible = False
                    cbDelete.SelectedItem = Nothing
                    pvpTheme.Screen = ScoreTheme.AppState.Register
                    lblError.Text = $"{editPlayer.PlayerName1} is now {newName}"
                    lblError.Visible = True
                    btnReg.Text = "Register"
                    btnDelete.Visible = True
                    cbDelete.SelectedItem = Nothing
                Else
                    btnDelete.Visible = False
                    pvpTheme.Screen = ScoreTheme.AppState.edit
                End If
            End If
        Else
            btnReg.Text = "Back"
            cbDelete.SelectedItem = Nothing
            cbDelete.Visible = True
            tbEdit.Visible = True
            btnDelete.Visible = False
            pvpTheme.Screen = ScoreTheme.AppState.edit
        End If
    End Sub
End Class
