<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class petInfo
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
        Me.txtBreed = New System.Windows.Forms.TextBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.dtpBirthday = New System.Windows.Forms.DateTimePicker()
        Me.cbVetStat = New System.Windows.Forms.ComboBox()
        Me.txtGetDate = New System.Windows.Forms.TextBox()
        Me.txtgetVac = New System.Windows.Forms.TextBox()
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
        Me.txtAge.ReadOnly = True
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
        Me.btnMale.Location = New System.Drawing.Point(123, 466)
        Me.btnMale.Name = "btnMale"
        Me.btnMale.Size = New System.Drawing.Size(330, 52)
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
        Me.btnFemale.Size = New System.Drawing.Size(330, 52)
        Me.btnFemale.TabIndex = 11
        Me.btnFemale.Text = "FEMALE"
        Me.btnFemale.UseVisualStyleBackColor = True
        '
        'btnFeline
        '
        Me.btnFeline.FlatAppearance.BorderSize = 0
        Me.btnFeline.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFeline.Font = New System.Drawing.Font("Glacial Indifference", 13.8!, System.Drawing.FontStyle.Bold)
        Me.btnFeline.Location = New System.Drawing.Point(122, 585)
        Me.btnFeline.Name = "btnFeline"
        Me.btnFeline.Size = New System.Drawing.Size(195, 52)
        Me.btnFeline.TabIndex = 12
        Me.btnFeline.Text = "FELINE"
        Me.btnFeline.UseVisualStyleBackColor = True
        '
        'btnCanine
        '
        Me.btnCanine.FlatAppearance.BorderSize = 0
        Me.btnCanine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCanine.Font = New System.Drawing.Font("Glacial Indifference", 13.8!, System.Drawing.FontStyle.Bold)
        Me.btnCanine.Location = New System.Drawing.Point(361, 585)
        Me.btnCanine.Name = "btnCanine"
        Me.btnCanine.Size = New System.Drawing.Size(195, 52)
        Me.btnCanine.TabIndex = 13
        Me.btnCanine.Text = "CANINE"
        Me.btnCanine.UseVisualStyleBackColor = True
        '
        'btnReptile
        '
        Me.btnReptile.FlatAppearance.BorderSize = 0
        Me.btnReptile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReptile.Font = New System.Drawing.Font("Glacial Indifference", 13.8!, System.Drawing.FontStyle.Bold)
        Me.btnReptile.Location = New System.Drawing.Point(603, 585)
        Me.btnReptile.Name = "btnReptile"
        Me.btnReptile.Size = New System.Drawing.Size(195, 52)
        Me.btnReptile.TabIndex = 14
        Me.btnReptile.Text = "REPTILE"
        Me.btnReptile.UseVisualStyleBackColor = True
        '
        'txtBreed
        '
        Me.txtBreed.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBreed.Font = New System.Drawing.Font("Glacial Indifference", 22.8!, System.Drawing.FontStyle.Bold)
        Me.txtBreed.Location = New System.Drawing.Point(169, 768)
        Me.txtBreed.Name = "txtBreed"
        Me.txtBreed.Size = New System.Drawing.Size(615, 46)
        Me.txtBreed.TabIndex = 15
        Me.txtBreed.Text = "bree"
        '
        'btnNext
        '
        Me.btnNext.FlatAppearance.BorderSize = 0
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Font = New System.Drawing.Font("Glacial Indifference", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.White
        Me.btnNext.Location = New System.Drawing.Point(153, 871)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(678, 62)
        Me.btnNext.TabIndex = 17
        Me.btnNext.Text = "NEXT"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.White
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Image = CType(resources.GetObject("btnBack.Image"), System.Drawing.Image)
        Me.btnBack.Location = New System.Drawing.Point(668, 16)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(65, 53)
        Me.btnBack.TabIndex = 18
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'dtpBirthday
        '
        Me.dtpBirthday.CalendarTitleBackColor = System.Drawing.Color.Beige
        Me.dtpBirthday.Font = New System.Drawing.Font("Glacial Indifference", 17.8!, System.Drawing.FontStyle.Bold)
        Me.dtpBirthday.Location = New System.Drawing.Point(184, 267)
        Me.dtpBirthday.Name = "dtpBirthday"
        Me.dtpBirthday.Size = New System.Drawing.Size(669, 43)
        Me.dtpBirthday.TabIndex = 19
        '
        'cbVetStat
        '
        Me.cbVetStat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbVetStat.Font = New System.Drawing.Font("Glacial Indifference", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbVetStat.FormattingEnabled = True
        Me.cbVetStat.Items.AddRange(New Object() {"COMPLETE", "INCOMPLETE"})
        Me.cbVetStat.Location = New System.Drawing.Point(169, 677)
        Me.cbVetStat.Name = "cbVetStat"
        Me.cbVetStat.Size = New System.Drawing.Size(678, 43)
        Me.cbVetStat.TabIndex = 20
        Me.cbVetStat.Text = "VAC"
        '
        'txtGetDate
        '
        Me.txtGetDate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtGetDate.Font = New System.Drawing.Font("Glacial Indifference", 22.8!, System.Drawing.FontStyle.Bold)
        Me.txtGetDate.Location = New System.Drawing.Point(169, 263)
        Me.txtGetDate.Name = "txtGetDate"
        Me.txtGetDate.ReadOnly = True
        Me.txtGetDate.Size = New System.Drawing.Size(658, 46)
        Me.txtGetDate.TabIndex = 21
        '
        'txtgetVac
        '
        Me.txtgetVac.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtgetVac.Font = New System.Drawing.Font("Glacial Indifference", 22.8!, System.Drawing.FontStyle.Bold)
        Me.txtgetVac.Location = New System.Drawing.Point(169, 677)
        Me.txtgetVac.Name = "txtgetVac"
        Me.txtgetVac.ReadOnly = True
        Me.txtgetVac.Size = New System.Drawing.Size(659, 46)
        Me.txtgetVac.TabIndex = 22
        '
        'petInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1884, 986)
        Me.Controls.Add(Me.txtgetVac)
        Me.Controls.Add(Me.txtGetDate)
        Me.Controls.Add(Me.cbVetStat)
        Me.Controls.Add(Me.dtpBirthday)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.txtBreed)
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
    Friend WithEvents txtBreed As TextBox
    Friend WithEvents btnNext As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents dtpBirthday As DateTimePicker
    Friend WithEvents cbVetStat As ComboBox
    Friend WithEvents txtGetDate As TextBox
    Friend WithEvents txtgetVac As TextBox
End Class
