Imports System.Data.SqlClient
Imports System.IO

Public Class Form1

    Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jwhitis\source\repos\Pool\Pool\LocalResults.mdf;Integrated Security=True"
    Dim player1Set As Boolean = False
    Dim player2Set As Boolean = False
    Dim playerStats1 As New PlayerStats
    Dim playerStats2 As New PlayerStats
    Dim screen As New AppState
    Public Enum AppState
        Start = 0
        Register = 1
        SelectPlayer = 2
        Winner = 3
        Switch = 4
    End Enum


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LocalResultsDataSet1.Players' table. You can move, or remove it, as needed.
        Me.PlayersTableAdapter1.Fill(Me.LocalResultsDataSet1.Players)
        'TODO: This line of code loads data into the 'PlayerNames.Players' table. You can move, or remove it, as needed.
        Me.PlayersTableAdapter.Fill(Me.PlayerNames.Players)

        Dim lstPlayers As New List(Of PlayerStats)
        Dim results As String = String.Empty

        lblError.Visible = False
        groupWinner.Visible = False

        With lstPlayers
            .Add(playerStats1)
            .Add(playerStats2)
        End With

        screen = AppState.Start

    End Sub

    Private Function getRivarly(ByVal wins As Integer, ByVal wins2 As Integer) As Boolean
        Dim totalGames As Integer = wins + wins2

        If wins / totalGames * 100 > 45 Or wins2 / totalGames * 100 > 45 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim player1 As String = String.Empty
        Dim wins As Integer = 0
        Dim command As String = "exec [dbo].[selPlayers_v1.1]"
        Dim adapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim dbCommand As New SqlCommand
        Dim sqlConnection As New SqlConnection
        Dim isRivarly As Boolean = False
        tbPlayer1.Visible = False
        tbPlayer2.Visible = False
        lblError.Visible = False
        txtWins.Visible = True
        txtWins2.Visible = True

        If Not String.IsNullOrEmpty(cbPlayer1.SelectedValue.ToString) And Not String.IsNullOrEmpty(cbPlayer2.SelectedValue.ToString) Then

#Region "if wins are not empty then add new game, else display wins"
            If Not String.IsNullOrEmpty(txtWins.Text) AndAlso Not String.IsNullOrEmpty(txtWins2.Text) Then

                If screen = 4 Then
                    With sqlConnection
                        .ConnectionString = connectionString
                        .Open()
                    End With

                    adapter = New SqlDataAdapter("Select wins from Players where playerName In ('" & cbPlayer1.SelectedValue.ToString & "','" & cbPlayer2.SelectedValue.ToString & "')", sqlConnection)
                    adapter.Fill(ds)

                    'save new wins if null txtbox wins, else then insert new game results.
                    Try
                        txtWins.Text = ds.Tables(0).Rows(0).Item(0).ToString
                        txtWins2.Text = ds.Tables(0).Rows(1).Item(0).ToString
                    Catch ex As Exception
                        sqlConnection.Close()
                        lblError.Text = "Name not found"
                        lblError.Visible = True
                    Finally
                        sqlConnection.Close()

                    End Try


                Else
                    With playerStats1
                        .PlayerName1 = cbPlayer1.SelectedValue.ToString
                        .Wins1 = txtWins.Text
                    End With

                    With playerStats2
                        .PlayerName1 = cbPlayer2.SelectedValue.ToString
                        .Wins1 = txtWins2.Text
                    End With
                    btnPlayer1win.Text = playerStats1.PlayerName1 & "  WINS! "
                    btnPlayer2Wins.Text = playerStats2.PlayerName1 & "  WINS!"
                    btnPlayer1win.Visible = True
                    btnPlayer2Wins.Visible = True
                    btnReg.Visible = False
                    btnSave.Visible = False
                    screen = 4
                End If



            Else 'we'll open current wins
                With sqlConnection
                    .ConnectionString = connectionString
                    .Open()
                End With

                adapter = New SqlDataAdapter("Select wins from Players where playerName In ('" & cbPlayer1.SelectedValue.ToString & "','" & cbPlayer2.SelectedValue.ToString & "')", sqlConnection)
                adapter.Fill(ds)

                'save new wins if null txtbox wins, else then insert new game results.
                Try
                    txtWins.Text = ds.Tables(0).Rows(0).Item(0).ToString
                    txtWins2.Text = ds.Tables(0).Rows(1).Item(0).ToString
                Catch ex As Exception
                    sqlConnection.Close()
                    lblError.Text = "Name not found"
                    lblError.Visible = True
                Finally
                    sqlConnection.Close()

                End Try




