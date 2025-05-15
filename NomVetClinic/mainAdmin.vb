Public Class mainAdmin

    Dim Appointment As Appointment
    Dim His As history
    Dim ownerDetails As ownerDetailsForm
    Dim dashboard As dashboard
    Dim petowner As petowner
    Dim petDetails As petDetails
    Dim bill As Biiling

    Private selectedButton As Button = Nothing

    Private ReadOnly defaultColor As Color = Color.FromArgb(156, 178, 133)

    Private Sub ResetAllButtonColors()
        For Each tb As Button In {btnDashboard, btnAppointment, btnPetOwner, btnHistory, btnLogout, btnPetDetails, btnBilling}
            tb.BackColor = defaultColor
        Next
    End Sub

    Private Sub SetSelectedButton(btn As Button)
        ResetAllButtonColors()
        btn.BackColor = Color.White
        selectedButton = btn
    End Sub


    Private Sub pctDashboard_MouseEnter(sender As Object, e As EventArgs) Handles pctDashboard.MouseEnter
        If selectedButton IsNot btnDashboard Then btnDashboard.BackColor = Color.White
    End Sub

    Private Sub pctDashboard_MouseLeave(sender As Object, e As EventArgs) Handles pctDashboard.MouseLeave
        If selectedButton IsNot btnDashboard Then btnDashboard.BackColor = defaultColor
    End Sub

    Private Sub pctAppointment_MouseEnter(sender As Object, e As EventArgs) Handles pctAppointment.MouseEnter
        If selectedButton IsNot btnAppointment Then btnAppointment.BackColor = Color.White
    End Sub

    Private Sub pctAppointment_MouseLeave(sender As Object, e As EventArgs) Handles pctAppointment.MouseLeave
        If selectedButton IsNot btnAppointment Then btnAppointment.BackColor = defaultColor
    End Sub

    Private Sub pctPetOwner_MouseEnter(sender As Object, e As EventArgs) Handles pctPetOwner.MouseEnter
        If selectedButton IsNot btnPetOwner Then btnPetOwner.BackColor = Color.White
    End Sub

    Private Sub pctPetOwner_MouseLeave(sender As Object, e As EventArgs) Handles pctPetOwner.MouseLeave
        If selectedButton IsNot btnPetOwner Then btnPetOwner.BackColor = defaultColor
    End Sub

    Private Sub pctPetDetails_MouseEnter(sender As Object, e As EventArgs) Handles pctPetDetails.MouseEnter

        If selectedButton IsNot btnPetDetails Then btnPetDetails.BackColor = Color.White
    End Sub

    Private Sub pctPetDetails_MouseLeave(sender As Object, e As EventArgs) Handles pctPetDetails.MouseLeave

        If selectedButton IsNot btnPetDetails Then btnPetDetails.BackColor = defaultColor
    End Sub

    Private Sub pctHistory_MouseEnter(sender As Object, e As EventArgs) Handles pctHistory.MouseEnter
        If selectedButton IsNot btnHistory Then btnHistory.BackColor = Color.White
    End Sub

    Private Sub pctHistory_MouseLeave(sender As Object, e As EventArgs) Handles pctHistory.MouseLeave
        If selectedButton IsNot btnHistory Then btnHistory.BackColor = defaultColor
    End Sub


    Private Sub pctBilling_MouseEnter(sender As Object, e As EventArgs) Handles pctbilling.MouseEnter
        If selectedButton IsNot btnBilling Then btnBilling.BackColor = Color.White
    End Sub

    Private Sub pctBilling_MouseLeave(sender As Object, e As EventArgs) Handles pctbilling.MouseLeave
        If selectedButton IsNot btnBilling Then btnBilling.BackColor = defaultColor
    End Sub

    Private Sub pctLogout_MouseEnter(sender As Object, e As EventArgs) Handles pctLogout.MouseEnter
        If selectedButton IsNot btnLogout Then btnLogout.BackColor = Color.White
    End Sub

    Private Sub pctLogout_MouseLeave(sender As Object, e As EventArgs) Handles pctLogout.MouseLeave
        If selectedButton IsNot btnLogout Then btnLogout.BackColor = defaultColor
    End Sub


    Private Sub pctDashboard_Click(sender As Object, e As EventArgs) Handles pctDashboard.Click
        SetSelectedButton(btnDashboard)

        dashboard = New dashboard
        AddHandler dashboard.MouseEnter, AddressOf pctHomePage_MouseEnter
        AddHandler dashboard.MouseMove, AddressOf MouseMovePanel

        Panel1.Controls.Clear()
        dashboard.Dock = DockStyle.None
        dashboard.Top = 0
        dashboard.Left = 0

        Panel1.Controls.Add(dashboard)
    End Sub

    Private Sub pctAppointment_Click(sender As Object, e As EventArgs) Handles pctAppointment.Click
        SetSelectedButton(btnAppointment)

        Appointment = New Appointment
        AddHandler Appointment.MouseEnter, AddressOf pctHomePage_MouseEnter
        AddHandler Appointment.MouseMove, AddressOf MouseMovePanel

        Panel1.Controls.Clear()
        Appointment.Dock = DockStyle.None
        Appointment.Top = 0
        Appointment.Left = 0
        Panel1.Controls.Add(Appointment)
    End Sub

    Private Sub pctPetOwner_Click(sender As Object, e As EventArgs) Handles pctPetOwner.Click
        SetSelectedButton(btnPetOwner)

        petowner = New petowner
        AddHandler petowner.MouseEnter, AddressOf pctHomePage_MouseEnter
        AddHandler petowner.MouseMove, AddressOf MouseMovePanel

        Panel1.Controls.Clear()
        petowner.Dock = DockStyle.None
        petowner.Top = 0
        petowner.Left = 0
        Panel1.Controls.Add(petowner)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles pctPetDetails.Click
        SetSelectedButton(btnPetDetails)

        petDetails = New petDetails
        AddHandler petDetails.MouseEnter, AddressOf pctHomePage_MouseEnter
        AddHandler petDetails.MouseMove, AddressOf MouseMovePanel

        Panel1.Controls.Clear()
        petDetails.Dock = DockStyle.None
        petDetails.Top = 0
        petDetails.Left = 0
        Panel1.Controls.Add(petDetails)
    End Sub

    Private Sub pctHistory_Click(sender As Object, e As EventArgs) Handles pctHistory.Click
        SetSelectedButton(btnHistory)

        His = New history
        AddHandler His.MouseEnter, AddressOf pctHomePage_MouseEnter
        AddHandler His.MouseMove, AddressOf MouseMovePanel

        Panel1.Controls.Clear()
        His.Dock = DockStyle.None
        His.Top = 0
        His.Left = 0
        Panel1.Controls.Add(His)
    End Sub

    Private Sub pctbilling_Click(sender As Object, e As EventArgs) Handles pctbilling.Click
        SetSelectedButton(btnBilling)

        bill = New Biiling
        AddHandler bill.MouseEnter, AddressOf pctHomePage_MouseEnter
        AddHandler bill.MouseMove, AddressOf MouseMovePanel


        Panel1.Controls.Clear()
        bill.Dock = DockStyle.None
        bill.Top = 0
        bill.Left = 0
        Panel1.Controls.Add(bill)
    End Sub

    Private Sub pctLogout_Click(sender As Object, e As EventArgs) Handles pctLogout.Click
        SetSelectedButton(btnLogout)

        TemporaryData.Clear()
        adminAccount.Close()
        Me.Close()
    End Sub


    Private Sub mainAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelAboveSlide.InitializePanel(pnlAbovebuttons, pnlAboveTimer)
        MakeFormRounded(Me, 20)
        pctDashboard_Click(Nothing, Nothing)

        For Each btn As Button In {btnDashboard, btnAppointment, btnPetOwner, btnHistory, btnLogout, btnPetDetails, btnBilling}
            MakeButtonRounded(btn, 30)
        Next

        For Each pct As PictureBox In {pctDashboard, pctAppointment, pctPetOwner, pctHistory, pctLogout, pctPetDetails, pctbilling}
            MakePictureBoxRounded(pct, 20)
        Next

    End Sub

    Private Sub pctHomePage_MouseEnter(sender As Object, e As EventArgs) Handles Panel1.MouseEnter, PictureBox1.MouseEnter
        PanelAboveSlide.MouseEnter(pnlAbovebuttons, pnlAboveTimer)
    End Sub

    Private Sub MouseMovePanel(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove, PictureBox1.MouseMove
        PanelAboveSlide.MouseMove(pnlAbovebuttons, e, pnlAboveTimer)
    End Sub

    Private Sub pnlAboveTimer_Tick(sender As Object, e As EventArgs) Handles pnlAboveTimer.Tick
        PanelAboveSlide.SlidePanel(pnlAbovebuttons, pnlAboveTimer)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub



End Class
