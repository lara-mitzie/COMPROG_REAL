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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.pnlBack = New System.Windows.Forms.Panel()
        Me.pnlShowInt = New System.Windows.Forms.Panel()
        Me.VScrollBar = New System.Windows.Forms.VScrollBar()
        Me.pnlButtons = New System.Windows.Forms.Panel()
        Me.btnhmm = New System.Windows.Forms.Button()
        Me.btnServices = New System.Windows.Forms.Button()
        Me.btnBooknow = New System.Windows.Forms.Button()
        Me.btnAboutUs = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.pnlAbovebuttons = New System.Windows.Forms.Panel()
        Me.pnlAboveTimer = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.pctBlur = New System.Windows.Forms.PictureBox()
        Me.pnlBack.SuspendLayout()
        Me.pnlButtons.SuspendLayout()
        Me.pnlAbovebuttons.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctBlur, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlBack
        '
        Me.pnlBack.Controls.Add(Me.pnlShowInt)
        Me.pnlBack.Controls.Add(Me.VScrollBar)
        Me.pnlBack.Controls.Add(Me.pnlButtons)
        Me.pnlBack.Controls.Add(Me.pnlAbovebuttons)
        Me.pnlBack.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBack.Location = New System.Drawing.Point(0, 0)
        Me.pnlBack.Name = "pnlBack"
        Me.pnlBack.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.pnlBack.Size = New System.Drawing.Size(1902, 1033)
        Me.pnlBack.TabIndex = 0
        '
        'pnlShowInt
        '
        Me.pnlShowInt.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlShowInt.Location = New System.Drawing.Point(0, 111)
        Me.pnlShowInt.Name = "pnlShowInt"
        Me.pnlShowInt.Size = New System.Drawing.Size(1884, 922)
        Me.pnlShowInt.TabIndex = 3
        '
        'VScrollBar
        '
        Me.VScrollBar.Dock = System.Windows.Forms.DockStyle.Right
        Me.VScrollBar.Location = New System.Drawing.Point(1884, 111)
        Me.VScrollBar.Name = "VScrollBar"
        Me.VScrollBar.Size = New System.Drawing.Size(18, 922)
        Me.VScrollBar.TabIndex = 2
        '
        'pnlButtons
        '
        Me.pnlButtons.BackColor = System.Drawing.Color.White
        Me.pnlButtons.Controls.Add(Me.btnhmm)
        Me.pnlButtons.Controls.Add(Me.btnServices)
        Me.pnlButtons.Controls.Add(Me.PictureBox1)
        Me.pnlButtons.Controls.Add(Me.btnBooknow)
        Me.pnlButtons.Controls.Add(Me.btnAboutUs)
        Me.pnlButtons.Controls.Add(Me.btnHome)
        Me.pnlButtons.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlButtons.Location = New System.Drawing.Point(0, 21)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.Size = New System.Drawing.Size(1902, 90)
        Me.pnlButtons.TabIndex = 1
        '
        'btnhmm
        '
        Me.btnhmm.FlatAppearance.BorderSize = 0
        Me.btnhmm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnhmm.Font = New System.Drawing.Font("Glacial Indifference", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhmm.Location = New System.Drawing.Point(684, 18)
        Me.btnhmm.Name = "btnhmm"
        Me.btnhmm.Size = New System.Drawing.Size(187, 57)
        Me.btnhmm.TabIndex = 2
        Me.btnhmm.Text = "SERVICES"
        Me.btnhmm.UseVisualStyleBackColor = True
        '
        'btnServices
        '
        Me.btnServices.FlatAppearance.BorderSize = 0
        Me.btnServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnServices.Font = New System.Drawing.Font("Glacial Indifference", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnServices.Location = New System.Drawing.Point(491, 18)
        Me.btnServices.Name = "btnServices"
        Me.btnServices.Size = New System.Drawing.Size(187, 57)
        Me.btnServices.TabIndex = 1
        Me.btnServices.Text = "INFO"
        Me.btnServices.UseVisualStyleBackColor = True
        '
        'btnBooknow
        '
        Me.btnBooknow.FlatAppearance.BorderSize = 0
        Me.btnBooknow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBooknow.Font = New System.Drawing.Font("Glacial Indifference", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnBooknow.Location = New System.Drawing.Point(1725, 18)
        Me.btnBooknow.Name = "btnBooknow"
        Me.btnBooknow.Size = New System.Drawing.Size(159, 57)
        Me.btnBooknow.TabIndex = 0
        Me.btnBooknow.Text = "BOOK NOW"
        Me.btnBooknow.UseVisualStyleBackColor = True
        '
        'btnAboutUs
        '
        Me.btnAboutUs.FlatAppearance.BorderSize = 0
        Me.btnAboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAboutUs.Font = New System.Drawing.Font("Glacial Indifference", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAboutUs.Location = New System.Drawing.Point(877, 18)
        Me.btnAboutUs.Name = "btnAboutUs"
        Me.btnAboutUs.Size = New System.Drawing.Size(187, 57)
        Me.btnAboutUs.TabIndex = 3
        Me.btnAboutUs.Text = "ABOUT US"
        Me.btnAboutUs.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Font = New System.Drawing.Font("Glacial Indifference", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.Location = New System.Drawing.Point(298, 18)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(187, 57)
        Me.btnHome.TabIndex = 0
        Me.btnHome.Text = "HOME"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'pnlAbovebuttons
        '
        Me.pnlAbovebuttons.BackColor = System.Drawing.Color.White
        Me.pnlAbovebuttons.Controls.Add(Me.btnMinimize)
        Me.pnlAbovebuttons.Controls.Add(Me.btnExit)
        Me.pnlAbovebuttons.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAbovebuttons.Location = New System.Drawing.Point(0, 0)
        Me.pnlAbovebuttons.Name = "pnlAbovebuttons"
        Me.pnlAbovebuttons.Size = New System.Drawing.Size(1902, 21)
        Me.pnlAbovebuttons.TabIndex = 1
        '
        'pnlAboveTimer
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(37, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(208, 73)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'btnMinimize
        '
        Me.btnMinimize.BackColor = System.Drawing.Color.White
        Me.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Image = CType(resources.GetObject("btnMinimize.Image"), System.Drawing.Image)
        Me.btnMinimize.Location = New System.Drawing.Point(1832, 0)
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
        Me.btnExit.Location = New System.Drawing.Point(1867, 0)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(35, 21)
        Me.btnExit.TabIndex = 0
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'pctBlur
        '
        Me.pctBlur.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pctBlur.Image = CType(resources.GetObject("pctBlur.Image"), System.Drawing.Image)
        Me.pctBlur.Location = New System.Drawing.Point(0, 0)
        Me.pctBlur.Name = "pctBlur"
        Me.pctBlur.Size = New System.Drawing.Size(1902, 1033)
        Me.pctBlur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctBlur.TabIndex = 0
        Me.pctBlur.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1902, 1033)
        Me.Controls.Add(Me.pnlBack)
        Me.Controls.Add(Me.pctBlur)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NOM VET CLINIC"
        Me.pnlBack.ResumeLayout(False)
        Me.pnlButtons.ResumeLayout(False)
        Me.pnlAbovebuttons.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctBlur, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlBack As Panel
    Friend WithEvents pnlAbovebuttons As Panel
    Friend WithEvents btnExit As Button
    Friend WithEvents VScrollBar As VScrollBar
    Friend WithEvents pnlAboveTimer As Timer
    Friend WithEvents pnlButtons As Panel
    Friend WithEvents btnHome As Button
    Friend WithEvents btnAboutUs As Button
    Friend WithEvents btnhmm As Button
    Friend WithEvents btnServices As Button
    Friend WithEvents btnBooknow As Button
    Friend WithEvents pnlShowInt As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnMinimize As Button
    Friend WithEvents pctBlur As PictureBox
End Class
