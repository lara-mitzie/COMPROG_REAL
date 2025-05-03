<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Location
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Location))
        Me.pctMain = New System.Windows.Forms.PictureBox()
        Me.WebView21 = New Microsoft.Web.WebView2.WinForms.WebView2()
        Me.pnlAbovebuttons3 = New System.Windows.Forms.Panel()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.pnlTimer4 = New System.Windows.Forms.Timer(Me.components)
        Me.pctBack = New System.Windows.Forms.PictureBox()
        CType(Me.pctMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WebView21, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAbovebuttons3.SuspendLayout()
        CType(Me.pctBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pctMain
        '
        Me.pctMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pctMain.Image = CType(resources.GetObject("pctMain.Image"), System.Drawing.Image)
        Me.pctMain.Location = New System.Drawing.Point(0, 0)
        Me.pctMain.Name = "pctMain"
        Me.pctMain.Size = New System.Drawing.Size(1902, 1033)
        Me.pctMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctMain.TabIndex = 0
        Me.pctMain.TabStop = False
        '
        'WebView21
        '
        Me.WebView21.AllowExternalDrop = True
        Me.WebView21.CreationProperties = Nothing
        Me.WebView21.DefaultBackgroundColor = System.Drawing.Color.White
        Me.WebView21.Location = New System.Drawing.Point(931, 228)
        Me.WebView21.Name = "WebView21"
        Me.WebView21.Size = New System.Drawing.Size(721, 589)
        Me.WebView21.TabIndex = 1
        Me.WebView21.ZoomFactor = 1.0R
        '
        'pnlAbovebuttons3
        '
        Me.pnlAbovebuttons3.BackColor = System.Drawing.Color.White
        Me.pnlAbovebuttons3.Controls.Add(Me.btnMinimize)
        Me.pnlAbovebuttons3.Controls.Add(Me.btnExit)
        Me.pnlAbovebuttons3.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAbovebuttons3.Location = New System.Drawing.Point(0, 0)
        Me.pnlAbovebuttons3.Name = "pnlAbovebuttons3"
        Me.pnlAbovebuttons3.Size = New System.Drawing.Size(1902, 21)
        Me.pnlAbovebuttons3.TabIndex = 3
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
        'pnlTimer4
        '
        '
        'pctBack
        '
        Me.pctBack.BackColor = System.Drawing.Color.White
        Me.pctBack.Image = CType(resources.GetObject("pctBack.Image"), System.Drawing.Image)
        Me.pctBack.Location = New System.Drawing.Point(46, 27)
        Me.pctBack.Name = "pctBack"
        Me.pctBack.Size = New System.Drawing.Size(66, 60)
        Me.pctBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctBack.TabIndex = 4
        Me.pctBack.TabStop = False
        '
        'Location
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1902, 1033)
        Me.Controls.Add(Me.pctBack)
        Me.Controls.Add(Me.pnlAbovebuttons3)
        Me.Controls.Add(Me.WebView21)
        Me.Controls.Add(Me.pctMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Location"
        Me.Text = "Location"
        CType(Me.pctMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WebView21, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAbovebuttons3.ResumeLayout(False)
        CType(Me.pctBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pctMain As PictureBox
    Friend WithEvents WebView21 As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents pnlAbovebuttons3 As Panel
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents pnlTimer4 As Timer
    Friend WithEvents pctBack As PictureBox
End Class
