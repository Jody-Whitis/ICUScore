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
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditPasswordToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlayerEditingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.cbGames.BackColor = System.Drawing.Color.Aquamarine
        Me.cbGames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGames.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbGames.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGames.FormattingEnabled = True
        Me.cbGames.Location = New System.Drawing.Point(101, 94)
        Me.cbGames.Margin = New System.Windows.Forms.Padding(2)
        Me.cbGames.Name = "cbGames"
        Me.cbGames.Size = New System.Drawing.Size(317, 27)
        Me.cbGames.TabIndex = 0
        '
        'cbPlayers
        '
        Me.cbPlayers.BackColor = System.Drawing.Color.Aquamarine
        Me.cbPlayers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPlayers.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbPlayers.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPlayers.FormattingEnabled = True
        Me.cbPlayers.Location = New System.Drawing.Point(101, 152)
        Me.cbPlayers.Margin = New System.Windows.Forms.Padding(2)
        Me.cbPlayers.Name = "cbPlayers"
        Me.cbPlayers.Size = New System.Drawing.Size(317, 27)
        Me.cbPlayers.TabIndex = 1
        '
        'txtScore
        '
        Me.txtScore.BackColor = System.Drawing.Color.Aquamarine
        Me.txtScore.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScore.Location = New System.Drawing.Point(101, 219)
        Me.txtScore.Margin = New System.Windows.Forms.Padding(2)
        Me.txtScore.Name = "txtScore"
        Me.txtScore.Size = New System.Drawing.Size(317, 24)
        Me.txtScore.TabIndex = 2
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.Aquamarine
        Me.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSubmit.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(177, 509)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(137, 52)
        Me.btnSubmit.TabIndex = 4
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Aquamarine
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(8, 595)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(92, 54)
        Me.btnBack.TabIndex = 5
        Me.btnBack.Text = "Home"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.Color.Aquamarine
        Me.lblError.Location = New System.Drawing.Point(187, 26)
        Me.lblError.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(136, 25)
        Me.lblError.TabIndex = 5
        Me.lblError.Text = "Stats Board"
        Me.lblError.Visible = False
        '
        'lstScores
        '
        Me.lstScores.BackColor = System.Drawing.Color.Aquamarine
        Me.lstScores.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstScores.FormattingEnabled = True
        Me.lstScores.HorizontalScrollbar = True
        Me.lstScores.ItemHeight = 20
        Me.lstScores.Location = New System.Drawing.Point(37, 364)
        Me.lstScores.Margin = New System.Windows.Forms.Padding(2)
        Me.lstScores.Name = "lstScores"
        Me.lstScores.Size = New System.Drawing.Size(434, 104)
        Me.lstScores.TabIndex = 6
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Aquamarine
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(413, 594)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(92, 54)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'txtNewGM
        '
        Me.txtNewGM.BackColor = System.Drawing.Color.Aquamarine
        Me.txtNewGM.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewGM.Location = New System.Drawing.Point(101, 296)
        Me.txtNewGM.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNewGM.Name = "txtNewGM"
        Me.txtNewGM.Size = New System.Drawing.Size(317, 24)
        Me.txtNewGM.TabIndex = 3
        Me.txtNewGM.Visible = False
        '
        'btnPvP
        '
        Me.btnPvP.BackColor = System.Drawing.Color.Aquamarine
        Me.btnPvP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPvP.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPvP.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPvP.Location = New System.Drawing.Point(282, 594)
        Me.btnPvP.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPvP.Name = "btnPvP"
        Me.btnPvP.Size = New System.Drawing.Size(92, 54)
        Me.btnPvP.TabIndex = 7
        Me.btnPvP.Text = "PvP"
        Me.btnPvP.UseVisualStyleBackColor = False
        '
        'mnuHighScore
        '
        Me.mnuHighScore.BackColor = System.Drawing.Color.RoyalBlue
        Me.mnuHighScore.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuHighScore.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.mnuHighScore.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.EditToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.mnuHighScore.Location = New System.Drawing.Point(0, 0)
        Me.mnuHighScore.Name = "mnuHighScore"
        Me.mnuHighScore.Padding = New System.Windows.Forms.Padding(4, 1, 0, 1)
        Me.mnuHighScore.Size = New System.Drawing.Size(516, 26)
        Me.mnuHighScore.TabIndex = 10
        Me.mnuHighScore.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.BackColor = System.Drawing.Color.RoyalBlue
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogOutToolStripMenuItem, Me.QuitToolStripMenuItem})
        Me.MenuToolStripMenuItem.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuToolStripMenuItem.ForeColor = System.Drawing.Color.Aquamarine
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(68, 24)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.BackColor = System.Drawing.Color.RoyalBlue
        Me.LogOutToolStripMenuItem.ForeColor = System.Drawing.Color.Aquamarine
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(151, 26)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.BackColor = System.Drawing.Color.RoyalBlue
        Me.QuitToolStripMenuItem.ForeColor = System.Drawing.Color.Aquamarine
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(151, 26)
        Me.QuitToolStripMenuItem.Text = "Quit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditPasswordToolStripMenuItem1, Me.PlayerEditingToolStripMenuItem})
        Me.EditToolStripMenuItem.ForeColor = System.Drawing.Color.Aquamarine
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(58, 24)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'EditPasswordToolStripMenuItem1
        '
        Me.EditPasswordToolStripMenuItem1.BackColor = System.Drawing.Color.RoyalBlue
        Me.EditPasswordToolStripMenuItem1.ForeColor = System.Drawing.Color.Aquamarine
        Me.EditPasswordToolStripMenuItem1.Name = "EditPasswordToolStripMenuItem1"
        Me.EditPasswordToolStripMenuItem1.Size = New System.Drawing.Size(216, 26)
        Me.EditPasswordToolStripMenuItem1.Text = "Edit Password"
        '
        'PlayerEditingToolStripMenuItem
        '
        Me.PlayerEditingToolStripMenuItem.BackColor = System.Drawing.Color.RoyalBlue
        Me.PlayerEditingToolStripMenuItem.ForeColor = System.Drawing.Color.Aquamarine
        Me.PlayerEditingToolStripMenuItem.Name = "PlayerEditingToolStripMenuItem"
        Me.PlayerEditingToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.PlayerEditingToolStripMenuItem.Text = "Player Editing"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem1})
        Me.AboutToolStripMenuItem.ForeColor = System.Drawing.Color.Aquamarine
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(79, 24)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.BackColor = System.Drawing.Color.RoyalBlue
        Me.AboutToolStripMenuItem1.ForeColor = System.Drawing.Color.Aquamarine
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(142, 26)
        Me.AboutToolStripMenuItem1.Text = "About"
        '
        'lblSelectedPlayer
        '
        Me.lblSelectedPlayer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSelectedPlayer.AutoSize = True
        Me.lblSelectedPlayer.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectedPlayer.ForeColor = System.Drawing.Color.Aquamarine
        Me.lblSelectedPlayer.Location = New System.Drawing.Point(173, 129)
        Me.lblSelectedPlayer.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSelectedPlayer.Name = "lblSelectedPlayer"
        Me.lblSelectedPlayer.Size = New System.Drawing.Size(152, 20)
        Me.lblSelectedPlayer.TabIndex = 11
        Me.lblSelectedPlayer.Text = "Selected Player"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.ForeColor = System.Drawing.Color.Aquamarine
        Me.lblScore.Location = New System.Drawing.Point(213, 198)
        Me.lblScore.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(61, 20)
        Me.lblScore.TabIndex = 12
        Me.lblScore.Text = "Score"
        '
        'lblNewGameMode
        '
        Me.lblNewGameMode.AutoSize = True
        Me.lblNewGameMode.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewGameMode.ForeColor = System.Drawing.Color.Aquamarine
        Me.lblNewGameMode.Location = New System.Drawing.Point(196, 273)
        Me.lblNewGameMode.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNewGameMode.Name = "lblNewGameMode"
        Me.lblNewGameMode.Size = New System.Drawing.Size(101, 20)
        Me.lblNewGameMode.TabIndex = 13
        Me.lblNewGameMode.Text = "New Mode"
        Me.lblNewGameMode.Visible = False
        '
        'lblScoreBoard
        '
        Me.lblScoreBoard.AutoSize = True
        Me.lblScoreBoard.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreBoard.ForeColor = System.Drawing.Color.Aquamarine
        Me.lblScoreBoard.Location = New System.Drawing.Point(185, 342)
        Me.lblScoreBoard.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblScoreBoard.Name = "lblScoreBoard"
        Me.lblScoreBoard.Size = New System.Drawing.Size(118, 20)
        Me.lblScoreBoard.TabIndex = 14
        Me.lblScoreBoard.Text = "ScoreBoard"
        Me.lblScoreBoard.Visible = False
        '
        'lblSelectedMode
        '
        Me.lblSelectedMode.AutoSize = True
        Me.lblSelectedMode.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectedMode.ForeColor = System.Drawing.Color.Aquamarine
        Me.lblSelectedMode.Location = New System.Drawing.Point(177, 71)
        Me.lblSelectedMode.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSelectedMode.Name = "lblSelectedMode"
        Me.lblSelectedMode.Size = New System.Drawing.Size(140, 20)
        Me.lblSelectedMode.TabIndex = 15
        Me.lblSelectedMode.Text = "Selected Mode"
        '
        'btnPlayerEditing
        '
        Me.btnPlayerEditing.BackColor = System.Drawing.Color.Aquamarine
        Me.btnPlayerEditing.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPlayerEditing.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPlayerEditing.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayerEditing.Location = New System.Drawing.Point(136, 594)
        Me.btnPlayerEditing.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPlayerEditing.Name = "btnPlayerEditing"
        Me.btnPlayerEditing.Size = New System.Drawing.Size(92, 54)
        Me.btnPlayerEditing.TabIndex = 6
        Me.btnPlayerEditing.Text = "Player Editing"
        Me.btnPlayerEditing.UseVisualStyleBackColor = False
        '
        'HighScores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.CancelButton = Me.btnBack
        Me.ClientSize = New System.Drawing.Size(516, 659)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuHighScore
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
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
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblSelectedPlayer As Label
    Friend WithEvents lblScore As Label
    Friend WithEvents lblNewGameMode As Label
    Friend WithEvents lblScoreBoard As Label
    Friend WithEvents lblSelectedMode As Label
    Friend WithEvents btnPlayerEditing As Button
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EditPasswordToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PlayerEditingToolStripMenuItem As ToolStripMenuItem
End Class
