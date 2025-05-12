<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        PictureBox1 = New PictureBox()
        btnlogin = New Button()
        txtpassword = New TextBox()
        txtusername = New TextBox()
        cbsee = New CheckBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.NOM_Veterinary_Clinic_Interface1
        PictureBox1.InitialImage = My.Resources.Resources._29
        PictureBox1.Location = New Point(-4, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1030, 597)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' btnlogin
        ' 
        btnlogin.BackColor = Color.Transparent
        btnlogin.BackgroundImageLayout = ImageLayout.None
        btnlogin.FlatAppearance.BorderSize = 0
        btnlogin.FlatStyle = FlatStyle.Flat
        btnlogin.Location = New Point(582, 471)
        btnlogin.Name = "btnlogin"
        btnlogin.Size = New Size(375, 53)
        btnlogin.TabIndex = 5
        btnlogin.Text = "LOGIN"
        btnlogin.UseVisualStyleBackColor = False
        ' 
        ' txtpassword
        ' 
        txtpassword.BorderStyle = BorderStyle.None
        txtpassword.Cursor = Cursors.IBeam
        txtpassword.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtpassword.Location = New Point(636, 393)
        txtpassword.Multiline = True
        txtpassword.Name = "txtpassword"
        txtpassword.Size = New Size(272, 27)
        txtpassword.TabIndex = 2
        txtpassword.Text = "PASSWORD"
        ' 
        ' txtusername
        ' 
        txtusername.BorderStyle = BorderStyle.None
        txtusername.Cursor = Cursors.IBeam
        txtusername.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtusername.Location = New Point(640, 328)
        txtusername.Multiline = True
        txtusername.Name = "txtusername"
        txtusername.Size = New Size(296, 27)
        txtusername.TabIndex = 1
        txtusername.Text = "USERNAME"
        ' 
        ' cbsee
        ' 
        cbsee.Appearance = Appearance.Button
        cbsee.AutoSize = True
        cbsee.FlatAppearance.BorderSize = 0
        cbsee.FlatStyle = FlatStyle.Flat
        cbsee.Image = My.Resources.Resources.mata
        cbsee.Location = New Point(912, 395)
        cbsee.Name = "cbsee"
        cbsee.Size = New Size(29, 23)
        cbsee.TabIndex = 6
        cbsee.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1024, 601)
        Controls.Add(cbsee)
        Controls.Add(txtpassword)
        Controls.Add(txtusername)
        Controls.Add(btnlogin)
        Controls.Add(PictureBox1)
        KeyPreview = True
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "NOM VET CLINIC"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnlogin As Button
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents txtusername As TextBox
    Friend WithEvents cbsee As CheckBox

End Class