#Region "future rivlary game title"
                'isRivarly = getRivarly(playerStats1.Wins1, playerStats2.Wins1)

                'If isRivarly Then
                '    lblError.Text = "RIVARLY GAME!"
                '    lblError.ForeColor = Color.LightGreen
                'End If
#End Region
            End If

#End Region

        End If

    End Sub


    Private Sub cbPlayer1Win_CheckedChanged(sender As Object, e As EventArgs) Handles cbPlayer1Win.CheckedChanged

    End Sub

    Private Sub btnReg_Click(sender As Object, e As EventArgs) Handles btnReg.Click
        Dim player1 As String = String.Empty
        Dim wins As Integer = 0
        Dim command As String = "exec insNewPlayer @newPlayer='" & tbPlayer1.Text & "'exec insNewPlayer @newPlayer='" & tbPlayer2.Text & "'"
        Dim dbCommand As New SqlCommand
        Dim sqlConnection As New SqlConnection

        tbPlayer1.Visible = True
        tbPlayer2.Visible = True
        txtWins.Visible = False
        txtWins2.Visible = False

        'If players have names, then update cbox and add them to db
        If Not String.IsNullOrEmpty(tbPlayer1.Text) And Not String.IsNullOrEmpty(tbPlayer2.Text) Then
            screen = AppState.Register

            With sqlConnection
                .ConnectionString = connectionString
                .Open()
            End With

            cbPlayer1.BeginUpdate()
            cbPlayer2.BeginUpdate()
            Try
                With dbCommand
                    .Connection = sqlConnection
                    .CommandText = command
                    .ExecuteNonQuery()

                End With

            Catch ex As Exception
                sqlConnection.Close()
                lblError.Text = "Name not found"
                lblError.Visible = True
            Finally
                sqlConnection.Close()
            End Try

            cbPlayer1.EndUpdate()
            cbPlayer2.EndUpdate()



            lblError.Text = "New Players Added"
            lblError.Visible = True
            tbPlayer1.ResetText()
            tbPlayer2.ResetText()
            tbPlayer1.Visible = False
            tbPlayer2.Visible = False
            cbPlayer1.Visible = True
            cbPlayer2.Visible = True
            btnSave.Visible = True
            cbPlayer1.ResetText()
            cbPlayer2.ResetText()
            cbPlayer1.Refresh()
            cbPlayer2.Refresh()
#Region "logic for future rivalry stats"
            'With sqlConnection
            '    .ConnectionString = connectionString
            '    .Open()
            'End With




            'adapter = New SqlDataAdapter("select player1win,player2win,player1name,player2name from games where player1name like '" & tbPlayer1.Text & "'" & "and player2name like '" & tbPlayer2.Text & "'", sqlConnection)
            'adapter.Fill(ds)


            'Try

            '    If ds.Tables(0).Rows(0).Item("player1win") / ds.Tables(0).Rows(0).Item("player2win") * 100 >= 50 Or ds.Tables(0).Rows(0).Item("player2win") / ds.Tables(0).Rows(0).Item("player1win") * 100 >= 50 Then
            '        lblError.Text = "RIVALARY!!!"
            '        lblError.Visible = True

            '    End If
            'Catch ex As Exception
            '    sqlConnection.Close()
            '    lblError.Text = "Name not found"
            '    lblError.Visible = True
            'Finally
            '    sqlConnection.Close()

            'End Try

            'if no players, then turn on tboxes to added them
