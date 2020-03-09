<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtUseremail = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.TxtPasswordConfirm = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.cbCurrentPlayers = New System.Windows.Forms.ComboBox()
        Me.txtDisplayName = New System.Windows.Forms.TextBox()
        Me.lblNewUser = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblDisplayName = New System.Windows.Forms.Label()
        Me.lblNewDisplayName = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblConfirmPassword = New System.Windows.Forms.Label()
        Me.mnuRegister = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditPasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlayerEditingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRegister.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtUseremail
        '
        Me.txtUseremail.BackColor = System.Drawing.Color.Lime
        Me.txtUseremail.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUseremail.Location = New System.Drawing.Point(195, 102)
        Me.txtUseremail.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtUseremail.Name = "txtUseremail"
        Me.txtUseremail.Size = New System.Drawing.Size(239, 24)
        Me.txtUseremail.TabIndex = 0
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.Lime
        Me.txtPassword.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(195, 234)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(239, 24)
        Me.txtPassword.TabIndex = 1
        '
        'TxtPasswordConfirm
        '
        Me.TxtPasswordConfirm.BackColor = System.Drawing.Color.Lime
        Me.TxtPasswordConfirm.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPasswordConfirm.Location = New System.Drawing.Point(195, 284)
        Me.TxtPasswordConfirm.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtPasswordConfirm.Name = "TxtPasswordConfirm"
        Me.TxtPasswordConfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPasswordConfirm.Size = New System.Drawing.Size(239, 24)
        Me.TxtPasswordConfirm.TabIndex = 2
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Lime
        Me.btnCancel.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(21, 378)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(113, 49)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.Lime
        Me.btnConfirm.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.Location = New System.Drawing.Point(319, 378)
        Me.btnConfirm.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(113, 49)
        Me.btnConfirm.TabIndex = 4
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'cbCurrentPlayers
        '
        Me.cbCurrentPlayers.BackColor = System.Drawing.Color.Lime
        Me.cbCurrentPlayers.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCurrentPlayers.FormattingEnabled = True
        Me.cbCurrentPlayers.Location = New System.Drawing.Point(195, 146)
        Me.cbCurrentPlayers.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbCurrentPlayers.Name = "cbCurrentPlayers"
        Me.cbCurrentPlayers.Size = New System.Drawing.Size(239, 27)
        Me.cbCurrentPlayers.TabIndex = 5
        '
        'txtDisplayName
        '
        Me.txtDisplayName.BackColor = System.Drawing.Color.Lime
        Me.txtDisplayName.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisplayName.Location = New System.Drawing.Point(195, 188)
        Me.txtDisplayName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDisplayName.Name = "txtDisplayName"
        Me.txtDisplayName.Size = New System.Drawing.Size(239, 24)
        Me.txtDisplayName.TabIndex = 6
        Me.txtDisplayName.Visible = False
        '
        'lblNewUser
        '
        Me.lblNewUser.AutoSize = True
        Me.lblNewUser.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewUser.ForeColor = System.Drawing.Color.Lime
        Me.lblNewUser.Location = New System.Drawing.Point(149, 26)
        Me.lblNewUser.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNewUser.Name = "lblNewUser"
        Me.lblNewUser.Size = New System.Drawing.Size(154, 33)
        Me.lblNewUser.TabIndex = 7
        Me.lblNewUser.Text = "New User"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.Lime
        Me.lblEmail.Location = New System.Drawing.Point(8, 102)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(118, 20)
        Me.lblEmail.TabIndex = 8
        Me.lblEmail.Text = "Email Name"
        '
        'lblDisplayName
        '
        Me.lblDisplayName.AutoSize = True
        Me.lblDisplayName.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplayName.ForeColor = System.Drawing.Color.Lime
        Me.lblDisplayName.Location = New System.Drawing.Point(8, 146)
        Me.lblDisplayName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDisplayName.Name = "lblDisplayName"
        Me.lblDisplayName.Size = New System.Drawing.Size(134, 20)
        Me.lblDisplayName.TabIndex = 9
        Me.lblDisplayName.Text = "Display Name"
        '
        'lblNewDisplayName
        '
        Me.lblNewDisplayName.AutoSize = True
        Me.lblNewDisplayName.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewDisplayName.ForeColor = System.Drawing.Color.Lime
        Me.lblNewDisplayName.Location = New System.Drawing.Point(8, 190)
        Me.lblNewDisplayName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNewDisplayName.Name = "lblNewDisplayName"
        Me.lblNewDisplayName.Size = New System.Drawing.Size(168, 20)
        Me.lblNewDisplayName.TabIndex = 10
        Me.lblNewDisplayName.Text = "New Display Name"
        Me.lblNewDisplayName.Visible = False
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.Lime
        Me.lblPassword.Location = New System.Drawing.Point(8, 234)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(99, 20)
        Me.lblPassword.TabIndex = 11
        Me.lblPassword.Text = "Password"
        '
        'lblConfirmPassword
        '
        Me.lblConfirmPassword.AutoSize = True
        Me.lblConfirmPassword.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmPassword.ForeColor = System.Drawing.Color.Lime
        Me.lblConfirmPassword.Location = New System.Drawing.Point(8, 285)
        Me.lblConfirmPassword.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblConfirmPassword.Name = "lblConfirmPassword"
        Me.lblConfirmPassword.Size = New System.Drawing.Size(169, 20)
        Me.lblConfirmPassword.TabIndex = 12
        Me.lblConfirmPassword.Text = "Confirm Password"
        '
        'mnuRegister
        '
        Me.mnuRegister.BackColor = System.Drawing.Color.RoyalBlue
        Me.mnuRegister.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.mnuRegister.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.mnuRegister.Location = New System.Drawing.Point(0, 0)
        Me.mnuRegister.Name = "mnuRegister"
        Me.mnuRegister.Padding = New System.Windows.Forms.Padding(4, 1, 0, 1)
        Me.mnuRegister.Size = New System.Drawing.Size(469, 26)
        Me.mnuRegister.TabIndex = 13
        Me.mnuRegister.Text = "mnuRegister"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditPasswordToolStripMenuItem, Me.PlayerEditingToolStripMenuItem, Me.LogOutToolStripMenuItem, Me.QuitToolStripMenuItem})
        Me.MenuToolStripMenuItem.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(71, 24)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'EditPasswordToolStripMenuItem
        '
        Me.EditPasswordToolStripMenuItem.BackColor = System.Drawing.Color.RoyalBlue
        Me.EditPasswordToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.EditPasswordToolStripMenuItem.Name = "EditPasswordToolStripMenuItem"
        Me.EditPasswordToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.EditPasswordToolStripMenuItem.Text = "Edit Password"
        Me.EditPasswordToolStripMenuItem.Visible = False
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.BackColor = System.Drawing.Color.RoyalBlue
        Me.LogOutToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        Me.LogOutToolStripMenuItem.Visible = False
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.BackColor = System.Drawing.Color.RoyalBlue
        Me.QuitToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.QuitToolStripMenuItem.Text = "Quit"
        '
        'PlayerEditingToolStripMenuItem
        '
        Me.PlayerEditingToolStripMenuItem.BackColor = System.Drawing.Color.RoyalBlue
        Me.PlayerEditingToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.PlayerEditingToolStripMenuItem.Name = "PlayerEditingToolStripMenuItem"
        Me.PlayerEditingToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.PlayerEditingToolStripMenuItem.Text = "Player Editing"
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(469, 441)
        Me.Controls.Add(Me.lblConfirmPassword)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblNewDisplayName)
        Me.Controls.Add(Me.lblDisplayName)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblNewUser)
        Me.Controls.Add(Me.txtDisplayName)
        Me.Controls.Add(Me.cbCurrentPlayers)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.TxtPasswordConfirm)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUseremail)
        Me.Controls.Add(Me.mnuRegister)
        Me.MainMenuStrip = Me.mnuRegister
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Register"
        Me.Text = "Register"
        Me.mnuRegister.ResumeLayout(False)
        Me.mnuRegister.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtUseremail As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents TxtPasswordConfirm As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnConfirm As Button
    Friend WithEvents cbCurrentPlayers As ComboBox
    Friend WithEvents txtDisplayName As TextBox
    Friend WithEvents lblNewUser As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblDisplayName As Label
    Friend WithEvents lblNewDisplayName As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblConfirmPassword As Label
    Friend WithEvents mnuRegister As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditPasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PlayerEditingToolStripMenuItem As ToolStripMenuItem
End Class
