<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class search
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(search))
        PictureBox1 = New PictureBox()
        btnDashboard = New Button()
        btnAppointment = New Button()
        btnPetowner = New Button()
        btnHistory = New Button()
        btnexit = New Button()
        pnlContainer = New Panel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._Me
        PictureBox1.Location = New Point(0, 1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1014, 558)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' btnDashboard
        ' 
        btnDashboard.FlatAppearance.BorderSize = 0
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.Image = CType(resources.GetObject("btnDashboard.Image"), Image)
        btnDashboard.Location = New Point(-9, 107)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(101, 75)
        btnDashboard.TabIndex = 1
        btnDashboard.UseVisualStyleBackColor = True
        ' 
        ' btnAppointment
        ' 
        btnAppointment.Location = New Point(-8, 183)
        btnAppointment.Name = "btnAppointment"
        btnAppointment.Size = New Size(101, 72)
        btnAppointment.TabIndex = 2
        btnAppointment.Text = "Button2"
        btnAppointment.UseVisualStyleBackColor = True
        ' 
        ' btnPetowner
        ' 
        btnPetowner.Location = New Point(-8, 256)
        btnPetowner.Name = "btnPetowner"
        btnPetowner.Size = New Size(101, 75)
        btnPetowner.TabIndex = 3
        btnPetowner.Text = "Button3"
        btnPetowner.UseVisualStyleBackColor = True
        ' 
        ' btnHistory
        ' 
        btnHistory.Location = New Point(-8, 331)
        btnHistory.Name = "btnHistory"
        btnHistory.Size = New Size(101, 75)
        btnHistory.TabIndex = 4
        btnHistory.Text = "Button4"
        btnHistory.UseVisualStyleBackColor = True
        ' 
        ' btnexit
        ' 
        btnexit.Location = New Point(-8, 470)
        btnexit.Name = "btnexit"
        btnexit.Size = New Size(101, 75)
        btnexit.TabIndex = 5
        btnexit.Text = "Button4"
        btnexit.UseVisualStyleBackColor = True
        ' 
        ' pnlContainer
        ' 
        pnlContainer.Location = New Point(92, 1)
        pnlContainer.Name = "pnlContainer"
        pnlContainer.Size = New Size(922, 558)
        pnlContainer.TabIndex = 6
        ' 
        ' search
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1014, 558)
        Controls.Add(pnlContainer)
        Controls.Add(btnexit)
        Controls.Add(btnHistory)
        Controls.Add(btnPetowner)
        Controls.Add(btnAppointment)
        Controls.Add(btnDashboard)
        Controls.Add(PictureBox1)
        Name = "search"
        Text = "/"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnAppointment As Button
    Friend WithEvents btnPetowner As Button
    Friend WithEvents btnHistory As Button
    Friend WithEvents btnexit As Button
    Friend WithEvents pnlContainer As Panel
End Class
