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
        Me.VScrollBar = New System.Windows.Forms.VScrollBar()
        Me.pnlButtons = New System.Windows.Forms.Panel()
        Me.pctProfPicture = New System.Windows.Forms.PictureBox()
        Me.btnSignIn = New System.Windows.Forms.Button()
        Me.btnAboutUs = New System.Windows.Forms.Button()
        Me.btnhmm = New System.Windows.Forms.Button()
        Me.btnServices = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.pnlAbovebuttons = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.pnlAboveTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlBack.SuspendLayout()
        Me.pnlButtons.SuspendLayout()
        CType(Me.pctProfPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAbovebuttons.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlBack
        '
        Me.pnlBack.Controls.Add(Me.Panel1)
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
        'VScrollBar
        '
        Me.VScrollBar.Dock = System.Windows.Forms.DockStyle.Right
        Me.VScrollBar.Location = New System.Drawing.Point(1881, 111)
        Me.VScrollBar.Name = "VScrollBar"
        Me.VScrollBar.Size = New System.Drawing.Size(21, 922)
        Me.VScrollBar.TabIndex = 2
        '
        'pnlButtons
        '
        Me.pnlButtons.BackColor = System.Drawing.Color.White
        Me.pnlButtons.Controls.Add(Me.pctProfPicture)
        Me.pnlButtons.Controls.Add(Me.btnSignIn)
        Me.pnlButtons.Controls.Add(Me.btnAboutUs)
        Me.pnlButtons.Controls.Add(Me.btnhmm)
        Me.pnlButtons.Controls.Add(Me.btnServices)
        Me.pnlButtons.Controls.Add(Me.btnHome)
        Me.pnlButtons.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlButtons.Location = New System.Drawing.Point(0, 21)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.Size = New System.Drawing.Size(1902, 90)
        Me.pnlButtons.TabIndex = 1
        '
        'pctProfPicture
        '
        Me.pctProfPicture.BackColor = System.Drawing.Color.Black
        Me.pctProfPicture.Location = New System.Drawing.Point(1722, 24)
        Me.pctProfPicture.Name = "pctProfPicture"
        Me.pctProfPicture.Size = New System.Drawing.Size(50, 45)
        Me.pctProfPicture.TabIndex = 4
        Me.pctProfPicture.TabStop = False
        '
        'btnSignIn
        '
        Me.btnSignIn.FlatAppearance.BorderSize = 0
        Me.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSignIn.Font = New System.Drawing.Font("Glacial Indifference", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnSignIn.Location = New System.Drawing.Point(1637, 18)
        Me.btnSignIn.Name = "btnSignIn"
        Me.btnSignIn.Size = New System.Drawing.Size(159, 57)
        Me.btnSignIn.TabIndex = 0
        Me.btnSignIn.Text = "SIGN IN"
        Me.btnSignIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSignIn.UseVisualStyleBackColor = True
        '
        'btnAboutUs
        '
        Me.btnAboutUs.FlatAppearance.BorderSize = 0
        Me.btnAboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAboutUs.Font = New System.Drawing.Font("Glacial Indifference", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAboutUs.Location = New System.Drawing.Point(903, 18)
        Me.btnAboutUs.Name = "btnAboutUs"
        Me.btnAboutUs.Size = New System.Drawing.Size(187, 57)
        Me.btnAboutUs.TabIndex = 3
        Me.btnAboutUs.Text = "ABOUT US"
        Me.btnAboutUs.UseVisualStyleBackColor = True
        '
        'btnhmm
        '
        Me.btnhmm.FlatAppearance.BorderSize = 0
        Me.btnhmm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnhmm.Font = New System.Drawing.Font("Glacial Indifference", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhmm.Location = New System.Drawing.Point(692, 18)
        Me.btnhmm.Name = "btnhmm"
        Me.btnhmm.Size = New System.Drawing.Size(187, 57)
        Me.btnhmm.TabIndex = 2
        Me.btnhmm.Text = "LOCATION"
        Me.btnhmm.UseVisualStyleBackColor = True
        '
        'btnServices
        '
        Me.btnServices.FlatAppearance.BorderSize = 0
        Me.btnServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnServices.Font = New System.Drawing.Font("Glacial Indifference", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnServices.Location = New System.Drawing.Point(481, 18)
        Me.btnServices.Name = "btnServices"
        Me.btnServices.Size = New System.Drawing.Size(187, 57)
        Me.btnServices.TabIndex = 1
        Me.btnServices.Text = "SERVICES"
        Me.btnServices.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Font = New System.Drawing.Font("Glacial Indifference", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.Location = New System.Drawing.Point(274, 18)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(187, 57)
        Me.btnHome.TabIndex = 0
        Me.btnHome.Text = "HOME"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'pnlAbovebuttons
        '
        Me.pnlAbovebuttons.BackColor = System.Drawing.Color.White
        Me.pnlAbovebuttons.Controls.Add(Me.btnExit)
        Me.pnlAbovebuttons.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAbovebuttons.Location = New System.Drawing.Point(0, 0)
        Me.pnlAbovebuttons.Name = "pnlAbovebuttons"
        Me.pnlAbovebuttons.Size = New System.Drawing.Size(1902, 21)
        Me.pnlAbovebuttons.TabIndex = 1
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
        'pnlAboveTimer
        '
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 111)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1881, 922)
        Me.Panel1.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1902, 1033)
        Me.Controls.Add(Me.pnlBack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.pnlBack.ResumeLayout(False)
        Me.pnlButtons.ResumeLayout(False)
        CType(Me.pctProfPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAbovebuttons.ResumeLayout(False)
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
    Friend WithEvents btnSignIn As Button
    Friend WithEvents pctProfPicture As PictureBox
    Friend WithEvents Panel1 As Panel
End Class
