Imports Pool.ScoreTheme

Public Class Home
    Dim homeTheme As New ScoreTheme(Me)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        homeTheme.Screen = AppState.Start
        homeTheme.SetBackground(Me)
        homeTheme.SetButtons(New Button() {btnPvP, btnHS, btnQuit})
        lblHome.ForeColor = Color.Aquamarine
        lblHome.Font = New Font("Gill Sans Ultra", 15, FontStyle.Bold)
        Me.ShowIcon = True
        Dim test As New Authenticate
        With test
            .User = "jodywhitis0407@gmail.com"
            .Password = "password123"
        End With
        Dim loggedIn As Boolean = test.GetLogin()
        test.isLoggedIn = loggedIn
        If loggedIn.Equals(True) Then
            test.ILogin_UpdatePassword("123abc")
        End If
    End Sub

    Private Sub btnPvP_Click(sender As Object, e As EventArgs) Handles btnPvP.Click
        PvP.Activate()
        PvP.Show()
        Me.Hide()
    End Sub

    Private Sub btnHS_Click(sender As Object, e As EventArgs) Handles btnHS.Click
        HighScores.Activate()
        HighScores.Show()
        Me.Hide()
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()
    End Sub
End Class