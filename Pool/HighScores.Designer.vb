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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HighScores))
        Me.cbGames = New System.Windows.Forms.ComboBox()
        Me.cbPlayers = New System.Windows.Forms.ComboBox()
        Me.txtScore = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblError = New System.Windows.Forms.Label()
        Me.lstScores = New System.Windows.Forms.ListBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtNewGM = New System.Windows.Forms.TextBox()
        Me.btnPvP = New System.Windows.Forms.Button()
        Me.mnuHighScore = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditPasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPlayerEditing = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblSelectedPlayer = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblNewGameMode = New System.Windows.Forms.Label()
        Me.lblScoreBoard = New System.Windows.Forms.Label()
        Me.lblSelectedMode = New System.Windows.Forms.Label()
        Me.btnPlayerEditing = New System.Windows.Forms.Button()
        Me.mnuHighScore.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbGames
        '
        Me.cbGames.BackColor = System.Drawing.Color.Lime
        Me.cbGames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGames.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbGames.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGames.FormattingEnabled = True
        Me.cbGames.Location = New System.Drawing.Point(152, 147)
        Me.cbGames.Name = "cbGames"
        Me.cbGames.Size = New System.Drawing.Size(474, 38)
        Me.cbGames.TabIndex = 0
        '
        'cbPlayers
        '
        Me.cbPlayers.BackColor = System.Drawing.Color.Lime
        Me.cbPlayers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPlayers.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbPlayers.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPlayers.FormattingEnabled = True
        Me.cbPlayers.Location = New System.Drawing.Point(152, 238)
        Me.cbPlayers.Name = "cbPlayers"
        Me.cbPlayers.Size = New System.Drawing.Size(474, 38)
        Me.cbPlayers.TabIndex = 1
        '
        'txtScore
        '
        Me.txtScore.BackColor = System.Drawing.Color.Lime
        Me.txtScore.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScore.Location = New System.Drawing.Point(152, 342)
        Me.txtScore.Name = "txtScore"
        Me.txtScore.Size = New System.Drawing.Size(474, 34)
        Me.txtScore.TabIndex = 2
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.Lime
        Me.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSubmit.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(266, 795)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(206, 81)
        Me.btnSubmit.TabIndex = 4
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Lime
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(12, 930)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(138, 84)
        Me.btnBack.TabIndex = 5
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.Color.Lime
        Me.lblError.Location = New System.Drawing.Point(277, 29)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(214, 39)
        Me.lblError.TabIndex = 5
        Me.lblError.Text = "Stats Board"
        Me.lblError.Visible = False
        '
        'lstScores
        '
        Me.lstScores.BackColor = System.Drawing.Color.Lime
        Me.lstScores.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstScores.FormattingEnabled = True
        Me.lstScores.ItemHeight = 33
        Me.lstScores.Location = New System.Drawing.Point(118, 570)
        Me.lstScores.Name = "lstScores"
        Me.lstScores.Size = New System.Drawing.Size(534, 169)
        Me.lstScores.TabIndex = 6
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Lime
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(620, 928)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(138, 84)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'txtNewGM
        '
        Me.txtNewGM.BackColor = System.Drawing.Color.Lime
        Me.txtNewGM.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewGM.Location = New System.Drawing.Point(152, 462)
        Me.txtNewGM.Name = "txtNewGM"
        Me.txtNewGM.Size = New System.Drawing.Size(474, 34)
        Me.txtNewGM.TabIndex = 3
        Me.txtNewGM.Visible = False
        '
        'btnPvP
        '
        Me.btnPvP.BackColor = System.Drawing.Color.Lime
        Me.btnPvP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPvP.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPvP.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPvP.Location = New System.Drawing.Point(423, 928)
        Me.btnPvP.Name = "btnPvP"
        Me.btnPvP.Size = New System.Drawing.Size(138, 84)
        Me.btnPvP.TabIndex = 7
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
        Me.mnuHighScore.Size = New System.Drawing.Size(774, 38)
        Me.mnuHighScore.TabIndex = 10
        Me.mnuHighScore.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.BackColor = System.Drawing.Color.RoyalBlue
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditPasswordToolStripMenuItem, Me.mnuPlayerEditing, Me.LogOutToolStripMenuItem, Me.QuitToolStripMenuItem})
        Me.MenuToolStripMenuItem.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(104, 34)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'EditPasswordToolStripMenuItem
        '
        Me.EditPasswordToolStripMenuItem.BackColor = System.Drawing.Color.RoyalBlue
        Me.EditPasswordToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.EditPasswordToolStripMenuItem.Name = "EditPasswordToolStripMenuItem"
        Me.EditPasswordToolStripMenuItem.Size = New System.Drawing.Size(331, 44)
        Me.EditPasswordToolStripMenuItem.Text = "Edit Password"
        '
        'mnuPlayerEditing
        '
        Me.mnuPlayerEditing.BackColor = System.Drawing.Color.RoyalBlue
        Me.mnuPlayerEditing.ForeColor = System.Drawing.Color.Lime
        Me.mnuPlayerEditing.Name = "mnuPlayerEditing"
        Me.mnuPlayerEditing.Size = New System.Drawing.Size(331, 44)
        Me.mnuPlayerEditing.Text = "Player Editing"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.BackColor = System.Drawing.Color.RoyalBlue
        Me.LogOutToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(331, 44)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.BackColor = System.Drawing.Color.RoyalBlue
        Me.QuitToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(331, 44)
        Me.QuitToolStripMenuItem.Text = "Quit"
        '
        'lblSelectedPlayer
        '
        Me.lblSelectedPlayer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSelectedPlayer.AutoSize = True
        Me.lblSelectedPlayer.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectedPlayer.ForeColor = System.Drawing.Color.Lime
        Me.lblSelectedPlayer.Location = New System.Drawing.Point(260, 202)
        Me.lblSelectedPlayer.Name = "lblSelectedPlayer"
        Me.lblSelectedPlayer.Size = New System.Drawing.Size(249, 33)
        Me.lblSelectedPlayer.TabIndex = 11
        Me.lblSelectedPlayer.Text = "Selected Player"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.ForeColor = System.Drawing.Color.Lime
        Me.lblScore.Location = New System.Drawing.Point(320, 309)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(99, 33)
        Me.lblScore.TabIndex = 12
        Me.lblScore.Text = "Score"
        '
        'lblNewGameMode
        '
        Me.lblNewGameMode.AutoSize = True
        Me.lblNewGameMode.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewGameMode.ForeColor = System.Drawing.Color.Lime
        Me.lblNewGameMode.Location = New System.Drawing.Point(294, 427)
        Me.lblNewGameMode.Name = "lblNewGameMode"
        Me.lblNewGameMode.Size = New System.Drawing.Size(163, 33)
        Me.lblNewGameMode.TabIndex = 13
        Me.lblNewGameMode.Text = "New Mode"
        Me.lblNewGameMode.Visible = False
        '
        'lblScoreBoard
        '
        Me.lblScoreBoard.AutoSize = True
        Me.lblScoreBoard.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreBoard.ForeColor = System.Drawing.Color.Lime
        Me.lblScoreBoard.Location = New System.Drawing.Point(278, 534)
        Me.lblScoreBoard.Name = "lblScoreBoard"
        Me.lblScoreBoard.Size = New System.Drawing.Size(189, 33)
        Me.lblScoreBoard.TabIndex = 14
        Me.lblScoreBoard.Text = "ScoreBoard"
        Me.lblScoreBoard.Visible = False
        '
        'lblSelectedMode
        '
        Me.lblSelectedMode.AutoSize = True
        Me.lblSelectedMode.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectedMode.ForeColor = System.Drawing.Color.Lime
        Me.lblSelectedMode.Location = New System.Drawing.Point(266, 111)
        Me.lblSelectedMode.Name = "lblSelectedMode"
        Me.lblSelectedMode.Size = New System.Drawing.Size(229, 33)
        Me.lblSelectedMode.TabIndex = 15
        Me.lblSelectedMode.Text = "Selected Mode"
        '
        'btnPlayerEditing
        '
        Me.btnPlayerEditing.BackColor = System.Drawing.Color.Lime
        Me.btnPlayerEditing.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPlayerEditing.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPlayerEditing.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayerEditing.Location = New System.Drawing.Point(204, 928)
        Me.btnPlayerEditing.Name = "btnPlayerEditing"
        Me.btnPlayerEditing.Size = New System.Drawing.Size(138, 84)
        Me.btnPlayerEditing.TabIndex = 6
        Me.btnPlayerEditing.Text = "Player Editing"
        Me.btnPlayerEditing.UseVisualStyleBackColor = False
        '
        'HighScores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.CancelButton = Me.btnBack
        Me.ClientSize = New System.Drawing.Size(774, 1030)
        Me.Controls.Add(Me.btnPlayerEditing)
        Me.Controls.Add(Me.lblSelectedMode)
        Me.Controls.Add(Me.lblScoreBoard)
        Me.Controls.Add(Me.lblNewGameMode)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblSelectedPlayer)
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
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuHighScore
        Me.Name = "HighScores"
        Me.Text = "HighScores"
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
    Friend WithEvents lstScores As ListBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtNewGM As TextBox
    Friend WithEvents btnPvP As Button
    Friend WithEvents mnuHighScore As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditPasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblSelectedPlayer As Label
    Friend WithEvents lblScore As Label
    Friend WithEvents lblNewGameMode As Label
    Friend WithEvents lblScoreBoard As Label
    Friend WithEvents lblSelectedMode As Label
    Friend WithEvents mnuPlayerEditing As ToolStripMenuItem
    Friend WithEvents btnPlayerEditing As Button
End Class
