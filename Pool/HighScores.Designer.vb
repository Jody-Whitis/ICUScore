<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HighScores
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
        Me.components = New System.ComponentModel.Container()
        Me.cbGames = New System.Windows.Forms.ComboBox()
        Me.cbPlayers = New System.Windows.Forms.ComboBox()
        Me.txtScore = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblError = New System.Windows.Forms.Label()
        Me.SelAllScoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LocalResultsDataSet2 = New Pool.LocalResultsDataSet2()
        Me.SelAllScoresTableAdapter = New Pool.LocalResultsDataSet2TableAdapters.selAllScoresTableAdapter()
        Me.lstScores = New System.Windows.Forms.ListBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtNewGM = New System.Windows.Forms.TextBox()
        Me.btnPvP = New System.Windows.Forms.Button()
        Me.mnuHighScore = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditPasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.SelAllScoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocalResultsDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuHighScore.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbGames
        '
        Me.cbGames.BackColor = System.Drawing.Color.Aquamarine
        Me.cbGames.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGames.FormattingEnabled = True
        Me.cbGames.Location = New System.Drawing.Point(136, 116)
        Me.cbGames.Name = "cbGames"
        Me.cbGames.Size = New System.Drawing.Size(474, 38)
        Me.cbGames.TabIndex = 0
        '
        'cbPlayers
        '
        Me.cbPlayers.BackColor = System.Drawing.Color.Aquamarine
        Me.cbPlayers.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPlayers.FormattingEnabled = True
        Me.cbPlayers.Location = New System.Drawing.Point(208, 173)
        Me.cbPlayers.Name = "cbPlayers"
        Me.cbPlayers.Size = New System.Drawing.Size(320, 38)
        Me.cbPlayers.TabIndex = 1
        '
        'txtScore
        '
        Me.txtScore.BackColor = System.Drawing.Color.Aquamarine
        Me.txtScore.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScore.Location = New System.Drawing.Point(254, 223)
        Me.txtScore.Name = "txtScore"
        Me.txtScore.Size = New System.Drawing.Size(217, 34)
        Me.txtScore.TabIndex = 2
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.btnSubmit.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(220, 455)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(298, 69)
        Me.btnSubmit.TabIndex = 3
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.btnBack.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(620, 570)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(128, 94)
        Me.btnBack.TabIndex = 4
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.Location = New System.Drawing.Point(320, 47)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(101, 30)
        Me.lblError.TabIndex = 5
        Me.lblError.Text = "Label1"
        '
        'SelAllScoresBindingSource
        '
        Me.SelAllScoresBindingSource.DataMember = "selAllScores"
        Me.SelAllScoresBindingSource.DataSource = Me.LocalResultsDataSet2
        '
        'LocalResultsDataSet2
        '
        Me.LocalResultsDataSet2.DataSetName = "LocalResultsDataSet2"
        Me.LocalResultsDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SelAllScoresTableAdapter
        '
        Me.SelAllScoresTableAdapter.ClearBeforeFill = True
        '
        'lstScores
        '
        Me.lstScores.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstScores.FormattingEnabled = True
        Me.lstScores.ItemHeight = 33
        Me.lstScores.Location = New System.Drawing.Point(92, 295)
        Me.lstScores.Name = "lstScores"
        Me.lstScores.Size = New System.Drawing.Size(553, 103)
        Me.lstScores.TabIndex = 6
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.btnAdd.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(12, 578)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(128, 81)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'txtNewGM
        '
        Me.txtNewGM.BackColor = System.Drawing.Color.Aquamarine
        Me.txtNewGM.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewGM.Location = New System.Drawing.Point(254, 339)
        Me.txtNewGM.Name = "txtNewGM"
        Me.txtNewGM.Size = New System.Drawing.Size(217, 34)
        Me.txtNewGM.TabIndex = 8
        Me.txtNewGM.Visible = False
        '
        'btnPvP
        '
        Me.btnPvP.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.btnPvP.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPvP.Location = New System.Drawing.Point(306, 566)
        Me.btnPvP.Name = "btnPvP"
        Me.btnPvP.Size = New System.Drawing.Size(128, 94)
        Me.btnPvP.TabIndex = 9
        Me.btnPvP.Text = "PvP"
        Me.btnPvP.UseVisualStyleBackColor = False
        '
        'mnuHighScore
        '
        Me.mnuHighScore.BackColor = System.Drawing.Color.RoyalBlue
        Me.mnuHighScore.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuHighScore.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.mnuHighScore.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.mnuHighScore.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.mnuHighScore.Location = New System.Drawing.Point(0, 0)
        Me.mnuHighScore.Name = "mnuHighScore"
        Me.mnuHighScore.Size = New System.Drawing.Size(760, 42)
        Me.mnuHighScore.TabIndex = 10
        Me.mnuHighScore.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.BackColor = System.Drawing.Color.RoyalBlue
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditPasswordToolStripMenuItem, Me.LogOutToolStripMenuItem, Me.QuitToolStripMenuItem})
        Me.MenuToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(115, 38)
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
        'HighScores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(760, 677)
        Me.Controls.Add(Me.btnPvP)
        Me.Controls.Add(Me.txtNewGM)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lstScores)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtScore)
        Me.Controls.Add(Me.cbPlayers)
        Me.Controls.Add(Me.cbGames)
        Me.Controls.Add(Me.mnuHighScore)
        Me.MainMenuStrip = Me.mnuHighScore
        Me.Name = "HighScores"
        Me.Text = "HighScores"
        CType(Me.SelAllScoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocalResultsDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuHighScore.ResumeLayout(False)
        Me.mnuHighScore.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbGames As ComboBox
    Friend WithEvents cbPlayers As ComboBox
    Friend WithEvents txtScore As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents lblError As Label
    Friend WithEvents SelAllScoresBindingSource As BindingSource
    Friend WithEvents LocalResultsDataSet2 As LocalResultsDataSet2
    Friend WithEvents SelAllScoresTableAdapter As LocalResultsDataSet2TableAdapters.selAllScoresTableAdapter
    Friend WithEvents lstScores As ListBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtNewGM As TextBox
    Friend WithEvents btnPvP As Button
    Friend WithEvents mnuHighScore As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditPasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As ToolStripMenuItem
End Class
