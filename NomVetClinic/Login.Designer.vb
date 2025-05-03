<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.pctBoxMain = New System.Windows.Forms.PictureBox()
        Me.pnlAbovebuttons3 = New System.Windows.Forms.Panel()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtCode6 = New System.Windows.Forms.TextBox()
        Me.txtCode5 = New System.Windows.Forms.TextBox()
        Me.txtCode4 = New System.Windows.Forms.TextBox()
        Me.txtCode3 = New System.Windows.Forms.TextBox()
        Me.txtCode2 = New System.Windows.Forms.TextBox()
        Me.txtCode1 = New System.Windows.Forms.TextBox()
        Me.btnBackLogin = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.timerPanel3 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pctBoxMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAbovebuttons3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pctBoxMain
        '
        Me.pctBoxMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pctBoxMain.Image = CType(resources.GetObject("pctBoxMain.Image"), System.Drawing.Image)
        Me.pctBoxMain.Location = New System.Drawing.Point(0, 0)
        Me.pctBoxMain.Name = "pctBoxMain"
        Me.pctBoxMain.Size = New System.Drawing.Size(1902, 1033)
        Me.pctBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctBoxMain.TabIndex = 0
        Me.pctBoxMain.TabStop = False
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
        Me.pnlAbovebuttons3.TabIndex = 2
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtCode6)
        Me.Panel1.Controls.Add(Me.txtCode5)
        Me.Panel1.Controls.Add(Me.txtCode4)
        Me.Panel1.Controls.Add(Me.txtCode3)
        Me.Panel1.Controls.Add(Me.txtCode2)
        Me.Panel1.Controls.Add(Me.txtCode1)
        Me.Panel1.Controls.Add(Me.btnBackLogin)
        Me.Panel1.Controls.Add(Me.btnLogin)
        Me.Panel1.Controls.Add(Me.txtUsername)
        Me.Panel1.Controls.Add(Me.pnlAbovebuttons3)
        Me.Panel1.Controls.Add(Me.pctBoxMain)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1902, 1033)
        Me.Panel1.TabIndex = 3
        '
        'txtCode6
        '
        Me.txtCode6.BackColor = System.Drawing.Color.SandyBrown
        Me.txtCode6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCode6.Font = New System.Drawing.Font("Glacial Indifference", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode6.Location = New System.Drawing.Point(1651, 557)
        Me.txtCode6.MaxLength = 1
        Me.txtCode6.Name = "txtCode6"
        Me.txtCode6.Size = New System.Drawing.Size(48, 60)
        Me.txtCode6.TabIndex = 17
        Me.txtCode6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCode5
        '
        Me.txtCode5.BackColor = System.Drawing.Color.RosyBrown
        Me.txtCode5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCode5.Font = New System.Drawing.Font("Glacial Indifference", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode5.Location = New System.Drawing.Point(1567, 557)
        Me.txtCode5.MaxLength = 1
        Me.txtCode5.Name = "txtCode5"
        Me.txtCode5.Size = New System.Drawing.Size(48, 60)
        Me.txtCode5.TabIndex = 16
        Me.txtCode5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCode4
        '
        Me.txtCode4.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtCode4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCode4.Font = New System.Drawing.Font("Glacial Indifference", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode4.Location = New System.Drawing.Point(1484, 557)
        Me.txtCode4.MaxLength = 1
        Me.txtCode4.Name = "txtCode4"
        Me.txtCode4.Size = New System.Drawing.Size(48, 60)
        Me.txtCode4.TabIndex = 15
        Me.txtCode4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCode3
        '
        Me.txtCode3.BackColor = System.Drawing.SystemColors.Info
        Me.txtCode3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCode3.Font = New System.Drawing.Font("Glacial Indifference", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode3.Location = New System.Drawing.Point(1402, 557)
        Me.txtCode3.MaxLength = 1
        Me.txtCode3.Name = "txtCode3"
        Me.txtCode3.Size = New System.Drawing.Size(48, 60)
        Me.txtCode3.TabIndex = 14
        Me.txtCode3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCode2
        '
        Me.txtCode2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtCode2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCode2.Font = New System.Drawing.Font("Glacial Indifference", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode2.Location = New System.Drawing.Point(1319, 557)
        Me.txtCode2.MaxLength = 1
        Me.txtCode2.Name = "txtCode2"
        Me.txtCode2.Size = New System.Drawing.Size(48, 60)
        Me.txtCode2.TabIndex = 13
        Me.txtCode2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCode1
        '
        Me.txtCode1.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtCode1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCode1.Font = New System.Drawing.Font("Glacial Indifference", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode1.Location = New System.Drawing.Point(1234, 557)
        Me.txtCode1.MaxLength = 1
        Me.txtCode1.Name = "txtCode1"
        Me.txtCode1.Size = New System.Drawing.Size(48, 60)
        Me.txtCode1.TabIndex = 12
        Me.txtCode1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnBackLogin
        '
        Me.btnBackLogin.BackColor = System.Drawing.Color.White
        Me.btnBackLogin.FlatAppearance.BorderSize = 0
        Me.btnBackLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBackLogin.Image = CType(resources.GetObject("btnBackLogin.Image"), System.Drawing.Image)
        Me.btnBackLogin.Location = New System.Drawing.Point(998, 44)
        Me.btnBackLogin.Name = "btnBackLogin"
        Me.btnBackLogin.Size = New System.Drawing.Size(63, 53)
        Me.btnBackLogin.TabIndex = 11
        Me.btnBackLogin.UseVisualStyleBackColor = False
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("Glacial Indifference", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(1140, 686)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(594, 84)
        Me.btnLogin.TabIndex = 10
        Me.btnLogin.Text = "LOGIN"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.SystemColors.Highlight
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsername.Font = New System.Drawing.Font("Glacial Indifference", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(1188, 441)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(476, 52)
        Me.txtUsername.TabIndex = 3
        Me.txtUsername.Text = "d"
        '
        'timerPanel3
        '
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1902, 1033)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.Text = "Login"
        CType(Me.pctBoxMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAbovebuttons3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pctBoxMain As PictureBox
    Friend WithEvents pnlAbovebuttons3 As Panel
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents timerPanel3 As Timer
    Friend WithEvents btnBackLogin As Button
    Friend WithEvents txtCode5 As TextBox
    Friend WithEvents txtCode4 As TextBox
    Friend WithEvents txtCode3 As TextBox
    Friend WithEvents txtCode2 As TextBox
    Friend WithEvents txtCode1 As TextBox
    Friend WithEvents txtCode6 As TextBox
End Class
