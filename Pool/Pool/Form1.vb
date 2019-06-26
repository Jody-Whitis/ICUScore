Imports System.Data.SqlClient
Imports System.IO

Public Class Form1

    Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jwhitis\source\repos\Pool\Pool\LocalResults.mdf;Integrated Security=True"
    Dim player1Set As Boolean = False
    Dim player2Set As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LocalResultsDataSet1.Players' table. You can move, or remove it, as needed.
        Me.PlayersTableAdapter1.Fill(Me.LocalResultsDataSet1.Players)
        'TODO: This line of code loads data into the 'PlayerNames.Players' table. You can move, or remove it, as needed.
        Me.PlayersTableAdapter.Fill(Me.PlayerNames.Players)
        Dim player1 As New PlayerStats
        Dim player2 As New PlayerStats
        Dim lstPlayers As New List(Of PlayerStats)
        Dim results As String = String.Empty

        lblError.Visible = False
        groupWinner.Visible = False
        player1.PlayerName1 = tbPlayer1.ToString
        player2.PlayerName1 = tbPlayer2.ToString


        With lstPlayers
            .Add(player1)
            .Add(player2)
        End With




    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim player1 As String = String.Empty
        Dim wins As Integer = 0
        Dim command As String = "exec [dbo].[selPlayers_v1.1]"
        Dim adapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim dbCommand As New SqlCommand
        Dim sqlConnection As New SqlConnection

        tbPlayer1.Visible = False
        tbPlayer2.Visible = False
        lblError.Visible = False

        'If Not String.IsNullOrEmpty(tbPlayer1.Text) And Not String.IsNullOrEmpty(tbPlayer2.Text) Then

        '    With sqlConnection
        '        .ConnectionString = connectionString
        '        .Open()
        '    End With

        If Not String.IsNullOrEmpty(cbPlayer1.SelectedValue.ToString) And Not String.IsNullOrEmpty(cbPlayer2.SelectedValue.ToString) Then
            With sqlConnection
                .ConnectionString = connectionString
                .Open()
            End With
        End If

        adapter = New SqlDataAdapter("select wins from Players where playerName in ('" & cbPlayer1.SelectedValue.ToString & "','" & cbPlayer2.SelectedValue.ToString & "')", sqlConnection)
        adapter.Fill(ds)


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



        ' End If





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



        If Not String.IsNullOrEmpty(tbPlayer1.Text) And Not String.IsNullOrEmpty(tbPlayer2.Text) Then

            With sqlConnection
                .ConnectionString = connectionString
                .Open()
            End With

            cbPlayer1.BeginUpdate()
            cbPlayer2.BeginUpdate()
            With dbCommand
                .Connection = sqlConnection
                .CommandText = command
                .ExecuteNonQuery()

            End With
            cbPlayer1.EndUpdate()
            cbPlayer2.EndUpdate()

            Try

                'If ds.Tables(0).Rows(0).Item("player1win") / ds.Tables(0).Rows(0).Item("player2win") * 100 >= 50 Or ds.Tables(0).Rows(0).Item("player2win") / ds.Tables(0).Rows(0).Item("player1win") * 100 >= 50 Then
                '    lblError.Text = "RIVALARY!!!"
                '    lblError.Visible = True

                'End If


            Catch ex As Exception
                sqlConnection.Close()
                lblError.Text = "Name not found"
                lblError.Visible = True
            Finally
                sqlConnection.Close()

            End Try


            lblError.Text = "New Players Added"
            lblError.Visible = True
            tbPlayer1.ResetText()
            tbPlayer2.ResetText()
            cbPlayer1.Visible = True
            cbPlayer2.Visible = True

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

        Else

            tbPlayer1.Visible = True
                tbPlayer2.Visible = True

            cbPlayer1.Visible = False
            cbPlayer2.Visible = False
        End If


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
        player1Set = True
    End Sub

    Private Sub FillByToolStripButton_Click_1(sender As Object, e As EventArgs)
        Try
            Me.PlayersTableAdapter1.FillBy(Me.LocalResultsDataSet1.Players)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub cbPlayer2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPlayer2.SelectedIndexChanged
        player2Set = True
    End Sub
End Class
