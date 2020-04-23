Imports System.Text
Imports Pool.Models.Validation
Public Class Register
    Dim allCurrentPlayers As New DataSet
    Dim getAllCurrent As New PlayerStats
    Dim currentPlayersHT As New Hashtable
    Dim user As New NewUser
    Dim inputValidation As New EmailValidation
    Public Structure NewUser
        Public userEmail As String
        Public passWord As String
        Public passwordEncripted As String
        Public displayName As String
        Public pID As Integer
    End Structure

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        allCurrentPlayers = getAllCurrent.GetAllResults("exec selAllPlayers @wins=0")
        FillCBox()
    End Sub

#Region "Fills"
    Private Sub FillCBox()
        cbCurrentPlayers.Items.Clear()
        cbCurrentPlayers.Items.Add("Choose your Name")
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
        cbCurrentPlayers.SelectedIndex = cbCurrentPlayers.Items.IndexOf("Choose your Name")
    End Sub
#End Region

#Region "Functions"
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
#End Region

#Region "Event Handlers"
    Private Sub cbCurrentPlayers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCurrentPlayers.SelectedIndexChanged
        Try
            If cbCurrentPlayers.SelectedItem.Equals("Not Me!") Then
                txtDisplayName.Visible = True
                lblNewDisplayName.Visible = True
                user.displayName = String.Empty
                user.pID = -1
            Else
                user.displayName = cbCurrentPlayers.SelectedItem.ToString
                txtDisplayName.Visible = False
                lblNewDisplayName.Visible = False
                For Each existingName As DictionaryEntry In currentPlayersHT
                    If existingName.Value.Equals(cbCurrentPlayers.SelectedItem.ToString) Then
                        user.pID = existingName.Key
                        Exit For
                    End If
                Next
            End If
        Catch ex As Exception
            Debug.WriteLine(ex.ToString)
            Dim selectIndexError As New Logging(Now, "Index selected error:", ex.ToString)
        End Try
    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        ScoreTheme.LogOutUser()
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        CurrentSession.PreviousForm = Me
        AboutThis.Activate()
        AboutThis.Show()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ScoreTheme.LoadNextFormClose(Me, Home)
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim registerSQL As New StringBuilder
        If ValidateRegister(New TextBox() {txtUseremail, txtPassword, TxtPasswordConfirm, TxtPasswordConfirm}).Equals(True) Then
            If inputValidation.isValid(txtUseremail.Text) Then
                user.userEmail = txtUseremail.Text
            Else
                Dim RequiredField As DialogResult = MessageBox.Show($"Missing required fields",
                      "Missing Requirement", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Exit Sub
            End If
            user.passWord = TxtPasswordConfirm.Text
            user.displayName = GetDisplayName()
            If txtPassword.Text.Equals(TxtPasswordConfirm.Text) Then
                Dim hashPassword As New Authenticate(txtUseremail.Text, txtPassword.Text)
                Dim insertPlayer As New PlayerStats
                user.passwordEncripted = hashPassword.GetEncriptedString()

                With registerSQL
                    .Append("exec [insNewUser] ")
                    .Append($"@userEmail='{inputValidation.SQLValidation(user.userEmail)}', @password='{user.passwordEncripted}',@displayName='{inputValidation.SQLValidation(user.displayName)}',")
                    .Append($"@timeStamp='{Now.ToString("MM/dd/yyyy")}',")
                    If (user.pID > -1) Then
                        .Append($"@pId = '{user.pID}'")
                    End If
                End With
                'register an existing or create a new one in players and login
                'We don't want to delete Player for wins records, just delete login
                'and set Player register bit
                insertPlayer.GetAllResults(registerSQL.ToString.TrimEnd(","))
                ScoreTheme.LoadNextFormClose(Me, Home)
            Else
                'Confirm your password
            End If
        Else
            Dim RequiredField As DialogResult = MessageBox.Show($"Missing required fields",
        "Missing Requirement", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End If

    End Sub
#End Region

End Class