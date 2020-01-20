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
        Me.btnPvP = New System.Windows.Forms.Button()
        Me.btnHS = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.lblHome = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPvP
        '
        Me.btnPvP.Location = New System.Drawing.Point(124, 205)
        Me.btnPvP.Name = "btnPvP"
        Me.btnPvP.Size = New System.Drawing.Size(196, 77)
        Me.btnPvP.TabIndex = 0
        Me.btnPvP.Text = "PVP"
        Me.btnPvP.UseVisualStyleBackColor = True
        '
        'btnHS
        '
        Me.btnHS.Location = New System.Drawing.Point(490, 205)
        Me.btnHS.Name = "btnHS"
        Me.btnHS.Size = New System.Drawing.Size(196, 77)
        Me.btnHS.TabIndex = 1
        Me.btnHS.Text = "HS"
        Me.btnHS.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(490, 361)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(196, 77)
        Me.btnQuit.TabIndex = 2
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'lblHome
        '
        Me.lblHome.AutoSize = True
        Me.lblHome.Location = New System.Drawing.Point(219, 62)
        Me.lblHome.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHome.Name = "lblHome"
        Me.lblHome.Size = New System.Drawing.Size(188, 25)
        Me.lblHome.TabIndex = 3
        Me.lblHome.Text = "Pick a Game Type"
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(241, 99)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(325, 31)
        Me.txtUser.TabIndex = 4
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(241, 151)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(325, 31)
        Me.txtPassword.TabIndex = 5
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(326, 207)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(140, 75)
        Me.btnLogin.TabIndex = 6
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(124, 361)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(196, 75)
        Me.btnLogout.TabIndex = 7
        Me.btnLogout.Text = "Log Out"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.lblHome)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnHS)
        Me.Controls.Add(Me.btnPvP)
        Me.Name = "Home"
        Me.Text = "Form1"
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
End Class
