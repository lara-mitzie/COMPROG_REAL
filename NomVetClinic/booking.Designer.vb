<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class booking
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(booking))
        Me.pnlButtons2 = New System.Windows.Forms.Panel()
        Me.pctLogoName = New System.Windows.Forms.PictureBox()
        Me.pnlAbovebuttons2 = New System.Windows.Forms.Panel()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.pnlAboveTimer2 = New System.Windows.Forms.Timer(Me.components)
        Me.pnlBack = New System.Windows.Forms.Panel()
        Me.pnlButtons2.SuspendLayout()
        CType(Me.pctLogoName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAbovebuttons2.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlButtons2
        '
        Me.pnlButtons2.BackColor = System.Drawing.Color.White
        Me.pnlButtons2.Controls.Add(Me.pctLogoName)
        Me.pnlButtons2.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlButtons2.Location = New System.Drawing.Point(0, 21)
        Me.pnlButtons2.Name = "pnlButtons2"
        Me.pnlButtons2.Size = New System.Drawing.Size(1866, 90)
        Me.pnlButtons2.TabIndex = 2
        '
        'pctLogoName
        '
        Me.pctLogoName.Image = CType(resources.GetObject("pctLogoName.Image"), System.Drawing.Image)
        Me.pctLogoName.Location = New System.Drawing.Point(870, 6)
        Me.pctLogoName.Name = "pctLogoName"
        Me.pctLogoName.Size = New System.Drawing.Size(208, 73)
        Me.pctLogoName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctLogoName.TabIndex = 4
        Me.pctLogoName.TabStop = False
        '
        'pnlAbovebuttons2
        '
        Me.pnlAbovebuttons2.BackColor = System.Drawing.Color.White
        Me.pnlAbovebuttons2.Controls.Add(Me.btnMinimize)
        Me.pnlAbovebuttons2.Controls.Add(Me.btnExit)
        Me.pnlAbovebuttons2.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAbovebuttons2.Location = New System.Drawing.Point(0, 0)
        Me.pnlAbovebuttons2.Name = "pnlAbovebuttons2"
        Me.pnlAbovebuttons2.Size = New System.Drawing.Size(1866, 21)
        Me.pnlAbovebuttons2.TabIndex = 3
        '
        'btnMinimize
        '
        Me.btnMinimize.BackColor = System.Drawing.Color.White
        Me.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Image = CType(resources.GetObject("btnMinimize.Image"), System.Drawing.Image)
        Me.btnMinimize.Location = New System.Drawing.Point(1796, 0)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(35, 21)
        Me.btnMinimize.TabIndex = 1
        Me.btnMinimize.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.White
        Me.btnExit.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.Location = New System.Drawing.Point(1831, 0)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(35, 21)
        Me.btnExit.TabIndex = 0
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'pnlAboveTimer2
        '
        '
        'pnlBack
        '
        Me.pnlBack.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBack.Location = New System.Drawing.Point(0, 111)
        Me.pnlBack.Name = "pnlBack"
        Me.pnlBack.Size = New System.Drawing.Size(1866, 764)
        Me.pnlBack.TabIndex = 4
        '
        'booking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1866, 875)
        Me.Controls.Add(Me.pnlBack)
        Me.Controls.Add(Me.pnlButtons2)
        Me.Controls.Add(Me.pnlAbovebuttons2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "booking"
        Me.Text = "booking"
        Me.pnlButtons2.ResumeLayout(False)
        CType(Me.pctLogoName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAbovebuttons2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlButtons2 As Panel
    Friend WithEvents pctLogoName As PictureBox
    Friend WithEvents pnlAbovebuttons2 As Panel
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents pnlAboveTimer2 As Timer
    Friend WithEvents pnlBack As Panel
End Class
