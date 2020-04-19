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
        Me.tbEmailAddress = New System.Windows.Forms.TextBox()
        Me.tbDisplayName = New System.Windows.Forms.TextBox()
        Me.lblDisplayName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cbTwoFactorEnabled
        '
        Me.cbTwoFactorEnabled.AutoSize = True
        Me.cbTwoFactorEnabled.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTwoFactorEnabled.ForeColor = System.Drawing.Color.Aquamarine
        Me.cbTwoFactorEnabled.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.cbTwoFactorEnabled.Location = New System.Drawing.Point(46, 257)
        Me.cbTwoFactorEnabled.Margin = New System.Windows.Forms.Padding(2)
        Me.cbTwoFactorEnabled.Name = "cbTwoFactorEnabled"
        Me.cbTwoFactorEnabled.Size = New System.Drawing.Size(320, 29)
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
        Me.cbSubscribed.Location = New System.Drawing.Point(46, 224)
        Me.cbSubscribed.Margin = New System.Windows.Forms.Padding(2)
        Me.cbSubscribed.Name = "cbSubscribed"
        Me.cbSubscribed.Size = New System.Drawing.Size(151, 29)
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
        Me.btnBack.Location = New System.Drawing.Point(8, 383)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(123, 60)
        Me.btnBack.TabIndex = 3
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Aquamarine
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(332, 383)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(123, 60)
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
        Me.cbDeactivate.Location = New System.Drawing.Point(46, 290)
        Me.cbDeactivate.Margin = New System.Windows.Forms.Padding(2)
        Me.cbDeactivate.Name = "cbDeactivate"
        Me.cbDeactivate.Size = New System.Drawing.Size(242, 29)
        Me.cbDeactivate.TabIndex = 2
        Me.cbDeactivate.Text = "Deactivate Account"
        Me.cbDeactivate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cbDeactivate.UseVisualStyleBackColor = True
        Me.cbDeactivate.Visible = False
        '
        'tbEmailAddress
        '
        Me.tbEmailAddress.BackColor = System.Drawing.Color.Aquamarine
        Me.tbEmailAddress.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEmailAddress.Location = New System.Drawing.Point(175, 168)
        Me.tbEmailAddress.Name = "tbEmailAddress"
        Me.tbEmailAddress.Size = New System.Drawing.Size(280, 24)
        Me.tbEmailAddress.TabIndex = 5
        '
        'tbDisplayName
        '
        Me.tbDisplayName.BackColor = System.Drawing.Color.Aquamarine
        Me.tbDisplayName.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDisplayName.Location = New System.Drawing.Point(175, 109)
        Me.tbDisplayName.Name = "tbDisplayName"
        Me.tbDisplayName.Size = New System.Drawing.Size(280, 24)
        Me.tbDisplayName.TabIndex = 6
        '
        'lblDisplayName
        '
        Me.lblDisplayName.AutoSize = True
        Me.lblDisplayName.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplayName.ForeColor = System.Drawing.Color.Aquamarine
        Me.lblDisplayName.Location = New System.Drawing.Point(20, 113)
        Me.lblDisplayName.Name = "lblDisplayName"
        Me.lblDisplayName.Size = New System.Drawing.Size(126, 20)
        Me.lblDisplayName.TabIndex = 7
        Me.lblDisplayName.Text = "Display Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Aquamarine
        Me.Label1.Location = New System.Drawing.Point(12, 172)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Email Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Aquamarine
        Me.Label2.Location = New System.Drawing.Point(122, 353)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(213, 19)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Click Save for any changes made"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblTitle.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Aquamarine
        Me.lblTitle.Location = New System.Drawing.Point(19, 35)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(224, 25)
        Me.lblTitle.TabIndex = 10
        Me.lblTitle.Text = "Profile Settings for "
        '
        'ProfileEditing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(463, 451)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblDisplayName)
        Me.Controls.Add(Me.tbDisplayName)
        Me.Controls.Add(Me.tbEmailAddress)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.cbDeactivate)
        Me.Controls.Add(Me.cbSubscribed)
        Me.Controls.Add(Me.cbTwoFactorEnabled)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
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
    Friend WithEvents tbEmailAddress As TextBox
    Friend WithEvents tbDisplayName As TextBox
    Friend WithEvents lblDisplayName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTitle As Label
End Class
