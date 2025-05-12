<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Interface4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Interface4))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblHome = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.lblServices = New System.Windows.Forms.Label()
        Me.lblAboutUs = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1881, 922)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblHome
        '
        Me.lblHome.AutoSize = True
        Me.lblHome.Font = New System.Drawing.Font("Glacial Indifference", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHome.Location = New System.Drawing.Point(1128, 545)
        Me.lblHome.Name = "lblHome"
        Me.lblHome.Size = New System.Drawing.Size(88, 35)
        Me.lblHome.TabIndex = 1
        Me.lblHome.Text = "Home"
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("Glacial Indifference", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(1140, 582)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(63, 35)
        Me.lblInfo.TabIndex = 2
        Me.lblInfo.Text = "Info"
        '
        'lblServices
        '
        Me.lblServices.AutoSize = True
        Me.lblServices.Font = New System.Drawing.Font("Glacial Indifference", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServices.Location = New System.Drawing.Point(1114, 619)
        Me.lblServices.Name = "lblServices"
        Me.lblServices.Size = New System.Drawing.Size(121, 35)
        Me.lblServices.TabIndex = 3
        Me.lblServices.Text = "Services"
        '
        'lblAboutUs
        '
        Me.lblAboutUs.AutoSize = True
        Me.lblAboutUs.Font = New System.Drawing.Font("Glacial Indifference", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAboutUs.Location = New System.Drawing.Point(1109, 655)
        Me.lblAboutUs.Name = "lblAboutUs"
        Me.lblAboutUs.Size = New System.Drawing.Size(131, 35)
        Me.lblAboutUs.TabIndex = 4
        Me.lblAboutUs.Text = "About Us"
        '
        'Interface4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblAboutUs)
        Me.Controls.Add(Me.lblServices)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.lblHome)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Interface4"
        Me.Size = New System.Drawing.Size(1881, 922)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblHome As Label
    Friend WithEvents lblInfo As Label
    Friend WithEvents lblServices As Label
    Friend WithEvents lblAboutUs As Label
End Class
