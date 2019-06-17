Imports System.IO

Public Class Form1
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

        If Not String.IsNullOrEmpty(tbPlayer1.ToString) Then




            txtWins.Text = wins

        End If



    End Sub
End Class
