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
        PictureBox1 = New PictureBox()
        lblAppointments = New Label()
        lblpets = New Label()
        lblVaccineSession = New Label()
        lblCheckupSessions = New Label()
        lblRevenueToday = New Label()
        lblAllOutRevenue = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.dashboard
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(924, 558)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' lblAppointments
        ' 
        lblAppointments.AutoSize = True
        lblAppointments.Location = New Point(135, 278)
        lblAppointments.Name = "lblAppointments"
        lblAppointments.Size = New Size(13, 15)
        lblAppointments.TabIndex = 1
        lblAppointments.Text = "0"
        ' 
        ' lblpets
        ' 
        lblpets.AutoSize = True
        lblpets.Location = New Point(341, 282)
        lblpets.Name = "lblpets"
        lblpets.Size = New Size(13, 15)
        lblpets.TabIndex = 2
        lblpets.Text = "0"
        ' 
        ' lblVaccineSession
        ' 
        lblVaccineSession.AutoSize = True
        lblVaccineSession.Location = New Point(549, 280)
        lblVaccineSession.Name = "lblVaccineSession"
        lblVaccineSession.Size = New Size(13, 15)
        lblVaccineSession.TabIndex = 3
        lblVaccineSession.Text = "0"
        ' 
        ' lblCheckupSessions
        ' 
        lblCheckupSessions.AutoSize = True
        lblCheckupSessions.Location = New Point(760, 281)
        lblCheckupSessions.Name = "lblCheckupSessions"
        lblCheckupSessions.Size = New Size(13, 15)
        lblCheckupSessions.TabIndex = 4
        lblCheckupSessions.Text = "0"
        ' 
        ' lblRevenueToday
        ' 
        lblRevenueToday.AutoSize = True
        lblRevenueToday.Location = New Point(181, 455)
        lblRevenueToday.Name = "lblRevenueToday"
        lblRevenueToday.Size = New Size(13, 15)
        lblRevenueToday.TabIndex = 5
        lblRevenueToday.Text = "0"
        ' 
        ' lblAllOutRevenue
        ' 
        lblAllOutRevenue.AutoSize = True
        lblAllOutRevenue.Location = New Point(489, 455)
        lblAllOutRevenue.Name = "lblAllOutRevenue"
        lblAllOutRevenue.Size = New Size(13, 15)
        lblAllOutRevenue.TabIndex = 6
        lblAllOutRevenue.Text = "0"
        ' 
        ' dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(lblAllOutRevenue)
        Controls.Add(lblRevenueToday)
        Controls.Add(lblCheckupSessions)
        Controls.Add(lblVaccineSession)
        Controls.Add(lblpets)
        Controls.Add(lblAppointments)
        Controls.Add(PictureBox1)
        Name = "dashboard"
        Size = New Size(924, 558)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblAppointments As Label
    Friend WithEvents lblpets As Label
    Friend WithEvents lblVaccineSession As Label
    Friend WithEvents lblCheckupSessions As Label
    Friend WithEvents lblRevenueToday As Label
    Friend WithEvents lblAllOutRevenue As Label

End Class
