Imports MySql.Data.MySqlClient
Imports QRCoder
Public Class Paymentmethod2vb
    Private generatedCode2 As String = ""
    Private Sub PaymentMethod2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set all panels to not visible initially except pnlLoginGCash2
        pnlLoginGCash2.Visible = True
        pnlConfirmGCash2.Visible = False
        pnlQRGCash2.Visible = False

        ' Set up initial login details
        SetLoginDetails2()
    End Sub
    ' Step 1: Login GCash
    Private Sub btnNext2_Click(sender As Object, e As EventArgs) Handles btnNext2.Click
        If txtMobile2.Text.Length = 10 AndAlso IsNumeric(txtMobile2.Text) Then
            TemporaryData.GcashMobileNumber = txtMobile2.Text
            ShowConfirmPanel2()
        Else
            MessageBox.Show("Enter a valid 10-digit mobile number.")
        End If
    End Sub
    Private Sub txtMobile2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMobile2.KeyPress
        ' Only allow numbers and max of 10 digits
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
        If txtMobile2.Text.Length >= 10 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub SetLoginDetails2()
        ' lblOwnerName2.Text = TemporaryData.OwnerName
        Dim price As Decimal
        If Decimal.TryParse(TemporaryData.ServicePrice, price) Then
            TemporaryData.DownpaymentAmount = price * 0.3D
        Else
            TemporaryData.DownpaymentAmount = 0D
        End If
        lblAmount2.Text = "(30%): ₱ " & TemporaryData.DownpaymentAmount.ToString("F2")
    End Sub
    ' Step 2: Confirmation
    Private Sub ShowConfirmPanel2()
        lblConfirmName2.Text = TemporaryData.OwnerName
        lblConfirmMobile2.Text = TemporaryData.GcashMobileNumber
        lblConfirmAmount2.Text = TemporaryData.DownpaymentAmount.ToString("F2")
        lblAmountPay2.Text = TemporaryData.DownpaymentAmount.ToString("F2")
        pnlConfirmGCash2.Visible = True
        pnlConfirmGCash2.BringToFront()
    End Sub
    Private Sub btnConfirmPayment2_Click(sender As Object, e As EventArgs) Handles btnConfirmPayment2.Click
        Dim dataInfo As New MySqlConnection("server=localhost;user id=root;password=rdtimbangMysql1;database=adminmain")
        Dim cmd As New MySqlCommand

        Try
            dataInfo.Open()
            cmd.Connection = dataInfo

            ' Insert owner information


            cmd.CommandText = "INSERT INTO ownerinformation(ownerName, EmailAddress, contactNumber, address,ownerSex,  ownerAge, ownerCode) 
                   VALUES (@ownerName, @EmailAddress, @contactNumber, @address,@ownerSex,  @ownerAge, @ownerCode)"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@ownerName", TemporaryData.OwnerName)
            cmd.Parameters.AddWithValue("@EmailAddress", TemporaryData.EmailAddress)
            cmd.Parameters.AddWithValue("@contactNumber", TemporaryData.ContactNumber)
            cmd.Parameters.AddWithValue("@address", TemporaryData.Address)
            cmd.Parameters.AddWithValue("@ownerCode", TemporaryData.userCode)
            cmd.Parameters.AddWithValue("@ownerSex", TemporaryData.ownerSex)
            cmd.Parameters.AddWithValue("@ownerAge", TemporaryData.ownerAge)

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



            Dim bookingID As Integer = Convert.ToInt32(cmd.LastInsertedId)

            ' ✅ Insert payment
            cmd.CommandText = "INSERT INTO payment(servicesId, bookingID, amountPaid, paymentMethod, paymentconfirm, downpayment, paymentStatus)
                           VALUES (@servicesId, @bookingID, @amountPaid, @paymentMethod, @paymentConfirm, @downpayment, @paymentStatus)"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@servicesId", serviceID)
            cmd.Parameters.AddWithValue("@bookingID", bookingID)
            cmd.Parameters.AddWithValue("@amountPaid", TemporaryData.DownpaymentAmount)
            cmd.Parameters.AddWithValue("@paymentMethod", "GCash")
            cmd.Parameters.AddWithValue("@paymentConfirm", "Yes")
            cmd.Parameters.AddWithValue("@downpayment", TemporaryData.DownpaymentAmount)
            cmd.Parameters.AddWithValue("@paymentStatus", "pending")
            cmd.ExecuteNonQuery()

            MessageBox.Show("Payment Confirmed!")
            MessageBox.Show("All data submitted successfully!")

            TemporaryData.Clear()
            Calendar2.Close()
            bookSummary.Close()
            Form1.Show()
            Me.Close()


        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            dataInfo.Close()
        End Try



    End Sub
    Private Sub lnkUseQRCode2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkUseQRCode2.LinkClicked
        ShowQRPanel2()
    End Sub
    ' Step 3: QR Code
    Private Sub ShowQRPanel2()
        lblQRName2.Text = TemporaryData.OwnerName
        lblQRAmount2.Text = "₱ " & TemporaryData.DownpaymentAmount.ToString("F2")
        GenerateAndDisplayQRCode2()
        pnlQRGCash2.Visible = True
        pnlQRGCash2.BringToFront()
    End Sub
    Private Sub GenerateAndDisplayQRCode2()
        Dim rand As New Random()
        generatedCode2 = rand.Next(100000, 999999).ToString()
        TemporaryData.GeneratedCode = generatedCode2
        Dim qrGenerator As New QRCodeGenerator()
        Dim qrData = qrGenerator.CreateQrCode(generatedCode2, QRCodeGenerator.ECCLevel.Q)
        Dim qrCode = New QRCode(qrData)
        Dim qrImage = qrCode.GetGraphic(6)
        pbQRCode2.Image = qrImage
        ' Removed: lblQRCode.Text = "Enter this code after scanning"
    End Sub
    Private Sub btnValidateCode2_Click(sender As Object, e As EventArgs) Handles btnValidateCode2.Click
        If txtEnteredCode2.Text = TemporaryData.GeneratedCode Then
            MessageBox.Show("QR Code Payment Confirmed!")

            Dim dataInfo As New MySqlConnection("server=localhost;user id=root;password=rdtimbangMysql1;database=adminmain")
            Dim cmd As New MySqlCommand

            Try
                dataInfo.Open()
                cmd.Connection = dataInfo

                ' Insert owner information


                cmd.CommandText = "INSERT INTO ownerinformation(ownerName, EmailAddress, contactNumber, address,ownerSex,  ownerAge, ownerCode) 
                   VALUES (@ownerName, @EmailAddress, @contactNumber, @address,@ownerSex,  @ownerAge, @ownerCode)"
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@ownerName", TemporaryData.OwnerName)
                cmd.Parameters.AddWithValue("@EmailAddress", TemporaryData.EmailAddress)
                cmd.Parameters.AddWithValue("@contactNumber", TemporaryData.ContactNumber)
                cmd.Parameters.AddWithValue("@address", TemporaryData.Address)
                cmd.Parameters.AddWithValue("@ownerCode", TemporaryData.userCode)
                cmd.Parameters.AddWithValue("@ownerSex", TemporaryData.ownerSex)
                cmd.Parameters.AddWithValue("@ownerAge", TemporaryData.ownerAge)

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


                Dim bookingID As Integer = Convert.ToInt32(cmd.LastInsertedId)


                cmd.CommandText = "INSERT INTO payment(servicesId, bookingID, amountPaid, paymentMethod, paymentconfirm, downpayment, paymentStatus)
                           VALUES (@servicesId, @bookingID, @amountPaid, @paymentMethod, @paymentConfirm, @downpayment, @paymentStatus)"
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@servicesId", serviceID)
                cmd.Parameters.AddWithValue("@bookingID", bookingID)
                cmd.Parameters.AddWithValue("@amountPaid", TemporaryData.DownpaymentAmount)
                cmd.Parameters.AddWithValue("@paymentMethod", "GCash")
                cmd.Parameters.AddWithValue("@paymentConfirm", "Yes")
                cmd.Parameters.AddWithValue("@downpayment", TemporaryData.DownpaymentAmount)
                cmd.Parameters.AddWithValue("@paymentStatus", "pending")
                cmd.ExecuteNonQuery()

                MessageBox.Show("Payment Confirmed!")
                MessageBox.Show("All data submitted successfully!")
                TemporaryData.Clear()
                Calendar2.Close()
                bookSummary.Close()
                Form1.Show()
                Me.Close()

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                dataInfo.Close()
            End Try


        Else
            MessageBox.Show("Invalid code. Try again.")
        End If
    End Sub
End Class