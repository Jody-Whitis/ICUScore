<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PasswordChange
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
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.txtNewPasswordConfirm = New System.Windows.Forms.TextBox()
        Me.btnUpdatePassword = New System.Windows.Forms.Button()
        Me.lblUpdate = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtCurrentPassword = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPassword.Location = New System.Drawing.Point(87, 222)
        Me.txtNewPassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPassword.Size = New System.Drawing.Size(356, 34)
        Me.txtNewPassword.TabIndex = 0
        '
        'txtNewPasswordConfirm
        '
        Me.txtNewPasswordConfirm.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPasswordConfirm.Location = New System.Drawing.Point(87, 302)
        Me.txtNewPasswordConfirm.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNewPasswordConfirm.Name = "txtNewPasswordConfirm"
        Me.txtNewPasswordConfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPasswordConfirm.Size = New System.Drawing.Size(356, 34)
        Me.txtNewPasswordConfirm.TabIndex = 1
        '
        'btnUpdatePassword
        '
        Me.btnUpdatePassword.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdatePassword.ForeColor = System.Drawing.Color.Green
        Me.btnUpdatePassword.Location = New System.Drawing.Point(319, 395)
        Me.btnUpdatePassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnUpdatePassword.Name = "btnUpdatePassword"
        Me.btnUpdatePassword.Size = New System.Drawing.Size(164, 86)
        Me.btnUpdatePassword.TabIndex = 2
        Me.btnUpdatePassword.Text = "Update Password"
        Me.btnUpdatePassword.UseVisualStyleBackColor = True
        '
        'lblUpdate
        '
        Me.lblUpdate.AutoSize = True
        Me.lblUpdate.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpdate.ForeColor = System.Drawing.Color.Lime
        Me.lblUpdate.Location = New System.Drawing.Point(146, 53)
        Me.lblUpdate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUpdate.Name = "lblUpdate"
        Me.lblUpdate.Size = New System.Drawing.Size(240, 30)
        Me.lblUpdate.TabIndex = 3
        Me.lblUpdate.Text = "Password Update"
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Green
        Me.btnCancel.Location = New System.Drawing.Point(33, 395)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(164, 86)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel Password"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtCurrentPassword
        '
        Me.txtCurrentPassword.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrentPassword.Location = New System.Drawing.Point(87, 144)
        Me.txtCurrentPassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCurrentPassword.Name = "txtCurrentPassword"
        Me.txtCurrentPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtCurrentPassword.Size = New System.Drawing.Size(356, 34)
        Me.txtCurrentPassword.TabIndex = 5
        '
        'PasswordChange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 528)
        Me.Controls.Add(Me.txtCurrentPassword)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblUpdate)
        Me.Controls.Add(Me.btnUpdatePassword)
        Me.Controls.Add(Me.txtNewPasswordConfirm)
        Me.Controls.Add(Me.txtNewPassword)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "PasswordChange"
        Me.Text = "PasswordChange"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents txtNewPasswordConfirm As TextBox
    Friend WithEvents btnUpdatePassword As Button
    Friend WithEvents lblUpdate As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtCurrentPassword As TextBox
End Class
