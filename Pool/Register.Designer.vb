<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Register
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Register))
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
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRegister.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtUseremail
        '
        Me.txtUseremail.BackColor = System.Drawing.Color.Aquamarine
        Me.txtUseremail.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUseremail.Location = New System.Drawing.Point(292, 159)
        Me.txtUseremail.Name = "txtUseremail"
        Me.txtUseremail.Size = New System.Drawing.Size(356, 34)
        Me.txtUseremail.TabIndex = 0
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.Aquamarine
        Me.txtPassword.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(292, 366)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(356, 34)
        Me.txtPassword.TabIndex = 3
        '
        'TxtPasswordConfirm
        '
        Me.TxtPasswordConfirm.BackColor = System.Drawing.Color.Aquamarine
        Me.TxtPasswordConfirm.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPasswordConfirm.Location = New System.Drawing.Point(292, 444)
        Me.TxtPasswordConfirm.Name = "TxtPasswordConfirm"
        Me.TxtPasswordConfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPasswordConfirm.Size = New System.Drawing.Size(356, 34)
        Me.TxtPasswordConfirm.TabIndex = 4
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Aquamarine
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(32, 591)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(170, 77)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.Aquamarine
        Me.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnConfirm.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.Location = New System.Drawing.Point(478, 591)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(170, 77)
        Me.btnConfirm.TabIndex = 6
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'cbCurrentPlayers
        '
        Me.cbCurrentPlayers.BackColor = System.Drawing.Color.Aquamarine
        Me.cbCurrentPlayers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCurrentPlayers.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbCurrentPlayers.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCurrentPlayers.FormattingEnabled = True
        Me.cbCurrentPlayers.Location = New System.Drawing.Point(292, 228)
        Me.cbCurrentPlayers.Name = "cbCurrentPlayers"
        Me.cbCurrentPlayers.Size = New System.Drawing.Size(356, 38)
        Me.cbCurrentPlayers.TabIndex = 1
        '
        'txtDisplayName
        '
        Me.txtDisplayName.BackColor = System.Drawing.Color.Aquamarine
        Me.txtDisplayName.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisplayName.Location = New System.Drawing.Point(292, 294)
        Me.txtDisplayName.Name = "txtDisplayName"
        Me.txtDisplayName.Size = New System.Drawing.Size(356, 34)
        Me.txtDisplayName.TabIndex = 2
        Me.txtDisplayName.Visible = False
        '
        'lblNewUser
        '
        Me.lblNewUser.AutoSize = True
        Me.lblNewUser.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewUser.ForeColor = System.Drawing.Color.Aquamarine
        Me.lblNewUser.Location = New System.Drawing.Point(224, 41)
        Me.lblNewUser.Name = "lblNewUser"
        Me.lblNewUser.Size = New System.Drawing.Size(236, 51)
        Me.lblNewUser.TabIndex = 7
        Me.lblNewUser.Text = "New User"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.Aquamarine
        Me.lblEmail.Location = New System.Drawing.Point(12, 159)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(190, 33)
        Me.lblEmail.TabIndex = 8
        Me.lblEmail.Text = "Email Name"
        '
        'lblDisplayName
        '
        Me.lblDisplayName.AutoSize = True
        Me.lblDisplayName.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplayName.ForeColor = System.Drawing.Color.Turquoise
        Me.lblDisplayName.Location = New System.Drawing.Point(12, 228)
        Me.lblDisplayName.Name = "lblDisplayName"
        Me.lblDisplayName.Size = New System.Drawing.Size(217, 33)
        Me.lblDisplayName.TabIndex = 9
        Me.lblDisplayName.Text = "Display Name"
        '
        'lblNewDisplayName
        '
        Me.lblNewDisplayName.AutoSize = True
        Me.lblNewDisplayName.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewDisplayName.ForeColor = System.Drawing.Color.Aquamarine
        Me.lblNewDisplayName.Location = New System.Drawing.Point(12, 297)
        Me.lblNewDisplayName.Name = "lblNewDisplayName"
        Me.lblNewDisplayName.Size = New System.Drawing.Size(252, 30)
        Me.lblNewDisplayName.TabIndex = 10
        Me.lblNewDisplayName.Text = "New Display Name"
        Me.lblNewDisplayName.Visible = False
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.Aquamarine
        Me.lblPassword.Location = New System.Drawing.Point(12, 366)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(158, 33)
        Me.lblPassword.TabIndex = 11
        Me.lblPassword.Text = "Password"
        '
        'lblConfirmPassword
        '
        Me.lblConfirmPassword.AutoSize = True
        Me.lblConfirmPassword.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmPassword.ForeColor = System.Drawing.Color.Aquamarine
        Me.lblConfirmPassword.Location = New System.Drawing.Point(12, 445)
        Me.lblConfirmPassword.Name = "lblConfirmPassword"
        Me.lblConfirmPassword.Size = New System.Drawing.Size(253, 30)
        Me.lblConfirmPassword.TabIndex = 12
        Me.lblConfirmPassword.Text = "Confirm Password"
        '
        'mnuRegister
        '
        Me.mnuRegister.BackColor = System.Drawing.Color.RoyalBlue
        Me.mnuRegister.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.mnuRegister.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.mnuRegister.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.mnuRegister.Location = New System.Drawing.Point(0, 0)
        Me.mnuRegister.Name = "mnuRegister"
        Me.mnuRegister.Size = New System.Drawing.Size(704, 42)
        Me.mnuRegister.TabIndex = 13
        Me.mnuRegister.Text = "mnuRegister"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogOutToolStripMenuItem, Me.QuitToolStripMenuItem})
        Me.MenuToolStripMenuItem.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuToolStripMenuItem.ForeColor = System.Drawing.Color.Aquamarine
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(115, 38)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.BackColor = System.Drawing.Color.RoyalBlue
        Me.LogOutToolStripMenuItem.ForeColor = System.Drawing.Color.Aquamarine
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(359, 44)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        Me.LogOutToolStripMenuItem.Visible = False
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.BackColor = System.Drawing.Color.RoyalBlue
        Me.QuitToolStripMenuItem.ForeColor = System.Drawing.Color.Aquamarine
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(359, 44)
        Me.QuitToolStripMenuItem.Text = "Quit"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem1})
        Me.AboutToolStripMenuItem.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutToolStripMenuItem.ForeColor = System.Drawing.Color.Aquamarine
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(128, 38)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.BackColor = System.Drawing.Color.RoyalBlue
        Me.AboutToolStripMenuItem1.ForeColor = System.Drawing.Color.Aquamarine
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(242, 44)
        Me.AboutToolStripMenuItem1.Text = "About"
        '
        'Register
        '
        Me.AcceptButton = Me.btnConfirm
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(704, 689)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuRegister
        Me.MaximizeBox = False
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
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As ToolStripMenuItem
End Class
