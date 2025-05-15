Imports MySql.Data.MySqlClient
Imports QRCoder

Public Class Paymentmethod3
    Private generatedCode As String = ""

    Private Sub PaymentMethod3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set all panels to not visible initially
        pnlLoginGCash3.Visible = True
        pnlConfirmGCash3.Visible = False
        pnlQRGCash3.Visible = False
        SetLoginDetails()
        pnlLoginGCash3.BringToFront()
    End Sub


    ' Step 1: Login GCash
    Private Sub btnNext3_Click(sender As Object, e As EventArgs) Handles btnNext3.Click
        If txtMobile3.Text.Length = 10 AndAlso IsNumeric(txtMobile3.Text) Then
            TemporaryData.GcashMobileNumber = txtMobile3.Text

            ' Hide login panel first
            pnlLoginGCash3.Visible = False

            ' Show confirmation panel
            ShowConfirmPanel()

            ' Debug information
            Console.WriteLine("Button Next clicked, showing confirm panel")
        Else
            MessageBox.Show("Enter a valid 10-digit mobile number.")
        End If
    End Sub

    Private Sub txtMobile_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMobile3.KeyPress
        ' Only allow numbers and max of 10 digits
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
        If txtMobile3.Text.Length >= 10 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub SetLoginDetails()
        lblOwnerName3.Text = TemporaryData.LoggedInOwnerName

        Dim price As Decimal
        If Decimal.TryParse(TemporaryData.ServicePrice, price) Then
            TemporaryData.DownpaymentAmount = price * 0.3D

        Else
            TemporaryData.DownpaymentAmount = 0D
        End If

        lblAmount3.Text = "(30%): ₱ " & TemporaryData.DownpaymentAmount.ToString("F2")
    End Sub

    ' Step 2: Confirmation
    Private Sub ShowConfirmPanel()
        ' Set confirmation panel details
        lblConfirmName3.Text = TemporaryData.LoggedInOwnerName
        lblConfirmMobile3.Text = TemporaryData.GcashMobileNumber
        lblConfirmAmount3.Text = TemporaryData.DownpaymentAmount.ToString("F2")
        lblAmountPay3.Text = TemporaryData.DownpaymentAmount.ToString("F2")

        ' Make sure QR panel is not visible
        pnlQRGCash3.Visible = False

        ' Show confirmation panel and bring to front
        pnlConfirmGCash3.Visible = True
        pnlConfirmGCash3.BringToFront()

        ' Debug information
        Console.WriteLine("Confirm panel should now be visible")
    End Sub

    Private Sub btnConfirmPayment3_Click(sender As Object, e As EventArgs) Handles btnConfirmPayment3.Click

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

            Dim bookingID As Integer = Convert.ToInt32(cmd.LastInsertedId)

            ' ✅ Insert payment
            cmd.CommandText = "INSERT INTO payment(servicesId, bookingID, amountPaid, paymentMethod, paymentconfirm, downpayment)
                           VALUES (@servicesId, @bookingID, @amountPaid, @paymentMethod, @paymentConfirm, @downpayment)"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@servicesId", serviceID)
            cmd.Parameters.AddWithValue("@bookingID", bookingID)
            cmd.Parameters.AddWithValue("@amountPaid", TemporaryData.DownpaymentAmount)
            cmd.Parameters.AddWithValue("@paymentMethod", "GCash")
            cmd.Parameters.AddWithValue("@paymentConfirm", "Yes")
            cmd.Parameters.AddWithValue("@downpayment", TemporaryData.DownpaymentAmount)
            cmd.ExecuteNonQuery()


            MessageBox.Show("All data submitted successfully!")
            customerAccount.RefreshCustomerAccount()
            customerAccount.Show()
            TemporaryData.Clear()
            Calendar2.Close()

            ' Form1.Hide()
            'Me.Hide()


        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            dataInfo.Close()
        End Try



        MessageBox.Show("Payment Confirmed!")
        Me.Close()
    End Sub

    Private Sub lnkUseQRCode3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkUseQRCode3.LinkClicked
        ' Debug output to verify the method is being called
        Debug.WriteLine("lnkUseQRCode3_LinkClicked was triggered")
        ShowQRPanel()
    End Sub

    ' Step 3: QR Code
    Private Sub ShowQRPanel()
        ' Debug output
        Debug.WriteLine("ShowQRPanel method called")

        ' Set amount text
        lblQRAmount3.Text = "₱ " & TemporaryData.DownpaymentAmount.ToString("F2")

        ' Generate QR code
        GenerateAndDisplayQRCode()

        ' Hide other panels explicitly
        pnlLoginGCash3.Visible = False
        pnlConfirmGCash3.Visible = False

        ' Make QR panel visible
        pnlQRGCash3.Visible = True
        pnlQRGCash3.BringToFront()

        ' Additional debugging
        Debug.WriteLine("QR Panel visibility set to: " & pnlQRGCash3.Visible.ToString())

        ' You can also force a refresh of the form
        Me.Refresh()
    End Sub

    Private Sub GenerateAndDisplayQRCode()
        Dim rand As New Random()
        generatedCode = rand.Next(100000, 999999).ToString()
        TemporaryData.GeneratedCode = generatedCode

        Dim qrGenerator As New QRCodeGenerator()
        Dim qrData = qrGenerator.CreateQrCode(generatedCode, QRCodeGenerator.ECCLevel.Q)
        Dim qrCode = New QRCode(qrData)
        Dim qrImage = qrCode.GetGraphic(6)

        pbQRCode3.Image = qrImage
        ' Removed: lblQRCode.Text = "Enter this code after scanning"
    End Sub

    Private Sub btnValidateCode3_Click(sender As Object, e As EventArgs) Handles btnValidateCode3.Click
        If txtEnteredCode3.Text = TemporaryData.GeneratedCode Then

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



                Dim bookingID As Integer = Convert.ToInt32(cmd.LastInsertedId)

                ' ✅ Insert payment
                cmd.CommandText = "INSERT INTO payment(servicesId, bookingID, amountPaid, paymentMethod, paymentconfirm, downpayment)
                           VALUES (@servicesId, @bookingID, @amountPaid, @paymentMethod, @paymentConfirm, @downpayment)"
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@servicesId", serviceID)
                cmd.Parameters.AddWithValue("@bookingID", bookingID)
                cmd.Parameters.AddWithValue("@amountPaid", TemporaryData.DownpaymentAmount)
                cmd.Parameters.AddWithValue("@paymentMethod", "GCash")
                cmd.Parameters.AddWithValue("@paymentConfirm", "Yes")
                cmd.Parameters.AddWithValue("@downpayment", TemporaryData.DownpaymentAmount)
                cmd.ExecuteNonQuery()

                MessageBox.Show("All data submitted successfully!")
                customerAccount.RefreshCustomerAccount()
                customerAccount.Show()
                TemporaryData.Clear()
                Calendar2.Close()

                ' Form1.Hide()
                'Me.Hide()


            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                dataInfo.Close()
            End Try



            MessageBox.Show("QR Code Payment Confirmed!")
            Me.Close()
        Else
            MessageBox.Show("Invalid code. Try again.")
        End If
    End Sub

End Class