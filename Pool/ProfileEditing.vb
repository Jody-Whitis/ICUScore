Public Class ProfileEditing
    Private Sub ProfileEditing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If CurrentSession.IsLoggedIn.Equals(True) Then
            Try
                cbTwoFactorEnabled.Checked = CurrentSession.TwoFactorEnabled
                cbSubscribed.Checked = CurrentSession.Subscribed
            Catch ex As Exception
                Dim optionsErrorLog As New Logging(Now.ToLongDateString, "Profile Options Error", ex.ToString)
                optionsErrorLog.LogAction()
            End Try


        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ScoreTheme.LoadNextFormClose(Me, Home)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click


        ScoreTheme.LoadNextFormClose(Me, Home)
    End Sub
End Class