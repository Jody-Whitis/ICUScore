Imports System.Windows.Forms
Public Class Test

    Public Sub SetBackground(ByRef t As Form)
        With t
            .BackColor = Color.Aquamarine
        End With
    End Sub

    Public Sub SetButtons(ByRef btn As Button)
        With btn
            .BackColor = Color.Aquamarine
        End With

    End Sub

    Public Sub SetBox(ByRef tBox As TextBox)
        With tBox
            .BackColor = Color.Aquamarine

        End With
    End Sub

    Public Sub SetCBox(ByRef cBox As ComboBox)
        With cBox
            .BackColor = Color.Aqua
        End With
    End Sub



End Class
