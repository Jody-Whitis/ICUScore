Imports System.Text
Imports System.Windows.Forms
Imports Pool.Logging
Public Class ScoreTheme

#Region "Set Controls"
    ''' <summary>
    ''' Set Error label and color
    ''' </summary>
    ''' <param name="errorText"></param>
    Public Shared Sub SetErrorLabel(ByRef errorText As Label)
        If errorText.Text.Contains("Error") Then
            errorText.ForeColor = Color.Red
            errorText.Visible = True
        Else
            errorText.Visible = False
        End If
    End Sub

    Public Shared Sub LoadNextFormHide(ByRef currentForm As Form, ByRef nextForm As Form)
        currentForm.Cursor = Cursors.WaitCursor
        nextForm.Activate()
        nextForm.Show()
        currentForm.Cursor = Cursors.Default
        currentForm.Hide()
    End Sub

    Public Shared Sub LoadNextFormClose(ByRef currentForm As Form, ByRef nextForm As Form)
        currentForm.Cursor = Cursors.WaitCursor
        nextForm.Activate()
        nextForm.Show()
        currentForm.Cursor = Cursors.Default
        currentForm.Close()
    End Sub

    ''' <summary>
    ''' Toggle enable and visiblity
    ''' </summary>
    ''' <param name="controls"></param>
    ''' <param name="toggle"></param>
    Public Shared Sub SetControl(ByRef controls As Control(), ByVal toggle As Boolean)
        For Each control In controls
            With control
                .Visible = toggle
                .Enabled = toggle
            End With
        Next
    End Sub


#End Region

    ''' <summary>
    ''' Retrieve key ID for this value
    ''' </summary>
    ''' <param name="values"></param>
    ''' <param name="col"></param>
    ''' <returns></returns>
    Public Shared Function GetKey(ByVal values As String, ByVal col As Hashtable) As Integer
        For Each items As DictionaryEntry In col
            If items.Value.Equals(values) Then
                Return items.Key
            End If
        Next
        Return -1
    End Function

    ''' <summary>
    ''' Fill combox from hashtable
    ''' </summary>
    ''' <param name="cBox"></param>
    ''' <param name="allDT"></param>
    Public Shared Sub FillBoxfromHT(ByRef cBox As ComboBox, ByVal allDT As Hashtable)
        cBox.Items.Clear()
        cBox.Items.Add("Choose")
        For Each entry As DictionaryEntry In allDT
            If Not entry.Value.Equals("Error") Then
                cBox.Items.Add(entry.Value)
            End If
        Next
    End Sub

    ''' <summary>
    ''' Use to validate selected item on cBox
    ''' </summary>
    ''' <param name="cBox"></param>
    ''' <returns></returns>
    Public Shared Function ValidateCBox(ByRef cBox As ComboBox) As Boolean
        If cBox.SelectedItem IsNot Nothing AndAlso Not String.IsNullOrEmpty(cBox.SelectedItem.ToString) AndAlso Not cBox.SelectedItem.ToString.Contains("Choose") Then
            Return True
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' Return list of subscribed users per mode
    ''' </summary>
    ''' <param name="gameMode"></param>
    ''' <returns></returns>
    Public Shared Function getSubs(ByVal gameMode As Games) As List(Of String)
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
            Dim exceptionLog As New Logging(Now, "Get subs", ex.ToString)
            exceptionLog.LogAction()
            Debug.WriteLine(ex.ToString)
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Use to set for guest controls
    ''' </summary>
    ''' <param name="controls"></param>
    ''' <param name="toggle"></param>
    Public Shared Sub GuestDisplay(ByRef controls As Control(), toggle As Boolean)
        For Each controlElement In controls
            controlElement.Enabled = toggle
            controlElement.Visible = toggle
        Next
    End Sub

    ''' <summary>
    ''' Reset user and go to home
    ''' </summary>
    Public Shared Sub LogOutUser()
        CurrentSession.DisplayName = String.Empty
        CurrentSession.UserEmail = String.Empty
        CurrentSession.Password = String.Empty
        CurrentSession.ID = -1
        CurrentSession.IsLoggedIn = False
        Application.Restart()
    End Sub
End Class
