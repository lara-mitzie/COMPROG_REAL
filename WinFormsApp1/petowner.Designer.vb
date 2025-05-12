<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class petowner
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(petowner))
        pnlOwnerContainer = New FlowLayoutPanel()
        btnCancel = New Button()
        btnSearch = New Button()
        txtName = New TextBox()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlOwnerContainer
        ' 
        pnlOwnerContainer.AutoScroll = True
        pnlOwnerContainer.FlowDirection = FlowDirection.TopDown
        pnlOwnerContainer.ForeColor = Color.Black
        pnlOwnerContainer.Location = New Point(409, 221)
        pnlOwnerContainer.Name = "pnlOwnerContainer"
        pnlOwnerContainer.Size = New Size(399, 221)
        pnlOwnerContainer.TabIndex = 10
        pnlOwnerContainer.WrapContents = False
        ' 
        ' btnCancel
        ' 
        btnCancel.FlatAppearance.BorderSize = 0
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Location = New Point(122, 375)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(154, 36)
        btnCancel.TabIndex = 9
        btnCancel.Text = "CANCEL"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' btnSearch
        ' 
        btnSearch.FlatAppearance.BorderSize = 0
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.Location = New Point(122, 325)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(154, 37)
        btnSearch.TabIndex = 8
        btnSearch.Text = "SEARCH"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' txtName
        ' 
        txtName.BorderStyle = BorderStyle.None
        txtName.Location = New Point(82, 261)
        txtName.Name = "txtName"
        txtName.Size = New Size(241, 16)
        txtName.TabIndex = 7
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(924, 558)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' petowner
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(pnlOwnerContainer)
        Controls.Add(btnCancel)
        Controls.Add(btnSearch)
        Controls.Add(txtName)
        Controls.Add(PictureBox1)
        Name = "petowner"
        Size = New Size(924, 558)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnlOwnerContainer As FlowLayoutPanel
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents PictureBox1 As PictureBox

End Class
