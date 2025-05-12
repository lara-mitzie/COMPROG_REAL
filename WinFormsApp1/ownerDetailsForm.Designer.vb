<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ownerDetailsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ownerDetailsForm))
        lblTotalBookings = New Label()
        PictureBox1 = New PictureBox()
        lblTotalPets = New Label()
        btnBack = New Button()
        txtAddress = New TextBox()
        txtContact = New TextBox()
        txtAge = New TextBox()
        txtSex = New TextBox()
        txtEmail = New TextBox()
        btnSaveChanges = New Button()
        txtName = New TextBox()
        Panel1 = New Panel()
        Panel2 = New Panel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTotalBookings
        ' 
        lblTotalBookings.AutoSize = True
        lblTotalBookings.Location = New Point(775, 314)
        lblTotalBookings.Name = "lblTotalBookings"
        lblTotalBookings.Size = New Size(31, 15)
        lblTotalBookings.TabIndex = 14
        lblTotalBookings.Text = "total"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1015, 559)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 15
        PictureBox1.TabStop = False
        ' 
        ' lblTotalPets
        ' 
        lblTotalPets.AutoSize = True
        lblTotalPets.Location = New Point(778, 395)
        lblTotalPets.Name = "lblTotalPets"
        lblTotalPets.Size = New Size(13, 15)
        lblTotalPets.TabIndex = 16
        lblTotalPets.Text = "0"
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(0, 461)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(93, 74)
        btnBack.TabIndex = 17
        btnBack.Text = "back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' txtAddress
        ' 
        txtAddress.BorderStyle = BorderStyle.None
        txtAddress.Font = New Font("SimSun", 11.25F)
        txtAddress.Location = New Point(762, 217)
        txtAddress.Multiline = True
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(178, 37)
        txtAddress.TabIndex = 19
        ' 
        ' txtContact
        ' 
        txtContact.BorderStyle = BorderStyle.None
        txtContact.Font = New Font("SimSun", 11.25F)
        txtContact.Location = New Point(761, 138)
        txtContact.Multiline = True
        txtContact.Name = "txtContact"
        txtContact.Size = New Size(178, 37)
        txtContact.TabIndex = 20
        ' 
        ' txtAge
        ' 
        txtAge.BorderStyle = BorderStyle.None
        txtAge.Font = New Font("SimSun", 11.25F)
        txtAge.Location = New Point(344, 217)
        txtAge.Multiline = True
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(178, 37)
        txtAge.TabIndex = 21
        ' 
        ' txtSex
        ' 
        txtSex.BorderStyle = BorderStyle.None
        txtSex.Font = New Font("SimSun", 11.25F)
        txtSex.Location = New Point(344, 302)
        txtSex.Multiline = True
        txtSex.Name = "txtSex"
        txtSex.Size = New Size(178, 37)
        txtSex.TabIndex = 22
        ' 
        ' txtEmail
        ' 
        txtEmail.BorderStyle = BorderStyle.None
        txtEmail.Font = New Font("SimSun", 11.25F)
        txtEmail.Location = New Point(344, 384)
        txtEmail.Multiline = True
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(178, 37)
        txtEmail.TabIndex = 23
        ' 
        ' btnSaveChanges
        ' 
        btnSaveChanges.FlatAppearance.BorderSize = 0
        btnSaveChanges.FlatStyle = FlatStyle.Flat
        btnSaveChanges.Font = New Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSaveChanges.ForeColor = SystemColors.ButtonFace
        btnSaveChanges.Location = New Point(713, 495)
        btnSaveChanges.Name = "btnSaveChanges"
        btnSaveChanges.Size = New Size(191, 40)
        btnSaveChanges.TabIndex = 26
        btnSaveChanges.Text = "Save Changes"
        btnSaveChanges.UseVisualStyleBackColor = True
        ' 
        ' txtName
        ' 
        txtName.BorderStyle = BorderStyle.None
        txtName.Font = New Font("SimSun", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtName.Location = New Point(344, 138)
        txtName.Multiline = True
        txtName.Name = "txtName"
        txtName.Size = New Size(178, 37)
        txtName.TabIndex = 18
        ' 
        ' Panel1
        ' 
        Panel1.Location = New Point(761, 305)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(178, 37)
        Panel1.TabIndex = 27
        ' 
        ' Panel2
        ' 
        Panel2.Location = New Point(762, 386)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(178, 37)
        Panel2.TabIndex = 28
        ' 
        ' ownerDetailsForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1014, 558)
        Controls.Add(txtName)
        Controls.Add(btnSaveChanges)
        Controls.Add(txtEmail)
        Controls.Add(txtSex)
        Controls.Add(txtAge)
        Controls.Add(txtContact)
        Controls.Add(txtAddress)
        Controls.Add(btnBack)
        Controls.Add(lblTotalPets)
        Controls.Add(lblTotalBookings)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Controls.Add(PictureBox1)
        Name = "ownerDetailsForm"
        Text = "ownerDetailsForm"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTotalBookings As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblTotalPets As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtContact As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtSex As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnSaveChanges As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class
