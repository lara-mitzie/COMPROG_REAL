Public Class pickService
    Private WithEvents scrollTimer As New Timer With {.Interval = 10}
    Private isMouseOver As Boolean = False

    Dim price As Integer

    Private Sub Services_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler btnNext.Paint, AddressOf btnBookNow_Paint
        lblPrice.Text = "₱ 0"
        btnVaccine.BackColor = Color.FromArgb(251, 237, 206)
        btnCheckUp.BackColor = Color.FromArgb(251, 237, 206)
        PanelAboveSlide.InitializePanel(pnlAbovebuttons2, pnlTimer8)
        Me.WindowState = FormWindowState.Maximized
        MakeButtonRounded(btnVaccine, 48)
        MakeButtonRounded(btnCheckUp, 48)
        MakeButtonRounded(btnNext, 48)
        positonsPanels.btnVAccinePS(btnVaccine)
        positonsPanels.btnCheckUPPS(btnCheckUp)
        positonsPanels.btnNextPS(btnNext)
        positonsPanels.lblPRicePS(lblPrice)
        positonsPanels.btnBackPS(btnBack)
        lblPrice.BackColor = Color.FromArgb(209, 226, 160)
        lblPrice.ForeColor = Color.FromArgb(80, 89, 80)
    End Sub

    Private Sub btnCheckUp_Click(sender As Object, e As EventArgs) Handles btnCheckUp.Click
        SetServiceAndPrice("CHECK-UP", btnCheckUp)
    End Sub

    Private Sub btnVaccination_Click(sender As Object, e As EventArgs) Handles btnVaccine.Click
        SetServiceAndPrice("VACCINATION", btnVaccine)
    End Sub

    Private Sub SetServiceAndPrice(serviceType As String, selectedButton As Button)
        Dim petType As String = TemporaryData.petType
        Dim calculatedPrice As Integer = 0

        ' Determine price
        Select Case serviceType
            Case "CHECK-UP"
                Select Case petType
                    Case "Feline"
                        calculatedPrice = 500
                    Case "Canine"
                        calculatedPrice = 400
                    Case "Reptile"
                        calculatedPrice = 600
                End Select

            Case "VACCINATION"
                Select Case petType
                    Case "Feline"
                        calculatedPrice = 1000
                    Case "Canine"
                        calculatedPrice = 1500
                    Case "Reptile"
                        calculatedPrice = 2000
                End Select
        End Select

        ' Save to TemporaryData
        price = calculatedPrice

        ' Update label
        lblPrice.Text = "₱ " & price.ToString()

        ' Update button colors
        btnVaccine.BackColor = Color.FromArgb(251, 237, 206)
        btnCheckUp.BackColor = Color.FromArgb(251, 237, 206)
        selectedButton.BackColor = Color.FromArgb(216, 199, 161)
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        TemporaryData.ServiceType = ServiceType
        TemporaryData.ServicePrice = price

        Calendar.Show()
        Me.Close()

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        Form1.Close()
    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub pnlAboveTimer_Tick(sender As Object, e As EventArgs) Handles pnlTimer8.Tick
        PanelAboveSlide.SlidePanel(pnlAbovebuttons2, pnlTimer8)
    End Sub



    'pnl Button Mouse enter
    Private Sub pctHomePage_MouseEnter(sender As Object, e As EventArgs) Handles pctMain.MouseEnter
        PanelAboveSlide.MouseEnter(pnlAbovebuttons2, pnlTimer8)
    End Sub


    'pnl Button Mouse Move
    Private Sub MouseMovePanel(sender As Object, e As MouseEventArgs) Handles pctMain.MouseMove
        PanelAboveSlide.MouseMove(pnlAbovebuttons2, e, pnlTimer8)
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

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        petInfo.Show()
        Me.Close()

    End Sub
End Class