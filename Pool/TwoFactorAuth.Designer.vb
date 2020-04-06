<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TwoFactorAuth
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TwoFactorAuth))
        Me.tbCode = New System.Windows.Forms.TextBox()
        Me.btnResend = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblTwoFactor = New System.Windows.Forms.Label()
        Me.lblResend = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tbCode
        '
        Me.tbCode.BackColor = System.Drawing.Color.Aquamarine
        Me.tbCode.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCode.Location = New System.Drawing.Point(101, 168)
        Me.tbCode.Name = "tbCode"
        Me.tbCode.Size = New System.Drawing.Size(202, 24)
        Me.tbCode.TabIndex = 0
        Me.tbCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnResend
        '
        Me.btnResend.BackColor = System.Drawing.Color.Aquamarine
        Me.btnResend.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnResend.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResend.Location = New System.Drawing.Point(65, 217)
        Me.btnResend.Name = "btnResend"
        Me.btnResend.Size = New System.Drawing.Size(113, 60)
        Me.btnResend.TabIndex = 1
        Me.btnResend.Text = "Resend Code"
        Me.btnResend.UseVisualStyleBackColor = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.Aquamarine
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSubmit.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(223, 217)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(113, 60)
        Me.btnSubmit.TabIndex = 2
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Aquamarine
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(12, 326)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(113, 60)
        Me.btnBack.TabIndex = 3
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lblTwoFactor
        '
        Me.lblTwoFactor.AutoSize = True
        Me.lblTwoFactor.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTwoFactor.ForeColor = System.Drawing.Color.Aquamarine
        Me.lblTwoFactor.Location = New System.Drawing.Point(21, 67)
        Me.lblTwoFactor.Name = "lblTwoFactor"
        Me.lblTwoFactor.Size = New System.Drawing.Size(370, 25)
        Me.lblTwoFactor.TabIndex = 4
        Me.lblTwoFactor.Text = "Enter the code send to this email."
        '
        'lblResend
        '
        Me.lblResend.AutoSize = True
        Me.lblResend.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResend.ForeColor = System.Drawing.Color.Aquamarine
        Me.lblResend.Location = New System.Drawing.Point(21, 108)
        Me.lblResend.Name = "lblResend"
        Me.lblResend.Size = New System.Drawing.Size(359, 25)
        Me.lblResend.TabIndex = 5
        Me.lblResend.Text = "Click Resend to send a new code."
        '
        'TwoFactorAuth
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(427, 398)
        Me.Controls.Add(Me.lblResend)
        Me.Controls.Add(Me.lblTwoFactor)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnResend)
        Me.Controls.Add(Me.tbCode)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TwoFactorAuth"
        Me.Text = "Two-Factor Authentication"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbCode As TextBox
    Friend WithEvents btnResend As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents lblTwoFactor As Label
    Friend WithEvents lblResend As Label
End Class
