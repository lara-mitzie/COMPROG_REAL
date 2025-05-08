<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewAppointment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(viewAppointment))
        Me.pctMain = New System.Windows.Forms.PictureBox()
        Me.pnlAbovebuttons2 = New System.Windows.Forms.Panel()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.TimerPanel = New System.Windows.Forms.Timer(Me.components)
        Me.pnlNearest = New System.Windows.Forms.Panel()
        Me.pnlPast = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        CType(Me.pctMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAbovebuttons2.SuspendLayout()
        Me.SuspendLayout()
        '
        'pctMain
        '
        Me.pctMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pctMain.Image = CType(resources.GetObject("pctMain.Image"), System.Drawing.Image)
        Me.pctMain.Location = New System.Drawing.Point(0, 0)
        Me.pctMain.Name = "pctMain"
        Me.pctMain.Size = New System.Drawing.Size(916, 537)
        Me.pctMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctMain.TabIndex = 0
        Me.pctMain.TabStop = False
        '
        'pnlAbovebuttons2
        '
        Me.pnlAbovebuttons2.BackColor = System.Drawing.Color.White
        Me.pnlAbovebuttons2.Controls.Add(Me.btnMinimize)
        Me.pnlAbovebuttons2.Controls.Add(Me.btnExit)
        Me.pnlAbovebuttons2.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAbovebuttons2.Location = New System.Drawing.Point(0, 0)
        Me.pnlAbovebuttons2.Name = "pnlAbovebuttons2"
        Me.pnlAbovebuttons2.Size = New System.Drawing.Size(916, 21)
        Me.pnlAbovebuttons2.TabIndex = 9
        '
        'btnMinimize
        '
        Me.btnMinimize.BackColor = System.Drawing.Color.White
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Image = CType(resources.GetObject("btnMinimize.Image"), System.Drawing.Image)
        Me.btnMinimize.Location = New System.Drawing.Point(799, 1)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(35, 21)
        Me.btnMinimize.TabIndex = 1
        Me.btnMinimize.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.White
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.Location = New System.Drawing.Point(837, 1)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(35, 21)
        Me.btnExit.TabIndex = 0
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'TimerPanel
        '
        '
        'pnlNearest
        '
        Me.pnlNearest.Location = New System.Drawing.Point(329, 95)
        Me.pnlNearest.Name = "pnlNearest"
        Me.pnlNearest.Size = New System.Drawing.Size(372, 27)
        Me.pnlNearest.TabIndex = 10
        '
        'pnlPast
        '
        Me.pnlPast.Location = New System.Drawing.Point(86, 177)
        Me.pnlPast.Name = "pnlPast"
        Me.pnlPast.Size = New System.Drawing.Size(749, 229)
        Me.pnlPast.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(75, 455)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(219, 53)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(615, 455)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(219, 53)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "Button2"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'viewAppointment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(916, 537)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.pnlPast)
        Me.Controls.Add(Me.pnlNearest)
        Me.Controls.Add(Me.pnlAbovebuttons2)
        Me.Controls.Add(Me.pctMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "viewAppointment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Appointments"
        CType(Me.pctMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAbovebuttons2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pctMain As PictureBox
    Friend WithEvents pnlAbovebuttons2 As Panel
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents TimerPanel As Timer
    Friend WithEvents pnlNearest As Panel
    Friend WithEvents pnlPast As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents btnCancel As Button
End Class
