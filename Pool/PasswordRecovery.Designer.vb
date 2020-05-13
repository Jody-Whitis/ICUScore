<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PasswordRecovery
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PasswordRecovery))
        Me.tbEmailAddress = New System.Windows.Forms.TextBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.lblEmailAddress = New System.Windows.Forms.Label()
        Me.lblTempPassword = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tbEmailAddress
        '
        Me.tbEmailAddress.BackColor = System.Drawing.Color.Aquamarine
        Me.tbEmailAddress.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEmailAddress.Location = New System.Drawing.Point(242, 262)
        Me.tbEmailAddress.Name = "tbEmailAddress"
        Me.tbEmailAddress.Size = New System.Drawing.Size(356, 33)
        Me.tbEmailAddress.TabIndex = 0
        '
        'btnSend
        '
        Me.btnSend.BackColor = System.Drawing.Color.Aquamarine
        Me.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSend.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSend.Location = New System.Drawing.Point(242, 513)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(208, 121)
        Me.btnSend.TabIndex = 1
        Me.btnSend.Text = "Send Temporary Password"
        Me.btnSend.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Aquamarine
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(12, 513)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(176, 123)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.Aquamarine
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnConfirm.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.Location = New System.Drawing.Point(504, 515)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(176, 119)
        Me.btnConfirm.TabIndex = 3
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = False
        Me.btnConfirm.Visible = False
        '
        'tbPassword
        '
        Me.tbPassword.BackColor = System.Drawing.Color.Aquamarine
        Me.tbPassword.Location = New System.Drawing.Point(242, 352)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.Size = New System.Drawing.Size(356, 31)
        Me.tbPassword.TabIndex = 2
        Me.tbPassword.UseSystemPasswordChar = True
        Me.tbPassword.Visible = False
        '
        'lblEmailAddress
        '
        Me.lblEmailAddress.AutoSize = True
        Me.lblEmailAddress.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailAddress.ForeColor = System.Drawing.Color.Aquamarine
        Me.lblEmailAddress.Location = New System.Drawing.Point(51, 262)
        Me.lblEmailAddress.Name = "lblEmailAddress"
        Me.lblEmailAddress.Size = New System.Drawing.Size(165, 32)
        Me.lblEmailAddress.TabIndex = 5
        Me.lblEmailAddress.Text = "Email Address"
        '
        'lblTempPassword
        '
        Me.lblTempPassword.AutoSize = True
        Me.lblTempPassword.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTempPassword.ForeColor = System.Drawing.Color.Aquamarine
        Me.lblTempPassword.Location = New System.Drawing.Point(40, 352)
        Me.lblTempPassword.Name = "lblTempPassword"
        Me.lblTempPassword.Size = New System.Drawing.Size(176, 32)
        Me.lblTempPassword.TabIndex = 6
        Me.lblTempPassword.Text = "Temp Password"
        Me.lblTempPassword.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Aquamarine
        Me.Label3.Location = New System.Drawing.Point(150, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(408, 44)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Password Recovery"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Aquamarine
        Me.Label1.Location = New System.Drawing.Point(51, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(577, 64)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "You can send a temporary password more than once." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Confirm with the password sent" &
    " in the email."
        '
        'PasswordRecovery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(699, 658)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblTempPassword)
        Me.Controls.Add(Me.lblEmailAddress)
        Me.Controls.Add(Me.tbPassword)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.tbEmailAddress)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PasswordRecovery"
        Me.Text = "PasswordRecovery"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbEmailAddress As TextBox
    Friend WithEvents btnSend As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnConfirm As Button
    Friend WithEvents tbPassword As TextBox
    Friend WithEvents lblEmailAddress As Label
    Friend WithEvents lblTempPassword As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
End Class
