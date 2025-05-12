<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calendar2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Calendar2))
        Me.pnlAbovebuttons2 = New System.Windows.Forms.Panel()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.pnlTimer9 = New System.Windows.Forms.Timer(Me.components)
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.btnNextDate = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.btnBackDate = New System.Windows.Forms.Button()
        Me.tableCalendar = New System.Windows.Forms.TableLayoutPanel()
        Me.pctMain = New System.Windows.Forms.PictureBox()
        Me.pctBlur = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.pnlAbovebuttons2.SuspendLayout()
        CType(Me.pctMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctBlur, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pnlAbovebuttons2.Size = New System.Drawing.Size(1863, 21)
        Me.pnlAbovebuttons2.TabIndex = 13
        '
        'btnMinimize
        '
        Me.btnMinimize.BackColor = System.Drawing.Color.White
        Me.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Image = CType(resources.GetObject("btnMinimize.Image"), System.Drawing.Image)
        Me.btnMinimize.Location = New System.Drawing.Point(1793, 0)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(35, 21)
        Me.btnMinimize.TabIndex = 1
        Me.btnMinimize.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.White
        Me.btnExit.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.Location = New System.Drawing.Point(1828, 0)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(35, 21)
        Me.btnExit.TabIndex = 0
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'pnlTimer9
        '
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.BackColor = System.Drawing.Color.White
        Me.lblMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblMonth.Font = New System.Drawing.Font("Glacial Indifference", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonth.Location = New System.Drawing.Point(465, 140)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(201, 72)
        Me.lblMonth.TabIndex = 18
        Me.lblMonth.Text = "Label1"
        '
        'btnNextDate
        '
        Me.btnNextDate.FlatAppearance.BorderSize = 0
        Me.btnNextDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNextDate.Font = New System.Drawing.Font("Glacial Indifference", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNextDate.Location = New System.Drawing.Point(780, 762)
        Me.btnNextDate.Name = "btnNextDate"
        Me.btnNextDate.Size = New System.Drawing.Size(180, 57)
        Me.btnNextDate.TabIndex = 17
        Me.btnNextDate.Text = "NEXT"
        Me.btnNextDate.UseVisualStyleBackColor = True
        '
        'btnConfirm
        '
        Me.btnConfirm.FlatAppearance.BorderSize = 0
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirm.Font = New System.Drawing.Font("Glacial Indifference", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.Location = New System.Drawing.Point(488, 762)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(194, 63)
        Me.btnConfirm.TabIndex = 16
        Me.btnConfirm.Text = "CONFIRM"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'btnBackDate
        '
        Me.btnBackDate.FlatAppearance.BorderSize = 0
        Me.btnBackDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBackDate.Font = New System.Drawing.Font("Glacial Indifference", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackDate.Location = New System.Drawing.Point(220, 762)
        Me.btnBackDate.Name = "btnBackDate"
        Me.btnBackDate.Size = New System.Drawing.Size(180, 57)
        Me.btnBackDate.TabIndex = 15
        Me.btnBackDate.Text = "BACK"
        Me.btnBackDate.UseVisualStyleBackColor = True
        '
        'tableCalendar
        '
        Me.tableCalendar.ColumnCount = 7
        Me.tableCalendar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.34783!))
        Me.tableCalendar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.65217!))
        Me.tableCalendar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115.0!))
        Me.tableCalendar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117.0!))
        Me.tableCalendar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112.0!))
        Me.tableCalendar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113.0!))
        Me.tableCalendar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112.0!))
        Me.tableCalendar.Location = New System.Drawing.Point(183, 309)
        Me.tableCalendar.Name = "tableCalendar"
        Me.tableCalendar.RowCount = 6
        Me.tableCalendar.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.4359!))
        Me.tableCalendar.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.5641!))
        Me.tableCalendar.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74.0!))
        Me.tableCalendar.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73.0!))
        Me.tableCalendar.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73.0!))
        Me.tableCalendar.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68.0!))
        Me.tableCalendar.Size = New System.Drawing.Size(777, 422)
        Me.tableCalendar.TabIndex = 14
        '
        'pctMain
        '
        Me.pctMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pctMain.Image = CType(resources.GetObject("pctMain.Image"), System.Drawing.Image)
        Me.pctMain.Location = New System.Drawing.Point(0, 0)
        Me.pctMain.Name = "pctMain"
        Me.pctMain.Size = New System.Drawing.Size(1863, 875)
        Me.pctMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctMain.TabIndex = 12
        Me.pctMain.TabStop = False
        '
        'pctBlur
        '
        Me.pctBlur.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pctBlur.Image = CType(resources.GetObject("pctBlur.Image"), System.Drawing.Image)
        Me.pctBlur.Location = New System.Drawing.Point(0, 0)
        Me.pctBlur.Name = "pctBlur"
        Me.pctBlur.Size = New System.Drawing.Size(1863, 875)
        Me.pctBlur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctBlur.TabIndex = 19
        Me.pctBlur.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Image = CType(resources.GetObject("btnBack.Image"), System.Drawing.Image)
        Me.btnBack.Location = New System.Drawing.Point(29, 39)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(65, 58)
        Me.btnBack.TabIndex = 20
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Calendar2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1863, 875)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.pnlAbovebuttons2)
        Me.Controls.Add(Me.lblMonth)
        Me.Controls.Add(Me.btnNextDate)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.btnBackDate)
        Me.Controls.Add(Me.tableCalendar)
        Me.Controls.Add(Me.pctMain)
        Me.Controls.Add(Me.pctBlur)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Calendar2"
        Me.Text = "Calendar2"
        Me.pnlAbovebuttons2.ResumeLayout(False)
        CType(Me.pctMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctBlur, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlAbovebuttons2 As Panel
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents pctMain As PictureBox
    Friend WithEvents pnlTimer9 As Timer
    Friend WithEvents lblMonth As Label
    Friend WithEvents btnNextDate As Button
    Friend WithEvents btnConfirm As Button
    Friend WithEvents btnBackDate As Button
    Friend WithEvents tableCalendar As TableLayoutPanel
    Friend WithEvents pctBlur As PictureBox
    Friend WithEvents btnBack As Button
End Class
