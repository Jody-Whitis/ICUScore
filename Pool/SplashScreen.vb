Public Class SplashScreen
    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Me.Cursor = Cursors.AppStarting
        txtLoad.AppendText($"{vbNewLine}Version: {My.Application.Info.Version.ToString & vbNewLine}2020")
    End Sub


End Class