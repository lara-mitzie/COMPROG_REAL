<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class petDetailsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(petDetailsForm))
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.txtSex = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnSaveChanges = New System.Windows.Forms.Button()
        Me.txtVacStatus = New System.Windows.Forms.TextBox()
        Me.picturmain = New System.Windows.Forms.PictureBox()
        Me.dtpDateUpdate = New System.Windows.Forms.DateTimePicker()
        CType(Me.picturmain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtType
        '
        Me.txtType.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtType.Font = New System.Drawing.Font("Glacial Indifference", 16.2!, System.Drawing.FontStyle.Bold)
        Me.txtType.Location = New System.Drawing.Point(929, 176)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(240, 33)
        Me.txtType.TabIndex = 25
        '
        'txtWeight
        '
        Me.txtWeight.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtWeight.Font = New System.Drawing.Font("Glacial Indifference", 16.2!, System.Drawing.FontStyle.Bold)
        Me.txtWeight.Location = New System.Drawing.Point(355, 512)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(240, 33)
        Me.txtWeight.TabIndex = 24
        '
        'txtSex
        '
        Me.txtSex.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSex.Font = New System.Drawing.Font("Glacial Indifference", 16.2!, System.Drawing.FontStyle.Bold)
        Me.txtSex.Location = New System.Drawing.Point(355, 404)
        Me.txtSex.Name = "txtSex"
        Me.txtSex.Size = New System.Drawing.Size(240, 33)
        Me.txtSex.TabIndex = 23
        '
        'txtAge
        '
        Me.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAge.Font = New System.Drawing.Font("Glacial Indifference", 16.2!, System.Drawing.FontStyle.Bold)
        Me.txtAge.Location = New System.Drawing.Point(355, 297)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(240, 33)
        Me.txtAge.TabIndex = 22
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtName.Font = New System.Drawing.Font("Glacial Indifference", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(355, 185)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(240, 33)
        Me.txtName.TabIndex = 21
        '
        'btnSaveChanges
        '
        Me.btnSaveChanges.BackColor = System.Drawing.Color.BurlyWood
        Me.btnSaveChanges.FlatAppearance.BorderSize = 0
        Me.btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveChanges.Font = New System.Drawing.Font("Glacial Indifference", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveChanges.ForeColor = System.Drawing.Color.White
        Me.btnSaveChanges.Location = New System.Drawing.Point(852, 657)
        Me.btnSaveChanges.Name = "btnSaveChanges"
        Me.btnSaveChanges.Size = New System.Drawing.Size(251, 76)
        Me.btnSaveChanges.TabIndex = 29
        Me.btnSaveChanges.Text = "SAVE"
        Me.btnSaveChanges.UseVisualStyleBackColor = False
        '
        'txtVacStatus
        '
        Me.txtVacStatus.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtVacStatus.Font = New System.Drawing.Font("Glacial Indifference", 16.2!, System.Drawing.FontStyle.Bold)
        Me.txtVacStatus.Location = New System.Drawing.Point(929, 284)
        Me.txtVacStatus.Name = "txtVacStatus"
        Me.txtVacStatus.Size = New System.Drawing.Size(240, 33)
        Me.txtVacStatus.TabIndex = 30
        '
        'picturmain
        '
        Me.picturmain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picturmain.Image = CType(resources.GetObject("picturmain.Image"), System.Drawing.Image)
        Me.picturmain.Location = New System.Drawing.Point(0, 0)
        Me.picturmain.Name = "picturmain"
        Me.picturmain.Size = New System.Drawing.Size(1241, 768)
        Me.picturmain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picturmain.TabIndex = 20
        Me.picturmain.TabStop = False
        '
        'dtpDateUpdate
        '
        Me.dtpDateUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateUpdate.Location = New System.Drawing.Point(929, 406)
        Me.dtpDateUpdate.Name = "dtpDateUpdate"
        Me.dtpDateUpdate.Size = New System.Drawing.Size(240, 30)
        Me.dtpDateUpdate.TabIndex = 33
        '
        'petDetailsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dtpDateUpdate)
        Me.Controls.Add(Me.txtVacStatus)
        Me.Controls.Add(Me.txtType)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.txtSex)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnSaveChanges)
        Me.Controls.Add(Me.picturmain)
        Me.Name = "petDetailsForm"
        Me.Size = New System.Drawing.Size(1241, 768)
        CType(Me.picturmain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picturmain As PictureBox
    Friend WithEvents txtType As TextBox
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents txtSex As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnSaveChanges As Button
    Friend WithEvents txtVacStatus As TextBox
    Friend WithEvents dtpDateUpdate As DateTimePicker
End Class
