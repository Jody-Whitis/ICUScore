<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.btnPvP = New System.Windows.Forms.Button()
        Me.btnHS = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.lblHome = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuHome = New System.Windows.Forms.ToolStripMenuItem()
        Me.logOutMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.quitMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditPasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditPlayerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnNewUser = New System.Windows.Forms.Button()
        Me.btnGuest = New System.Windows.Forms.Button()
        Me.btnTest = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPvP
        '
        Me.btnPvP.BackColor = System.Drawing.Color.Aquamarine
        Me.btnPvP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPvP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.btnPvP.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPvP.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPvP.ForeColor = System.Drawing.Color.Black
        Me.btnPvP.Location = New System.Drawing.Point(78, 236)
        Me.btnPvP.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnPvP.Name = "btnPvP"
        Me.btnPvP.Size = New System.Drawing.Size(131, 45)
        Me.btnPvP.TabIndex = 6
        Me.btnPvP.Text = "PVP"
        Me.btnPvP.UseVisualStyleBackColor = False
        '
        'btnHS
        '
        Me.btnHS.BackColor = System.Drawing.Color.Aquamarine
        Me.btnHS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHS.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnHS.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHS.ForeColor = System.Drawing.Color.Black
        Me.btnHS.Location = New System.Drawing.Point(305, 236)
        Me.btnHS.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnHS.Name = "btnHS"
        Me.btnHS.Size = New System.Drawing.Size(131, 45)
        Me.btnHS.TabIndex = 7
        Me.btnHS.Text = "HS"
        Me.btnHS.UseVisualStyleBackColor = False
        '
        'btnQuit
        '
        Me.btnQuit.BackColor = System.Drawing.Color.Aquamarine
        Me.btnQuit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnQuit.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.ForeColor = System.Drawing.Color.Black
        Me.btnQuit.Location = New System.Drawing.Point(391, 373)
        Me.btnQuit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(131, 47)
        Me.btnQuit.TabIndex = 9
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = False
        '
        'lblHome
        '
        Me.lblHome.AutoSize = True
        Me.lblHome.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHome.ForeColor = System.Drawing.Color.Aquamarine
        Me.lblHome.Location = New System.Drawing.Point(159, 45)
        Me.lblHome.Name = "lblHome"
        Me.lblHome.Size = New System.Drawing.Size(215, 26)
        Me.lblHome.TabIndex = 3
        Me.lblHome.Text = "Login or Register"
        '
        'txtUser
        '
        Me.txtUser.AcceptsTab = True
        Me.txtUser.BackColor = System.Drawing.Color.Aquamarine
        Me.txtUser.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.Location = New System.Drawing.Point(176, 109)
        Me.txtUser.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtUser.Size = New System.Drawing.Size(261, 26)
        Me.txtUser.TabIndex = 1
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.Aquamarine
        Me.txtPassword.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(176, 173)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(261, 26)
        Me.txtPassword.TabIndex = 2
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.Aquamarine
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogin.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.Black
        Me.btnLogin.Location = New System.Drawing.Point(305, 285)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(131, 48)
        Me.btnLogin.TabIndex = 5
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Aquamarine
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogout.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.Black
        Me.btnLogout.Location = New System.Drawing.Point(196, 374)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(131, 48)
        Me.btnLogout.TabIndex = 8
        Me.btnLogout.Text = "Log Out"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'lblUser
        '
        Me.lblUser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.Aquamarine
        Me.lblUser.Location = New System.Drawing.Point(85, 109)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(73, 26)
        Me.lblUser.TabIndex = 9
        Me.lblUser.Text = "User:"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.Aquamarine
        Me.lblPassword.Location = New System.Drawing.Point(33, 173)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(119, 25)
        Me.lblPassword.TabIndex = 10
        Me.lblPassword.Text = "Password:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.RoyalBlue
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHome, Me.EditToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(536, 28)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuHome
        '
        Me.mnuHome.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.logOutMnu, Me.quitMnu})
        Me.mnuHome.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuHome.ForeColor = System.Drawing.Color.Aquamarine
        Me.mnuHome.Name = "mnuHome"
        Me.mnuHome.Size = New System.Drawing.Size(71, 24)
        Me.mnuHome.Text = "Menu"
        '
        'logOutMnu
        '
        Me.logOutMnu.BackColor = System.Drawing.Color.RoyalBlue
        Me.logOutMnu.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logOutMnu.ForeColor = System.Drawing.Color.Aquamarine
        Me.logOutMnu.Name = "logOutMnu"
        Me.logOutMnu.Size = New System.Drawing.Size(154, 26)
        Me.logOutMnu.Text = "Log Out"
        Me.logOutMnu.Visible = False
        '
        'quitMnu
        '
        Me.quitMnu.BackColor = System.Drawing.Color.RoyalBlue
        Me.quitMnu.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quitMnu.ForeColor = System.Drawing.Color.Aquamarine
        Me.quitMnu.Name = "quitMnu"
        Me.quitMnu.Size = New System.Drawing.Size(154, 26)
        Me.quitMnu.Text = "Quit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditPasswordToolStripMenuItem, Me.EditPlayerToolStripMenuItem})
        Me.EditToolStripMenuItem.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditToolStripMenuItem.ForeColor = System.Drawing.Color.Aquamarine
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(58, 24)
        Me.EditToolStripMenuItem.Text = "Edit"
        Me.EditToolStripMenuItem.Visible = False
        '
        'EditPasswordToolStripMenuItem
        '
        Me.EditPasswordToolStripMenuItem.BackColor = System.Drawing.Color.RoyalBlue
        Me.EditPasswordToolStripMenuItem.ForeColor = System.Drawing.Color.Aquamarine
        Me.EditPasswordToolStripMenuItem.Name = "EditPasswordToolStripMenuItem"
        Me.EditPasswordToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.EditPasswordToolStripMenuItem.Text = "Edit Password"
        '
        'EditPlayerToolStripMenuItem
        '
        Me.EditPlayerToolStripMenuItem.BackColor = System.Drawing.Color.RoyalBlue
        Me.EditPlayerToolStripMenuItem.ForeColor = System.Drawing.Color.Aquamarine
        Me.EditPlayerToolStripMenuItem.Name = "EditPlayerToolStripMenuItem"
        Me.EditPlayerToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.EditPlayerToolStripMenuItem.Text = "Player Editing"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem1})
        Me.AboutToolStripMenuItem.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutToolStripMenuItem.ForeColor = System.Drawing.Color.Aquamarine
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(79, 24)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.BackColor = System.Drawing.Color.RoyalBlue
        Me.AboutToolStripMenuItem1.ForeColor = System.Drawing.Color.Aquamarine
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(142, 26)
        Me.AboutToolStripMenuItem1.Text = "About"
        '
        'btnNewUser
        '
        Me.btnNewUser.BackColor = System.Drawing.Color.Aquamarine
        Me.btnNewUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNewUser.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewUser.ForeColor = System.Drawing.Color.Black
        Me.btnNewUser.Location = New System.Drawing.Point(78, 285)
        Me.btnNewUser.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnNewUser.Name = "btnNewUser"
        Me.btnNewUser.Size = New System.Drawing.Size(131, 48)
        Me.btnNewUser.TabIndex = 3
        Me.btnNewUser.Text = "New User"
        Me.btnNewUser.UseVisualStyleBackColor = False
        '
        'btnGuest
        '
        Me.btnGuest.BackColor = System.Drawing.Color.Aquamarine
        Me.btnGuest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuest.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGuest.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuest.ForeColor = System.Drawing.Color.Black
        Me.btnGuest.Location = New System.Drawing.Point(8, 374)
        Me.btnGuest.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnGuest.Name = "btnGuest"
        Me.btnGuest.Size = New System.Drawing.Size(131, 46)
        Me.btnGuest.TabIndex = 4
        Me.btnGuest.Text = "Guest"
        Me.btnGuest.UseVisualStyleBackColor = False
        '
        'btnTest
        '
        Me.btnTest.BackColor = System.Drawing.Color.Aquamarine
        Me.btnTest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTest.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTest.ForeColor = System.Drawing.Color.Black
        Me.btnTest.Location = New System.Drawing.Point(444, 11)
        Me.btnTest.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(81, 71)
        Me.btnTest.TabIndex = 12
        Me.btnTest.Text = "Test 2-fact"
        Me.btnTest.UseVisualStyleBackColor = False
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.CancelButton = Me.btnQuit
        Me.ClientSize = New System.Drawing.Size(536, 454)
        Me.Controls.Add(Me.btnTest)
        Me.Controls.Add(Me.btnGuest)
        Me.Controls.Add(Me.btnNewUser)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.lblHome)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnHS)
        Me.Controls.Add(Me.btnPvP)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.Name = "Home"
        Me.Text = "Login"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPvP As Button
    Friend WithEvents btnHS As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents lblHome As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents lblUser As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuHome As ToolStripMenuItem
    Friend WithEvents logOutMnu As ToolStripMenuItem
    Friend WithEvents quitMnu As ToolStripMenuItem
    Friend WithEvents btnNewUser As Button
    Friend WithEvents btnGuest As Button
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditPasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditPlayerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnTest As Button
End Class
