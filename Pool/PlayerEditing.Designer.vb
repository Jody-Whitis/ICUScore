<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlayerEditing
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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.cbPlayerNames = New System.Windows.Forms.ComboBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.tbEdit = New System.Windows.Forms.TextBox()
        Me.lblError = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(12, 176)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(122, 45)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'cbPlayerNames
        '
        Me.cbPlayerNames.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbPlayerNames.BackColor = System.Drawing.Color.Aquamarine
        Me.cbPlayerNames.FormattingEnabled = True
        Me.cbPlayerNames.Location = New System.Drawing.Point(98, 82)
        Me.cbPlayerNames.Name = "cbPlayerNames"
        Me.cbPlayerNames.Size = New System.Drawing.Size(202, 24)
        Me.cbPlayerNames.TabIndex = 1
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(268, 176)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(122, 45)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(140, 176)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(122, 45)
        Me.btnEdit.TabIndex = 3
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'tbEdit
        '
        Me.tbEdit.Location = New System.Drawing.Point(98, 124)
        Me.tbEdit.Name = "tbEdit"
        Me.tbEdit.Size = New System.Drawing.Size(202, 22)
        Me.tbEdit.TabIndex = 4
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Location = New System.Drawing.Point(137, 28)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(0, 17)
        Me.lblError.TabIndex = 5
        '
        'PlayerEditing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 309)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.tbEdit)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.cbPlayerNames)
        Me.Controls.Add(Me.btnBack)
        Me.Name = "PlayerEditing"
        Me.Text = "PlayerEditing"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents cbPlayerNames As ComboBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents tbEdit As TextBox
    Friend WithEvents lblError As Label
End Class
