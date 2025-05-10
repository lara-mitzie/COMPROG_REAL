<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pickServices3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pickServices3))
        Me.pnlAbovebuttons2 = New System.Windows.Forms.Panel()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.pctMain = New System.Windows.Forms.PictureBox()
        Me.pnlTimer8 = New System.Windows.Forms.Timer(Me.components)
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnCheckUp = New System.Windows.Forms.Button()
        Me.btnVaccine = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.pnlAbovebuttons2.SuspendLayout()
        CType(Me.pctMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlAbovebuttons2
        '
        Me.pnlAbovebuttons2.BackColor = System.Drawing.Color.White
        Me.pnlAbovebuttons2.Controls.Add(Me.btnMinimize)
        Me.pnlAbovebuttons2.Controls.Add(Me.btnExit)
        Me.pnlAbovebuttons2.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAbovebuttons2.Location = New System.Drawing.Point(0, 0)
        Me.pnlAbovebuttons2.Name = "pnlAbovebuttons2"
        Me.pnlAbovebuttons2.Size = New System.Drawing.Size(1866, 21)
        Me.pnlAbovebuttons2.TabIndex = 21
        '
        'btnMinimize
        '
        Me.btnMinimize.BackColor = System.Drawing.Color.White
        Me.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Image = CType(resources.GetObject("btnMinimize.Image"), System.Drawing.Image)
        Me.btnMinimize.Location = New System.Drawing.Point(1796, 0)
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
        Me.btnExit.Location = New System.Drawing.Point(1831, 0)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(35, 21)
        Me.btnExit.TabIndex = 0
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'pctMain
        '
        Me.pctMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pctMain.Image = CType(resources.GetObject("pctMain.Image"), System.Drawing.Image)
        Me.pctMain.Location = New System.Drawing.Point(0, 0)
        Me.pctMain.Name = "pctMain"
        Me.pctMain.Size = New System.Drawing.Size(1866, 939)
        Me.pctMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctMain.TabIndex = 22
        Me.pctMain.TabStop = False
        '
        'pnlTimer8
        '
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.White
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Image = CType(resources.GetObject("btnBack.Image"), System.Drawing.Image)
        Me.btnBack.Location = New System.Drawing.Point(1601, 34)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(63, 53)
        Me.btnBack.TabIndex = 27
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnCheckUp
        '
        Me.btnCheckUp.FlatAppearance.BorderSize = 0
        Me.btnCheckUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheckUp.Font = New System.Drawing.Font("Glacial Indifference", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckUp.Location = New System.Drawing.Point(1104, 426)
        Me.btnCheckUp.Name = "btnCheckUp"
        Me.btnCheckUp.Size = New System.Drawing.Size(525, 87)
        Me.btnCheckUp.TabIndex = 26
        Me.btnCheckUp.Text = "CHECK-UP"
        Me.btnCheckUp.UseVisualStyleBackColor = True
        '
        'btnVaccine
        '
        Me.btnVaccine.FlatAppearance.BorderSize = 0
        Me.btnVaccine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVaccine.Font = New System.Drawing.Font("Glacial Indifference", 16.2!, System.Drawing.FontStyle.Bold)
        Me.btnVaccine.Location = New System.Drawing.Point(286, 426)
        Me.btnVaccine.Name = "btnVaccine"
        Me.btnVaccine.Size = New System.Drawing.Size(525, 87)
        Me.btnVaccine.TabIndex = 25
        Me.btnVaccine.Text = "VACCINATION"
        Me.btnVaccine.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.FlatAppearance.BorderSize = 0
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Font = New System.Drawing.Font("Glacial Indifference", 16.2!, System.Drawing.FontStyle.Bold)
        Me.btnNext.ForeColor = System.Drawing.Color.White
        Me.btnNext.Location = New System.Drawing.Point(1161, 749)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(693, 87)
        Me.btnNext.TabIndex = 24
        Me.btnNext.Text = "NEXT"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Glacial Indifference", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(418, 777)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(160, 57)
        Me.lblPrice.TabIndex = 23
        Me.lblPrice.Text = "Label1"
        '
        'pickServices3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1866, 939)
        Me.Controls.Add(Me.pnlAbovebuttons2)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnCheckUp)
        Me.Controls.Add(Me.btnVaccine)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.pctMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "pickServices3"
        Me.Text = "pickServices3"
        Me.pnlAbovebuttons2.ResumeLayout(False)
        CType(Me.pctMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlAbovebuttons2 As Panel
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents pctMain As PictureBox
    Friend WithEvents pnlTimer8 As Timer
    Friend WithEvents btnBack As Button
    Friend WithEvents btnCheckUp As Button
    Friend WithEvents btnVaccine As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents lblPrice As Label
End Class
