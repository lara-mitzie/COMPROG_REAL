<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Appointment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Appointment))
        Me.btnAll = New System.Windows.Forms.Button()
        Me.btnThisWeek = New System.Windows.Forms.Button()
        Me.ParentPanel = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAll
        '
        Me.btnAll.BackColor = System.Drawing.Color.White
        Me.btnAll.FlatAppearance.BorderSize = 0
        Me.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAll.Font = New System.Drawing.Font("Glacial Indifference", 12.0!)
        Me.btnAll.Location = New System.Drawing.Point(273, 208)
        Me.btnAll.Name = "btnAll"
        Me.btnAll.Size = New System.Drawing.Size(121, 37)
        Me.btnAll.TabIndex = 11
        Me.btnAll.Text = "ALL"
        Me.btnAll.UseVisualStyleBackColor = False
        '
        'btnThisWeek
        '
        Me.btnThisWeek.BackColor = System.Drawing.Color.White
        Me.btnThisWeek.FlatAppearance.BorderSize = 0
        Me.btnThisWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnThisWeek.Font = New System.Drawing.Font("Glacial Indifference", 12.0!)
        Me.btnThisWeek.Location = New System.Drawing.Point(113, 208)
        Me.btnThisWeek.Name = "btnThisWeek"
        Me.btnThisWeek.Size = New System.Drawing.Size(121, 37)
        Me.btnThisWeek.TabIndex = 10
        Me.btnThisWeek.Text = "WEEK"
        Me.btnThisWeek.UseVisualStyleBackColor = False
        '
        'ParentPanel
        '
        Me.ParentPanel.AutoScroll = True
        Me.ParentPanel.Location = New System.Drawing.Point(147, 289)
        Me.ParentPanel.Name = "ParentPanel"
        Me.ParentPanel.Size = New System.Drawing.Size(941, 340)
        Me.ParentPanel.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1241, 768)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.White
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearch.Font = New System.Drawing.Font("Glacial Indifference", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.txtSearch.Location = New System.Drawing.Point(679, 212)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(372, 28)
        Me.txtSearch.TabIndex = 12
        '
        'btnSearch
        '
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Location = New System.Drawing.Point(1057, 208)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(47, 34)
        Me.btnSearch.TabIndex = 13
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Appointment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnAll)
        Me.Controls.Add(Me.btnThisWeek)
        Me.Controls.Add(Me.ParentPanel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Appointment"
        Me.Size = New System.Drawing.Size(1241, 768)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAll As Button
    Friend WithEvents btnThisWeek As Button
    Friend WithEvents ParentPanel As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
End Class
