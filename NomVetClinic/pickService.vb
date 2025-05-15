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

        If TemporaryData.petvacStatus = "COMPLETE" Then
            btnVaccine.Enabled = False
            btnVaccine.Text = "VACCINATION (Completed)"
            btnVaccine.BackColor = Color.LightGray
        End If

    End Sub

    Private Sub btnCheckUp_Click(sender As Object, e As EventArgs) Handles btnCheckUp.Click
        SetServiceAndPrice("CHECK-UP", btnCheckUp)
    End Sub

    Private Sub btnVaccination_Click(sender As Object, e As EventArgs) Handles btnVaccine.Click
        SetServiceAndPrice("VACCINATION", btnVaccine)
    End Sub

    Private Sub SetServiceAndPrice(serviceType As String, selectedButton As Button)
        Dim petType As String = TemporaryData.petType
        Dim priceToAdd As Integer = 0

        ' Determine the price for the selected service
        Select Case serviceType
            Case "CHECK-UP"
                Select Case petType
                    Case "Feline" : priceToAdd = 500
                    Case "Canine" : priceToAdd = 400
                    Case "Reptile" : priceToAdd = 600
                End Select
            Case "VACCINATION"
                Select Case petType
                    Case "Feline" : priceToAdd = 1000
                    Case "Canine" : priceToAdd = 1500
                    Case "Reptile" : priceToAdd = 2000
                End Select
        End Select

        ' Get the current services as a list for easier manipulation
        Dim currentServices As New List(Of String)
        If Not String.IsNullOrEmpty(TemporaryData.ServiceType) Then
            currentServices.AddRange(TemporaryData.ServiceType.Split(","c))
        End If

        ' Track if the service was selected or deselected
        Dim wasSelected As Boolean = currentServices.Contains(serviceType)

        ' Recalculate the entire price from scratch to avoid cumulative errors
        If wasSelected Then
            ' Remove the service if it was already selected
            currentServices.Remove(serviceType)
            selectedButton.BackColor = Color.FromArgb(251, 237, 206) ' Deselected color
        Else
            ' Add the service if it wasn't selected
            currentServices.Add(serviceType)
            selectedButton.BackColor = Color.FromArgb(216, 199, 161) ' Selected color
        End If

        ' Update the service list in TemporaryData
        TemporaryData.ServiceType = String.Join(",", currentServices)

        ' Recalculate the total price from scratch
        Dim totalPrice As Integer = 0
        For Each service As String In currentServices
            Select Case service
                Case "CHECK-UP"
                    Select Case petType
                        Case "Feline" : totalPrice += 500
                        Case "Canine" : totalPrice += 400
                        Case "Reptile" : totalPrice += 600
                    End Select
                Case "VACCINATION"
                    Select Case petType
                        Case "Feline" : totalPrice += 1000
                        Case "Canine" : totalPrice += 1500
                        Case "Reptile" : totalPrice += 2000
                    End Select
            End Select
        Next

        ' Update the price in TemporaryData
        TemporaryData.ServicePrice = totalPrice

        ' Update price label
        lblPrice.Text = "₱ " & TemporaryData.ServicePrice.ToString()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If String.IsNullOrEmpty(TemporaryData.ServiceType) Then
            MessageBox.Show("Please select a service (Check-Up or Vaccination) before proceeding.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Calendar.Show()
        Me.Hide()
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
