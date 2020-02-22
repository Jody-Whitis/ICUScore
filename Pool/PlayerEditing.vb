Public Class PlayerEditing
    Private Sub PlayerEditing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim pvpTheme As New ScoreTheme(Me)
        With pvpTheme
            .SetBackground(Me)
            .SetButtons(New Button() {btnBack, btnDelete, btnEdit})
            .SetCBox(New ComboBox() {cbPlayerNames})
            .SetControl(New Control() {btnBack, btnDelete, btnEdit, cbPlayerNames}, True)
        End With
        Me.CenterToScreen()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        With PvP
            .Activate()
            .Show()
        End With
        Me.Close()
    End Sub
End Class