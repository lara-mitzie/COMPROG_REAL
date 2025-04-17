<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Interface2
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Interface2))
        Me.pctAnimals = New System.Windows.Forms.PictureBox()
        Me.timerAbovepnl2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pctAnimals, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pctAnimals
        '
        Me.pctAnimals.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pctAnimals.Image = CType(resources.GetObject("pctAnimals.Image"), System.Drawing.Image)
        Me.pctAnimals.Location = New System.Drawing.Point(0, 0)
        Me.pctAnimals.Name = "pctAnimals"
        Me.pctAnimals.Size = New System.Drawing.Size(1902, 903)
        Me.pctAnimals.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctAnimals.TabIndex = 0
        Me.pctAnimals.TabStop = False
        '
        'Interface2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pctAnimals)
        Me.Name = "Interface2"
        Me.Size = New System.Drawing.Size(1902, 903)
        CType(Me.pctAnimals, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pctAnimals As PictureBox
    Friend WithEvents timerAbovepnl2 As Timer
End Class
