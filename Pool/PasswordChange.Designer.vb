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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PasswordChange))
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.txtNewPasswordConfirm = New System.Windows.Forms.TextBox()
        Me.btnUpdatePassword = New System.Windows.Forms.Button()
        Me.lblUpdate = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtCurrentPassword = New System.Windows.Forms.TextBox()
        Me.lblCurrentPassword = New System.Windows.Forms.Label()
        Me.lblNewPassword = New System.Windows.Forms.Label()
        Me.lblConfirmPassword = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNewPassword
        '
        Me.txtNewPassword.BackColor = System.Drawing.Color.Aquamarine
        Me.txtNewPassword.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPassword.Location = New System.Drawing.Point(87, 320)
        Me.txtNewPassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPassword.Size = New System.Drawing.Size(356, 34)
        Me.txtNewPassword.TabIndex = 2
        '
        'txtNewPasswordConfirm
        '
        Me.txtNewPasswordConfirm.BackColor = System.Drawing.Color.Aquamarine
        Me.txtNewPasswordConfirm.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPasswordConfirm.Location = New System.Drawing.Point(87, 432)
        Me.txtNewPasswordConfirm.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNewPasswordConfirm.Name = "txtNewPasswordConfirm"
        Me.txtNewPasswordConfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPasswordConfirm.Size = New System.Drawing.Size(356, 34)
        Me.txtNewPasswordConfirm.TabIndex = 3
        '
        'btnUpdatePassword
        '
        Me.btnUpdatePassword.BackColor = System.Drawing.Color.Aquamarine
        Me.btnUpdatePassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdatePassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpdatePassword.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdatePassword.ForeColor = System.Drawing.Color.Black
        Me.btnUpdatePassword.Location = New System.Drawing.Point(377, 529)
        Me.btnUpdatePassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnUpdatePassword.Name = "btnUpdatePassword"
        Me.btnUpdatePassword.Size = New System.Drawing.Size(164, 86)
        Me.btnUpdatePassword.TabIndex = 5
        Me.btnUpdatePassword.Text = "Update Password"
        Me.btnUpdatePassword.UseVisualStyleBackColor = False
        '
        'lblUpdate
        '
        Me.lblUpdate.AutoSize = True
        Me.lblUpdate.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpdate.ForeColor = System.Drawing.Color.Aquamarine
        Me.lblUpdate.Location = New System.Drawing.Point(79, 86)
        Me.lblUpdate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUpdate.Name = "lblUpdate"
        Me.lblUpdate.Size = New System.Drawing.Size(366, 44)
        Me.lblUpdate.TabIndex = 3
        Me.lblUpdate.Text = "Password Update"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Aquamarine
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.Location = New System.Drawing.Point(13, 529)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(164, 86)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'txtCurrentPassword
        '
        Me.txtCurrentPassword.BackColor = System.Drawing.Color.Aquamarine
        Me.txtCurrentPassword.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrentPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtCurrentPassword.Location = New System.Drawing.Point(87, 210)
        Me.txtCurrentPassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCurrentPassword.Name = "txtCurrentPassword"
        Me.txtCurrentPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtCurrentPassword.Size = New System.Drawing.Size(356, 34)
        Me.txtCurrentPassword.TabIndex = 1
        '
        'lblCurrentPassword
        '
        Me.lblCurrentPassword.AutoSize = True
        Me.lblCurrentPassword.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentPassword.ForeColor = System.Drawing.Color.Aquamarine
        Me.lblCurrentPassword.Location = New System.Drawing.Point(146, 175)
        Me.lblCurrentPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCurrentPassword.Name = "lblCurrentPassword"
        Me.lblCurrentPassword.Size = New System.Drawing.Size(251, 30)
        Me.lblCurrentPassword.TabIndex = 6
        Me.lblCurrentPassword.Text = "Current Password"
        '
        'lblNewPassword
        '
        Me.lblNewPassword.AutoSize = True
        Me.lblNewPassword.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewPassword.ForeColor = System.Drawing.Color.Aquamarine
        Me.lblNewPassword.Location = New System.Drawing.Point(159, 285)
        Me.lblNewPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNewPassword.Name = "lblNewPassword"
        Me.lblNewPassword.Size = New System.Drawing.Size(201, 30)
        Me.lblNewPassword.TabIndex = 7
        Me.lblNewPassword.Text = "New Password"
        '
        'lblConfirmPassword
        '
        Me.lblConfirmPassword.AutoSize = True
        Me.lblConfirmPassword.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmPassword.ForeColor = System.Drawing.Color.Aquamarine
        Me.lblConfirmPassword.Location = New System.Drawing.Point(133, 397)
        Me.lblConfirmPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblConfirmPassword.Name = "lblConfirmPassword"
        Me.lblConfirmPassword.Size = New System.Drawing.Size(253, 30)
        Me.lblConfirmPassword.TabIndex = 8
        Me.lblConfirmPassword.Text = "Confirm Password"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.RoyalBlue
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(554, 41)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogOutToolStripMenuItem, Me.QuitToolStripMenuItem})
        Me.MenuToolStripMenuItem.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuToolStripMenuItem.ForeColor = System.Drawing.Color.Aquamarine
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(115, 37)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.BackColor = System.Drawing.Color.RoyalBlue
        Me.LogOutToolStripMenuItem.ForeColor = System.Drawing.Color.Aquamarine
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(263, 44)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.BackColor = System.Drawing.Color.RoyalBlue
        Me.QuitToolStripMenuItem.ForeColor = System.Drawing.Color.Aquamarine
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(263, 44)
        Me.QuitToolStripMenuItem.Text = "Quit"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem1})
        Me.AboutToolStripMenuItem.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutToolStripMenuItem.ForeColor = System.Drawing.Color.Aquamarine
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(128, 37)
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
        'PasswordChange
        '
        Me.AcceptButton = Me.btnUpdatePassword
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(554, 629)
        Me.Controls.Add(Me.lblConfirmPassword)
        Me.Controls.Add(Me.lblNewPassword)
        Me.Controls.Add(Me.lblCurrentPassword)
        Me.Controls.Add(Me.txtCurrentPassword)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblUpdate)
        Me.Controls.Add(Me.btnUpdatePassword)
        Me.Controls.Add(Me.txtNewPasswordConfirm)
        Me.Controls.Add(Me.txtNewPassword)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "PasswordChange"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PasswordChange"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents txtNewPasswordConfirm As TextBox
    Friend WithEvents btnUpdatePassword As Button
    Friend WithEvents lblUpdate As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtCurrentPassword As TextBox
    Friend WithEvents lblCurrentPassword As Label
    Friend WithEvents lblNewPassword As Label
    Friend WithEvents lblConfirmPassword As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As ToolStripMenuItem
End Class
