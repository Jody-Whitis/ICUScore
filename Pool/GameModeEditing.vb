Public Class GameModeEditing
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Try
            If PreviousForm IsNot Nothing Then
                Dim highScores As Form = PreviousForm
                highScores.Show()
                highScores.Activate()
                Me.Close()
            Else
                Dim highScoreForm As New HighScores
                highScoreForm.Activate()
                highScoreForm.Show()
                Me.Close()
            End If
        Catch ex As Exception
            Dim highScoreForm As New HighScores
            highScoreForm.Activate()
            highScoreForm.Show()
            Me.Close()
        End Try
    End Sub
End Class