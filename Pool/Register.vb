Public Class Register
    Dim registerTheme As New ScoreTheme(Me)
    Dim allCurrentPlayers As New DataSet
    Dim getAllCurrent As New PlayerStats
    Dim currentPlayersHT As New Hashtable
    Dim newUserRegister As New NewUser

    Public Structure NewUser
        Public userEmail As String
        Public passWord As String
        Public passwordEncripted As String
        Public displayName As String
        Public pID As Integer
    End Structure

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        registerTheme.SetBackground(Me)
        registerTheme.SetButtons(New Button() {btnCancel, btnConfirm})
        registerTheme.SetTBox(New TextBox() {txtPassword, TxtPasswordConfirm, txtUseremail, txtDisplayName})
        cbCurrentPlayers.BackColor = Color.RoyalBlue
        cbCurrentPlayers.ForeColor = Color.Aquamarine
        allCurrentPlayers = getAllCurrent.GetAllResults("exec selAllPlayers @wins=0")
        FillCBox()
    End Sub

    Private Sub FillCBox()
        cbCurrentPlayers.Items.Clear()
        Try
            If allCurrentPlayers.Tables(0).Rows.Count > 0 Then
                Dim unRegistered = (From names In allCurrentPlayers.Tables(0) Where names.Item("Registered").Equals(0)
                                    Select names).Distinct

                For Each unRegName In unRegistered
                    cbCurrentPlayers.Items.Add(unRegName.Item("PlayerName"))
                    currentPlayersHT.Add(unRegName.Item("iD"), unRegName.Item("PlayerName"))
                Next
            End If
        Catch ex As Exception
            Debug.WriteLine(ex.ToString)
            Dim fillLog As New Logging(Now, "Fill error: ", ex.ToString)
        End Try
        cbCurrentPlayers.Items.Add("Not Me!")
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Home.Activate()
        Home.Show()
        Me.Close()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If ValidateRegister(New TextBox() {txtUseremail, txtPassword, TxtPasswordConfirm, TxtPasswordConfirm}).Equals(True) Then
            newUserRegister.userEmail = txtUseremail.Text
            newUserRegister.passWord = TxtPasswordConfirm.Text
            newUserRegister.displayName = GetDisplayName()
            If txtPassword.Text.Equals(TxtPasswordConfirm.Text) Then
                Dim hashPassword As New Authenticate(txtUseremail.Text, txtPassword.Text)
                Dim insertPlayer As New PlayerStats
                newUserRegister.passwordEncripted = hashPassword.GetEncriptedString()

                'insertPlayer.GetAllResults($"")

                Home.Activate()
                Home.Show()
                Me.Close()
            Else
                '
            End If
        Else
            ''''
        End If

    End Sub

    Private Function ValidateRegister(ByRef tBoxes As TextBox()) As Boolean
        Dim validEntry As Boolean = False
        For Each field In tBoxes
            If String.IsNullOrEmpty(field.Text) Then
                validEntry = False
                Exit For
            Else
                validEntry = True
            End If
        Next
        Return validEntry
    End Function

    Private Function GetDisplayName() As String
        Try
            If Not cbCurrentPlayers.SelectedItem.Equals("Not Me!") Then
                Return cbCurrentPlayers.SelectedItem.ToString
            Else
                Return txtDisplayName.Text
            End If
        Catch ex As Exception
            Debug.WriteLine(ex.ToString)
            Dim indexErrorLog As New Logging(Now, "DisplayName index error: ", ex.ToString)
            Return String.Empty
        End Try
        Return String.Empty
    End Function

    Private Sub cbCurrentPlayers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCurrentPlayers.SelectedIndexChanged
        Try
            If cbCurrentPlayers.SelectedItem.Equals("Not Me!") Then
                txtDisplayName.Visible = True
                newUserRegister.displayName = String.Empty
            Else
                newUserRegister.displayName = cbCurrentPlayers.SelectedItem.ToString
                For Each existingName As DictionaryEntry In currentPlayersHT
                    If existingName.Value.Equals(cbCurrentPlayers.SelectedItem.ToString) Then
                        newUserRegister.pID = existingName.Key
                        Exit For
                    End If
                Next
            End If
        Catch ex As Exception
            Debug.WriteLine(ex.ToString)
            Dim selectIndexError As New Logging(Now, "Index selected error:", ex.ToString)
        End Try
    End Sub
End Class