Imports MySql.Data.MySqlClient

Public Class bookSummary2vb
    Private WithEvents scrollTimer As New Timer With {.Interval = 10}
    Private isMouseOver As Boolean = False

    Private Sub ucSummaryInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler btnConfirm.Paint, AddressOf btnBookNow_Paint
        MakeFormRounded(Me, 48)
        PanelAboveSlide.InitializePanel(pnlAbovebuttons2, TimerPanel2)
        MakeButtonRounded(btnConfirm, 48)
        Dim labels As Label() = {
        lblPetName, lblPSex, lblPAge, lblBookingdate, lblPType, lblPWeight, lblService, lblServicePrice, lblPVacStatus, lblPBrithday, lblPbreed
        }

        For Each tb As Label In labels
            tb.BackColor = Color.FromArgb(239, 232, 224)
            tb.ForeColor = Color.FromArgb(173, 159, 155)
        Next


        lblPetName.Text = TemporaryData.petName
        lblPSex.Text = TemporaryData.petSex
        lblPType.Text = TemporaryData.petType
        lblPWeight.Text = TemporaryData.petWeight.ToString() & " kg"
        lblPAge.Text = TemporaryData.petAge.ToString() & " yrs"
        lblPbreed.Text = TemporaryData.petBreed
        lblPVacStatus.Text = TemporaryData.petvacStatus
        lblPBrithday.Text = TemporaryData.petBirthday.ToShortDateString()

        lblService.Text = TemporaryData.ServiceType
        lblServicePrice.Text = "₱" & TemporaryData.ServicePrice.ToString("N2")
        lblBookingdate.Text = TemporaryData.BookingDate.ToShortDateString()
    End Sub


    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim dataInfo As New MySqlConnection("server=localhost;user id=root;password=rdtimbangMysql1;database=adminmain")
        Dim cmd As New MySqlCommand

        Try
            dataInfo.Open()
            cmd.Connection = dataInfo

            ' Use the existing ownerID from the logged-in user
            Dim ownerID As Integer = TemporaryData.LoggedInOwnerID

            ' Insert pet information, linking to the ownerID
            cmd.CommandText = "INSERT INTO petinformation(ownerID, petName, petSex, petType, petAge, petBirthday, petWeight, petBreed, petVacStatus)
                           VALUES (@ownerID, @petName, @petSex, @petType, @petAge, @petBirthday, @petWeight, @petBreed, @petVacStatus)"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@ownerID", ownerID)
            cmd.Parameters.AddWithValue("@petName", TemporaryData.petName)
            cmd.Parameters.AddWithValue("@petSex", TemporaryData.petSex)
            cmd.Parameters.AddWithValue("@petType", TemporaryData.petType)
            cmd.Parameters.AddWithValue("@petAge", TemporaryData.petAge)
            cmd.Parameters.AddWithValue("@petBirthday", TemporaryData.petBirthday)
            cmd.Parameters.AddWithValue("@petWeight", TemporaryData.petWeight)
            cmd.Parameters.AddWithValue("@petBreed", TemporaryData.petBreed)
            cmd.Parameters.AddWithValue("@petVacStatus", TemporaryData.petvacStatus)
            cmd.ExecuteNonQuery()

            Dim petID As Integer = Convert.ToInt32(cmd.LastInsertedId)

            ' Insert service info (optional: check if already exists first in future)
            cmd.CommandText = "INSERT INTO services(serviceName, servicePrice)
                           VALUES (@serviceName, @servicePrice)"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@serviceName", TemporaryData.ServiceType)
            cmd.Parameters.AddWithValue("@servicePrice", TemporaryData.ServicePrice)
            cmd.ExecuteNonQuery()

            Dim serviceID As Integer = Convert.ToInt32(cmd.LastInsertedId)

            If serviceID = 0 Then
                Throw New Exception("Error: ServiceID was not correctly retrieved.")
            End If

            ' Insert booking info
            cmd.CommandText = "INSERT INTO bookingtable(petID, serviceID, bookingDate, bookingStatus)
                           VALUES (@petID, @serviceID, @bookingDate, @bookingStatus)"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@petID", petID)
            cmd.Parameters.AddWithValue("@serviceID", serviceID)
            cmd.Parameters.AddWithValue("@bookingStatus", "Confirmed".ToLower)
            cmd.Parameters.AddWithValue("@bookingDate", TemporaryData.BookingDate)
            cmd.ExecuteNonQuery()

            MessageBox.Show("All data submitted successfully!")
            customerAccount.RefreshCustomerAccount()
            customerAccount.Show()
            TemporaryData.Clear()
            Calendar2.Close()
            Form1.Show()
            ' Form1.Hide()
            'Me.Hide()


        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            dataInfo.Close()
        End Try


        Me.Close()
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

    Private Sub MouseMovePanel(sender As Object, e As MouseEventArgs) Handles pctMain.MouseMove
        PanelAboveSlide.MouseMove(pnlAbovebuttons2, e, TimerPanel2)
    End Sub

    'pnl Button Mouse enter
    Private Sub pctHomePage_MouseEnter(sender As Object, e As EventArgs) Handles pctMain.MouseEnter
        PanelAboveSlide.MouseEnter(pnlAbovebuttons2, TimerPanel2)
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