<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class history
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(history))
        PictureBox1 = New PictureBox()
        txtSearch = New TextBox()
        btnSearch = New Button()
        dvgBookingHistory = New DataGridView()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dvgBookingHistory, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, -1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(924, 558)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(62, 143)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(109, 23)
        txtSearch.TabIndex = 2
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(178, 143)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(29, 23)
        btnSearch.TabIndex = 3
        btnSearch.Text = "Button1"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' dvgBookingHistory
        ' 
        dvgBookingHistory.ColumnHeadersHeight = 30
        dvgBookingHistory.Location = New Point(70, 189)
        dvgBookingHistory.Name = "dvgBookingHistory"
        dvgBookingHistory.RowHeadersWidth = 65
        dvgBookingHistory.Size = New Size(787, 250)
        dvgBookingHistory.TabIndex = 4
        ' 
        ' history
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(dvgBookingHistory)
        Controls.Add(btnSearch)
        Controls.Add(txtSearch)
        Controls.Add(PictureBox1)
        Name = "history"
        Size = New Size(924, 558)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(dvgBookingHistory, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents dvgBookingHistory As DataGridView

End Class
