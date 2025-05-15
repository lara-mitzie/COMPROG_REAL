<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentMethod
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PaymentMethod))
        Me.pnlPayment = New System.Windows.Forms.Panel()
        Me.pnlLoginGCash = New System.Windows.Forms.Panel()
        Me.pnlQRGCash = New System.Windows.Forms.Panel()
        Me.txtEnteredCode = New System.Windows.Forms.TextBox()
        Me.lblQRCode = New System.Windows.Forms.Label()
        Me.pbQRCode = New System.Windows.Forms.PictureBox()
        Me.btnValidateCode = New System.Windows.Forms.Button()
        Me.lblQRAmount = New System.Windows.Forms.Label()
        Me.lnkUseQRCode = New System.Windows.Forms.LinkLabel()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.lblOwnerName = New System.Windows.Forms.Label()
        Me.txtMobile = New System.Windows.Forms.TextBox()
        Me.pnlConfirmGCash = New System.Windows.Forms.Panel()
        Me.lblAmountPay = New System.Windows.Forms.Label()
        Me.lblConfirmMobile = New System.Windows.Forms.Label()
        Me.btnConfirmPayment = New System.Windows.Forms.Button()
        Me.lblConfirmAmount = New System.Windows.Forms.Label()
        Me.lblConfirmName = New System.Windows.Forms.Label()
        Me.pnlPayment.SuspendLayout()
        Me.pnlLoginGCash.SuspendLayout()
        Me.pnlQRGCash.SuspendLayout()
        CType(Me.pbQRCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlConfirmGCash.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlPayment
        '
        Me.pnlPayment.Controls.Add(Me.pnlConfirmGCash)
        Me.pnlPayment.Controls.Add(Me.pnlLoginGCash)
        Me.pnlPayment.Controls.Add(Me.pnlQRGCash)
        Me.pnlPayment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlPayment.Location = New System.Drawing.Point(0, 0)
        Me.pnlPayment.Name = "pnlPayment"
        Me.pnlPayment.Size = New System.Drawing.Size(1067, 554)
        Me.pnlPayment.TabIndex = 0
        '
        'pnlLoginGCash
        '
        Me.pnlLoginGCash.BackgroundImage = CType(resources.GetObject("pnlLoginGCash.BackgroundImage"), System.Drawing.Image)
        Me.pnlLoginGCash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlLoginGCash.Controls.Add(Me.lnkUseQRCode)
        Me.pnlLoginGCash.Controls.Add(Me.btnNext)
        Me.pnlLoginGCash.Controls.Add(Me.lblAmount)
        Me.pnlLoginGCash.Controls.Add(Me.lblOwnerName)
        Me.pnlLoginGCash.Controls.Add(Me.txtMobile)
        Me.pnlLoginGCash.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlLoginGCash.Location = New System.Drawing.Point(0, 0)
        Me.pnlLoginGCash.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlLoginGCash.Name = "pnlLoginGCash"
        Me.pnlLoginGCash.Size = New System.Drawing.Size(1067, 554)
        Me.pnlLoginGCash.TabIndex = 2
        '
        'pnlQRGCash
        '
        Me.pnlQRGCash.BackgroundImage = CType(resources.GetObject("pnlQRGCash.BackgroundImage"), System.Drawing.Image)
        Me.pnlQRGCash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlQRGCash.Controls.Add(Me.txtEnteredCode)
        Me.pnlQRGCash.Controls.Add(Me.lblQRCode)
        Me.pnlQRGCash.Controls.Add(Me.pbQRCode)
        Me.pnlQRGCash.Controls.Add(Me.btnValidateCode)
        Me.pnlQRGCash.Controls.Add(Me.lblQRAmount)
        Me.pnlQRGCash.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlQRGCash.Location = New System.Drawing.Point(0, 0)
        Me.pnlQRGCash.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlQRGCash.Name = "pnlQRGCash"
        Me.pnlQRGCash.Size = New System.Drawing.Size(1067, 554)
        Me.pnlQRGCash.TabIndex = 8
        '
        'txtEnteredCode
        '
        Me.txtEnteredCode.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEnteredCode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEnteredCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnteredCode.Location = New System.Drawing.Point(447, 439)
        Me.txtEnteredCode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEnteredCode.Name = "txtEnteredCode"
        Me.txtEnteredCode.Size = New System.Drawing.Size(225, 22)
        Me.txtEnteredCode.TabIndex = 8
        '
        'lblQRCode
        '
        Me.lblQRCode.AutoSize = True
        Me.lblQRCode.BackColor = System.Drawing.Color.Transparent
        Me.lblQRCode.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblQRCode.Location = New System.Drawing.Point(413, 413)
        Me.lblQRCode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblQRCode.Name = "lblQRCode"
        Me.lblQRCode.Size = New System.Drawing.Size(74, 16)
        Me.lblQRCode.TabIndex = 7
        Me.lblQRCode.Text = "Enter Code"
        '
        'pbQRCode
        '
        Me.pbQRCode.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pbQRCode.Location = New System.Drawing.Point(416, 185)
        Me.pbQRCode.Margin = New System.Windows.Forms.Padding(4)
        Me.pbQRCode.Name = "pbQRCode"
        Me.pbQRCode.Size = New System.Drawing.Size(268, 222)
        Me.pbQRCode.TabIndex = 6
        Me.pbQRCode.TabStop = False
        '
        'btnValidateCode
        '
        Me.btnValidateCode.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnValidateCode.FlatAppearance.BorderSize = 0
        Me.btnValidateCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnValidateCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnValidateCode.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnValidateCode.Location = New System.Drawing.Point(447, 497)
        Me.btnValidateCode.Margin = New System.Windows.Forms.Padding(4)
        Me.btnValidateCode.Name = "btnValidateCode"
        Me.btnValidateCode.Size = New System.Drawing.Size(220, 33)
        Me.btnValidateCode.TabIndex = 3
        Me.btnValidateCode.Text = "Submit"
        Me.btnValidateCode.UseVisualStyleBackColor = False
        '
        'lblQRAmount
        '
        Me.lblQRAmount.AutoSize = True
        Me.lblQRAmount.BackColor = System.Drawing.Color.Transparent
        Me.lblQRAmount.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblQRAmount.Location = New System.Drawing.Point(325, 142)
        Me.lblQRAmount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblQRAmount.Name = "lblQRAmount"
        Me.lblQRAmount.Size = New System.Drawing.Size(52, 16)
        Me.lblQRAmount.TabIndex = 2
        Me.lblQRAmount.Text = "Amount"
        '
        'lnkUseQRCode
        '
        Me.lnkUseQRCode.AutoSize = True
        Me.lnkUseQRCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkUseQRCode.Location = New System.Drawing.Point(267, 354)
        Me.lnkUseQRCode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lnkUseQRCode.Name = "lnkUseQRCode"
        Me.lnkUseQRCode.Size = New System.Drawing.Size(79, 15)
        Me.lnkUseQRCode.TabIndex = 5
        Me.lnkUseQRCode.TabStop = True
        Me.lnkUseQRCode.Text = "Generate QR"
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnNext.FlatAppearance.BorderSize = 0
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnNext.Location = New System.Drawing.Point(310, 420)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(465, 41)
        Me.btnNext.TabIndex = 3
        Me.btnNext.Text = "NEXT"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.BackColor = System.Drawing.Color.Transparent
        Me.lblAmount.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lblAmount.Location = New System.Drawing.Point(322, 185)
        Me.lblAmount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(52, 16)
        Me.lblAmount.TabIndex = 2
        Me.lblAmount.Text = "Amount"
        '
        'lblOwnerName
        '
        Me.lblOwnerName.AutoSize = True
        Me.lblOwnerName.BackColor = System.Drawing.Color.Transparent
        Me.lblOwnerName.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lblOwnerName.Location = New System.Drawing.Point(289, 137)
        Me.lblOwnerName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOwnerName.Name = "lblOwnerName"
        Me.lblOwnerName.Size = New System.Drawing.Size(135, 16)
        Me.lblOwnerName.TabIndex = 1
        Me.lblOwnerName.Text = "Nom Veterinary Clinic"
        '
        'txtMobile
        '
        Me.txtMobile.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMobile.Location = New System.Drawing.Point(325, 322)
        Me.txtMobile.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(328, 15)
        Me.txtMobile.TabIndex = 0
        '
        'pnlConfirmGCash
        '
        Me.pnlConfirmGCash.BackgroundImage = CType(resources.GetObject("pnlConfirmGCash.BackgroundImage"), System.Drawing.Image)
        Me.pnlConfirmGCash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlConfirmGCash.Controls.Add(Me.lblAmountPay)
        Me.pnlConfirmGCash.Controls.Add(Me.lblConfirmMobile)
        Me.pnlConfirmGCash.Controls.Add(Me.btnConfirmPayment)
        Me.pnlConfirmGCash.Controls.Add(Me.lblConfirmAmount)
        Me.pnlConfirmGCash.Controls.Add(Me.lblConfirmName)
        Me.pnlConfirmGCash.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlConfirmGCash.Location = New System.Drawing.Point(0, 0)
        Me.pnlConfirmGCash.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlConfirmGCash.Name = "pnlConfirmGCash"
        Me.pnlConfirmGCash.Size = New System.Drawing.Size(1067, 554)
        Me.pnlConfirmGCash.TabIndex = 9
        '
        'lblAmountPay
        '
        Me.lblAmountPay.AutoSize = True
        Me.lblAmountPay.BackColor = System.Drawing.Color.Transparent
        Me.lblAmountPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmountPay.Location = New System.Drawing.Point(704, 411)
        Me.lblAmountPay.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAmountPay.Name = "lblAmountPay"
        Me.lblAmountPay.Size = New System.Drawing.Size(65, 18)
        Me.lblAmountPay.TabIndex = 7
        Me.lblAmountPay.Text = "Amount"
        '
        'lblConfirmMobile
        '
        Me.lblConfirmMobile.AutoSize = True
        Me.lblConfirmMobile.BackColor = System.Drawing.Color.Transparent
        Me.lblConfirmMobile.Location = New System.Drawing.Point(504, 180)
        Me.lblConfirmMobile.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblConfirmMobile.Name = "lblConfirmMobile"
        Me.lblConfirmMobile.Size = New System.Drawing.Size(48, 16)
        Me.lblConfirmMobile.TabIndex = 4
        Me.lblConfirmMobile.Text = "Mobile"
        '
        'btnConfirmPayment
        '
        Me.btnConfirmPayment.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnConfirmPayment.FlatAppearance.BorderSize = 0
        Me.btnConfirmPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmPayment.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnConfirmPayment.Location = New System.Drawing.Point(447, 478)
        Me.btnConfirmPayment.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConfirmPayment.Name = "btnConfirmPayment"
        Me.btnConfirmPayment.Size = New System.Drawing.Size(220, 30)
        Me.btnConfirmPayment.TabIndex = 3
        Me.btnConfirmPayment.Text = "Submit Payment"
        Me.btnConfirmPayment.UseVisualStyleBackColor = False
        '
        'lblConfirmAmount
        '
        Me.lblConfirmAmount.AutoSize = True
        Me.lblConfirmAmount.BackColor = System.Drawing.Color.Transparent
        Me.lblConfirmAmount.Location = New System.Drawing.Point(307, 330)
        Me.lblConfirmAmount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblConfirmAmount.Name = "lblConfirmAmount"
        Me.lblConfirmAmount.Size = New System.Drawing.Size(52, 16)
        Me.lblConfirmAmount.TabIndex = 2
        Me.lblConfirmAmount.Text = "Amount"
        '
        'lblConfirmName
        '
        Me.lblConfirmName.AutoSize = True
        Me.lblConfirmName.BackColor = System.Drawing.Color.Transparent
        Me.lblConfirmName.Location = New System.Drawing.Point(504, 137)
        Me.lblConfirmName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblConfirmName.Name = "lblConfirmName"
        Me.lblConfirmName.Size = New System.Drawing.Size(44, 16)
        Me.lblConfirmName.TabIndex = 1
        Me.lblConfirmName.Text = "Name"
        '
        'PaymentMethod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.pnlPayment)
        Me.Name = "PaymentMethod"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PaymentMethod"
        Me.pnlPayment.ResumeLayout(False)
        Me.pnlLoginGCash.ResumeLayout(False)
        Me.pnlLoginGCash.PerformLayout()
        Me.pnlQRGCash.ResumeLayout(False)
        Me.pnlQRGCash.PerformLayout()
        CType(Me.pbQRCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlConfirmGCash.ResumeLayout(False)
        Me.pnlConfirmGCash.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlPayment As Panel
    Friend WithEvents pnlLoginGCash As Panel
    Friend WithEvents lnkUseQRCode As LinkLabel
    Friend WithEvents btnNext As Button
    Friend WithEvents lblAmount As Label
    Friend WithEvents lblOwnerName As Label
    Friend WithEvents txtMobile As TextBox
    Friend WithEvents pnlQRGCash As Panel
    Friend WithEvents txtEnteredCode As TextBox
    Friend WithEvents lblQRCode As Label
    Friend WithEvents pbQRCode As PictureBox
    Friend WithEvents btnValidateCode As Button
    Friend WithEvents lblQRAmount As Label
    Friend WithEvents pnlConfirmGCash As Panel
    Friend WithEvents lblAmountPay As Label
    Friend WithEvents lblConfirmMobile As Label
    Friend WithEvents btnConfirmPayment As Button
    Friend WithEvents lblConfirmAmount As Label
    Friend WithEvents lblConfirmName As Label
End Class
