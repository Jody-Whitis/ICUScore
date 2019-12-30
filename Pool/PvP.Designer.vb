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
        Me.tbEdit = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.txtWins = New System.Windows.Forms.TextBox()
        Me.txtWins2 = New System.Windows.Forms.TextBox()
        Me.lblError = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnReg = New System.Windows.Forms.Button()
        Me.PlayersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlayerNames = New Pool.PlayerNames()
        Me.LocalResultsDataSet = New Pool.LocalResultsDataSet()
        Me.LocalResultsDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlayersTableAdapter = New Pool.PlayerNamesTableAdapters.PlayersTableAdapter()
        Me.cbPlayer1 = New System.Windows.Forms.ComboBox()
        Me.cbPlayer2 = New System.Windows.Forms.ComboBox()
        Me.PlayersBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LocalResultsDataSet1 = New Pool.LocalResultsDataSet1()
        Me.PlayersTableAdapter1 = New Pool.LocalResultsDataSet1TableAdapters.PlayersTableAdapter()
        Me.btnPlayer1win = New System.Windows.Forms.Button()
        Me.btnPlayer2Wins = New System.Windows.Forms.Button()
        Me.btnHighScore = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lstAllWins = New System.Windows.Forms.ListBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.cbDelete = New System.Windows.Forms.ComboBox()
        Me.txtWinsagainst = New System.Windows.Forms.TextBox()
        Me.txtWinsAgainst2 = New System.Windows.Forms.TextBox()
        Me.txtTotalAgainst = New System.Windows.Forms.TextBox()
        Me.btnEdit = New System.Windows.Forms.Button()
        CType(Me.PlayersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerNames, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocalResultsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocalResultsDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayersBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocalResultsDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbEdit
        '
        Me.tbEdit.BackColor = System.Drawing.Color.Aquamarine
        Me.tbEdit.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEdit.Location = New System.Drawing.Point(343, 89)
        Me.tbEdit.Margin = New System.Windows.Forms.Padding(6)
        Me.tbEdit.Name = "tbEdit"
        Me.tbEdit.Size = New System.Drawing.Size(337, 34)
        Me.tbEdit.TabIndex = 0
        Me.tbEdit.Visible = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'txtWins
        '
        Me.txtWins.BackColor = System.Drawing.Color.Aquamarine
        Me.txtWins.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWins.Location = New System.Drawing.Point(194, 106)
        Me.txtWins.Margin = New System.Windows.Forms.Padding(6)
        Me.txtWins.Multiline = True
        Me.txtWins.Name = "txtWins"
        Me.txtWins.Size = New System.Drawing.Size(87, 62)
        Me.txtWins.TabIndex = 3
        '
        'txtWins2
        '
        Me.txtWins2.BackColor = System.Drawing.Color.Aquamarine
        Me.txtWins2.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWins2.Location = New System.Drawing.Point(727, 106)
        Me.txtWins2.Margin = New System.Windows.Forms.Padding(6)
        Me.txtWins2.Multiline = True
        Me.txtWins2.Name = "txtWins2"
        Me.txtWins2.Size = New System.Drawing.Size(82, 62)
        Me.txtWins2.TabIndex = 4
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(411, 184)
        Me.lblError.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(189, 79)
        Me.lblError.TabIndex = 6
        Me.lblError.Text = "Error"
        Me.lblError.Visible = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.btnSave.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(410, 625)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(6)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(224, 69)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnReg
        '
        Me.btnReg.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.btnReg.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReg.Location = New System.Drawing.Point(410, 438)
        Me.btnReg.Margin = New System.Windows.Forms.Padding(6)
        Me.btnReg.Name = "btnReg"
        Me.btnReg.Size = New System.Drawing.Size(224, 69)
        Me.btnReg.TabIndex = 11
        Me.btnReg.Text = "Register"
        Me.btnReg.UseVisualStyleBackColor = False
        '
        'PlayersBindingSource
        '
        Me.PlayersBindingSource.DataMember = "Players"
        Me.PlayersBindingSource.DataSource = Me.PlayerNames
        '
        'PlayerNames
        '
        Me.PlayerNames.DataSetName = "PlayerNames"
        Me.PlayerNames.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LocalResultsDataSet
        '
        Me.LocalResultsDataSet.DataSetName = "LocalResultsDataSet"
        Me.LocalResultsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LocalResultsDataSetBindingSource
        '
        Me.LocalResultsDataSetBindingSource.DataSource = Me.LocalResultsDataSet
        Me.LocalResultsDataSetBindingSource.Position = 0
        '
        'PlayersTableAdapter
        '
        Me.PlayersTableAdapter.ClearBeforeFill = True
        '
        'cbPlayer1
        '
        Me.cbPlayer1.BackColor = System.Drawing.Color.Aquamarine
        Me.cbPlayer1.DisplayMember = "PlayerName"
        Me.cbPlayer1.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPlayer1.FormattingEnabled = True
        Me.cbPlayer1.Location = New System.Drawing.Point(146, 54)
        Me.cbPlayer1.Margin = New System.Windows.Forms.Padding(6)
        Me.cbPlayer1.Name = "cbPlayer1"
        Me.cbPlayer1.Size = New System.Drawing.Size(238, 38)
        Me.cbPlayer1.TabIndex = 12
        Me.cbPlayer1.ValueMember = "PlayerName"
        '
        'cbPlayer2
        '
        Me.cbPlayer2.BackColor = System.Drawing.Color.Aquamarine
        Me.cbPlayer2.DisplayMember = "PlayerName"
        Me.cbPlayer2.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPlayer2.FormattingEnabled = True
        Me.cbPlayer2.Location = New System.Drawing.Point(633, 54)
        Me.cbPlayer2.Margin = New System.Windows.Forms.Padding(6)
        Me.cbPlayer2.Name = "cbPlayer2"
        Me.cbPlayer2.Size = New System.Drawing.Size(238, 38)
        Me.cbPlayer2.TabIndex = 14
        Me.cbPlayer2.ValueMember = "PlayerName"
        '
        'PlayersBindingSource1
        '
        Me.PlayersBindingSource1.DataMember = "Players"
        Me.PlayersBindingSource1.DataSource = Me.LocalResultsDataSet1
        '
        'LocalResultsDataSet1
        '
        Me.LocalResultsDataSet1.DataSetName = "LocalResultsDataSet1"
        Me.LocalResultsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PlayersTableAdapter1
        '
        Me.PlayersTableAdapter1.ClearBeforeFill = True
        '
        'btnPlayer1win
        '
        Me.btnPlayer1win.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.btnPlayer1win.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayer1win.Location = New System.Drawing.Point(10, 438)
        Me.btnPlayer1win.Margin = New System.Windows.Forms.Padding(6)
        Me.btnPlayer1win.Name = "btnPlayer1win"
        Me.btnPlayer1win.Size = New System.Drawing.Size(374, 69)
        Me.btnPlayer1win.TabIndex = 15
        Me.btnPlayer1win.Text = """Wins"" !"
        Me.btnPlayer1win.UseVisualStyleBackColor = False
        Me.btnPlayer1win.Visible = False
        '
        'btnPlayer2Wins
        '
        Me.btnPlayer2Wins.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.btnPlayer2Wins.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayer2Wins.Location = New System.Drawing.Point(656, 438)
        Me.btnPlayer2Wins.Margin = New System.Windows.Forms.Padding(6)
        Me.btnPlayer2Wins.Name = "btnPlayer2Wins"
        Me.btnPlayer2Wins.Size = New System.Drawing.Size(384, 69)
        Me.btnPlayer2Wins.TabIndex = 16
        Me.btnPlayer2Wins.Text = """Wins""!"
        Me.btnPlayer2Wins.UseVisualStyleBackColor = False
        Me.btnPlayer2Wins.Visible = False
        '
        'btnHighScore
        '
        Me.btnHighScore.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.btnHighScore.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHighScore.Location = New System.Drawing.Point(20, 625)
        Me.btnHighScore.Margin = New System.Windows.Forms.Padding(6)
        Me.btnHighScore.Name = "btnHighScore"
        Me.btnHighScore.Size = New System.Drawing.Size(261, 69)
        Me.btnHighScore.TabIndex = 17
        Me.btnHighScore.Text = "HighScores"
        Me.btnHighScore.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.btnBack.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(816, 625)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(6)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(235, 69)
        Me.btnBack.TabIndex = 18
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lstAllWins
        '
        Me.lstAllWins.BackColor = System.Drawing.Color.Aquamarine
        Me.lstAllWins.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstAllWins.ForeColor = System.Drawing.Color.Green
        Me.lstAllWins.FormattingEnabled = True
        Me.lstAllWins.ItemHeight = 44
        Me.lstAllWins.Location = New System.Drawing.Point(234, 293)
        Me.lstAllWins.Name = "lstAllWins"
        Me.lstAllWins.Size = New System.Drawing.Size(587, 136)
        Me.lstAllWins.TabIndex = 19
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.btnDelete.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(616, 533)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(6)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(224, 69)
        Me.btnDelete.TabIndex = 20
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        Me.btnDelete.Visible = False
        '
        'cbDelete
        '
        Me.cbDelete.BackColor = System.Drawing.Color.Aquamarine
        Me.cbDelete.DisplayMember = "PlayerName"
        Me.cbDelete.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDelete.FormattingEnabled = True
        Me.cbDelete.Location = New System.Drawing.Point(383, 39)
        Me.cbDelete.Margin = New System.Windows.Forms.Padding(6)
        Me.cbDelete.Name = "cbDelete"
        Me.cbDelete.Size = New System.Drawing.Size(238, 38)
        Me.cbDelete.TabIndex = 21
        Me.cbDelete.ValueMember = "PlayerName"
        Me.cbDelete.Visible = False
        '
        'txtWinsagainst
        '
        Me.txtWinsagainst.BackColor = System.Drawing.Color.Aquamarine
        Me.txtWinsagainst.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWinsagainst.Location = New System.Drawing.Point(194, 178)
        Me.txtWinsagainst.Margin = New System.Windows.Forms.Padding(6)
        Me.txtWinsagainst.Multiline = True
        Me.txtWinsagainst.Name = "txtWinsagainst"
        Me.txtWinsagainst.Size = New System.Drawing.Size(87, 62)
        Me.txtWinsagainst.TabIndex = 22
        '
        'txtWinsAgainst2
        '
        Me.txtWinsAgainst2.BackColor = System.Drawing.Color.Aquamarine
        Me.txtWinsAgainst2.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWinsAgainst2.Location = New System.Drawing.Point(722, 184)
        Me.txtWinsAgainst2.Margin = New System.Windows.Forms.Padding(6)
        Me.txtWinsAgainst2.Multiline = True
        Me.txtWinsAgainst2.Name = "txtWinsAgainst2"
        Me.txtWinsAgainst2.Size = New System.Drawing.Size(87, 62)
        Me.txtWinsAgainst2.TabIndex = 23
        '
        'txtTotalAgainst
        '
        Me.txtTotalAgainst.BackColor = System.Drawing.Color.Aquamarine
        Me.txtTotalAgainst.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalAgainst.Location = New System.Drawing.Point(410, 129)
        Me.txtTotalAgainst.Margin = New System.Windows.Forms.Padding(6)
        Me.txtTotalAgainst.Multiline = True
        Me.txtTotalAgainst.Name = "txtTotalAgainst"
        Me.txtTotalAgainst.Size = New System.Drawing.Size(175, 49)
        Me.txtTotalAgainst.TabIndex = 24
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.btnEdit.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(217, 533)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(6)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(224, 69)
        Me.btnEdit.TabIndex = 25
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        Me.btnEdit.Visible = False
        '
        'PvP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(1078, 752)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.txtTotalAgainst)
        Me.Controls.Add(Me.txtWinsAgainst2)
        Me.Controls.Add(Me.txtWinsagainst)
        Me.Controls.Add(Me.cbDelete)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.lstAllWins)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnHighScore)
        Me.Controls.Add(Me.btnPlayer2Wins)
        Me.Controls.Add(Me.btnPlayer1win)
        Me.Controls.Add(Me.cbPlayer2)
        Me.Controls.Add(Me.cbPlayer1)
        Me.Controls.Add(Me.btnReg)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.txtWins2)
        Me.Controls.Add(Me.txtWins)
        Me.Controls.Add(Me.tbEdit)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "PvP"
        Me.Text = "PvP"
        CType(Me.PlayersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerNames, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocalResultsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocalResultsDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayersBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocalResultsDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbEdit As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents txtWins As TextBox
    Friend WithEvents txtWins2 As TextBox
    Friend WithEvents lblError As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnReg As Button
    Friend WithEvents LocalResultsDataSetBindingSource As BindingSource
    Friend WithEvents LocalResultsDataSet As LocalResultsDataSet
    Friend WithEvents PlayerNames As PlayerNames
    Friend WithEvents PlayersBindingSource As BindingSource
    Friend WithEvents PlayersTableAdapter As PlayerNamesTableAdapters.PlayersTableAdapter
    Friend WithEvents cbPlayer1 As ComboBox
    Friend WithEvents cbPlayer2 As ComboBox
    Friend WithEvents LocalResultsDataSet1 As LocalResultsDataSet1
    Friend WithEvents PlayersBindingSource1 As BindingSource
    Friend WithEvents PlayersTableAdapter1 As LocalResultsDataSet1TableAdapters.PlayersTableAdapter
    Friend WithEvents btnPlayer1win As Button
    Friend WithEvents btnPlayer2Wins As Button
    Friend WithEvents btnHighScore As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents lstAllWins As ListBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents cbDelete As ComboBox
    Friend WithEvents txtWinsagainst As TextBox
    Friend WithEvents txtWinsAgainst2 As TextBox
    Friend WithEvents txtTotalAgainst As TextBox
    Friend WithEvents btnEdit As Button
End Class
