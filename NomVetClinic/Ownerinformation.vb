﻿Public Class Ownerinformation

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

        If txtEmailAdd.Text.Contains("@") AndAlso txtEmailAdd.Text.Contains(".") Then
            If txtEmailAdd.Text.Trim.EndsWith("@gmail.com") OrElse txtEmailAdd.Text.Trim.EndsWith("@yahoo.com") Then
                TemporaryData.EmailAddress = txtEmailAdd.Text
            Else
                MessageBox.Show("Please Enter a valid Email", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        Else
            MessageBox.Show("Please Enter a valid Email", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If txtContactNumber.Text.Length < 10 Then
            MessageBox.Show("Phone Number must contain 10 numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If txtAge.Text = CStr(txtAge.Tag) OrElse String.IsNullOrWhiteSpace(txtAge.Text) Then
            MessageBox.Show("Age cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Not IsNumeric(txtAge.Text) Then
            MessageBox.Show("Age must be a number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If txtGetSex.Text = CStr(txtGetSex.Tag) OrElse String.IsNullOrWhiteSpace(txtGetSex.Text) Then
            MessageBox.Show("Sex cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' ✅ Save to TemporaryData
        TemporaryData.OwnerName = txtFullName.Text
        TemporaryData.Address = txtAddress.Text
        TemporaryData.ContactNumber = txtContactNumber.Text
        TemporaryData.ownerAge = Val(txtAge.Text)
        TemporaryData.ownerSex = cbSex.SelectedItem.ToString()

        petInfo.Show()
        Me.Close()
    End Sub

    Private Sub cbSex_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSex.SelectedIndexChanged
        ' ✅ Update the textbox above with selected sex
        txtGetSex.Text = cbSex.SelectedItem.ToString()
    End Sub

    Private Sub keyPressContactNUmber(sender As Object, e As KeyPressEventArgs) Handles txtContactNumber.KeyPress
        If txtContactNumber.Text.Length = 10 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub keyPressFullName(sender As Object, e As KeyPressEventArgs) Handles txtFullName.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
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
        txtContactNumber.Tag = "PHONE(+63)"
        txtContactNumber.Text = CStr(txtContactNumber.Tag)
        txtAge.Tag = "AGE"
        txtAge.Text = CStr(txtAge.Tag)
        txtGetSex.Tag = "SEX"
        txtGetSex.Text = CStr(txtGetSex.Tag)

        If Not String.IsNullOrWhiteSpace(TemporaryData.OwnerName) Then
            txtFullName.Text = TemporaryData.OwnerName
        Else
            txtFullName.Text = CStr(txtFullName.Tag)
        End If

        If Not String.IsNullOrWhiteSpace(TemporaryData.EmailAddress) Then
            txtEmailAdd.Text = TemporaryData.EmailAddress
        Else
            txtEmailAdd.Text = CStr(txtEmailAdd.Tag)
        End If

        If Not String.IsNullOrWhiteSpace(TemporaryData.Address) Then
            txtAddress.Text = TemporaryData.Address
        Else
            txtAddress.Text = CStr(txtAddress.Tag)
        End If

        If TemporaryData.ContactNumber <> 0 Then
            txtContactNumber.Text = TemporaryData.ContactNumber.ToString()
        Else
            txtContactNumber.Text = CStr(txtContactNumber.Tag)
        End If

        ' ✅ Load existing age/sex if exists
        If TemporaryData.ownerAge <> 0 Then
            txtAge.Text = TemporaryData.ownerAge.ToString()
        End If

        If Not String.IsNullOrEmpty(TemporaryData.ownerSex) Then
            cbSex.SelectedItem = TemporaryData.ownerSex
            txtGetSex.Text = TemporaryData.ownerSex
        End If

        For Each tb As TextBox In {txtFullName, txtEmailAdd, txtAddress, txtContactNumber}
            tb.ForeColor = Color.FromArgb(138, 120, 120)
        Next
    End Sub

    Private Sub pnlAboveTimer_Tick(sender As Object, e As EventArgs) Handles pnlTopTImer4.Tick
        PanelAboveSlide.SlidePanel(pnlAbovebuttons3, pnlTopTImer4)
    End Sub

    Private Sub TextBoxColors(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each tb As TextBox In {txtFullName, txtEmailAdd, txtAddress, txtContactNumber, txtAge, txtGetSex}
            tb.BackColor = Color.FromArgb(239, 232, 224)
        Next
    End Sub

    Private Sub TFontextColors(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each tb As TextBox In {txtFullName, txtEmailAdd, txtAddress, txtContactNumber, txtAge, txtGetSex}
            tb.ForeColor = Color.FromArgb(138, 120, 120)
        Next
    End Sub

    Private Sub TextBox_Enter(sender As Object, e As EventArgs) Handles txtFullName.Enter, txtEmailAdd.Enter, txtAddress.Enter, txtContactNumber.Enter, txtAge.Enter, txtGetSex.Enter
        Dim tb As TextBox = CType(sender, TextBox)
        If tb.Text = CStr(tb.Tag) Then
            tb.Text = ""
            tb.ForeColor = Color.FromArgb(138, 120, 120)
        End If
    End Sub

    Private Sub TextBox_Leave(sender As Object, e As EventArgs) Handles txtFullName.Leave, txtEmailAdd.Leave, txtAddress.Leave, txtContactNumber.Leave, txtAge.Leave, txtGetSex.Leave

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
        btnNext.Invalidate()
    End Sub

    Private Sub btnBookNow_MouseLeave(sender As Object, e As EventArgs) Handles btnNext.MouseLeave
        isMouseOver = False
        btnNext.Invalidate()
    End Sub

    Private Sub pctHomePage_MouseEnter(sender As Object, e As EventArgs) Handles pctBoxMain.MouseEnter
        PanelAboveSlide.MouseEnter(pnlAbovebuttons3, pnlTopTImer4)
    End Sub

    Private Sub MouseMovePanel(sender As Object, e As MouseEventArgs) Handles pctBoxMain.MouseMove
        PanelAboveSlide.MouseMove(pnlAbovebuttons3, e, pnlTopTImer4)
    End Sub

    Private Sub handles_keyUSername(sender As Object, e As KeyEventArgs) Handles txtFullName.KeyDown, txtEmailAdd.KeyDown, txtAddress.KeyDown, txtContactNumber.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            If sender Is txtContactNumber Then
                If txtFullName.Text = CStr(txtFullName.Tag) OrElse String.IsNullOrWhiteSpace(txtFullName.Text) OrElse
                   txtEmailAdd.Text = CStr(txtEmailAdd.Tag) OrElse String.IsNullOrWhiteSpace(txtEmailAdd.Text) OrElse
                   txtAddress.Text = CStr(txtAddress.Tag) OrElse String.IsNullOrWhiteSpace(txtAddress.Text) OrElse
                   txtContactNumber.Text = CStr(txtContactNumber.Tag) OrElse String.IsNullOrWhiteSpace(txtContactNumber.Text) Then

                    MessageBox.Show("Please make sure all fields are filled out and updated.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                btnNext.PerformClick()
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
        TemporaryData.OwnerName = ""
        TemporaryData.EmailAddress = ""
        TemporaryData.Address = ""
        TemporaryData.ContactNumber = 0
        TemporaryData.Clear()

        Me.Close()
    End Sub

End Class
