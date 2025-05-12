<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ownerinformation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ownerinformation))
        Me.pnlAbovebuttons3 = New System.Windows.Forms.Panel()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.pnlTopTImer4 = New System.Windows.Forms.Timer(Me.components)
        Me.pctBoxMain = New System.Windows.Forms.PictureBox()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.txtEmailAdd = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtContactNumber = New System.Windows.Forms.TextBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.cbSex = New System.Windows.Forms.ComboBox()
        Me.txtGetSex = New System.Windows.Forms.TextBox()
        Me.pnlAbovebuttons3.SuspendLayout()
        CType(Me.pctBoxMain, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pnlAbovebuttons3.Size = New System.Drawing.Size(1902, 21)
        Me.pnlAbovebuttons3.TabIndex = 3
        '
        'btnMinimize
        '
        Me.btnMinimize.BackColor = System.Drawing.Color.White
        Me.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Image = CType(resources.GetObject("btnMinimize.Image"), System.Drawing.Image)
        Me.btnMinimize.Location = New System.Drawing.Point(1832, 0)
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
        Me.btnExit.Location = New System.Drawing.Point(1867, 0)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(35, 21)
        Me.btnExit.TabIndex = 0
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'pnlTopTImer4
        '
        '
        'pctBoxMain
        '
        Me.pctBoxMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pctBoxMain.Image = CType(resources.GetObject("pctBoxMain.Image"), System.Drawing.Image)
        Me.pctBoxMain.Location = New System.Drawing.Point(0, 0)
        Me.pctBoxMain.Name = "pctBoxMain"
        Me.pctBoxMain.Size = New System.Drawing.Size(1902, 1033)
        Me.pctBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctBoxMain.TabIndex = 4
        Me.pctBoxMain.TabStop = False
        '
        'txtFullName
        '
        Me.txtFullName.BackColor = System.Drawing.SystemColors.Highlight
        Me.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFullName.Font = New System.Drawing.Font("Glacial Indifference", 25.8!, System.Drawing.FontStyle.Bold)
        Me.txtFullName.Location = New System.Drawing.Point(256, 348)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(548, 52)
        Me.txtFullName.TabIndex = 5
        '
        'txtEmailAdd
        '
        Me.txtEmailAdd.BackColor = System.Drawing.SystemColors.Highlight
        Me.txtEmailAdd.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmailAdd.Font = New System.Drawing.Font("Glacial Indifference", 25.8!, System.Drawing.FontStyle.Bold)
        Me.txtEmailAdd.Location = New System.Drawing.Point(256, 560)
        Me.txtEmailAdd.Name = "txtEmailAdd"
        Me.txtEmailAdd.Size = New System.Drawing.Size(548, 52)
        Me.txtEmailAdd.TabIndex = 6
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.SystemColors.Highlight
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAddress.Font = New System.Drawing.Font("Glacial Indifference", 25.8!, System.Drawing.FontStyle.Bold)
        Me.txtAddress.Location = New System.Drawing.Point(256, 662)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(548, 52)
        Me.txtAddress.TabIndex = 7
        '
        'txtContactNumber
        '
        Me.txtContactNumber.BackColor = System.Drawing.SystemColors.Highlight
        Me.txtContactNumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtContactNumber.Font = New System.Drawing.Font("Glacial Indifference", 25.8!, System.Drawing.FontStyle.Bold)
        Me.txtContactNumber.Location = New System.Drawing.Point(256, 773)
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.Size = New System.Drawing.Size(548, 52)
        Me.txtContactNumber.TabIndex = 8
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.Black
        Me.btnNext.FlatAppearance.BorderSize = 0
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Font = New System.Drawing.Font("Glacial Indifference", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.White
        Me.btnNext.Location = New System.Drawing.Point(134, 874)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(739, 85)
        Me.btnNext.TabIndex = 9
        Me.btnNext.Text = "NEXT"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.White
        Me.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Image = CType(resources.GetObject("btnBack.Image"), System.Drawing.Image)
        Me.btnBack.Location = New System.Drawing.Point(717, 59)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(67, 61)
        Me.btnBack.TabIndex = 10
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'txtAge
        '
        Me.txtAge.BackColor = System.Drawing.SystemColors.Highlight
        Me.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAge.Font = New System.Drawing.Font("Glacial Indifference", 25.8!, System.Drawing.FontStyle.Bold)
        Me.txtAge.Location = New System.Drawing.Point(200, 464)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(269, 52)
        Me.txtAge.TabIndex = 11
        '
        'cbSex
        '
        Me.cbSex.Font = New System.Drawing.Font("Glacial Indifference", 20.8!, System.Drawing.FontStyle.Bold)
        Me.cbSex.FormattingEnabled = True
        Me.cbSex.Items.AddRange(New Object() {"MALE", "FEMALE"})
        Me.cbSex.Location = New System.Drawing.Point(572, 462)
        Me.cbSex.Name = "cbSex"
        Me.cbSex.Size = New System.Drawing.Size(285, 50)
        Me.cbSex.TabIndex = 12
        '
        'txtGetSex
        '
        Me.txtGetSex.BackColor = System.Drawing.SystemColors.Highlight
        Me.txtGetSex.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtGetSex.Font = New System.Drawing.Font("Glacial Indifference", 25.8!, System.Drawing.FontStyle.Bold)
        Me.txtGetSex.Location = New System.Drawing.Point(572, 461)
        Me.txtGetSex.Name = "txtGetSex"
        Me.txtGetSex.ReadOnly = True
        Me.txtGetSex.Size = New System.Drawing.Size(269, 52)
        Me.txtGetSex.TabIndex = 13
        '
        'Ownerinformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1902, 1033)
        Me.Controls.Add(Me.txtGetSex)
        Me.Controls.Add(Me.cbSex)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.txtContactNumber)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtEmailAdd)
        Me.Controls.Add(Me.txtFullName)
        Me.Controls.Add(Me.pnlAbovebuttons3)
        Me.Controls.Add(Me.pctBoxMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Ownerinformation"
        Me.Text = "Ownerinformation"
        Me.pnlAbovebuttons3.ResumeLayout(False)
        CType(Me.pctBoxMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlAbovebuttons3 As Panel
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents pnlTopTImer4 As Timer
    Friend WithEvents pctBoxMain As PictureBox
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents txtEmailAdd As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtContactNumber As TextBox
    Friend WithEvents btnNext As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents txtAge As TextBox
    Friend WithEvents cbSex As ComboBox
    Friend WithEvents txtGetSex As TextBox
End Class
