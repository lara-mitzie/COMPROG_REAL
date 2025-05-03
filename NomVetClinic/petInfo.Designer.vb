<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class petInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(petInfo))
        Me.pnlAbovebuttons3 = New System.Windows.Forms.Panel()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.pnlTimer7 = New System.Windows.Forms.Timer(Me.components)
        Me.pctMain = New System.Windows.Forms.PictureBox()
        Me.txtPetName = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.btnMale = New System.Windows.Forms.Button()
        Me.btnFemale = New System.Windows.Forms.Button()
        Me.btnFeline = New System.Windows.Forms.Button()
        Me.btnCanine = New System.Windows.Forms.Button()
        Me.btnReptile = New System.Windows.Forms.Button()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.dtpBirthday = New System.Windows.Forms.DateTimePicker()
        Me.pnlAbovebuttons3.SuspendLayout()
        CType(Me.pctMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlAbovebuttons3
        '
        Me.pnlAbovebuttons3.BackColor = System.Drawing.Color.White
        Me.pnlAbovebuttons3.Controls.Add(Me.btnMinimize)
        Me.pnlAbovebuttons3.Controls.Add(Me.btnExit)
        Me.pnlAbovebuttons3.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAbovebuttons3.Location = New System.Drawing.Point(0, 0)
        Me.pnlAbovebuttons3.Name = "pnlAbovebuttons3"
        Me.pnlAbovebuttons3.Size = New System.Drawing.Size(1884, 21)
        Me.pnlAbovebuttons3.TabIndex = 4
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
        'pnlTimer7
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
        Me.pctMain.TabIndex = 5
        Me.pctMain.TabStop = False
        '
        'txtPetName
        '
        Me.txtPetName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPetName.Font = New System.Drawing.Font("Glacial Indifference", 22.8!, System.Drawing.FontStyle.Bold)
        Me.txtPetName.Location = New System.Drawing.Point(184, 184)
        Me.txtPetName.Name = "txtPetName"
        Me.txtPetName.Size = New System.Drawing.Size(632, 46)
        Me.txtPetName.TabIndex = 6
        Me.txtPetName.Text = "f"
        '
        'txtAge
        '
        Me.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAge.Font = New System.Drawing.Font("Glacial Indifference", 22.8!, System.Drawing.FontStyle.Bold)
        Me.txtAge.Location = New System.Drawing.Point(184, 351)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(262, 46)
        Me.txtAge.TabIndex = 8
        Me.txtAge.Text = "age"
        '
        'txtWeight
        '
        Me.txtWeight.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtWeight.Font = New System.Drawing.Font("Glacial Indifference", 22.8!, System.Drawing.FontStyle.Bold)
        Me.txtWeight.Location = New System.Drawing.Point(537, 351)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(262, 46)
        Me.txtWeight.TabIndex = 9
        Me.txtWeight.Text = "w"
        '
        'btnMale
        '
        Me.btnMale.FlatAppearance.BorderSize = 0
        Me.btnMale.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMale.Font = New System.Drawing.Font("Glacial Indifference", 13.8!, System.Drawing.FontStyle.Bold)
        Me.btnMale.Location = New System.Drawing.Point(163, 466)
        Me.btnMale.Name = "btnMale"
        Me.btnMale.Size = New System.Drawing.Size(290, 52)
        Me.btnMale.TabIndex = 10
        Me.btnMale.Text = "MALE"
        Me.btnMale.UseVisualStyleBackColor = True
        '
        'btnFemale
        '
        Me.btnFemale.FlatAppearance.BorderSize = 0
        Me.btnFemale.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFemale.Font = New System.Drawing.Font("Glacial Indifference", 13.8!, System.Drawing.FontStyle.Bold)
        Me.btnFemale.Location = New System.Drawing.Point(523, 466)
        Me.btnFemale.Name = "btnFemale"
        Me.btnFemale.Size = New System.Drawing.Size(293, 52)
        Me.btnFemale.TabIndex = 11
        Me.btnFemale.Text = "FEMALE"
        Me.btnFemale.UseVisualStyleBackColor = True
        '
        'btnFeline
        '
        Me.btnFeline.FlatAppearance.BorderSize = 0
        Me.btnFeline.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFeline.Font = New System.Drawing.Font("Glacial Indifference", 13.8!, System.Drawing.FontStyle.Bold)
        Me.btnFeline.Location = New System.Drawing.Point(163, 585)
        Me.btnFeline.Name = "btnFeline"
        Me.btnFeline.Size = New System.Drawing.Size(168, 52)
        Me.btnFeline.TabIndex = 12
        Me.btnFeline.Text = "FELINE"
        Me.btnFeline.UseVisualStyleBackColor = True
        '
        'btnCanine
        '
        Me.btnCanine.FlatAppearance.BorderSize = 0
        Me.btnCanine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCanine.Font = New System.Drawing.Font("Glacial Indifference", 13.8!, System.Drawing.FontStyle.Bold)
        Me.btnCanine.Location = New System.Drawing.Point(402, 585)
        Me.btnCanine.Name = "btnCanine"
        Me.btnCanine.Size = New System.Drawing.Size(168, 52)
        Me.btnCanine.TabIndex = 13
        Me.btnCanine.Text = "CANINE"
        Me.btnCanine.UseVisualStyleBackColor = True
        '
        'btnReptile
        '
        Me.btnReptile.FlatAppearance.BorderSize = 0
        Me.btnReptile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReptile.Font = New System.Drawing.Font("Glacial Indifference", 13.8!, System.Drawing.FontStyle.Bold)
        Me.btnReptile.Location = New System.Drawing.Point(644, 585)
        Me.btnReptile.Name = "btnReptile"
        Me.btnReptile.Size = New System.Drawing.Size(168, 52)
        Me.btnReptile.TabIndex = 14
        Me.btnReptile.Text = "REPTILE"
        Me.btnReptile.UseVisualStyleBackColor = True
        '
        'TextBox5
        '
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox5.Font = New System.Drawing.Font("Glacial Indifference", 22.8!, System.Drawing.FontStyle.Bold)
        Me.TextBox5.Location = New System.Drawing.Point(184, 679)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(594, 46)
        Me.TextBox5.TabIndex = 15
        Me.TextBox5.Text = "bree"
        '
        'TextBox6
        '
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox6.Font = New System.Drawing.Font("Glacial Indifference", 22.8!, System.Drawing.FontStyle.Bold)
        Me.TextBox6.Location = New System.Drawing.Point(184, 764)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(594, 46)
        Me.TextBox6.TabIndex = 16
        Me.TextBox6.Text = "vac"
        '
        'Button6
        '
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Glacial Indifference", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(153, 871)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(678, 62)
        Me.Button6.TabIndex = 17
        Me.Button6.Text = "NEXT"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.White
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Image = CType(resources.GetObject("Button7.Image"), System.Drawing.Image)
        Me.Button7.Location = New System.Drawing.Point(668, 16)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(65, 53)
        Me.Button7.TabIndex = 18
        Me.Button7.UseVisualStyleBackColor = False
        '
        'dtpBirthday
        '
        Me.dtpBirthday.Font = New System.Drawing.Font("Glacial Indifference", 20.8!, System.Drawing.FontStyle.Bold)
        Me.dtpBirthday.Location = New System.Drawing.Point(184, 267)
        Me.dtpBirthday.Name = "dtpBirthday"
        Me.dtpBirthday.Size = New System.Drawing.Size(632, 49)
        Me.dtpBirthday.TabIndex = 19
        '
        'petInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1884, 986)
        Me.Controls.Add(Me.dtpBirthday)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.btnReptile)
        Me.Controls.Add(Me.btnCanine)
        Me.Controls.Add(Me.btnFeline)
        Me.Controls.Add(Me.btnFemale)
        Me.Controls.Add(Me.btnMale)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.txtPetName)
        Me.Controls.Add(Me.pnlAbovebuttons3)
        Me.Controls.Add(Me.pctMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "petInfo"
        Me.Text = "petInfo"
        Me.pnlAbovebuttons3.ResumeLayout(False)
        CType(Me.pctMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlAbovebuttons3 As Panel
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents pnlTimer7 As Timer
    Friend WithEvents pctMain As PictureBox
    Friend WithEvents txtPetName As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents btnMale As Button
    Friend WithEvents btnFemale As Button
    Friend WithEvents btnFeline As Button
    Friend WithEvents btnCanine As Button
    Friend WithEvents btnReptile As Button
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents dtpBirthday As DateTimePicker
End Class
