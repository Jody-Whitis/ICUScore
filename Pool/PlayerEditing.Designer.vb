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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PlayerEditing))
        Me.btnBack = New System.Windows.Forms.Button()
        Me.cbPlayerNames = New System.Windows.Forms.ComboBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.tbEdit = New System.Windows.Forms.TextBox()
        Me.lblError = New System.Windows.Forms.Label()
        Me.mnuPlayerEditing = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditPasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblSelectedName = New System.Windows.Forms.Label()
        Me.lblNewName = New System.Windows.Forms.Label()
        Me.lblEditing = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.mnuPlayerEditing.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Lime
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(23, 573)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(183, 70)
        Me.btnBack.TabIndex = 5
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'cbPlayerNames
        '
        Me.cbPlayerNames.BackColor = System.Drawing.Color.Lime
        Me.cbPlayerNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPlayerNames.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbPlayerNames.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPlayerNames.FormattingEnabled = True
        Me.cbPlayerNames.Location = New System.Drawing.Point(108, 200)
        Me.cbPlayerNames.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbPlayerNames.Name = "cbPlayerNames"
        Me.cbPlayerNames.Size = New System.Drawing.Size(428, 47)
        Me.cbPlayerNames.TabIndex = 1
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Lime
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDelete.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(353, 422)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(183, 70)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.Lime
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEdit.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnEdit.Location = New System.Drawing.Point(108, 422)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(183, 70)
        Me.btnEdit.TabIndex = 3
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'tbEdit
        '
        Me.tbEdit.BackColor = System.Drawing.Color.Lime
        Me.tbEdit.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEdit.Location = New System.Drawing.Point(108, 336)
        Me.tbEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbEdit.Name = "tbEdit"
        Me.tbEdit.Size = New System.Drawing.Size(428, 41)
        Me.tbEdit.TabIndex = 2
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Location = New System.Drawing.Point(206, 44)
        Me.lblError.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(0, 25)
        Me.lblError.TabIndex = 5
        '
        'mnuPlayerEditing
        '
        Me.mnuPlayerEditing.BackColor = System.Drawing.Color.RoyalBlue
        Me.mnuPlayerEditing.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.mnuPlayerEditing.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.mnuPlayerEditing.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.mnuPlayerEditing.Location = New System.Drawing.Point(0, 0)
        Me.mnuPlayerEditing.Name = "mnuPlayerEditing"
        Me.mnuPlayerEditing.Size = New System.Drawing.Size(674, 41)
        Me.mnuPlayerEditing.TabIndex = 6
        Me.mnuPlayerEditing.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditPasswordToolStripMenuItem, Me.LogOutToolStripMenuItem, Me.QuitToolStripMenuItem})
        Me.MenuToolStripMenuItem.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(115, 37)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'EditPasswordToolStripMenuItem
        '
        Me.EditPasswordToolStripMenuItem.BackColor = System.Drawing.Color.RoyalBlue
        Me.EditPasswordToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.EditPasswordToolStripMenuItem.Name = "EditPasswordToolStripMenuItem"
        Me.EditPasswordToolStripMenuItem.Size = New System.Drawing.Size(360, 44)
        Me.EditPasswordToolStripMenuItem.Text = "Edit Password"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.BackColor = System.Drawing.Color.RoyalBlue
        Me.LogOutToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(360, 44)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.BackColor = System.Drawing.Color.RoyalBlue
        Me.QuitToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(360, 44)
        Me.QuitToolStripMenuItem.Text = "Quit"
        '
        'lblSelectedName
        '
        Me.lblSelectedName.AutoSize = True
        Me.lblSelectedName.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectedName.ForeColor = System.Drawing.Color.Lime
        Me.lblSelectedName.Location = New System.Drawing.Point(204, 156)
        Me.lblSelectedName.Name = "lblSelectedName"
        Me.lblSelectedName.Size = New System.Drawing.Size(263, 39)
        Me.lblSelectedName.TabIndex = 7
        Me.lblSelectedName.Text = "Selected Name"
        '
        'lblNewName
        '
        Me.lblNewName.AutoSize = True
        Me.lblNewName.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewName.ForeColor = System.Drawing.Color.Lime
        Me.lblNewName.Location = New System.Drawing.Point(231, 292)
        Me.lblNewName.Name = "lblNewName"
        Me.lblNewName.Size = New System.Drawing.Size(190, 39)
        Me.lblNewName.TabIndex = 8
        Me.lblNewName.Text = "New Name"
        Me.lblNewName.Visible = False
        '
        'lblEditing
        '
        Me.lblEditing.AutoSize = True
        Me.lblEditing.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEditing.ForeColor = System.Drawing.Color.Lime
        Me.lblEditing.Location = New System.Drawing.Point(255, 48)
        Me.lblEditing.Name = "lblEditing"
        Me.lblEditing.Size = New System.Drawing.Size(138, 39)
        Me.lblEditing.TabIndex = 9
        Me.lblEditing.Text = "Editing"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Lime
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAdd.Location = New System.Drawing.Point(454, 573)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(183, 70)
        Me.btnAdd.TabIndex = 10
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'PlayerEditing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.CancelButton = Me.btnBack
        Me.ClientSize = New System.Drawing.Size(674, 679)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblEditing)
        Me.Controls.Add(Me.lblNewName)
        Me.Controls.Add(Me.lblSelectedName)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.tbEdit)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.cbPlayerNames)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.mnuPlayerEditing)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuPlayerEditing
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "PlayerEditing"
        Me.Text = "PlayerEditing"
        Me.mnuPlayerEditing.ResumeLayout(False)
        Me.mnuPlayerEditing.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents cbPlayerNames As ComboBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents tbEdit As TextBox
    Friend WithEvents lblError As Label
    Friend WithEvents mnuPlayerEditing As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditPasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblSelectedName As Label
    Friend WithEvents lblNewName As Label
    Friend WithEvents lblEditing As Label
    Friend WithEvents btnAdd As Button
End Class
