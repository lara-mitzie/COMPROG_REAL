<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class customerAccount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(customerAccount))
        Me.pnlPetList = New System.Windows.Forms.Panel()
        Me.btnAddPet = New System.Windows.Forms.Button()
        Me.pnlAbovebuttons2 = New System.Windows.Forms.Panel()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.pnlTimer2 = New System.Windows.Forms.Timer(Me.components)
        Me.pctMain = New System.Windows.Forms.PictureBox()
        Me.pctBlur = New System.Windows.Forms.PictureBox()
        Me.pnlAbovebuttons2.SuspendLayout()
        CType(Me.pctMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctBlur, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlPetList
        '
        Me.pnlPetList.Location = New System.Drawing.Point(180, 191)
        Me.pnlPetList.Name = "pnlPetList"
        Me.pnlPetList.Size = New System.Drawing.Size(1700, 720)
        Me.pnlPetList.TabIndex = 1
        '
        'btnAddPet
        '
        Me.btnAddPet.Font = New System.Drawing.Font("Glacial Indifference", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddPet.ForeColor = System.Drawing.Color.White
        Me.btnAddPet.Location = New System.Drawing.Point(702, 874)
        Me.btnAddPet.Name = "btnAddPet"
        Me.btnAddPet.Size = New System.Drawing.Size(429, 77)
        Me.btnAddPet.TabIndex = 0
        Me.btnAddPet.Text = "ADD NEW PET"
        Me.btnAddPet.UseVisualStyleBackColor = True
        '
        'pnlAbovebuttons2
        '
        Me.pnlAbovebuttons2.BackColor = System.Drawing.Color.White
        Me.pnlAbovebuttons2.Controls.Add(Me.btnMinimize)
        Me.pnlAbovebuttons2.Controls.Add(Me.btnExit)
        Me.pnlAbovebuttons2.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAbovebuttons2.Location = New System.Drawing.Point(0, 0)
        Me.pnlAbovebuttons2.Name = "pnlAbovebuttons2"
        Me.pnlAbovebuttons2.Size = New System.Drawing.Size(1884, 21)
        Me.pnlAbovebuttons2.TabIndex = 4
        '
        'btnMinimize
        '
        Me.btnMinimize.BackColor = System.Drawing.Color.White
        Me.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Image = CType(resources.GetObject("btnMinimize.Image"), System.Drawing.Image)
        Me.btnMinimize.Location = New System.Drawing.Point(1814, 0)
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
        Me.btnExit.Location = New System.Drawing.Point(1849, 0)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(35, 21)
        Me.btnExit.TabIndex = 0
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'pnlTimer2
        '
        '
        'pctMain
        '
        Me.pctMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pctMain.Image = CType(resources.GetObject("pctMain.Image"), System.Drawing.Image)
        Me.pctMain.Location = New System.Drawing.Point(0, 0)
        Me.pctMain.Name = "pctMain"
        Me.pctMain.Size = New System.Drawing.Size(1884, 986)
        Me.pctMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctMain.TabIndex = 0
        Me.pctMain.TabStop = False
        '
        'pctBlur
        '
        Me.pctBlur.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pctBlur.Image = CType(resources.GetObject("pctBlur.Image"), System.Drawing.Image)
        Me.pctBlur.Location = New System.Drawing.Point(0, 0)
        Me.pctBlur.Name = "pctBlur"
        Me.pctBlur.Size = New System.Drawing.Size(1884, 986)
        Me.pctBlur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctBlur.TabIndex = 5
        Me.pctBlur.TabStop = False
        Me.pctBlur.Visible = False
        '
        'customerAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1884, 986)
        Me.Controls.Add(Me.btnAddPet)
        Me.Controls.Add(Me.pnlAbovebuttons2)
        Me.Controls.Add(Me.pnlPetList)
        Me.Controls.Add(Me.pctMain)
        Me.Controls.Add(Me.pctBlur)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "customerAccount"
        Me.Text = "customerAccount"
        Me.pnlAbovebuttons2.ResumeLayout(False)
        CType(Me.pctMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctBlur, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlPetList As Panel
    Friend WithEvents pnlAbovebuttons2 As Panel
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents pnlTimer2 As Timer
    Friend WithEvents btnAddPet As Button
    Friend WithEvents pctMain As PictureBox
    Friend WithEvents pctBlur As PictureBox
End Class
