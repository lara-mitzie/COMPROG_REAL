<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class petInformation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(petInformation))
        Me.lblPetType = New System.Windows.Forms.Label()
        Me.lblpetVacStatus = New System.Windows.Forms.Label()
        Me.lblPEtBreed = New System.Windows.Forms.Label()
        Me.lblPetWeight = New System.Windows.Forms.Label()
        Me.lblPetBirthday = New System.Windows.Forms.Label()
        Me.lblPetAge = New System.Windows.Forms.Label()
        Me.lblPetSex = New System.Windows.Forms.Label()
        Me.lblPetName = New System.Windows.Forms.Label()
        Me.pctMain = New System.Windows.Forms.PictureBox()
        Me.pnlAbovebuttons2 = New System.Windows.Forms.Panel()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.TimerPanel2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pctMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAbovebuttons2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblPetType
        '
        Me.lblPetType.AutoSize = True
        Me.lblPetType.Font = New System.Drawing.Font("Glacial Indifference", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPetType.Location = New System.Drawing.Point(952, 262)
        Me.lblPetType.Name = "lblPetType"
        Me.lblPetType.Size = New System.Drawing.Size(78, 34)
        Me.lblPetType.TabIndex = 45
        Me.lblPetType.Text = "TEXT"
        '
        'lblpetVacStatus
        '
        Me.lblpetVacStatus.AutoSize = True
        Me.lblpetVacStatus.Font = New System.Drawing.Font("Glacial Indifference", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpetVacStatus.Location = New System.Drawing.Point(993, 360)
        Me.lblpetVacStatus.Name = "lblpetVacStatus"
        Me.lblpetVacStatus.Size = New System.Drawing.Size(78, 34)
        Me.lblpetVacStatus.TabIndex = 40
        Me.lblpetVacStatus.Text = "TEXT"
        '
        'lblPEtBreed
        '
        Me.lblPEtBreed.AutoSize = True
        Me.lblPEtBreed.Font = New System.Drawing.Font("Glacial Indifference", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPEtBreed.Location = New System.Drawing.Point(869, 456)
        Me.lblPEtBreed.Name = "lblPEtBreed"
        Me.lblPEtBreed.Size = New System.Drawing.Size(78, 34)
        Me.lblPEtBreed.TabIndex = 39
        Me.lblPEtBreed.Text = "TEXT"
        '
        'lblPetWeight
        '
        Me.lblPetWeight.AutoSize = True
        Me.lblPetWeight.Font = New System.Drawing.Font("Glacial Indifference", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPetWeight.Location = New System.Drawing.Point(360, 452)
        Me.lblPetWeight.Name = "lblPetWeight"
        Me.lblPetWeight.Size = New System.Drawing.Size(78, 34)
        Me.lblPetWeight.TabIndex = 38
        Me.lblPetWeight.Text = "TEXT"
        '
        'lblPetBirthday
        '
        Me.lblPetBirthday.AutoSize = True
        Me.lblPetBirthday.Font = New System.Drawing.Font("Glacial Indifference", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPetBirthday.Location = New System.Drawing.Point(458, 262)
        Me.lblPetBirthday.Name = "lblPetBirthday"
        Me.lblPetBirthday.Size = New System.Drawing.Size(78, 34)
        Me.lblPetBirthday.TabIndex = 37
        Me.lblPetBirthday.Text = "TEXT"
        '
        'lblPetAge
        '
        Me.lblPetAge.AutoSize = True
        Me.lblPetAge.Font = New System.Drawing.Font("Glacial Indifference", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPetAge.Location = New System.Drawing.Point(300, 360)
        Me.lblPetAge.Name = "lblPetAge"
        Me.lblPetAge.Size = New System.Drawing.Size(78, 34)
        Me.lblPetAge.TabIndex = 36
        Me.lblPetAge.Text = "TEXT"
        '
        'lblPetSex
        '
        Me.lblPetSex.AutoSize = True
        Me.lblPetSex.Font = New System.Drawing.Font("Glacial Indifference", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPetSex.Location = New System.Drawing.Point(895, 170)
        Me.lblPetSex.Name = "lblPetSex"
        Me.lblPetSex.Size = New System.Drawing.Size(78, 34)
        Me.lblPetSex.TabIndex = 35
        Me.lblPetSex.Text = "TEXT"
        '
        'lblPetName
        '
        Me.lblPetName.AutoSize = True
        Me.lblPetName.Font = New System.Drawing.Font("Glacial Indifference", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPetName.Location = New System.Drawing.Point(386, 170)
        Me.lblPetName.Name = "lblPetName"
        Me.lblPetName.Size = New System.Drawing.Size(78, 34)
        Me.lblPetName.TabIndex = 34
        Me.lblPetName.Text = "TEXT"
        '
        'pctMain
        '
        Me.pctMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pctMain.Image = CType(resources.GetObject("pctMain.Image"), System.Drawing.Image)
        Me.pctMain.Location = New System.Drawing.Point(0, 0)
        Me.pctMain.Name = "pctMain"
        Me.pctMain.Size = New System.Drawing.Size(1348, 721)
        Me.pctMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctMain.TabIndex = 46
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
        Me.pnlAbovebuttons2.Size = New System.Drawing.Size(1348, 21)
        Me.pnlAbovebuttons2.TabIndex = 47
        '
        'btnMinimize
        '
        Me.btnMinimize.BackColor = System.Drawing.Color.White
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Image = CType(resources.GetObject("btnMinimize.Image"), System.Drawing.Image)
        Me.btnMinimize.Location = New System.Drawing.Point(1228, 0)
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
        Me.btnExit.Location = New System.Drawing.Point(1266, 0)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(35, 21)
        Me.btnExit.TabIndex = 0
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'TimerPanel2
        '
        '
        'petInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1348, 721)
        Me.Controls.Add(Me.pnlAbovebuttons2)
        Me.Controls.Add(Me.lblPetType)
        Me.Controls.Add(Me.lblpetVacStatus)
        Me.Controls.Add(Me.lblPEtBreed)
        Me.Controls.Add(Me.lblPetWeight)
        Me.Controls.Add(Me.lblPetBirthday)
        Me.Controls.Add(Me.lblPetAge)
        Me.Controls.Add(Me.lblPetSex)
        Me.Controls.Add(Me.lblPetName)
        Me.Controls.Add(Me.pctMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "petInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PetInformation"
        CType(Me.pctMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAbovebuttons2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPetType As Label
    Friend WithEvents lblpetVacStatus As Label
    Friend WithEvents lblPEtBreed As Label
    Friend WithEvents lblPetWeight As Label
    Friend WithEvents lblPetBirthday As Label
    Friend WithEvents lblPetAge As Label
    Friend WithEvents lblPetSex As Label
    Friend WithEvents lblPetName As Label
    Friend WithEvents pctMain As PictureBox
    Friend WithEvents pnlAbovebuttons2 As Panel
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents TimerPanel2 As Timer
End Class
