Public Class booking

    Dim page1Booking As New bkYesOrNo

    Private WithEvents scrollTimer As New Timer With {.Interval = 10}
    Private Sub booking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        AddHandler pnlButtons2.Resize, Sub() CenterPictureBoxHorizontally(pctLogoName, pnlButtons2)
        CenterPictureBoxHorizontally(pctLogoName, pnlButtons2)
        PanelAboveSlide.InitializePanel(pnlAbovebuttons2, pnlAboveTimer2)
    End Sub


    Private Sub InterfaceBooking(sender As Object, e As EventArgs) Handles MyBase.Load
        page1Booking = New bkYesOrNo
        page1Booking.Dock = DockStyle.Fill
        pnlBack.Controls.Add(page1Booking)
    End Sub

    Private Sub pnlAboveTimer_Tick(sender As Object, e As EventArgs) Handles pnlAboveTimer2.Tick
        PanelAboveSlide.SlidePanel(pnlAbovebuttons2, pnlAboveTimer2)
    End Sub



    'pnl Button Mouse enter
    Private Sub pctHomePage_MouseEnter(sender As Object, e As EventArgs) Handles pnlButtons2.MouseEnter
        PanelAboveSlide.MouseEnter(pnlAbovebuttons2, pnlAboveTimer2)
    End Sub




    'pnl Button Mouse Move
    Private Sub MouseMovePanel(sender As Object, e As MouseEventArgs) Handles pnlButtons2.MouseMove
        PanelAboveSlide.MouseMove(pnlAbovebuttons2, e, pnlAboveTimer2)
    End Sub




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        Form1.Close()
    End Sub




    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub




    Private Sub PanelBtnShadow(sender As Object, graphic As PaintEventArgs) Handles pnlButtons2.Paint
        DropShadow.pnlButtonsShadow(graphic.Graphics, pnlButtons2)
    End Sub

    Private Sub pctLogoName_Click(sender As Object, e As EventArgs) Handles pctLogoName.Click
        Form1.Show()
        Me.Close()
    End Sub
End Class