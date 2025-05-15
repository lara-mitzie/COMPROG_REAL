<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dashboard
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dashboard))
        Me.lblCheckupSessions = New System.Windows.Forms.Label()
        Me.lblVaccineSession = New System.Windows.Forms.Label()
        Me.lblpets = New System.Windows.Forms.Label()
        Me.lblAppointments = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtAllOutRevenue = New System.Windows.Forms.TextBox()
        Me.txtRevenueToday = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCheckupSessions
        '
        Me.lblCheckupSessions.AutoSize = True
        Me.lblCheckupSessions.Font = New System.Drawing.Font("Glacial Indifference", 22.2!, System.Drawing.FontStyle.Bold)
        Me.lblCheckupSessions.Location = New System.Drawing.Point(1034, 349)
        Me.lblCheckupSessions.Name = "lblCheckupSessions"
        Me.lblCheckupSessions.Size = New System.Drawing.Size(42, 44)
        Me.lblCheckupSessions.TabIndex = 11
        Me.lblCheckupSessions.Text = "0"
        '
        'lblVaccineSession
        '
        Me.lblVaccineSession.AutoSize = True
        Me.lblVaccineSession.Font = New System.Drawing.Font("Glacial Indifference", 22.2!, System.Drawing.FontStyle.Bold)
        Me.lblVaccineSession.Location = New System.Drawing.Point(749, 348)
        Me.lblVaccineSession.Name = "lblVaccineSession"
        Me.lblVaccineSession.Size = New System.Drawing.Size(42, 44)
        Me.lblVaccineSession.TabIndex = 10
        Me.lblVaccineSession.Text = "0"
        '
        'lblpets
        '
        Me.lblpets.AutoSize = True
        Me.lblpets.Font = New System.Drawing.Font("Glacial Indifference", 22.2!, System.Drawing.FontStyle.Bold)
        Me.lblpets.Location = New System.Drawing.Point(465, 349)
        Me.lblpets.Name = "lblpets"
        Me.lblpets.Size = New System.Drawing.Size(42, 44)
        Me.lblpets.TabIndex = 9
        Me.lblpets.Text = "0"
        '
        'lblAppointments
        '
        Me.lblAppointments.AutoSize = True
        Me.lblAppointments.Font = New System.Drawing.Font("Glacial Indifference", 22.2!, System.Drawing.FontStyle.Bold)
        Me.lblAppointments.Location = New System.Drawing.Point(185, 349)
        Me.lblAppointments.Name = "lblAppointments"
        Me.lblAppointments.Size = New System.Drawing.Size(42, 44)
        Me.lblAppointments.TabIndex = 8
        Me.lblAppointments.Text = "0"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1241, 768)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'txtAllOutRevenue
        '
        Me.txtAllOutRevenue.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAllOutRevenue.Font = New System.Drawing.Font("Glacial Indifference", 22.2!, System.Drawing.FontStyle.Bold)
        Me.txtAllOutRevenue.Location = New System.Drawing.Point(582, 602)
        Me.txtAllOutRevenue.Name = "txtAllOutRevenue"
        Me.txtAllOutRevenue.ReadOnly = True
        Me.txtAllOutRevenue.Size = New System.Drawing.Size(219, 45)
        Me.txtAllOutRevenue.TabIndex = 14
        Me.txtAllOutRevenue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRevenueToday
        '
        Me.txtRevenueToday.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRevenueToday.Font = New System.Drawing.Font("Glacial Indifference", 22.2!, System.Drawing.FontStyle.Bold)
        Me.txtRevenueToday.Location = New System.Drawing.Point(190, 602)
        Me.txtRevenueToday.Name = "txtRevenueToday"
        Me.txtRevenueToday.ReadOnly = True
        Me.txtRevenueToday.Size = New System.Drawing.Size(161, 45)
        Me.txtRevenueToday.TabIndex = 15
        Me.txtRevenueToday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txtRevenueToday)
        Me.Controls.Add(Me.txtAllOutRevenue)
        Me.Controls.Add(Me.lblCheckupSessions)
        Me.Controls.Add(Me.lblVaccineSession)
        Me.Controls.Add(Me.lblpets)
        Me.Controls.Add(Me.lblAppointments)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "dashboard"
        Me.Size = New System.Drawing.Size(1241, 768)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCheckupSessions As Label
    Friend WithEvents lblVaccineSession As Label
    Friend WithEvents lblpets As Label
    Friend WithEvents lblAppointments As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtAllOutRevenue As TextBox
    Friend WithEvents txtRevenueToday As TextBox
End Class
