Imports System.Text
Imports System.Linq
Public Class HighScores
    Dim test As New ScoreTheme(Me)
    Dim player As New PlayerStats
    Dim games As New Games
    'Dim screen As New AppState
    'Public Enum AppState
    '    NoPlayerEx = -1
    '    Start = 0
    '    Register = 1
    '    SelectPlayer = 2
    '    Winner = 3
    '    Switch = 4
    '    Add = 5
    'End Enum
    Dim allPlayers As New Hashtable
    Dim allGames As New Hashtable
    Dim highScores As New DataSet
    Dim addLoc As New Point
    Dim saveLoc As New Point
    Dim saveDim As New Drawing.Size
    Dim addDim As New Drawing.Size
    Private Sub HighScores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstScores.Visible = False
        test.Screen = ScoreTheme.AppState.Start
        allPlayers = player.IDBConnect_GetAllPlayers()
        test.FillCBoxAll(allPlayers, cbPlayers, lblError)
        allGames = games.GetAllPlayers()
        test.FillCBoxAll(allGames, cbGames, lblError)
        highScores = games.GetAllResults("exec selAllScores @output=0")

        lblError.Visible = False
        If test.Screen = -1 Then
            lblError.Visible = True
        Else
            test.Screen = ScoreTheme.AppState.SelectPlayer
        End If
        addLoc = btnAdd.Location
        saveLoc = btnSubmit.Location
        saveDim = btnSubmit.Size
        addDim = btnAdd.Size
    End Sub

    'Private Sub GetAll(allList As Hashtable, ByRef cBox As ComboBox)
    '    cBox.Items.Clear()
    '    For Each name As DictionaryEntry In allList
    '        If test.Screen = 0 AndAlso name.Value.ToString.Contains("Error") Then
    '            test.Screen = -1
    '            lblError.Text = "Error getting all players"
    '            Exit For
    '        Else
    '            cBox.Items.Add(name.Value)
    '            test.Screen = Test.AppState.SelectPlayer
    '        End If
    '    Next
    'End Sub
    'Private Function GetKey(values As String, col As Hashtable) As Integer
    '    For Each items As DictionaryEntry In col
    '        If items.Value.Equals(values) Then
    '            Return items.Key
    '        End If
    '    Next
    '    Return -1
    'End Function
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        lblError.Visible = False
        Dim score As Integer = -1
        If test.Screen > 0 Then
            'got a player
            If Not String.IsNullOrEmpty(cbPlayers.SelectedItem.ToString) Then
                'got a new score
                If Not String.IsNullOrEmpty(txtScore.Text) Then
                    If Integer.TryParse(txtScore.Text.Trim, score) Then
                        test.Screen = ScoreTheme.AppState.Winner
                        With player
                            .PlayerName1 = cbPlayers.SelectedItem.ToString
                            .Wins1 = score
                            .PID = test.GetKey(.PlayerName1, allPlayers)
                        End With
                        With games
                            .GameMode = cbGames.SelectedItem.ToString
                            .Score = txtScore.Text
                            .GameID = test.GetKey(.GameMode, allGames)
                        End With

                        'Search for game to update
                        Dim searchGames = $"exec [dbo].[selScores_v1.1] @playerId={player.PID},@gameID = {games.GameID},@results=0"
                        Dim foundScoreResult = games.GetGames(searchGames)
                        'Update a score or add a new one

                        'If foundScoreResult.Count > 0 AndAlso Not foundScoreResult.First Is Nothing Then
                        '    player.IsFound = 1
                        'Else
                        '    player.IsFound = 0
                        'End If
                        Try
                            If foundScoreResult.Tables(0).Rows.Count > 0 Then
                                player.IsFound = 1
                            Else
                                player.IsFound = 0
                            End If
                        Catch ex As Exception
                            player.IsFound = 0
                        End Try

                        Dim sqlString = $"exec [dbo].[insScore_v1.1] @pid={player.PID},@score={games.Score},@gID={games.GameID},@result={player.IsFound}"
                        lblError.Text = games.InsertGame(sqlString)
                        test.SetErrorLabel(lblError)
                        highScores.Clear()
                        highScores = games.GetAllResults("exec selAllScores @output=0")
                        GetHighScores(games.GameMode)
                        Refresh()
                    Else
                        lblError.Text = "Error: nan"
                        test.SetErrorLabel(lblError)
                    End If

                Else
                    test.Screen = ScoreTheme.AppState.SelectPlayer
                    Try
                        txtScore.Text = String.Empty
                    Catch ex As Exception
                        lblError.Text = "error"
                    End Try
                    test.SetErrorLabel(lblError)
                End If
            End If
        Else
            lblError.Text = "Error"
            test.SetErrorLabel(lblError)
            test.Screen = 1
        End If

    End Sub
    'Protected Sub SetError(ByRef errorText As Label)
    '    If errorText.Text.Contains("Error") Then
    '        errorText.ForeColor = Color.Red
    '        errorText.Visible = True
    '    Else
    '        errorText.Visible = False
    '    End If
    'End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        PvP.Show()
        Me.Hide()
    End Sub

    Private Sub cbPlayers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPlayers.SelectedIndexChanged
        If test.Screen = ScoreTheme.AppState.SelectPlayer Then
            player.PlayerName1 = cbPlayers.SelectedItem
            test.SetErrorLabel(lblError)
        End If
    End Sub

    Private Sub GetHighScores(ByVal gameMode As String)
        If highScores.Tables(0).Rows.Count > 0 Then
            lstScores.Items.Clear()
            Try
                Dim scores = (From r In highScores.Tables(0).AsEnumerable Where r.Item("gameMode").Equals(gameMode)
                              Select r
                                  )
                For Each score In scores
                    Dim playerNameScore As String = score.Item("playerName")
                    Dim playerScore As String = score.Item("highScore")
                    lstScores.Items.Add(playerNameScore & "".PadRight(10) & ":" & " ".PadRight(5) & playerScore)
                Next
                lstScores.BackColor = Color.Aquamarine
                lstScores.Visible = True
                lstScores.Refresh()
            Catch ex As Exception
                Debug.WriteLine(ex.ToString)
                lblError.Text = ex.Message.ToString
                test.SetErrorLabel(lblError)
            End Try
        End If
    End Sub

    Private Sub cbGames_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbGames.SelectedIndexChanged
        games.GameMode = cbGames.SelectedItem
        GetHighScores(games.GameMode)
        test.SetErrorLabel(lblError)
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If test.Screen <> ScoreTheme.AppState.Add Then
            test.Screen = ScoreTheme.AppState.Add
            cbGames.Visible = False
            cbPlayers.Visible = False
            txtScore.Visible = False
            lstScores.Visible = False
            txtNewGM.Visible = True
            btnSubmit.Visible = False
            btnBack.Visible = False
            btnAdd.Location = saveLoc
            btnAdd.Size = saveDim
        ElseIf test.Screen = ScoreTheme.AppState.Add Then
            If Not String.IsNullOrEmpty(txtNewGM.Text) Then
                Dim newGM As String = $"[dbo].[insNewGame] @gameMode = '{txtNewGM.Text}'"
                games.InsertGame(newGM)
                allGames = games.GetAllPlayers()
                test.FillCBoxAll(allGames, cbGames, lblError)
                highScores = games.GetAllResults("exec selAllScores @output=0")
                txtNewGM.ResetText()
                txtNewGM.Visible = False
                lstScores.Visible = True
                cbGames.Visible = True
                cbPlayers.Visible = True
                txtScore.Visible = True
                btnSubmit.Visible = True
                btnBack.Visible = True
                btnAdd.Location = addLoc
                btnAdd.Size = addDim
                test.Screen = ScoreTheme.AppState.SelectPlayer
            End If
        End If
    End Sub
End Class