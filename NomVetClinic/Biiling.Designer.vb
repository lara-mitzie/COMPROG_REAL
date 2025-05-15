<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Biiling
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Biiling))
        Me.dgvViewBilling = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtPet = New System.Windows.Forms.TextBox()
        Me.btnSarch = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.txtTotalCOst = New System.Windows.Forms.TextBox()
        Me.txtPaymentStatus = New System.Windows.Forms.TextBox()
        CType(Me.dgvViewBilling, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvViewBilling
        '
        Me.dgvViewBilling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvViewBilling.Location = New System.Drawing.Point(555, 271)
        Me.dgvViewBilling.Name = "dgvViewBilling"
        Me.dgvViewBilling.RowHeadersWidth = 51
        Me.dgvViewBilling.RowTemplate.Height = 24
        Me.dgvViewBilling.Size = New System.Drawing.Size(592, 416)
        Me.dgvViewBilling.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1241, 768)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtName.Font = New System.Drawing.Font("Glacial Indifference", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(217, 291)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(247, 22)
        Me.txtName.TabIndex = 2
        '
        'txtPet
        '
        Me.txtPet.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPet.Font = New System.Drawing.Font("Glacial Indifference", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPet.Location = New System.Drawing.Point(216, 346)
        Me.txtPet.Name = "txtPet"
        Me.txtPet.Size = New System.Drawing.Size(247, 22)
        Me.txtPet.TabIndex = 3
        '
        'btnSarch
        '
        Me.btnSarch.FlatAppearance.BorderSize = 0
        Me.btnSarch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSarch.Font = New System.Drawing.Font("Glacial Indifference", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSarch.Location = New System.Drawing.Point(203, 397)
        Me.btnSarch.Name = "btnSarch"
        Me.btnSarch.Size = New System.Drawing.Size(183, 32)
        Me.btnSarch.TabIndex = 4
        Me.btnSarch.Text = "SEARCH"
        Me.btnSarch.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Glacial Indifference", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(203, 636)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(183, 32)
        Me.btnUpdate.TabIndex = 5
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'txtTotalCOst
        '
        Me.txtTotalCOst.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotalCOst.Font = New System.Drawing.Font("Glacial Indifference", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalCOst.Location = New System.Drawing.Point(261, 486)
        Me.txtTotalCOst.Name = "txtTotalCOst"
        Me.txtTotalCOst.ReadOnly = True
        Me.txtTotalCOst.Size = New System.Drawing.Size(205, 22)
        Me.txtTotalCOst.TabIndex = 6
        '
        'txtPaymentStatus
        '
        Me.txtPaymentStatus.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPaymentStatus.Font = New System.Drawing.Font("Glacial Indifference", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaymentStatus.Location = New System.Drawing.Point(305, 576)
        Me.txtPaymentStatus.Name = "txtPaymentStatus"
        Me.txtPaymentStatus.Size = New System.Drawing.Size(161, 22)
        Me.txtPaymentStatus.TabIndex = 7
        '
        'Biiling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txtPaymentStatus)
        Me.Controls.Add(Me.txtTotalCOst)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSarch)
        Me.Controls.Add(Me.txtPet)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.dgvViewBilling)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Biiling"
        Me.Size = New System.Drawing.Size(1241, 768)
        CType(Me.dgvViewBilling, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dgvViewBilling As DataGridView
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtPet As TextBox
    Friend WithEvents btnSarch As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents txtTotalCOst As TextBox
    Friend WithEvents txtPaymentStatus As TextBox
End Class
