<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bookSummary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(bookSummary))
        Me.pctMain = New System.Windows.Forms.PictureBox()
        Me.pnlAbovebuttons2 = New System.Windows.Forms.Panel()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.TimerPanel2 = New System.Windows.Forms.Timer(Me.components)
        Me.lblOwnerName = New System.Windows.Forms.Label()
        Me.lblEmailAdd = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.lblPetName = New System.Windows.Forms.Label()
        Me.lblDateBirth = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.lblPetSex = New System.Windows.Forms.Label()
        Me.lblPetType = New System.Windows.Forms.Label()
        Me.lblVaccination = New System.Windows.Forms.Label()
        Me.lblBreed = New System.Windows.Forms.Label()
        Me.lblServiceType = New System.Windows.Forms.Label()
        Me.lblServicePrice = New System.Windows.Forms.Label()
        Me.lblBookingDate = New System.Windows.Forms.Label()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.lblOwnerAge = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
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
        Me.pctMain.Size = New System.Drawing.Size(1366, 768)
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
        Me.pnlAbovebuttons2.Size = New System.Drawing.Size(1366, 21)
        Me.pnlAbovebuttons2.TabIndex = 8
        '
        'btnMinimize
        '
        Me.btnMinimize.BackColor = System.Drawing.Color.White
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Image = CType(resources.GetObject("btnMinimize.Image"), System.Drawing.Image)
        Me.btnMinimize.Location = New System.Drawing.Point(1266, 0)
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
        Me.btnExit.Location = New System.Drawing.Point(1303, 0)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(35, 21)
        Me.btnExit.TabIndex = 0
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'TimerPanel2
        '
        '
        'lblOwnerName
        '
        Me.lblOwnerName.AutoSize = True
        Me.lblOwnerName.Font = New System.Drawing.Font("Glacial Indifference", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOwnerName.Location = New System.Drawing.Point(299, 224)
        Me.lblOwnerName.Name = "lblOwnerName"
        Me.lblOwnerName.Size = New System.Drawing.Size(77, 28)
        Me.lblOwnerName.TabIndex = 9
        Me.lblOwnerName.Text = "Label1"
        '
        'lblEmailAdd
        '
        Me.lblEmailAdd.AutoSize = True
        Me.lblEmailAdd.Font = New System.Drawing.Font("Glacial Indifference", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailAdd.Location = New System.Drawing.Point(247, 393)
        Me.lblEmailAdd.Name = "lblEmailAdd"
        Me.lblEmailAdd.Size = New System.Drawing.Size(77, 28)
        Me.lblEmailAdd.TabIndex = 10
        Me.lblEmailAdd.Text = "Label1"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Glacial Indifference", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(283, 455)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(77, 28)
        Me.lblAddress.TabIndex = 11
        Me.lblAddress.Text = "Label1"
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Font = New System.Drawing.Font("Glacial Indifference", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhoneNumber.Location = New System.Drawing.Point(257, 527)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(77, 28)
        Me.lblPhoneNumber.TabIndex = 12
        Me.lblPhoneNumber.Text = "Label1"
        '
        'lblPetName
        '
        Me.lblPetName.AutoSize = True
        Me.lblPetName.Font = New System.Drawing.Font("Glacial Indifference", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPetName.Location = New System.Drawing.Point(646, 262)
        Me.lblPetName.Name = "lblPetName"
        Me.lblPetName.Size = New System.Drawing.Size(77, 28)
        Me.lblPetName.TabIndex = 13
        Me.lblPetName.Text = "Label1"
        '
        'lblDateBirth
        '
        Me.lblDateBirth.AutoSize = True
        Me.lblDateBirth.Font = New System.Drawing.Font("Glacial Indifference", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateBirth.Location = New System.Drawing.Point(646, 333)
        Me.lblDateBirth.Name = "lblDateBirth"
        Me.lblDateBirth.Size = New System.Drawing.Size(82, 28)
        Me.lblDateBirth.TabIndex = 14
        Me.lblDateBirth.Text = "Label2"
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Font = New System.Drawing.Font("Glacial Indifference", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.Location = New System.Drawing.Point(646, 434)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(82, 28)
        Me.lblAge.TabIndex = 15
        Me.lblAge.Text = "Label2"
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Font = New System.Drawing.Font("Glacial Indifference", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeight.Location = New System.Drawing.Point(646, 520)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(82, 28)
        Me.lblWeight.TabIndex = 16
        Me.lblWeight.Text = "Label2"
        '
        'lblPetSex
        '
        Me.lblPetSex.AutoSize = True
        Me.lblPetSex.Font = New System.Drawing.Font("Glacial Indifference", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPetSex.Location = New System.Drawing.Point(999, 262)
        Me.lblPetSex.Name = "lblPetSex"
        Me.lblPetSex.Size = New System.Drawing.Size(82, 28)
        Me.lblPetSex.TabIndex = 17
        Me.lblPetSex.Text = "Label2"
        '
        'lblPetType
        '
        Me.lblPetType.AutoSize = True
        Me.lblPetType.Font = New System.Drawing.Font("Glacial Indifference", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPetType.Image = CType(resources.GetObject("lblPetType.Image"), System.Drawing.Image)
        Me.lblPetType.Location = New System.Drawing.Point(999, 333)
        Me.lblPetType.Name = "lblPetType"
        Me.lblPetType.Size = New System.Drawing.Size(82, 28)
        Me.lblPetType.TabIndex = 18
        Me.lblPetType.Text = "Label2"
        '
        'lblVaccination
        '
        Me.lblVaccination.AutoSize = True
        Me.lblVaccination.Font = New System.Drawing.Font("Glacial Indifference", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVaccination.Location = New System.Drawing.Point(999, 424)
        Me.lblVaccination.Name = "lblVaccination"
        Me.lblVaccination.Size = New System.Drawing.Size(82, 28)
        Me.lblVaccination.TabIndex = 19
        Me.lblVaccination.Text = "Label2"
        '
        'lblBreed
        '
        Me.lblBreed.AutoSize = True
        Me.lblBreed.Font = New System.Drawing.Font("Glacial Indifference", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBreed.Location = New System.Drawing.Point(999, 520)
        Me.lblBreed.Name = "lblBreed"
        Me.lblBreed.Size = New System.Drawing.Size(82, 28)
        Me.lblBreed.TabIndex = 20
        Me.lblBreed.Text = "Label2"
        '
        'lblServiceType
        '
        Me.lblServiceType.AutoSize = True
        Me.lblServiceType.Font = New System.Drawing.Font("Glacial Indifference", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServiceType.Location = New System.Drawing.Point(233, 616)
        Me.lblServiceType.Name = "lblServiceType"
        Me.lblServiceType.Size = New System.Drawing.Size(82, 28)
        Me.lblServiceType.TabIndex = 21
        Me.lblServiceType.Text = "Label2"
        '
        'lblServicePrice
        '
        Me.lblServicePrice.AutoSize = True
        Me.lblServicePrice.Font = New System.Drawing.Font("Glacial Indifference", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServicePrice.Location = New System.Drawing.Point(311, 661)
        Me.lblServicePrice.Name = "lblServicePrice"
        Me.lblServicePrice.Size = New System.Drawing.Size(82, 28)
        Me.lblServicePrice.TabIndex = 22
        Me.lblServicePrice.Text = "Label2"
        '
        'lblBookingDate
        '
        Me.lblBookingDate.AutoSize = True
        Me.lblBookingDate.Font = New System.Drawing.Font("Glacial Indifference", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookingDate.Location = New System.Drawing.Point(311, 708)
        Me.lblBookingDate.Name = "lblBookingDate"
        Me.lblBookingDate.Size = New System.Drawing.Size(82, 28)
        Me.lblBookingDate.TabIndex = 23
        Me.lblBookingDate.Text = "Label2"
        '
        'btnConfirm
        '
        Me.btnConfirm.FlatAppearance.BorderSize = 0
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirm.Font = New System.Drawing.Font("Glacial Indifference", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.ForeColor = System.Drawing.Color.White
        Me.btnConfirm.Location = New System.Drawing.Point(825, 634)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(273, 87)
        Me.btnConfirm.TabIndex = 24
        Me.btnConfirm.Text = "CONFIRM"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'lblOwnerAge
        '
        Me.lblOwnerAge.AutoSize = True
        Me.lblOwnerAge.Font = New System.Drawing.Font("Glacial Indifference", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOwnerAge.Location = New System.Drawing.Point(187, 280)
        Me.lblOwnerAge.Name = "lblOwnerAge"
        Me.lblOwnerAge.Size = New System.Drawing.Size(77, 28)
        Me.lblOwnerAge.TabIndex = 25
        Me.lblOwnerAge.Text = "Label1"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Glacial Indifference", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.Location = New System.Drawing.Point(233, 333)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(77, 28)
        Me.lblGender.TabIndex = 26
        Me.lblGender.Text = "Label1"
        '
        'bookSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblOwnerAge)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.lblBookingDate)
        Me.Controls.Add(Me.lblServicePrice)
        Me.Controls.Add(Me.lblServiceType)
        Me.Controls.Add(Me.lblBreed)
        Me.Controls.Add(Me.lblVaccination)
        Me.Controls.Add(Me.lblPetType)
        Me.Controls.Add(Me.lblPetSex)
        Me.Controls.Add(Me.lblWeight)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.lblDateBirth)
        Me.Controls.Add(Me.lblPetName)
        Me.Controls.Add(Me.lblPhoneNumber)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblEmailAdd)
        Me.Controls.Add(Me.lblOwnerName)
        Me.Controls.Add(Me.pnlAbovebuttons2)
        Me.Controls.Add(Me.pctMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "bookSummary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "bookSummary"
        CType(Me.pctMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAbovebuttons2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pctMain As PictureBox
    Friend WithEvents pnlAbovebuttons2 As Panel
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents TimerPanel2 As Timer
    Friend WithEvents lblOwnerName As Label
    Friend WithEvents lblEmailAdd As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents lblPetName As Label
    Friend WithEvents lblDateBirth As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents lblWeight As Label
    Friend WithEvents lblPetSex As Label
    Friend WithEvents lblPetType As Label
    Friend WithEvents lblVaccination As Label
    Friend WithEvents lblBreed As Label
    Friend WithEvents lblServiceType As Label
    Friend WithEvents lblServicePrice As Label
    Friend WithEvents lblBookingDate As Label
    Friend WithEvents btnConfirm As Button
    Friend WithEvents lblOwnerAge As Label
    Friend WithEvents lblGender As Label
End Class
