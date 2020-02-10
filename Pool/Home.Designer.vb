<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Me.components = New System.ComponentModel.Container()
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
        Me.editPasswordMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.logOutMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.quitMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnNewUser = New System.Windows.Forms.Button()
        Me.btnGuest = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPvP
        '
        Me.btnPvP.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPvP.ForeColor = System.Drawing.Color.Green
        Me.btnPvP.Location = New System.Drawing.Point(50, 243)
        Me.btnPvP.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnPvP.Name = "btnPvP"
        Me.btnPvP.Size = New System.Drawing.Size(131, 49)
        Me.btnPvP.TabIndex = 0
        Me.btnPvP.Text = "PVP"
        Me.btnPvP.UseVisualStyleBackColor = True
        '
        'btnHS
        '
        Me.btnHS.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHS.ForeColor = System.Drawing.Color.Green
        Me.btnHS.Location = New System.Drawing.Point(327, 242)
        Me.btnHS.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnHS.Name = "btnHS"
        Me.btnHS.Size = New System.Drawing.Size(131, 49)
        Me.btnHS.TabIndex = 1
        Me.btnHS.Text = "HS"
        Me.btnHS.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.ForeColor = System.Drawing.Color.Green
        Me.btnQuit.Location = New System.Drawing.Point(327, 346)
        Me.btnQuit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(131, 49)
        Me.btnQuit.TabIndex = 2
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'lblHome
        '
        Me.lblHome.AutoSize = True
        Me.lblHome.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHome.ForeColor = System.Drawing.Color.Lime
        Me.lblHome.Location = New System.Drawing.Point(172, 68)
        Me.lblHome.Name = "lblHome"
        Me.lblHome.Size = New System.Drawing.Size(167, 20)
        Me.lblHome.TabIndex = 3
        Me.lblHome.Text = "Login or Register"
        '
        'txtUser
        '
        Me.txtUser.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.Location = New System.Drawing.Point(176, 146)
        Me.txtUser.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(261, 26)
        Me.txtUser.TabIndex = 4
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(176, 193)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(261, 22)
        Me.txtPassword.TabIndex = 5
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.Green
        Me.btnLogin.Location = New System.Drawing.Point(299, 241)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(93, 48)
        Me.btnLogin.TabIndex = 6
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.Green
        Me.btnLogout.Location = New System.Drawing.Point(50, 349)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(131, 48)
        Me.btnLogout.TabIndex = 7
        Me.btnLogout.Text = "Log Out"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.Lime
        Me.lblUser.Location = New System.Drawing.Point(78, 139)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(73, 26)
        Me.lblUser.TabIndex = 9
        Me.lblUser.Text = "User:"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.Lime
        Me.lblPassword.Location = New System.Drawing.Point(33, 188)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(119, 25)
        Me.lblPassword.TabIndex = 10
        Me.lblPassword.Text = "Password:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.RoyalBlue
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHome})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(530, 28)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuHome
        '
        Me.mnuHome.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.editPasswordMnu, Me.logOutMnu, Me.quitMnu})
        Me.mnuHome.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuHome.ForeColor = System.Drawing.Color.Lime
        Me.mnuHome.Name = "mnuHome"
        Me.mnuHome.Size = New System.Drawing.Size(71, 24)
        Me.mnuHome.Text = "Menu"
        '
        'editPasswordMnu
        '
        Me.editPasswordMnu.BackColor = System.Drawing.Color.DodgerBlue
        Me.editPasswordMnu.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editPasswordMnu.ForeColor = System.Drawing.Color.Lime
        Me.editPasswordMnu.Name = "editPasswordMnu"
        Me.editPasswordMnu.Size = New System.Drawing.Size(216, 26)
        Me.editPasswordMnu.Text = "Edit Password"
        Me.editPasswordMnu.Visible = False
        '
        'logOutMnu
        '
        Me.logOutMnu.BackColor = System.Drawing.Color.DodgerBlue
        Me.logOutMnu.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logOutMnu.ForeColor = System.Drawing.Color.Lime
        Me.logOutMnu.Name = "logOutMnu"
        Me.logOutMnu.Size = New System.Drawing.Size(216, 26)
        Me.logOutMnu.Text = "Log Out"
        Me.logOutMnu.Visible = False
        '
        'quitMnu
        '
        Me.quitMnu.BackColor = System.Drawing.Color.DodgerBlue
        Me.quitMnu.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quitMnu.ForeColor = System.Drawing.Color.Lime
        Me.quitMnu.Name = "quitMnu"
        Me.quitMnu.Size = New System.Drawing.Size(216, 26)
        Me.quitMnu.Text = "Quit"
        '
        'btnNewUser
        '
        Me.btnNewUser.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewUser.ForeColor = System.Drawing.Color.Green
        Me.btnNewUser.Location = New System.Drawing.Point(137, 242)
        Me.btnNewUser.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnNewUser.Name = "btnNewUser"
        Me.btnNewUser.Size = New System.Drawing.Size(95, 47)
        Me.btnNewUser.TabIndex = 12
        Me.btnNewUser.Text = "New User"
        Me.btnNewUser.UseVisualStyleBackColor = True
        '
        'btnGuest
        '
        Me.btnGuest.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuest.ForeColor = System.Drawing.Color.Green
        Me.btnGuest.Location = New System.Drawing.Point(185, 349)
        Me.btnGuest.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGuest.Name = "btnGuest"
        Me.btnGuest.Size = New System.Drawing.Size(131, 48)
        Me.btnGuest.TabIndex = 13
        Me.btnGuest.Text = "Guest"
        Me.btnGuest.UseVisualStyleBackColor = True
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 425)
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
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
    Friend WithEvents editPasswordMnu As ToolStripMenuItem
    Friend WithEvents logOutMnu As ToolStripMenuItem
    Friend WithEvents quitMnu As ToolStripMenuItem
    Friend WithEvents btnNewUser As Button
    Friend WithEvents btnGuest As Button
End Class
