<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.tbPlayer1 = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tbPlayer2 = New System.Windows.Forms.TextBox()
        Me.txtWins = New System.Windows.Forms.TextBox()
        Me.txtWins2 = New System.Windows.Forms.TextBox()
        Me.txtResults = New System.Windows.Forms.TextBox()
        Me.lblError = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.cbPlayer1Win = New System.Windows.Forms.CheckBox()
        Me.cbPlayer2Win = New System.Windows.Forms.CheckBox()
        Me.groupWinner = New System.Windows.Forms.GroupBox()
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
        Me.groupWinner.SuspendLayout()
        CType(Me.PlayersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerNames, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocalResultsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocalResultsDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayersBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocalResultsDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbPlayer1
        '
        Me.tbPlayer1.Location = New System.Drawing.Point(75, 55)
        Me.tbPlayer1.Name = "tbPlayer1"
        Me.tbPlayer1.Size = New System.Drawing.Size(161, 20)
        Me.tbPlayer1.TabIndex = 0
        Me.tbPlayer1.Visible = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'tbPlayer2
        '
        Me.tbPlayer2.Location = New System.Drawing.Point(260, 55)
        Me.tbPlayer2.Name = "tbPlayer2"
        Me.tbPlayer2.Size = New System.Drawing.Size(161, 20)
        Me.tbPlayer2.TabIndex = 2
        Me.tbPlayer2.Visible = False
        '
        'txtWins
        '
        Me.txtWins.Location = New System.Drawing.Point(134, 81)
        Me.txtWins.Name = "txtWins"
        Me.txtWins.Size = New System.Drawing.Size(33, 20)
        Me.txtWins.TabIndex = 3
        '
        'txtWins2
        '
        Me.txtWins2.Location = New System.Drawing.Point(336, 81)
        Me.txtWins2.Name = "txtWins2"
        Me.txtWins2.Size = New System.Drawing.Size(30, 20)
        Me.txtWins2.TabIndex = 4
        '
        'txtResults
        '
        Me.txtResults.Location = New System.Drawing.Point(150, 226)
        Me.txtResults.Multiline = True
        Me.txtResults.Name = "txtResults"
        Me.txtResults.Size = New System.Drawing.Size(216, 37)
        Me.txtResults.TabIndex = 5
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(141, 154)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(95, 39)
        Me.lblError.TabIndex = 6
        Me.lblError.Text = "Error"
        Me.lblError.Visible = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(205, 333)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(112, 36)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'cbPlayer1Win
        '
        Me.cbPlayer1Win.AutoSize = True
        Me.cbPlayer1Win.Location = New System.Drawing.Point(16, 21)
        Me.cbPlayer1Win.Name = "cbPlayer1Win"
        Me.cbPlayer1Win.Size = New System.Drawing.Size(45, 17)
        Me.cbPlayer1Win.TabIndex = 8
        Me.cbPlayer1Win.Text = "Win"
        Me.cbPlayer1Win.UseVisualStyleBackColor = True
        '
        'cbPlayer2Win
        '
        Me.cbPlayer2Win.AutoSize = True
        Me.cbPlayer2Win.Location = New System.Drawing.Point(281, 19)
        Me.cbPlayer2Win.Name = "cbPlayer2Win"
        Me.cbPlayer2Win.Size = New System.Drawing.Size(45, 17)
        Me.cbPlayer2Win.TabIndex = 9
        Me.cbPlayer2Win.Text = "Win"
        Me.cbPlayer2Win.UseVisualStyleBackColor = True
        '
        'groupWinner
        '
        Me.groupWinner.Controls.Add(Me.cbPlayer1Win)
        Me.groupWinner.Controls.Add(Me.cbPlayer2Win)
        Me.groupWinner.Location = New System.Drawing.Point(95, 107)
        Me.groupWinner.Name = "groupWinner"
        Me.groupWinner.Size = New System.Drawing.Size(332, 44)
        Me.groupWinner.TabIndex = 10
        Me.groupWinner.TabStop = False
        Me.groupWinner.Text = "Winner"
        '
        'btnReg
        '
        Me.btnReg.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.btnReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReg.Location = New System.Drawing.Point(205, 269)
        Me.btnReg.Name = "btnReg"
        Me.btnReg.Size = New System.Drawing.Size(112, 36)
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
        Me.cbPlayer1.DataSource = Me.PlayersBindingSource
        Me.cbPlayer1.DisplayMember = "PlayerName"
        Me.cbPlayer1.FormattingEnabled = True
        Me.cbPlayer1.Location = New System.Drawing.Point(95, 28)
        Me.cbPlayer1.Name = "cbPlayer1"
        Me.cbPlayer1.Size = New System.Drawing.Size(121, 21)
        Me.cbPlayer1.TabIndex = 12
        Me.cbPlayer1.ValueMember = "PlayerName"
        '
        'cbPlayer2
        '
        Me.cbPlayer2.DataSource = Me.PlayersBindingSource1
        Me.cbPlayer2.DisplayMember = "PlayerName"
        Me.cbPlayer2.FormattingEnabled = True
        Me.cbPlayer2.Location = New System.Drawing.Point(282, 28)
        Me.cbPlayer2.Name = "cbPlayer2"
        Me.cbPlayer2.Size = New System.Drawing.Size(121, 21)
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(539, 391)
        Me.Controls.Add(Me.cbPlayer2)
        Me.Controls.Add(Me.cbPlayer1)
        Me.Controls.Add(Me.btnReg)
        Me.Controls.Add(Me.groupWinner)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.txtResults)
        Me.Controls.Add(Me.txtWins2)
        Me.Controls.Add(Me.txtWins)
        Me.Controls.Add(Me.tbPlayer2)
        Me.Controls.Add(Me.tbPlayer1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.groupWinner.ResumeLayout(False)
        Me.groupWinner.PerformLayout()
        CType(Me.PlayersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerNames, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocalResultsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocalResultsDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayersBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocalResultsDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbPlayer1 As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents tbPlayer2 As TextBox
    Friend WithEvents txtWins As TextBox
    Friend WithEvents txtWins2 As TextBox
    Friend WithEvents txtResults As TextBox
    Friend WithEvents lblError As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents cbPlayer1Win As CheckBox
    Friend WithEvents cbPlayer2Win As CheckBox
    Friend WithEvents groupWinner As GroupBox
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
End Class
