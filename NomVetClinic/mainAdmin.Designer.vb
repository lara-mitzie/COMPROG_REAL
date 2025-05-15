<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainAdmin))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnHistory = New System.Windows.Forms.Button()
        Me.btnPetOwner = New System.Windows.Forms.Button()
        Me.btnAppointment = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.pnlAbovebuttons = New System.Windows.Forms.Panel()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.pnlAboveTimer = New System.Windows.Forms.Timer(Me.components)
        Me.btnPetDetails = New System.Windows.Forms.Button()
        Me.btnBilling = New System.Windows.Forms.Button()
        Me.pctbilling = New System.Windows.Forms.PictureBox()
        Me.pctPetDetails = New System.Windows.Forms.PictureBox()
        Me.pctLogout = New System.Windows.Forms.PictureBox()
        Me.pctHistory = New System.Windows.Forms.PictureBox()
        Me.pctPetOwner = New System.Windows.Forms.PictureBox()
        Me.pctAppointment = New System.Windows.Forms.PictureBox()
        Me.pctDashboard = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlAbovebuttons.SuspendLayout()
        CType(Me.pctbilling, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctPetDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctLogout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctPetOwner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctAppointment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctDashboard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(142, 21)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1224, 747)
        Me.Panel1.TabIndex = 20
        '
        'btnLogout
        '
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Location = New System.Drawing.Point(4, 684)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(117, 77)
        Me.btnLogout.TabIndex = 19
        Me.btnLogout.Text = " "
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnHistory
        '
        Me.btnHistory.FlatAppearance.BorderSize = 0
        Me.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHistory.Location = New System.Drawing.Point(4, 477)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Size = New System.Drawing.Size(117, 77)
        Me.btnHistory.TabIndex = 18
        Me.btnHistory.Text = " "
        Me.btnHistory.UseVisualStyleBackColor = True
        '
        'btnPetOwner
        '
        Me.btnPetOwner.FlatAppearance.BorderSize = 0
        Me.btnPetOwner.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPetOwner.Location = New System.Drawing.Point(4, 304)
        Me.btnPetOwner.Name = "btnPetOwner"
        Me.btnPetOwner.Size = New System.Drawing.Size(117, 77)
        Me.btnPetOwner.TabIndex = 17
        Me.btnPetOwner.Text = " "
        Me.btnPetOwner.UseVisualStyleBackColor = True
        '
        'btnAppointment
        '
        Me.btnAppointment.FlatAppearance.BorderSize = 0
        Me.btnAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAppointment.Location = New System.Drawing.Point(4, 217)
        Me.btnAppointment.Name = "btnAppointment"
        Me.btnAppointment.Size = New System.Drawing.Size(117, 77)
        Me.btnAppointment.TabIndex = 16
        Me.btnAppointment.Text = " "
        Me.btnAppointment.UseVisualStyleBackColor = True
        '
        'btnDashboard
        '
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Location = New System.Drawing.Point(4, 130)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(117, 77)
        Me.btnDashboard.TabIndex = 15
        Me.btnDashboard.Text = " "
        Me.btnDashboard.UseVisualStyleBackColor = True
        '
        'pnlAbovebuttons
        '
        Me.pnlAbovebuttons.BackColor = System.Drawing.Color.White
        Me.pnlAbovebuttons.Controls.Add(Me.btnMinimize)
        Me.pnlAbovebuttons.Controls.Add(Me.btnExit)
        Me.pnlAbovebuttons.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAbovebuttons.Location = New System.Drawing.Point(0, 0)
        Me.pnlAbovebuttons.Name = "pnlAbovebuttons"
        Me.pnlAbovebuttons.Size = New System.Drawing.Size(1366, 21)
        Me.pnlAbovebuttons.TabIndex = 2
        '
        'btnMinimize
        '
        Me.btnMinimize.BackColor = System.Drawing.Color.White
        Me.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Image = CType(resources.GetObject("btnMinimize.Image"), System.Drawing.Image)
        Me.btnMinimize.Location = New System.Drawing.Point(1296, 0)
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
        Me.btnExit.Location = New System.Drawing.Point(1331, 0)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(35, 21)
        Me.btnExit.TabIndex = 0
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'pnlAboveTimer
        '
        '
        'btnPetDetails
        '
        Me.btnPetDetails.FlatAppearance.BorderSize = 0
        Me.btnPetDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPetDetails.Location = New System.Drawing.Point(4, 391)
        Me.btnPetDetails.Name = "btnPetDetails"
        Me.btnPetDetails.Size = New System.Drawing.Size(117, 77)
        Me.btnPetDetails.TabIndex = 26
        Me.btnPetDetails.Text = " "
        Me.btnPetDetails.UseVisualStyleBackColor = True
        '
        'btnBilling
        '
        Me.btnBilling.FlatAppearance.BorderSize = 0
        Me.btnBilling.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBilling.Location = New System.Drawing.Point(4, 563)
        Me.btnBilling.Name = "btnBilling"
        Me.btnBilling.Size = New System.Drawing.Size(117, 77)
        Me.btnBilling.TabIndex = 28
        Me.btnBilling.Text = " "
        Me.btnBilling.UseVisualStyleBackColor = True
        '
        'pctbilling
        '
        Me.pctbilling.Image = CType(resources.GetObject("pctbilling.Image"), System.Drawing.Image)
        Me.pctbilling.Location = New System.Drawing.Point(8, 568)
        Me.pctbilling.Name = "pctbilling"
        Me.pctbilling.Size = New System.Drawing.Size(109, 67)
        Me.pctbilling.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctbilling.TabIndex = 29
        Me.pctbilling.TabStop = False
        '
        'pctPetDetails
        '
        Me.pctPetDetails.Image = CType(resources.GetObject("pctPetDetails.Image"), System.Drawing.Image)
        Me.pctPetDetails.Location = New System.Drawing.Point(8, 396)
        Me.pctPetDetails.Name = "pctPetDetails"
        Me.pctPetDetails.Size = New System.Drawing.Size(109, 67)
        Me.pctPetDetails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctPetDetails.TabIndex = 27
        Me.pctPetDetails.TabStop = False
        '
        'pctLogout
        '
        Me.pctLogout.Image = CType(resources.GetObject("pctLogout.Image"), System.Drawing.Image)
        Me.pctLogout.Location = New System.Drawing.Point(8, 689)
        Me.pctLogout.Name = "pctLogout"
        Me.pctLogout.Size = New System.Drawing.Size(109, 67)
        Me.pctLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctLogout.TabIndex = 25
        Me.pctLogout.TabStop = False
        '
        'pctHistory
        '
        Me.pctHistory.Image = CType(resources.GetObject("pctHistory.Image"), System.Drawing.Image)
        Me.pctHistory.Location = New System.Drawing.Point(8, 482)
        Me.pctHistory.Name = "pctHistory"
        Me.pctHistory.Size = New System.Drawing.Size(109, 67)
        Me.pctHistory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctHistory.TabIndex = 24
        Me.pctHistory.TabStop = False
        '
        'pctPetOwner
        '
        Me.pctPetOwner.Image = CType(resources.GetObject("pctPetOwner.Image"), System.Drawing.Image)
        Me.pctPetOwner.Location = New System.Drawing.Point(8, 309)
        Me.pctPetOwner.Name = "pctPetOwner"
        Me.pctPetOwner.Size = New System.Drawing.Size(109, 67)
        Me.pctPetOwner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctPetOwner.TabIndex = 23
        Me.pctPetOwner.TabStop = False
        '
        'pctAppointment
        '
        Me.pctAppointment.Image = CType(resources.GetObject("pctAppointment.Image"), System.Drawing.Image)
        Me.pctAppointment.Location = New System.Drawing.Point(8, 222)
        Me.pctAppointment.Name = "pctAppointment"
        Me.pctAppointment.Size = New System.Drawing.Size(109, 67)
        Me.pctAppointment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctAppointment.TabIndex = 22
        Me.pctAppointment.TabStop = False
        '
        'pctDashboard
        '
        Me.pctDashboard.Image = CType(resources.GetObject("pctDashboard.Image"), System.Drawing.Image)
        Me.pctDashboard.Location = New System.Drawing.Point(8, 135)
        Me.pctDashboard.Name = "pctDashboard"
        Me.pctDashboard.Size = New System.Drawing.Size(109, 67)
        Me.pctDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctDashboard.TabIndex = 21
        Me.pctDashboard.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1366, 768)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'mainAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.pctbilling)
        Me.Controls.Add(Me.btnBilling)
        Me.Controls.Add(Me.pctPetDetails)
        Me.Controls.Add(Me.btnPetDetails)
        Me.Controls.Add(Me.pctLogout)
        Me.Controls.Add(Me.pctHistory)
        Me.Controls.Add(Me.pctPetOwner)
        Me.Controls.Add(Me.pctAppointment)
        Me.Controls.Add(Me.pctDashboard)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlAbovebuttons)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnHistory)
        Me.Controls.Add(Me.btnPetOwner)
        Me.Controls.Add(Me.btnAppointment)
        Me.Controls.Add(Me.btnDashboard)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "mainAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "mainAdmin"
        Me.pnlAbovebuttons.ResumeLayout(False)
        CType(Me.pctbilling, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctPetDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctLogout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctPetOwner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctAppointment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctDashboard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnHistory As Button
    Friend WithEvents btnPetOwner As Button
    Friend WithEvents btnAppointment As Button
    Friend WithEvents btnDashboard As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pnlAbovebuttons As Panel
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents pnlAboveTimer As Timer
    Friend WithEvents pctDashboard As PictureBox
    Friend WithEvents pctAppointment As PictureBox
    Friend WithEvents pctPetOwner As PictureBox
    Friend WithEvents pctHistory As PictureBox
    Friend WithEvents pctLogout As PictureBox
    Friend WithEvents pctPetDetails As PictureBox
    Friend WithEvents btnPetDetails As Button
    Friend WithEvents pctbilling As PictureBox
    Friend WithEvents btnBilling As Button
End Class
