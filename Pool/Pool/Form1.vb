Imports System.Data.SqlClient
Imports System.IO

Public Class Form1

    Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jwhitis\source\repos\Pool\Pool\LocalResults.mdf;Integrated Security=True"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim player1 As New PlayerStats
        Dim player2 As New PlayerStats
        Dim lstPlayers As New List(Of PlayerStats)
        Dim results As String = String.Empty

        lblError.Visible = False

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

        If Not String.IsNullOrEmpty(tbPlayer1.Text) And Not String.IsNullOrEmpty(tbPlayer2.Text) Then

            With sqlConnection
                .ConnectionString = connectionString
                .Open()
            End With

            adapter = New SqlDataAdapter("select wins from Players where playerName in ('" & tbPlayer1.Text & "','" & tbPlayer2.Text & "')", sqlConnection)
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



        End If





    End Sub




    Private Sub cbPlayer1Win_CheckedChanged(sender As Object, e As EventArgs) Handles cbPlayer1Win.CheckedChanged

    End Sub

    Private Sub btnReg_Click(sender As Object, e As EventArgs) Handles btnReg.Click







    End Sub
End Class
