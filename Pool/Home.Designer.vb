﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPvP
        '
        Me.btnPvP.Location = New System.Drawing.Point(75, 380)
        Me.btnPvP.Name = "btnPvP"
        Me.btnPvP.Size = New System.Drawing.Size(196, 77)
        Me.btnPvP.TabIndex = 0
        Me.btnPvP.Text = "PVP"
        Me.btnPvP.UseVisualStyleBackColor = True
        '
        'btnHS
        '
        Me.btnHS.Location = New System.Drawing.Point(490, 378)
        Me.btnHS.Name = "btnHS"
        Me.btnHS.Size = New System.Drawing.Size(196, 77)
        Me.btnHS.TabIndex = 1
        Me.btnHS.Text = "HS"
        Me.btnHS.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(490, 544)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(196, 77)
        Me.btnQuit.TabIndex = 2
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'lblHome
        '
        Me.lblHome.AutoSize = True
        Me.lblHome.Location = New System.Drawing.Point(260, 88)
        Me.lblHome.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHome.Name = "lblHome"
        Me.lblHome.Size = New System.Drawing.Size(188, 25)
        Me.lblHome.TabIndex = 3
        Me.lblHome.Text = "Pick a Game Type"
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(264, 228)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(325, 31)
        Me.txtUser.TabIndex = 4
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(264, 302)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(325, 31)
        Me.txtPassword.TabIndex = 5
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(306, 380)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(140, 75)
        Me.btnLogin.TabIndex = 6
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(57, 545)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(196, 75)
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
        Me.lblUser.Location = New System.Drawing.Point(70, 233)
        Me.lblUser.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(63, 25)
        Me.lblUser.TabIndex = 9
        Me.lblUser.Text = "User:"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(70, 309)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(112, 25)
        Me.lblPassword.TabIndex = 10
        Me.lblPassword.Text = "Password:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.RoyalBlue
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHome})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(795, 42)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuHome
        '
        Me.mnuHome.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.editPasswordMnu, Me.logOutMnu, Me.quitMnu})
        Me.mnuHome.Name = "mnuHome"
        Me.mnuHome.Size = New System.Drawing.Size(98, 36)
        Me.mnuHome.Text = "Menu"
        '
        'editPasswordMnu
        '
        Me.editPasswordMnu.BackColor = System.Drawing.Color.DodgerBlue
        Me.editPasswordMnu.ForeColor = System.Drawing.Color.Lime
        Me.editPasswordMnu.Name = "editPasswordMnu"
        Me.editPasswordMnu.Size = New System.Drawing.Size(293, 44)
        Me.editPasswordMnu.Text = "Edit Password"
        Me.editPasswordMnu.Visible = False
        '
        'logOutMnu
        '
        Me.logOutMnu.BackColor = System.Drawing.Color.DodgerBlue
        Me.logOutMnu.ForeColor = System.Drawing.Color.Lime
        Me.logOutMnu.Name = "logOutMnu"
        Me.logOutMnu.Size = New System.Drawing.Size(293, 44)
        Me.logOutMnu.Text = "Log Out"
        Me.logOutMnu.Visible = False
        '
        'quitMnu
        '
        Me.quitMnu.BackColor = System.Drawing.Color.DodgerBlue
        Me.quitMnu.ForeColor = System.Drawing.Color.Lime
        Me.quitMnu.Name = "quitMnu"
        Me.quitMnu.Size = New System.Drawing.Size(293, 44)
        Me.quitMnu.Text = "Quit"
        '
        'btnNewUser
        '
        Me.btnNewUser.Location = New System.Drawing.Point(101, 383)
        Me.btnNewUser.Name = "btnNewUser"
        Me.btnNewUser.Size = New System.Drawing.Size(142, 74)
        Me.btnNewUser.TabIndex = 12
        Me.btnNewUser.Text = "New User"
        Me.btnNewUser.UseVisualStyleBackColor = True
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(795, 664)
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
        Me.Name = "Home"
        Me.Text = "Form1"
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
End Class
