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
        Me.SuspendLayout()
        '
        'txtUseremail
        '
        Me.txtUseremail.Location = New System.Drawing.Point(175, 249)
        Me.txtUseremail.Name = "txtUseremail"
        Me.txtUseremail.Size = New System.Drawing.Size(357, 31)
        Me.txtUseremail.TabIndex = 0
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(175, 401)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(357, 31)
        Me.txtPassword.TabIndex = 1
        '
        'TxtPasswordConfirm
        '
        Me.TxtPasswordConfirm.Location = New System.Drawing.Point(175, 475)
        Me.TxtPasswordConfirm.Name = "TxtPasswordConfirm"
        Me.TxtPasswordConfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPasswordConfirm.Size = New System.Drawing.Size(357, 31)
        Me.TxtPasswordConfirm.TabIndex = 2
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(46, 552)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(170, 76)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(486, 552)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(170, 76)
        Me.btnConfirm.TabIndex = 4
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'cbCurrentPlayers
        '
        Me.cbCurrentPlayers.FormattingEnabled = True
        Me.cbCurrentPlayers.Location = New System.Drawing.Point(175, 302)
        Me.cbCurrentPlayers.Name = "cbCurrentPlayers"
        Me.cbCurrentPlayers.Size = New System.Drawing.Size(357, 33)
        Me.cbCurrentPlayers.TabIndex = 5
        '
        'txtDisplayName
        '
        Me.txtDisplayName.Location = New System.Drawing.Point(175, 341)
        Me.txtDisplayName.Name = "txtDisplayName"
        Me.txtDisplayName.Size = New System.Drawing.Size(357, 31)
        Me.txtDisplayName.TabIndex = 6
        Me.txtDisplayName.Visible = False
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 684)
        Me.Controls.Add(Me.txtDisplayName)
        Me.Controls.Add(Me.cbCurrentPlayers)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.TxtPasswordConfirm)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUseremail)
        Me.Name = "Register"
        Me.Text = "Register"
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
End Class
