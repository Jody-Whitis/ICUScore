<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProfileEditing
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProfileEditing))
        Me.cbTwoFactorEnabled = New System.Windows.Forms.CheckBox()
        Me.cbSubscribed = New System.Windows.Forms.CheckBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.cbDeactivate = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'cbTwoFactorEnabled
        '
        Me.cbTwoFactorEnabled.AutoSize = True
        Me.cbTwoFactorEnabled.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTwoFactorEnabled.ForeColor = System.Drawing.Color.Aquamarine
        Me.cbTwoFactorEnabled.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.cbTwoFactorEnabled.Location = New System.Drawing.Point(69, 379)
        Me.cbTwoFactorEnabled.Name = "cbTwoFactorEnabled"
        Me.cbTwoFactorEnabled.Size = New System.Drawing.Size(499, 43)
        Me.cbTwoFactorEnabled.TabIndex = 0
        Me.cbTwoFactorEnabled.Text = "Two-Factor Authentication"
        Me.cbTwoFactorEnabled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cbTwoFactorEnabled.UseVisualStyleBackColor = True
        '
        'cbSubscribed
        '
        Me.cbSubscribed.AutoSize = True
        Me.cbSubscribed.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSubscribed.ForeColor = System.Drawing.Color.Aquamarine
        Me.cbSubscribed.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.cbSubscribed.Location = New System.Drawing.Point(69, 301)
        Me.cbSubscribed.Name = "cbSubscribed"
        Me.cbSubscribed.Size = New System.Drawing.Size(238, 43)
        Me.cbSubscribed.TabIndex = 1
        Me.cbSubscribed.Text = "Subscribed"
        Me.cbSubscribed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cbSubscribed.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Aquamarine
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(12, 598)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(185, 94)
        Me.btnBack.TabIndex = 3
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Aquamarine
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(498, 598)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(185, 94)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'cbDeactivate
        '
        Me.cbDeactivate.AutoSize = True
        Me.cbDeactivate.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDeactivate.ForeColor = System.Drawing.Color.Aquamarine
        Me.cbDeactivate.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.cbDeactivate.Location = New System.Drawing.Point(69, 447)
        Me.cbDeactivate.Name = "cbDeactivate"
        Me.cbDeactivate.Size = New System.Drawing.Size(378, 43)
        Me.cbDeactivate.TabIndex = 2
        Me.cbDeactivate.Text = "Deactivate Account"
        Me.cbDeactivate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cbDeactivate.UseVisualStyleBackColor = True
        '
        'ProfileEditing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(695, 705)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.cbDeactivate)
        Me.Controls.Add(Me.cbSubscribed)
        Me.Controls.Add(Me.cbTwoFactorEnabled)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ProfileEditing"
        Me.Text = "ProfileEditing"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbTwoFactorEnabled As CheckBox
    Friend WithEvents cbSubscribed As CheckBox
    Friend WithEvents btnBack As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents cbDeactivate As CheckBox
End Class