#End Region

        Else
            If screen = 1 Then
                lblError.Text = "Back"
                lblError.Visible = True
                tbPlayer1.ResetText()
                tbPlayer2.ResetText()
                tbPlayer1.Visible = False
                tbPlayer2.Visible = False
                cbPlayer1.Visible = True
                cbPlayer2.Visible = True
                btnSave.Visible = True
                cbPlayer1.ResetText()
                cbPlayer2.ResetText()
                cbPlayer1.Refresh()
                cbPlayer2.Refresh()
                screen = AppState.Switch
            Else
                tbPlayer1.Visible = True
                tbPlayer2.Visible = True
                cbPlayer1.Visible = False
                cbPlayer2.Visible = False
                btnSave.Visible = False
                screen = AppState.Register
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

    Private Sub cbPlayer1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPlayer1.SelectedIndexChanged
        Dim player1 As String = String.Empty
        Dim wins As Integer = 0
        Dim command As String = "exec [dbo].[selPlayers_v1.1]"
        Dim adapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim dbCommand As New SqlCommand
        Dim sqlConnection As New SqlConnection
        Dim isRivarly As Boolean = False
        tbPlayer1.Visible = False
        tbPlayer2.Visible = False
        lblError.Visible = False
        txtWins.Visible = True
        txtWins2.Visible = True

        With SqlConnection
            .ConnectionString = connectionString
            .Open()
        End With



        'save new wins if null txtbox wins, else then insert new game results.
        Try
            adapter = New SqlDataAdapter("Select wins from Players where playerName In ('" & cbPlayer1.SelectedValue.ToString & "')", sqlConnection)
            adapter.Fill(ds)
            txtWins.Text = ds.Tables(0).Rows(0).Item(0).ToString
        Catch ex As Exception
            sqlConnection.Close()
            lblError.Text = "Name not found"
            lblError.Visible = True
        Finally
            sqlConnection.Close()

        End Try


    End Sub

    Private Sub cbPlayer2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPlayer2.SelectedIndexChanged
        Dim player1 As String = String.Empty
        Dim wins As Integer = 0
        Dim command As String = "exec [dbo].[selPlayers_v1.1]"
        Dim adapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim dbCommand As New SqlCommand
        Dim sqlConnection As New SqlConnection
        Dim isRivarly As Boolean = False
        tbPlayer1.Visible = False
        tbPlayer2.Visible = False
        lblError.Visible = False
        txtWins.Visible = True
        txtWins2.Visible = True

        With SqlConnection
            .ConnectionString = connectionString
            .Open()
        End With



        'save new wins if null txtbox wins, else then insert new game results.
        Try
            adapter = New SqlDataAdapter("Select wins from Players where playerName In ('" & cbPlayer2.SelectedValue.ToString & "')", sqlConnection)
            adapter.Fill(ds)
            txtWins2.Text = ds.Tables(0).Rows(0).Item(0).ToString
        Catch ex As Exception
            sqlConnection.Close()
            lblError.Text = "Name not found"
            lblError.Visible = True
        Finally
            sqlConnection.Close()

        End Try


    End Sub

    Private Sub FillByToolStripButton_Click_1(sender As Object, e As EventArgs)
        Try
            Me.PlayersTableAdapter1.FillBy(Me.LocalResultsDataSet1.Players)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnPlayer1win_Click(sender As Object, e As EventArgs) Handles btnPlayer1win.Click
        Dim adapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim dbCommand As New SqlCommand
        Dim sqlConnection As New SqlConnection
        screen = AppState.Winner

        With SqlConnection
            .ConnectionString = connectionString
            .Open()
        End With

        playerStats1.Wins1 += 1
        adapter = New SqlDataAdapter("exec dbo.[insWins_v1.1] @newPlayer = '" & playerStats1.PlayerName1 & "',@wins = " & playerStats1.Wins1, sqlConnection)
        adapter.Fill(ds)

        Try
            adapter = New SqlDataAdapter("select wins from Players where playerName in ('" & cbPlayer1.SelectedValue.ToString & "')", sqlConnection)
            adapter.Fill(ds)
            txtWins.Text = ds.Tables(0).Rows(0).Item(0).ToString
        Catch ex As Exception
            SqlConnection.Close()
            lblError.Text = "Game not saved"
            lblError.Visible = True
        Finally
            btnPlayer1win.Visible = False
            btnPlayer2Wins.Visible = False
            btnReg.Visible = True
            btnSave.Visible = True
            sqlConnection.Close()
        End Try

    End Sub

    Private Sub btnPlayer2Wins_Click(sender As Object, e As EventArgs) Handles btnPlayer2Wins.Click
        Dim adapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim dbCommand As New SqlCommand
        Dim sqlConnection As New SqlConnection
        screen = AppState.Winner


        With sqlConnection
            .ConnectionString = connectionString
            .Open()
        End With

        playerStats2.Wins1 += 1
        adapter = New SqlDataAdapter("exec dbo.[insWins_v1.1] @newPlayer = '" & playerStats2.PlayerName1 & "',@wins = " & playerStats2.Wins1, sqlConnection)
        adapter.Fill(ds)

        Try
            adapter = New SqlDataAdapter("select wins from Players where playerName in ('" & cbPlayer2.SelectedValue.ToString & "')", sqlConnection)
            adapter.Fill(ds)

            txtWins2.Text = ds.Tables(0).Rows(0).Item(0).ToString
        Catch ex As Exception
            sqlConnection.Close()
            lblError.Text = "Game not saved"
            lblError.Visible = True
        Finally
            btnPlayer1win.Visible = False
            btnPlayer2Wins.Visible = False
            btnReg.Visible = True
            btnSave.Visible = True
            sqlConnection.Close()
        End Try
    End Sub
End Class
