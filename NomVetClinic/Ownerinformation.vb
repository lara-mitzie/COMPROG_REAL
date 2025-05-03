Public Class Ownerinformation

    Private isMouseOver As Boolean = False
    Private WithEvents scrollTimer As New Timer With {.Interval = 10}





    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        If txtFullName.Text = CStr(txtFullName.Tag) OrElse String.IsNullOrWhiteSpace(txtFullName.Text) Then
            MessageBox.Show("Full Name cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If txtEmailAdd.Text = CStr(txtEmailAdd.Tag) OrElse String.IsNullOrWhiteSpace(txtEmailAdd.Text) Then
            MessageBox.Show("Email Address cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If txtAddress.Text = CStr(txtAddress.Tag) OrElse String.IsNullOrWhiteSpace(txtAddress.Text) Then
            MessageBox.Show("Address cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If txtContactNumber.Text = CStr(txtContactNumber.Tag) OrElse String.IsNullOrWhiteSpace(txtContactNumber.Text) Then
            MessageBox.Show("Contact Number cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If


        If Not txtContactNumber.Text.All(Function(c) Char.IsDigit(c)) Then
            MessageBox.Show("Contact Number must contain only numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If


        TemporaryData.OwnerName = txtFullName.Text
        TemporaryData.EmailAddress = txtEmailAdd.Text
        TemporaryData.Address = txtAddress.Text
        TemporaryData.ContactNumber = txtContactNumber.Text

        petInfo.Show()
        Me.Close()
    End Sub




    Private Sub Ownerinformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler btnNext.Paint, AddressOf btnBookNow_Paint

        PanelAboveSlide.InitializePanel(pnlAbovebuttons3, pnlTopTImer4)
        Me.WindowState = FormWindowState.Maximized
        txtFullName.Tag = "FULL NAME"
        txtFullName.Text = CStr(txtFullName.Tag)
        txtEmailAdd.Tag = "EMAIL"
        txtEmailAdd.Text = CStr(txtEmailAdd.Tag)
        txtAddress.Tag = "ADDRESS"
        txtAddress.Text = CStr(txtAddress.Tag)
        txtContactNumber.Tag = "PHONE"
        txtContactNumber.Text = CStr(txtContactNumber.Tag)

    End Sub

    Private Sub pnlAboveTimer_Tick(sender As Object, e As EventArgs) Handles pnlTopTImer4.Tick
        PanelAboveSlide.SlidePanel(pnlAbovebuttons3, pnlTopTImer4)

    End Sub


    Private Sub TextBoxColors(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each tb As TextBox In {txtFullName, txtEmailAdd, txtAddress, txtContactNumber}
            tb.BackColor = Color.FromArgb(239, 232, 224)
        Next

    End Sub

    Private Sub TFontextColors(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each tb As TextBox In {txtFullName, txtEmailAdd, txtAddress, txtContactNumber}
            tb.ForeColor = Color.FromArgb(138, 120, 120)
        Next
    End Sub

    Private Sub TextBox_Enter(sender As Object, e As EventArgs) Handles txtFullName.Enter, txtEmailAdd.Enter, txtAddress.Enter, txtContactNumber.Enter

        Dim tb As TextBox = CType(sender, TextBox)
        If tb.Text = CStr(tb.Tag) Then
            tb.Text = ""
            tb.ForeColor = Color.FromArgb(138, 120, 120)
        End If
    End Sub

    Private Sub TextBox_Leave(sender As Object, e As EventArgs) Handles txtFullName.Leave, txtEmailAdd.Leave, txtAddress.Leave, txtContactNumber.Leave
        Dim tb As TextBox = CType(sender, TextBox)
        If tb.Text.Trim() = "" Then
            tb.Text = CStr(tb.Tag)
            tb.ForeColor = Color.FromArgb(138, 120, 120)
        End If
    End Sub

    Private Sub PositionsAndROunding(sender As Object, e As EventArgs) Handles MyBase.Load
        positonsPanels.txtFullNameON(txtFullName)
        positonsPanels.txtEAddressOn(txtEmailAdd)
        positonsPanels.txtAddressOn(txtAddress)
        positonsPanels.txtCNumberON(txtContactNumber)
        positonsPanels.btnNextON(btnNext)
        positonsPanels.buttonBackON(btnBack)
        MakeButtonRounded(btnNext, 48)
    End Sub

    Private Sub btnBookNow_Paint(sender As Object, e As PaintEventArgs)
        If isMouseOver Then
            GradientHelper.DrawGradientButton(sender, e, Color.FromArgb(0, 151, 178), Color.FromArgb(126, 217, 87), Drawing2D.LinearGradientMode.Horizontal)
        Else
            GradientHelper.DrawGradientButton(sender, e, Color.FromArgb(126, 217, 87), Color.FromArgb(0, 151, 178), Drawing2D.LinearGradientMode.Horizontal)
        End If
    End Sub

    Private Sub btnBookNow_MouseEnter(sender As Object, e As EventArgs) Handles btnNext.MouseEnter
        isMouseOver = True
        btnNext.Invalidate() ' Force the button to repaint
    End Sub

    Private Sub btnBookNow_MouseLeave(sender As Object, e As EventArgs) Handles btnNext.MouseLeave
        isMouseOver = False
        btnNext.Invalidate() ' Force the button to repaint
    End Sub

    'pnl Button Mouse enter
    Private Sub pctHomePage_MouseEnter(sender As Object, e As EventArgs) Handles pctBoxMain.MouseEnter
        PanelAboveSlide.MouseEnter(pnlAbovebuttons3, pnlTopTImer4)
    End Sub

    'pnl Button Mouse Move
    Private Sub MouseMovePanel(sender As Object, e As MouseEventArgs) Handles pctBoxMain.MouseMove
        PanelAboveSlide.MouseMove(pnlAbovebuttons3, e, pnlTopTImer4)
    End Sub

    Private Sub handles_keyUSername(sender As Object, e As KeyEventArgs) Handles txtFullName.KeyDown, txtEmailAdd.KeyDown, txtAddress.KeyDown, txtContactNumber.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            If sender Is txtContactNumber Then
                btnNext.PerformClick() ' Automatically click the button
            Else
                Me.SelectNextControl(CType(sender, Control), True, True, True, True)
            End If

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        Form1.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        booking.Show()
        Me.Close()
    End Sub




End Class