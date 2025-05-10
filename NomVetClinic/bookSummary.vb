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
        lblVaccination, lblBreed, lblServiceType, lblServicePrice, lblBookingDate
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

        Dim dataInfo As New MySqlConnection("server=localhost;user id=root;password=rdtimbangMysql1;database=adminmain")
        Dim cmd As New MySqlCommand

        Try
            dataInfo.Open()
            cmd.Connection = dataInfo

            ' Insert owner information
            cmd.CommandText = "INSERT INTO ownerinformation(ownerName, EmailAddress, contactNumber, address, ownerCode) 
                           VALUES (@ownerName, @EmailAddress, @contactNumber, @address,@ownerCode)"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@ownerName", TemporaryData.OwnerName)
            cmd.Parameters.AddWithValue("@EmailAddress", TemporaryData.EmailAddress)
            cmd.Parameters.AddWithValue("@contactNumber", TemporaryData.ContactNumber)
            cmd.Parameters.AddWithValue("@address", TemporaryData.Address)
            cmd.Parameters.AddWithValue("@ownerCode", TemporaryData.userCode)
            cmd.ExecuteNonQuery()

            ' Get the last inserted ownerID
            Dim ownerID As Integer = Convert.ToInt32(cmd.LastInsertedId)

            ' Insert pet information, linking to the ownerID
            cmd.CommandText = "INSERT INTO petinformation(ownerID, petName, petSex, petType, petAge, petBirthday, petWeight, petBreed, petVacStatus)
                           VALUES (@ownerID, @petName, @petSex, @petType, @petAge, @petBirthday, @petWeight, @petBreed, @petVacStatus)"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@ownerID", ownerID) ' Use the ownerID from the last insert
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


            cmd.CommandText = "INSERT INTO services(serviceName, servicePrice)
                           VALUES (@serviceName, @servicePrice)"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@serviceName", TemporaryData.ServiceType)
            cmd.Parameters.AddWithValue("@servicePrice", TemporaryData.ServicePrice)
            cmd.ExecuteNonQuery()


            Dim serviceID As Integer = Convert.ToInt32(cmd.LastInsertedId)

            ' checkin if the id is valid ba
            If serviceID = 0 Then
                Throw New Exception("Error: ServiceID was not correctly retrieved.")
            End If


            cmd.CommandText = "INSERT INTO bookingtable(petID, serviceID, bookingDate, bookingStatus)
                           VALUES (@petID, @serviceID, @bookingDate, @bookingStatus)"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@petID", petID) ' Use the petID from the last insert
            cmd.Parameters.AddWithValue("@serviceID", serviceID) ' Use the serviceID from the last insert
            cmd.Parameters.AddWithValue("bookingStatus", "Confirmed".ToLower)
            cmd.Parameters.AddWithValue("@bookingDate", TemporaryData.BookingDate)
            cmd.ExecuteNonQuery()

            MessageBox.Show("All data submitted successfully!")

            TemporaryData.Clear()
            addCode.Close()
            Form1.Show()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            dataInfo.Close()
        End Try
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