<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Interface1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Interface1))
        Me.pctHomePage = New System.Windows.Forms.PictureBox()
        Me.btnBookNow1 = New System.Windows.Forms.Button()
        CType(Me.pctHomePage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pctHomePage
        '
        Me.pctHomePage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pctHomePage.Image = CType(resources.GetObject("pctHomePage.Image"), System.Drawing.Image)
        Me.pctHomePage.Location = New System.Drawing.Point(0, 0)
        Me.pctHomePage.Name = "pctHomePage"
        Me.pctHomePage.Size = New System.Drawing.Size(1902, 903)
        Me.pctHomePage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctHomePage.TabIndex = 1
        Me.pctHomePage.TabStop = False
        '
        'btnBookNow1
        '
        Me.btnBookNow1.FlatAppearance.BorderSize = 0
        Me.btnBookNow1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBookNow1.Font = New System.Drawing.Font("Glacial Indifference", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBookNow1.ForeColor = System.Drawing.Color.White
        Me.btnBookNow1.Location = New System.Drawing.Point(410, 627)
        Me.btnBookNow1.Name = "btnBookNow1"
        Me.btnBookNow1.Size = New System.Drawing.Size(364, 85)
        Me.btnBookNow1.TabIndex = 3
        Me.btnBookNow1.Text = "BOOK NOW "
        Me.btnBookNow1.UseVisualStyleBackColor = True
        '
        'Interface1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnBookNow1)
        Me.Controls.Add(Me.pctHomePage)
        Me.Name = "Interface1"
        Me.Size = New System.Drawing.Size(1902, 903)
        CType(Me.pctHomePage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pctHomePage As PictureBox
    Friend WithEvents btnBookNow1 As Button
End Class
