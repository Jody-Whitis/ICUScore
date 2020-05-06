Public Class GameModeEditing
    Dim games As New Games
    Dim inputValidation As New ValidationBase

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If Not String.IsNullOrEmpty(tbNewGame.Text.ToString.Trim) Then
            Dim submittedAlert As DialogResult = MessageBox.Show($"Are you sure you want to add this game?",
"New Game Mode Submission", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If submittedAlert.Equals(DialogResult.Yes) Then
                'try to insert if not blank
                Dim newGM As String = $"[dbo].[insNewGame] @gameMode = '{inputValidation.SQLValidation(tbNewGame.Text.ToString.Trim)}'"
                games.InsertGame(newGM)
                tbNewGame.ResetText()
                btnBack_Click(Nothing, Nothing)
            Else
                Exit Sub
            End If
        Else
            Dim emptyNameAlert As DialogResult = MessageBox.Show($"You got to name it first!",
"Missing Name", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ScoreTheme.LoadNextFormClose(Me, HighScores)
    End Sub

    Private Sub GameModeEditing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

End Class