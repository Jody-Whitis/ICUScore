Imports System.Windows.Forms

Public Class ScoreTheme
#Region "Props"
    Public Enum AppState
        NoPlayerEx = -1
        Start = 0
        Register = 1
        SelectPlayer = 2
        Winner = 3
        Switch = 4
        Add = 5
        edit = 6
        Delete = 7
    End Enum
    Private _screen As AppState
    Private _form As Form
    Public Sub New()

    End Sub
    Public Sub New(f As Form)
        Form = f
    End Sub
    Public Property Screen As AppState
        Get
            Return _screen
        End Get
        Set(value As AppState)
            _screen = value
        End Set
    End Property
    Public Property Form As Form
        Get
            Return _form
        End Get
        Set(value As Form)
            _form = value
        End Set
    End Property
#End Region

#Region "Set theme"
    Public Sub SetErrorLabel(ByRef errorText As Label)
        If errorText.Text.Contains("Error") Then
            errorText.ForeColor = Color.Red
            errorText.Visible = True
        Else
            errorText.Visible = False
            errorText.ForeColor = Color.Green
        End If
    End Sub
    Public Sub SetVisiblityTxtBox(ByRef txtBox As TextBox(), ByVal toggle As Boolean)
        For Each tBox As TextBox In txtBox
            tBox.Visible = toggle
        Next
    End Sub

    Public Sub SetVisibiltyButton(ByRef btn As Button(), ByVal toggle As Boolean)
        For Each button In btn
            button.Visible = toggle
        Next
    End Sub

    Public Sub SetBackground(ByRef t As Form)
        With t
            .BackColor = Color.RoyalBlue
        End With
    End Sub

    Public Sub SetButtons(ByRef buttons As Button())
        For Each btn In buttons
            With btn
                .BackColor = Color.Aquamarine
                .Font = New Font("Gill Sans Ultra", 9,
                FontStyle.Bold)
            End With
        Next
    End Sub

    Public Sub SetTBox(ByRef tBoxes As TextBox())
        For Each tbox In tBoxes
            With tbox
                .BackColor = Color.Aquamarine
                .Font = New Font("Gill Sans Ultra", 9,
               FontStyle.Bold)
            End With
        Next
    End Sub

    Public Sub SetCBox(ByRef cBoxes As ComboBox())
        For Each cBox In cBoxes
            With cBox
                .BackColor = Color.Aqua
            End With
        Next
    End Sub
#End Region
    Public Function GetKey(ByVal values As String, ByVal col As Hashtable) As Integer
        For Each items As DictionaryEntry In col
            If items.Value.Equals(values) Then
                Return items.Key
            End If
        Next
        Return -1
    End Function
    Public Sub FillBoxfromHT(ByRef cBox As ComboBox, ByVal allPlayersDT As Hashtable)
        cBox.Items.Clear()
        For Each player As DictionaryEntry In allPlayersDT
            If Not player.Value.Equals("Error") Then
                cBox.Items.Add(player.Value)
            End If
        Next
    End Sub
    Public Sub FillCBoxAll(ByVal allList As Hashtable, ByRef cBox As ComboBox, ByRef lblError As Label)
        cBox.Items.Clear()
        For Each name As DictionaryEntry In allList
            If Screen = 0 AndAlso name.Value.ToString.Contains("Error") Then
                Screen = -1
                lblError.Text = "Error getting all players"
                Exit For
            Else
                cBox.Items.Add(name.Value)
                Screen = AppState.SelectPlayer
            End If
        Next
    End Sub

    Public Function ValidateCBox(ByRef cBox As ComboBox) As Boolean
        If cBox.SelectedItem IsNot Nothing AndAlso Not String.IsNullOrEmpty(cBox.SelectedItem.ToString) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function getSubs(ByVal gameMode As Games) As List(Of String)
        Dim listOfSubs As New List(Of String)
        Dim subResults As New DataSet
        Try
            subResults = gameMode.GetAllResults("exec [selSubs]")
            For i = 0 To subResults.Tables(0).Rows.Count - 1
                With listOfSubs
                    .Add(subResults.Tables(0).Rows(i).Item("emailAddress").ToString)
                End With
            Next
            Return listOfSubs
        Catch ex As Exception
            Debug.WriteLine(ex.ToString)
            Return Nothing
        End Try
    End Function
End Class
