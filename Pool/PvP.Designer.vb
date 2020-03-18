<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PvP
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PvP))
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.txtWins = New System.Windows.Forms.TextBox()
        Me.txtWins2 = New System.Windows.Forms.TextBox()
        Me.lblError = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.cbPlayer1 = New System.Windows.Forms.ComboBox()
        Me.cbPlayer2 = New System.Windows.Forms.ComboBox()
        Me.btnPlayer1win = New System.Windows.Forms.Button()
        Me.btnPlayer2Wins = New System.Windows.Forms.Button()
        Me.btnHighScore = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lstAllWins = New System.Windows.Forms.ListBox()
        Me.txtWinsagainst = New System.Windows.Forms.TextBox()
        Me.txtWinsAgainst2 = New System.Windows.Forms.TextBox()
        Me.txtTotalAgainst = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditPasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cbGames = New System.Windows.Forms.ComboBox()
        Me.btnRegisterTest = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPlayer1 = New System.Windows.Forms.Label()
        Me.lblPlayer2 = New System.Windows.Forms.Label()
        Me.lblTotalAgainst = New System.Windows.Forms.Label()
        Me.lblTotalWins1 = New System.Windows.Forms.Label()
        Me.lblTotalWins2 = New System.Windows.Forms.Label()
        Me.lblWinsAgainst1 = New System.Windows.Forms.Label()
        Me.lblWinsAgainst2 = New System.Windows.Forms.Label()
        Me.lblScoreBoard = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'txtWins
        '
        Me.txtWins.BackColor = System.Drawing.Color.Lime
        Me.txtWins.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWins.Location = New System.Drawing.Point(20, 336)
        Me.txtWins.Margin = New System.Windows.Forms.Padding(6)
        Me.txtWins.Multiline = True
        Me.txtWins.Name = "txtWins"
        Me.txtWins.ReadOnly = True
        Me.txtWins.Size = New System.Drawing.Size(186, 48)
        Me.txtWins.TabIndex = 4
        Me.txtWins.Visible = False
        '
        'txtWins2
        '
        Me.txtWins2.BackColor = System.Drawing.Color.Lime
        Me.txtWins2.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWins2.Location = New System.Drawing.Point(778, 336)
        Me.txtWins2.Margin = New System.Windows.Forms.Padding(6)
        Me.txtWins2.Multiline = True
        Me.txtWins2.Name = "txtWins2"
        Me.txtWins2.ReadOnly = True
        Me.txtWins2.Size = New System.Drawing.Size(186, 48)
        Me.txtWins2.TabIndex = 5
        Me.txtWins2.Visible = False
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(386, 61)
        Me.lblError.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(131, 55)
        Me.lblError.TabIndex = 6
        Me.lblError.Text = "Error"
        Me.lblError.Visible = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Lime
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(364, 811)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(6)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(236, 69)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'cbPlayer1
        '
        Me.cbPlayer1.BackColor = System.Drawing.Color.Lime
        Me.cbPlayer1.DisplayMember = "PlayerName"
        Me.cbPlayer1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPlayer1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbPlayer1.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPlayer1.FormattingEnabled = True
        Me.cbPlayer1.Location = New System.Drawing.Point(18, 164)
        Me.cbPlayer1.Margin = New System.Windows.Forms.Padding(6)
        Me.cbPlayer1.Name = "cbPlayer1"
        Me.cbPlayer1.Size = New System.Drawing.Size(322, 38)
        Me.cbPlayer1.Sorted = True
        Me.cbPlayer1.TabIndex = 1
        Me.cbPlayer1.ValueMember = "PlayerName"
        '
        'cbPlayer2
        '
        Me.cbPlayer2.BackColor = System.Drawing.Color.Lime
        Me.cbPlayer2.DisplayMember = "PlayerName"
        Me.cbPlayer2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPlayer2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbPlayer2.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPlayer2.FormattingEnabled = True
        Me.cbPlayer2.Location = New System.Drawing.Point(645, 164)
        Me.cbPlayer2.Margin = New System.Windows.Forms.Padding(6)
        Me.cbPlayer2.Name = "cbPlayer2"
        Me.cbPlayer2.Size = New System.Drawing.Size(319, 38)
        Me.cbPlayer2.TabIndex = 2
        Me.cbPlayer2.ValueMember = "PlayerName"
        '
        'btnPlayer1win
        '
        Me.btnPlayer1win.BackColor = System.Drawing.Color.Lime
        Me.btnPlayer1win.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPlayer1win.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPlayer1win.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayer1win.Location = New System.Drawing.Point(20, 812)
        Me.btnPlayer1win.Margin = New System.Windows.Forms.Padding(6)
        Me.btnPlayer1win.Name = "btnPlayer1win"
        Me.btnPlayer1win.Size = New System.Drawing.Size(324, 69)
        Me.btnPlayer1win.TabIndex = 14
        Me.btnPlayer1win.Text = """Wins"" !"
        Me.btnPlayer1win.UseVisualStyleBackColor = False
        Me.btnPlayer1win.Visible = False
        '
        'btnPlayer2Wins
        '
        Me.btnPlayer2Wins.BackColor = System.Drawing.Color.Lime
        Me.btnPlayer2Wins.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPlayer2Wins.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPlayer2Wins.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayer2Wins.Location = New System.Drawing.Point(634, 812)
        Me.btnPlayer2Wins.Margin = New System.Windows.Forms.Padding(6)
        Me.btnPlayer2Wins.Name = "btnPlayer2Wins"
        Me.btnPlayer2Wins.Size = New System.Drawing.Size(327, 69)
        Me.btnPlayer2Wins.TabIndex = 15
        Me.btnPlayer2Wins.Text = """Wins""!"
        Me.btnPlayer2Wins.UseVisualStyleBackColor = False
        Me.btnPlayer2Wins.Visible = False
        '
        'btnHighScore
        '
        Me.btnHighScore.BackColor = System.Drawing.Color.Lime
        Me.btnHighScore.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHighScore.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnHighScore.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHighScore.Location = New System.Drawing.Point(700, 930)
        Me.btnHighScore.Margin = New System.Windows.Forms.Padding(6)
        Me.btnHighScore.Name = "btnHighScore"
        Me.btnHighScore.Size = New System.Drawing.Size(261, 69)
        Me.btnHighScore.TabIndex = 13
        Me.btnHighScore.Text = "HighScores"
        Me.btnHighScore.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Lime
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(20, 930)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(6)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(236, 69)
        Me.btnBack.TabIndex = 11
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lstAllWins
        '
        Me.lstAllWins.BackColor = System.Drawing.Color.Lime
        Me.lstAllWins.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 8.0!)
        Me.lstAllWins.ForeColor = System.Drawing.Color.Black
        Me.lstAllWins.FormattingEnabled = True
        Me.lstAllWins.ItemHeight = 30
        Me.lstAllWins.Location = New System.Drawing.Point(20, 586)
        Me.lstAllWins.Name = "lstAllWins"
        Me.lstAllWins.Size = New System.Drawing.Size(940, 154)
        Me.lstAllWins.TabIndex = 9
        '
        'txtWinsagainst
        '
        Me.txtWinsagainst.BackColor = System.Drawing.Color.Lime
        Me.txtWinsagainst.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWinsagainst.Location = New System.Drawing.Point(20, 472)
        Me.txtWinsagainst.Margin = New System.Windows.Forms.Padding(6)
        Me.txtWinsagainst.Multiline = True
        Me.txtWinsagainst.Name = "txtWinsagainst"
        Me.txtWinsagainst.ReadOnly = True
        Me.txtWinsagainst.Size = New System.Drawing.Size(186, 51)
        Me.txtWinsagainst.TabIndex = 6
        '
        'txtWinsAgainst2
        '
        Me.txtWinsAgainst2.BackColor = System.Drawing.Color.Lime
        Me.txtWinsAgainst2.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWinsAgainst2.Location = New System.Drawing.Point(774, 472)
        Me.txtWinsAgainst2.Margin = New System.Windows.Forms.Padding(6)
        Me.txtWinsAgainst2.Multiline = True
        Me.txtWinsAgainst2.Name = "txtWinsAgainst2"
        Me.txtWinsAgainst2.ReadOnly = True
        Me.txtWinsAgainst2.Size = New System.Drawing.Size(186, 52)
        Me.txtWinsAgainst2.TabIndex = 8
        '
        'txtTotalAgainst
        '
        Me.txtTotalAgainst.BackColor = System.Drawing.Color.Lime
        Me.txtTotalAgainst.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalAgainst.Location = New System.Drawing.Point(394, 472)
        Me.txtTotalAgainst.Margin = New System.Windows.Forms.Padding(6)
        Me.txtTotalAgainst.Multiline = True
        Me.txtTotalAgainst.Name = "txtTotalAgainst"
        Me.txtTotalAgainst.ReadOnly = True
        Me.txtTotalAgainst.Size = New System.Drawing.Size(187, 49)
        Me.txtTotalAgainst.TabIndex = 7
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.RoyalBlue
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(974, 41)
        Me.MenuStrip1.TabIndex = 26
        Me.MenuStrip1.Text = "MenuStrip1"
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
        Me.LogOutToolStripMenuItem.Text = "Log out"
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.BackColor = System.Drawing.Color.RoyalBlue
        Me.QuitToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(360, 44)
        Me.QuitToolStripMenuItem.Text = "Quit"
        '
        'cbGames
        '
        Me.cbGames.BackColor = System.Drawing.Color.Lime
        Me.cbGames.DisplayMember = "PlayerName"
        Me.cbGames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGames.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbGames.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGames.FormattingEnabled = True
        Me.cbGames.Location = New System.Drawing.Point(269, 336)
        Me.cbGames.Margin = New System.Windows.Forms.Padding(6)
        Me.cbGames.Name = "cbGames"
        Me.cbGames.Size = New System.Drawing.Size(444, 38)
        Me.cbGames.TabIndex = 3
        Me.cbGames.ValueMember = "PlayerName"
        Me.cbGames.Visible = False
        '
        'btnRegisterTest
        '
        Me.btnRegisterTest.BackColor = System.Drawing.Color.Lime
        Me.btnRegisterTest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegisterTest.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRegisterTest.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegisterTest.Location = New System.Drawing.Point(364, 929)
        Me.btnRegisterTest.Margin = New System.Windows.Forms.Padding(6)
        Me.btnRegisterTest.Name = "btnRegisterTest"
        Me.btnRegisterTest.Size = New System.Drawing.Size(236, 70)
        Me.btnRegisterTest.TabIndex = 12
        Me.btnRegisterTest.Text = "Player Edit"
        Me.btnRegisterTest.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(365, 291)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 33)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Selected Game"
        '
        'lblPlayer1
        '
        Me.lblPlayer1.AutoSize = True
        Me.lblPlayer1.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayer1.ForeColor = System.Drawing.Color.Lime
        Me.lblPlayer1.Location = New System.Drawing.Point(18, 119)
        Me.lblPlayer1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPlayer1.Name = "lblPlayer1"
        Me.lblPlayer1.Size = New System.Drawing.Size(166, 42)
        Me.lblPlayer1.TabIndex = 30
        Me.lblPlayer1.Text = "Player 1"
        '
        'lblPlayer2
        '
        Me.lblPlayer2.AutoSize = True
        Me.lblPlayer2.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayer2.ForeColor = System.Drawing.Color.Lime
        Me.lblPlayer2.Location = New System.Drawing.Point(814, 119)
        Me.lblPlayer2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPlayer2.Name = "lblPlayer2"
        Me.lblPlayer2.Size = New System.Drawing.Size(166, 42)
        Me.lblPlayer2.TabIndex = 31
        Me.lblPlayer2.Text = "Player 2"
        '
        'lblTotalAgainst
        '
        Me.lblTotalAgainst.AutoSize = True
        Me.lblTotalAgainst.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAgainst.ForeColor = System.Drawing.Color.Lime
        Me.lblTotalAgainst.Location = New System.Drawing.Point(342, 427)
        Me.lblTotalAgainst.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalAgainst.Name = "lblTotalAgainst"
        Me.lblTotalAgainst.Size = New System.Drawing.Size(292, 30)
        Me.lblTotalAgainst.TabIndex = 32
        Me.lblTotalAgainst.Text = "Total P1 vs P2 Games"
        '
        'lblTotalWins1
        '
        Me.lblTotalWins1.AutoSize = True
        Me.lblTotalWins1.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalWins1.ForeColor = System.Drawing.Color.Lime
        Me.lblTotalWins1.Location = New System.Drawing.Point(12, 291)
        Me.lblTotalWins1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalWins1.Name = "lblTotalWins1"
        Me.lblTotalWins1.Size = New System.Drawing.Size(149, 30)
        Me.lblTotalWins1.TabIndex = 33
        Me.lblTotalWins1.Text = "Total Wins"
        '
        'lblTotalWins2
        '
        Me.lblTotalWins2.AutoSize = True
        Me.lblTotalWins2.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalWins2.ForeColor = System.Drawing.Color.Lime
        Me.lblTotalWins2.Location = New System.Drawing.Point(783, 291)
        Me.lblTotalWins2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalWins2.Name = "lblTotalWins2"
        Me.lblTotalWins2.Size = New System.Drawing.Size(149, 30)
        Me.lblTotalWins2.TabIndex = 34
        Me.lblTotalWins2.Text = "Total Wins"
        '
        'lblWinsAgainst1
        '
        Me.lblWinsAgainst1.AutoSize = True
        Me.lblWinsAgainst1.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWinsAgainst1.ForeColor = System.Drawing.Color.Lime
        Me.lblWinsAgainst1.Location = New System.Drawing.Point(12, 427)
        Me.lblWinsAgainst1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWinsAgainst1.Name = "lblWinsAgainst1"
        Me.lblWinsAgainst1.Size = New System.Drawing.Size(230, 30)
        Me.lblWinsAgainst1.TabIndex = 35
        Me.lblWinsAgainst1.Text = "Times beaten P2"
        '
        'lblWinsAgainst2
        '
        Me.lblWinsAgainst2.AutoSize = True
        Me.lblWinsAgainst2.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWinsAgainst2.ForeColor = System.Drawing.Color.Lime
        Me.lblWinsAgainst2.Location = New System.Drawing.Point(736, 427)
        Me.lblWinsAgainst2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWinsAgainst2.Name = "lblWinsAgainst2"
        Me.lblWinsAgainst2.Size = New System.Drawing.Size(230, 30)
        Me.lblWinsAgainst2.TabIndex = 36
        Me.lblWinsAgainst2.Text = "Times beaten P1"
        '
        'lblScoreBoard
        '
        Me.lblScoreBoard.AutoSize = True
        Me.lblScoreBoard.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreBoard.ForeColor = System.Drawing.Color.Lime
        Me.lblScoreBoard.Location = New System.Drawing.Point(316, 544)
        Me.lblScoreBoard.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblScoreBoard.Name = "lblScoreBoard"
        Me.lblScoreBoard.Size = New System.Drawing.Size(370, 42)
        Me.lblScoreBoard.TabIndex = 37
        Me.lblScoreBoard.Text = "Current ScoreBoard"
        '
        'PvP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.CancelButton = Me.btnBack
        Me.ClientSize = New System.Drawing.Size(974, 1029)
        Me.Controls.Add(Me.lblScoreBoard)
        Me.Controls.Add(Me.lblWinsAgainst2)
        Me.Controls.Add(Me.lblWinsAgainst1)
        Me.Controls.Add(Me.lblTotalWins2)
        Me.Controls.Add(Me.lblTotalWins1)
        Me.Controls.Add(Me.lblTotalAgainst)
        Me.Controls.Add(Me.lblPlayer2)
        Me.Controls.Add(Me.lblPlayer1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRegisterTest)
        Me.Controls.Add(Me.cbGames)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.txtTotalAgainst)
        Me.Controls.Add(Me.txtWinsAgainst2)
        Me.Controls.Add(Me.txtWinsagainst)
        Me.Controls.Add(Me.lstAllWins)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnHighScore)
        Me.Controls.Add(Me.btnPlayer2Wins)
        Me.Controls.Add(Me.btnPlayer1win)
        Me.Controls.Add(Me.cbPlayer2)
        Me.Controls.Add(Me.cbPlayer1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.txtWins2)
        Me.Controls.Add(Me.txtWins)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "PvP"
        Me.Text = "PvP"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents txtWins As TextBox
    Friend WithEvents txtWins2 As TextBox
    Friend WithEvents lblError As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents cbPlayer1 As ComboBox
    Friend WithEvents cbPlayer2 As ComboBox
    Friend WithEvents btnPlayer1win As Button
    Friend WithEvents btnPlayer2Wins As Button
    Friend WithEvents btnHighScore As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents lstAllWins As ListBox
    Friend WithEvents txtWinsagainst As TextBox
    Friend WithEvents txtWinsAgainst2 As TextBox
    Friend WithEvents txtTotalAgainst As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditPasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cbGames As ComboBox
    Friend WithEvents btnRegisterTest As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblPlayer1 As Label
    Friend WithEvents lblPlayer2 As Label
    Friend WithEvents lblTotalAgainst As Label
    Friend WithEvents lblTotalWins1 As Label
    Friend WithEvents lblTotalWins2 As Label
    Friend WithEvents lblWinsAgainst1 As Label
    Friend WithEvents lblWinsAgainst2 As Label
    Friend WithEvents lblScoreBoard As Label
End Class
