<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SplashScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashScreen))
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtLoad = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTitle
        '
        Me.txtTitle.BackColor = System.Drawing.Color.RoyalBlue
        Me.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTitle.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.txtTitle.Enabled = False
        Me.txtTitle.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.ForeColor = System.Drawing.Color.Lime
        Me.txtTitle.Location = New System.Drawing.Point(8, 196)
        Me.txtTitle.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTitle.Multiline = True
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.ReadOnly = True
        Me.txtTitle.Size = New System.Drawing.Size(165, 50)
        Me.txtTitle.TabIndex = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(6, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(238, 232)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'txtLoad
        '
        Me.txtLoad.BackColor = System.Drawing.Color.RoyalBlue
        Me.txtLoad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLoad.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoad.ForeColor = System.Drawing.Color.Lime
        Me.txtLoad.Location = New System.Drawing.Point(302, 105)
        Me.txtLoad.Multiline = True
        Me.txtLoad.Name = "txtLoad"
        Me.txtLoad.ReadOnly = True
        Me.txtLoad.Size = New System.Drawing.Size(219, 171)
        Me.txtLoad.TabIndex = 3
        Me.txtLoad.Text = "ICU ScoreBoard"
        Me.txtLoad.UseWaitCursor = True
        '
        'SplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(533, 288)
        Me.Controls.Add(Me.txtLoad)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.txtTitle)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "SplashScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ICUScore"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtLoad As TextBox
End Class
