<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bookSummary2vb
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(bookSummary2vb))
        Me.pnlAbovebuttons2 = New System.Windows.Forms.Panel()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.pctMain = New System.Windows.Forms.PictureBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.lblService = New System.Windows.Forms.Label()
        Me.lblServicePrice = New System.Windows.Forms.Label()
        Me.lblBookingdate = New System.Windows.Forms.Label()
        Me.lblPetName = New System.Windows.Forms.Label()
        Me.lblPBrithday = New System.Windows.Forms.Label()
        Me.lblPAge = New System.Windows.Forms.Label()
        Me.lblPWeight = New System.Windows.Forms.Label()
        Me.lblPSex = New System.Windows.Forms.Label()
        Me.lblPType = New System.Windows.Forms.Label()
        Me.lblPbreed = New System.Windows.Forms.Label()
        Me.lblPVacStatus = New System.Windows.Forms.Label()
        Me.TimerPanel2 = New System.Windows.Forms.Timer(Me.components)
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
        Me.pnlAbovebuttons2.Size = New System.Drawing.Size(1348, 21)
        Me.pnlAbovebuttons2.TabIndex = 9
        '
        'btnMinimize
        '
        Me.btnMinimize.BackColor = System.Drawing.Color.White
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Image = CType(resources.GetObject("btnMinimize.Image"), System.Drawing.Image)
        Me.btnMinimize.Location = New System.Drawing.Point(1204, 0)
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
        Me.btnExit.Location = New System.Drawing.Point(1241, 0)
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
        Me.pctMain.Size = New System.Drawing.Size(1348, 721)
        Me.pctMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctMain.TabIndex = 10
        Me.pctMain.TabStop = False
        '
        'btnConfirm
        '
        Me.btnConfirm.Font = New System.Drawing.Font("Glacial Indifference", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.Location = New System.Drawing.Point(693, 597)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(319, 92)
        Me.btnConfirm.TabIndex = 11
        Me.btnConfirm.Text = "CONFIRM"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'lblService
        '
        Me.lblService.AutoSize = True
        Me.lblService.Font = New System.Drawing.Font("Glacial Indifference", 13.8!, System.Drawing.FontStyle.Bold)
        Me.lblService.Location = New System.Drawing.Point(215, 259)
        Me.lblService.Name = "lblService"
        Me.lblService.Size = New System.Drawing.Size(77, 28)
        Me.lblService.TabIndex = 12
        Me.lblService.Text = "Label1"
        '
        'lblServicePrice
        '
        Me.lblServicePrice.AutoSize = True
        Me.lblServicePrice.Font = New System.Drawing.Font("Glacial Indifference", 13.8!, System.Drawing.FontStyle.Bold)
        Me.lblServicePrice.Location = New System.Drawing.Point(215, 340)
        Me.lblServicePrice.Name = "lblServicePrice"
        Me.lblServicePrice.Size = New System.Drawing.Size(82, 28)
        Me.lblServicePrice.TabIndex = 13
        Me.lblServicePrice.Text = "Label2"
        '
        'lblBookingdate
        '
        Me.lblBookingdate.AutoSize = True
        Me.lblBookingdate.Font = New System.Drawing.Font("Glacial Indifference", 13.8!, System.Drawing.FontStyle.Bold)
        Me.lblBookingdate.Location = New System.Drawing.Point(215, 423)
        Me.lblBookingdate.Name = "lblBookingdate"
        Me.lblBookingdate.Size = New System.Drawing.Size(82, 28)
        Me.lblBookingdate.TabIndex = 14
        Me.lblBookingdate.Text = "Label3"
        '
        'lblPetName
        '
        Me.lblPetName.AutoSize = True
        Me.lblPetName.Font = New System.Drawing.Font("Glacial Indifference", 13.8!, System.Drawing.FontStyle.Bold)
        Me.lblPetName.Location = New System.Drawing.Point(697, 205)
        Me.lblPetName.Name = "lblPetName"
        Me.lblPetName.Size = New System.Drawing.Size(84, 28)
        Me.lblPetName.TabIndex = 15
        Me.lblPetName.Text = "Label4"
        '
        'lblPBrithday
        '
        Me.lblPBrithday.AutoSize = True
        Me.lblPBrithday.Font = New System.Drawing.Font("Glacial Indifference", 13.8!, System.Drawing.FontStyle.Bold)
        Me.lblPBrithday.Location = New System.Drawing.Point(757, 284)
        Me.lblPBrithday.Name = "lblPBrithday"
        Me.lblPBrithday.Size = New System.Drawing.Size(83, 28)
        Me.lblPBrithday.TabIndex = 16
        Me.lblPBrithday.Text = "Label5"
        '
        'lblPAge
        '
        Me.lblPAge.AutoSize = True
        Me.lblPAge.Font = New System.Drawing.Font("Glacial Indifference", 13.8!, System.Drawing.FontStyle.Bold)
        Me.lblPAge.Location = New System.Drawing.Point(640, 363)
        Me.lblPAge.Name = "lblPAge"
        Me.lblPAge.Size = New System.Drawing.Size(83, 28)
        Me.lblPAge.TabIndex = 17
        Me.lblPAge.Text = "Label6"
        '
        'lblPWeight
        '
        Me.lblPWeight.AutoSize = True
        Me.lblPWeight.Font = New System.Drawing.Font("Glacial Indifference", 13.8!, System.Drawing.FontStyle.Bold)
        Me.lblPWeight.Location = New System.Drawing.Point(679, 443)
        Me.lblPWeight.Name = "lblPWeight"
        Me.lblPWeight.Size = New System.Drawing.Size(83, 28)
        Me.lblPWeight.TabIndex = 18
        Me.lblPWeight.Text = "Label7"
        '
        'lblPSex
        '
        Me.lblPSex.AutoSize = True
        Me.lblPSex.Font = New System.Drawing.Font("Glacial Indifference", 13.8!, System.Drawing.FontStyle.Bold)
        Me.lblPSex.Location = New System.Drawing.Point(1063, 205)
        Me.lblPSex.Name = "lblPSex"
        Me.lblPSex.Size = New System.Drawing.Size(83, 28)
        Me.lblPSex.TabIndex = 19
        Me.lblPSex.Text = "Label8"
        '
        'lblPType
        '
        Me.lblPType.AutoSize = True
        Me.lblPType.Font = New System.Drawing.Font("Glacial Indifference", 13.8!, System.Drawing.FontStyle.Bold)
        Me.lblPType.Location = New System.Drawing.Point(1113, 284)
        Me.lblPType.Name = "lblPType"
        Me.lblPType.Size = New System.Drawing.Size(83, 28)
        Me.lblPType.TabIndex = 20
        Me.lblPType.Text = "Label9"
        '
        'lblPbreed
        '
        Me.lblPbreed.AutoSize = True
        Me.lblPbreed.Font = New System.Drawing.Font("Glacial Indifference", 13.8!, System.Drawing.FontStyle.Bold)
        Me.lblPbreed.Location = New System.Drawing.Point(1044, 443)
        Me.lblPbreed.Name = "lblPbreed"
        Me.lblPbreed.Size = New System.Drawing.Size(91, 28)
        Me.lblPbreed.TabIndex = 21
        Me.lblPbreed.Text = "Label10"
        '
        'lblPVacStatus
        '
        Me.lblPVacStatus.AutoSize = True
        Me.lblPVacStatus.Font = New System.Drawing.Font("Glacial Indifference", 13.8!, System.Drawing.FontStyle.Bold)
        Me.lblPVacStatus.Location = New System.Drawing.Point(1135, 363)
        Me.lblPVacStatus.Name = "lblPVacStatus"
        Me.lblPVacStatus.Size = New System.Drawing.Size(84, 28)
        Me.lblPVacStatus.TabIndex = 22
        Me.lblPVacStatus.Text = "Label11"
        '
        'TimerPanel2
        '
        '
        'bookSummary2vb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1348, 721)
        Me.Controls.Add(Me.lblPVacStatus)
        Me.Controls.Add(Me.lblPbreed)
        Me.Controls.Add(Me.lblPType)
        Me.Controls.Add(Me.lblPSex)
        Me.Controls.Add(Me.lblPWeight)
        Me.Controls.Add(Me.lblPAge)
        Me.Controls.Add(Me.lblPBrithday)
        Me.Controls.Add(Me.lblPetName)
        Me.Controls.Add(Me.lblBookingdate)
        Me.Controls.Add(Me.lblServicePrice)
        Me.Controls.Add(Me.lblService)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.pnlAbovebuttons2)
        Me.Controls.Add(Me.pctMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "bookSummary2vb"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "bookSummary2vb"
        Me.pnlAbovebuttons2.ResumeLayout(False)
        CType(Me.pctMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlAbovebuttons2 As Panel
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents pctMain As PictureBox
    Friend WithEvents btnConfirm As Button
    Friend WithEvents lblService As Label
    Friend WithEvents lblServicePrice As Label
    Friend WithEvents lblBookingdate As Label
    Friend WithEvents lblPetName As Label
    Friend WithEvents lblPBrithday As Label
    Friend WithEvents lblPAge As Label
    Friend WithEvents lblPWeight As Label
    Friend WithEvents lblPSex As Label
    Friend WithEvents lblPType As Label
    Friend WithEvents lblPbreed As Label
    Friend WithEvents lblPVacStatus As Label
    Friend WithEvents TimerPanel2 As Timer
End Class
