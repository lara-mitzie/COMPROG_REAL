Imports MySql.Data.MySqlClient

Public Class bookSummary
    Private WithEvents scrollTimer As New Timer With {.Interval = 10}
    Private isMouseOver As Boolean = False

    Private Sub MainLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler btnConfirm.Paint, AddressOf btnBookNow_Paint


        lblOwnerName.Text = TemporaryData.OwnerName
        lblEmailAdd.Text = TemporaryData.EmailAddress
        lblAddress.Text = TemporaryData.Address
        lblPhoneNumber.Text = TemporaryData.ContactNumber
        lblOwnerAge.Text = TemporaryData.ownerAge
        lblGender.Text = TemporaryData.ownerSex

        lblPetName.Text = TemporaryData.petName
        lblDateBirth.Text = TemporaryData.petBirthday
        lblPetSex.Text = TemporaryData.petSex
        lblPetType.Text = TemporaryData.petType
        lblAge.Text = TemporaryData.petAge
        lblWeight.Text = TemporaryData.petWeight
        lblBreed.Text = TemporaryData.petBreed
        lblVaccination.Text = TemporaryData.petvacStatus

        lblServiceType.Text = TemporaryData.ServiceType
        lblServicePrice.Text = "₱ " & TemporaryData.ServicePrice

        lblBookingDate.Text = TemporaryData.BookingDate


        Dim labels As Label() = {
        lblOwnerName, lblEmailAdd, lblAddress, lblPhoneNumber, lblPetName,
        lblDateBirth, lblAge, lblWeight, lblPetSex, lblPetType,
        lblVaccination, lblBreed, lblServiceType, lblServicePrice, lblBookingDate,
        lblOwnerAge, lblGender
    }

        For Each tb As Label In labels
            tb.BackColor = Color.FromArgb(239, 232, 224)
            tb.ForeColor = Color.FromArgb(173, 159, 155)
        Next

        PanelAboveSlide.InitializePanel(pnlAbovebuttons2, TimerPanel2)

        MakeFormRounded(Me, 25)
        MakeButtonRounded(btnConfirm, 48)



    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Paymentmethod2vb.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub pnlAboveTimer_Tick(sender As Object, e As EventArgs) Handles TimerPanel2.Tick
        PanelAboveSlide.SlidePanel(pnlAbovebuttons2, TimerPanel2)
    End Sub



    'pnl Button Mouse enter
    Private Sub pctHomePage_MouseEnter(sender As Object, e As EventArgs) Handles pctMain.MouseEnter
        PanelAboveSlide.MouseEnter(pnlAbovebuttons2, TimerPanel2)
    End Sub


    'pnl Button Mouse Move
    Private Sub MouseMovePanel(sender As Object, e As MouseEventArgs) Handles pctMain.MouseMove
        PanelAboveSlide.MouseMove(pnlAbovebuttons2, e, TimerPanel2)
    End Sub

    Private Sub btnBookNow_Paint(sender As Object, e As PaintEventArgs)
        If isMouseOver Then
            GradientHelper.DrawGradientButton(sender, e, Color.FromArgb(0, 151, 178), Color.FromArgb(126, 217, 87), Drawing2D.LinearGradientMode.Horizontal)
        Else
            GradientHelper.DrawGradientButton(sender, e, Color.FromArgb(126, 217, 87), Color.FromArgb(0, 151, 178), Drawing2D.LinearGradientMode.Horizontal)
        End If
    End Sub

    Private Sub btnBookNow_MouseEnter(sender As Object, e As EventArgs) Handles btnConfirm.MouseEnter
        isMouseOver = True
        btnConfirm.Invalidate()
    End Sub

    Private Sub btnBookNow_MouseLeave(sender As Object, e As EventArgs) Handles btnConfirm.MouseLeave
        isMouseOver = False
        btnConfirm.Invalidate()
    End Sub


End Class