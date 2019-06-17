<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.SuspendLayout()
        '
        'tbPlayer1
        '
        Me.tbPlayer1.Location = New System.Drawing.Point(31, 112)
        Me.tbPlayer1.Name = "tbPlayer1"
        Me.tbPlayer1.Size = New System.Drawing.Size(161, 20)
        Me.tbPlayer1.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'tbPlayer2
        '
        Me.tbPlayer2.Location = New System.Drawing.Point(315, 112)
        Me.tbPlayer2.Name = "tbPlayer2"
        Me.tbPlayer2.Size = New System.Drawing.Size(161, 20)
        Me.tbPlayer2.TabIndex = 2
        '
        'txtWins
        '
        Me.txtWins.Location = New System.Drawing.Point(64, 154)
        Me.txtWins.Name = "txtWins"
        Me.txtWins.Size = New System.Drawing.Size(99, 20)
        Me.txtWins.TabIndex = 3
        '
        'txtWins2
        '
        Me.txtWins2.Location = New System.Drawing.Point(347, 154)
        Me.txtWins2.Name = "txtWins2"
        Me.txtWins2.Size = New System.Drawing.Size(84, 20)
        Me.txtWins2.TabIndex = 4
        '
        'txtResults
        '
        Me.txtResults.Location = New System.Drawing.Point(150, 226)
        Me.txtResults.Multiline = True
        Me.txtResults.Name = "txtResults"
        Me.txtResults.Size = New System.Drawing.Size(216, 82)
        Me.txtResults.TabIndex = 5
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(207, 154)
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
        Me.cbPlayer1Win.Location = New System.Drawing.Point(111, 189)
        Me.cbPlayer1Win.Name = "cbPlayer1Win"
        Me.cbPlayer1Win.Size = New System.Drawing.Size(45, 17)
        Me.cbPlayer1Win.TabIndex = 8
        Me.cbPlayer1Win.Text = "Win"
        Me.cbPlayer1Win.UseVisualStyleBackColor = True
        '
        'cbPlayer2Win
        '
        Me.cbPlayer2Win.AutoSize = True
        Me.cbPlayer2Win.Location = New System.Drawing.Point(386, 189)
        Me.cbPlayer2Win.Name = "cbPlayer2Win"
        Me.cbPlayer2Win.Size = New System.Drawing.Size(45, 17)
        Me.cbPlayer2Win.TabIndex = 9
        Me.cbPlayer2Win.Text = "Win"
        Me.cbPlayer2Win.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(539, 391)
        Me.Controls.Add(Me.cbPlayer2Win)
        Me.Controls.Add(Me.cbPlayer1Win)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.txtResults)
        Me.Controls.Add(Me.txtWins2)
        Me.Controls.Add(Me.txtWins)
        Me.Controls.Add(Me.tbPlayer2)
        Me.Controls.Add(Me.tbPlayer1)
        Me.Name = "Form1"
        Me.Text = "Form1"
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
End Class
