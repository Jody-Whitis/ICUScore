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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPassword.Location = New System.Drawing.Point(87, 320)
        Me.txtNewPassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPassword.Size = New System.Drawing.Size(356, 34)
        Me.txtNewPassword.TabIndex = 0
        '
        'txtNewPasswordConfirm
        '
        Me.txtNewPasswordConfirm.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPasswordConfirm.Location = New System.Drawing.Point(87, 432)
        Me.txtNewPasswordConfirm.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNewPasswordConfirm.Name = "txtNewPasswordConfirm"
        Me.txtNewPasswordConfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPasswordConfirm.Size = New System.Drawing.Size(356, 34)
        Me.txtNewPasswordConfirm.TabIndex = 1
        '
        'btnUpdatePassword
        '
        Me.btnUpdatePassword.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdatePassword.ForeColor = System.Drawing.Color.Black
        Me.btnUpdatePassword.Location = New System.Drawing.Point(377, 529)
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
        Me.lblUpdate.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpdate.ForeColor = System.Drawing.Color.Lime
        Me.lblUpdate.Location = New System.Drawing.Point(79, 54)
        Me.lblUpdate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUpdate.Name = "lblUpdate"
        Me.lblUpdate.Size = New System.Drawing.Size(366, 44)
        Me.lblUpdate.TabIndex = 3
        Me.lblUpdate.Text = "Password Update"
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.Location = New System.Drawing.Point(13, 529)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(164, 86)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtCurrentPassword
        '
        Me.txtCurrentPassword.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrentPassword.Location = New System.Drawing.Point(87, 210)
        Me.txtCurrentPassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCurrentPassword.Name = "txtCurrentPassword"
        Me.txtCurrentPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtCurrentPassword.Size = New System.Drawing.Size(356, 34)
        Me.txtCurrentPassword.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(146, 175)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 30)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Current Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(159, 285)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(201, 30)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "New Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Lime
        Me.Label3.Location = New System.Drawing.Point(133, 397)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(253, 30)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Confirm Password"
        '
        'PasswordChange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(554, 629)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
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
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
