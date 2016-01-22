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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ChromeThemeContainer1 = New xCapture.ChromeThemeContainer()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ChromeButton2 = New xCapture.ChromeButton()
        Me.ChromeButton1 = New xCapture.ChromeButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ChromeThemeContainer1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'ChromeThemeContainer1
        '
        Me.ChromeThemeContainer1.BackColor = System.Drawing.Color.White
        Me.ChromeThemeContainer1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.ChromeThemeContainer1.Controls.Add(Me.StatusStrip1)
        Me.ChromeThemeContainer1.Controls.Add(Me.Label1)
        Me.ChromeThemeContainer1.Controls.Add(Me.ChromeButton2)
        Me.ChromeThemeContainer1.Controls.Add(Me.ChromeButton1)
        Me.ChromeThemeContainer1.Controls.Add(Me.PictureBox1)
        Me.ChromeThemeContainer1.Customization = "AAAA/1paWv9ycnL/"
        Me.ChromeThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChromeThemeContainer1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ChromeThemeContainer1.Image = Nothing
        Me.ChromeThemeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ChromeThemeContainer1.Movable = True
        Me.ChromeThemeContainer1.Name = "ChromeThemeContainer1"
        Me.ChromeThemeContainer1.NoRounding = False
        Me.ChromeThemeContainer1.Sizable = True
        Me.ChromeThemeContainer1.Size = New System.Drawing.Size(1230, 717)
        Me.ChromeThemeContainer1.SmartBounds = True
        Me.ChromeThemeContainer1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.ChromeThemeContainer1.TabIndex = 0
        Me.ChromeThemeContainer1.Text = "xCapture By Recreation|Bloodhs3d"
        Me.ChromeThemeContainer1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ChromeThemeContainer1.Transparent = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 695)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1230, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(171, 17)
        Me.ToolStripStatusLabel1.Text = "Made By Recreation|Bloodshed"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(282, 693)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(652, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Although The Picture Here Does Not Shows Your Whole Screen, Your Whole Screen Cap" &
    "ture will be there when you save it."
        '
        'ChromeButton2
        '
        Me.ChromeButton2.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w=="
        Me.ChromeButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ChromeButton2.Image = Nothing
        Me.ChromeButton2.Location = New System.Drawing.Point(1143, 669)
        Me.ChromeButton2.Name = "ChromeButton2"
        Me.ChromeButton2.NoRounding = False
        Me.ChromeButton2.Size = New System.Drawing.Size(75, 23)
        Me.ChromeButton2.TabIndex = 2
        Me.ChromeButton2.Text = "Save"
        Me.ChromeButton2.Transparent = False
        '
        'ChromeButton1
        '
        Me.ChromeButton1.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w=="
        Me.ChromeButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ChromeButton1.Image = Nothing
        Me.ChromeButton1.Location = New System.Drawing.Point(12, 669)
        Me.ChromeButton1.Name = "ChromeButton1"
        Me.ChromeButton1.NoRounding = False
        Me.ChromeButton1.Size = New System.Drawing.Size(75, 23)
        Me.ChromeButton1.TabIndex = 1
        Me.ChromeButton1.Text = "Capture"
        Me.ChromeButton1.Transparent = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 53)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1206, 603)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1230, 717)
        Me.Controls.Add(Me.ChromeThemeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ChromeThemeContainer1.ResumeLayout(False)
        Me.ChromeThemeContainer1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ChromeThemeContainer1 As ChromeThemeContainer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ChromeButton1 As ChromeButton
    Friend WithEvents ChromeButton2 As ChromeButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
End Class
