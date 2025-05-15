Imports MySql.Data.MySqlClient
Imports QRCoder

Public Class PaymentMethod
    Private generatedCode As String = ""

    Private Sub PaymentMethod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set all panels to not visible initially except pnlLoginGCash
        pnlLoginGCash.Visible = True ' Changed to True to automatically show this panel
        pnlConfirmGCash.Visible = False
        pnlQRGCash.Visible = False
        SetLoginDetails()
        pnlLoginGCash.BringToFront()
    End Sub

    ' Step 1: Login GCash
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If txtMobile.Text.Length = 10 AndAlso IsNumeric(txtMobile.Text) Then
            TemporaryData.GcashMobileNumber = txtMobile.Text
            ShowConfirmPanel()
        Else
            MessageBox.Show("Enter a valid 10-digit mobile number.")
        End If
    End Sub

    Private Sub txtMobile_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMobile.KeyPress
        ' Only allow numbers and max of 10 digits
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
        If txtMobile.Text.Length >= 10 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub SetLoginDetails()
        'lblOwnerName.Text = TemporaryData.LoggedInOwnerName

        Dim price As Decimal
        If Decimal.TryParse(TemporaryData.ServicePrice, price) Then
            TemporaryData.DownpaymentAmount = price * 0.3D
        Else
            TemporaryData.DownpaymentAmount = 0D
        End If

        lblAmount.Text = "Downpayment (30%): ₱ " & TemporaryData.DownpaymentAmount.ToString("F2")
    End Sub

    ' Step 2: Confirmation
    Private Sub ShowConfirmPanel()
        lblConfirmName.Text = TemporaryData.LoggedInOwnerName
        lblConfirmMobile.Text = TemporaryData.GcashMobileNumber
        lblConfirmAmount.Text = "Downpayment: ₱ " & TemporaryData.DownpaymentAmount.ToString("F2")
        lblAmountPay.Text = "Downpayment: ₱ " & TemporaryData.DownpaymentAmount.ToString("F2")

        pnlLoginGCash.Visible = False ' Hide login panel
        pnlConfirmGCash.Visible = True
        pnlConfirmGCash.BringToFront()
    End Sub

    Private Sub btnConfirmPayment_Click(sender As Object, e As EventArgs)

        Dim dataInfo As New MySqlConnection("server=localhost;user id=root;password=rdtimbangMysql1;database=adminmain")
        Dim cmd As New MySqlCommand

        Try
            dataInfo.Open()
            cmd.Connection = dataInfo

            Dim petID As Integer

            ' Check if we're rebooking an existing pet or adding a new one
            If TemporaryData.petID > 0 Then
                ' Use the existing petID for rebooking
                petID = TemporaryData.petID
            Else
                ' Insert new pet information
                cmd.CommandText = "INSERT INTO petinformation(ownerID, petName, petSex, petType, petAge, petBirthday, petWeight, petBreed, petVacStatus)
                        VALUES (@ownerID, @petName, @petSex, @petType, @petAge, @petBirthday, @petWeight, @petBreed, @petVacStatus)"
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@ownerID", TemporaryData.LoggedInOwnerID)
                cmd.Parameters.AddWithValue("@petName", TemporaryData.petName)
                cmd.Parameters.AddWithValue("@petSex", TemporaryData.petSex)
                cmd.Parameters.AddWithValue("@petType", TemporaryData.petType)
                cmd.Parameters.AddWithValue("@petAge", TemporaryData.petAge)
                cmd.Parameters.AddWithValue("@petBirthday", TemporaryData.petBirthday)
                cmd.Parameters.AddWithValue("@petWeight", TemporaryData.petWeight)
                cmd.Parameters.AddWithValue("@petBreed", TemporaryData.petBreed)
                cmd.Parameters.AddWithValue("@petVacStatus", TemporaryData.petvacStatus)
                cmd.ExecuteNonQuery()

                petID = Convert.ToInt32(cmd.LastInsertedId)
            End If

            ' Find or create service ID
            Dim serviceID As Integer = 0

            ' First check if this service already exists
            cmd.CommandText = "SELECT servicesId FROM services WHERE serviceName = @serviceName"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@serviceName", TemporaryData.ServiceType)

            Using reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    serviceID = Convert.ToInt32(reader("servicesId"))
                End If
            End Using

            ' If service doesn't exist, create it
            If serviceID = 0 Then
                cmd.CommandText = "INSERT INTO services(serviceName, servicePrice)
                        VALUES (@serviceName, @servicePrice)"
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@serviceName", TemporaryData.ServiceType)
                cmd.Parameters.AddWithValue("@servicePrice", TemporaryData.ServicePrice)
                cmd.ExecuteNonQuery()

                serviceID = Convert.ToInt32(cmd.LastInsertedId)
            End If

            If serviceID = 0 Then
                Throw New Exception("Error: ServiceID was not correctly retrieved.")
            End If

            ' Insert booking info
            cmd.CommandText = "INSERT INTO bookingtable(petID, serviceID, bookingDate, bookingStatus)
                    VALUES (@petID, @serviceID, @bookingDate, @bookingStatus)"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@petID", petID)
            cmd.Parameters.AddWithValue("@serviceID", serviceID)
            cmd.Parameters.AddWithValue("@bookingStatus", "Confirmed")
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

            MessageBox.Show("Booking submitted successfully!")
            customerAccount.RefreshCustomerAccount()
            customerAccount.Show()
            TemporaryData.Clear()
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            dataInfo.Close()
        End Try

        MessageBox.Show("Payment Confirmed!")
        Me.Close()
    End Sub

    Private Sub lnkUseQRCode_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkUseQRCode.LinkClicked
        ShowQRPanel()
    End Sub

    ' Step 3: QR Code
    Private Sub ShowQRPanel()
        lblQRAmount.Text = "₱ " & TemporaryData.DownpaymentAmount.ToString("F2")
        GenerateAndDisplayQRCode()

        ' Hide other panels
        pnlLoginGCash.Visible = False
        pnlConfirmGCash.Visible = False

        ' Show QR panel and bring to front
        pnlQRGCash.Visible = True
        pnlQRGCash.BringToFront()
    End Sub

    Private Sub GenerateAndDisplayQRCode()
        Dim rand As New Random()
        generatedCode = rand.Next(100000, 999999).ToString()
        TemporaryData.GeneratedCode = generatedCode

        Dim qrGenerator As New QRCodeGenerator()
        Dim qrData = qrGenerator.CreateQrCode(generatedCode, QRCodeGenerator.ECCLevel.Q)
        Dim qrCode = New QRCode(qrData)
        Dim qrImage = qrCode.GetGraphic(6)

        pbQRCode.Image = qrImage
        ' Removed: lblQRCode.Text = "Enter this code after scanning"
    End Sub

    Private Sub btnValidateCode_Click(sender As Object, e As EventArgs) Handles btnValidateCode.Click
        If txtEnteredCode.Text = TemporaryData.GeneratedCode Then


            Dim dataInfo As New MySqlConnection("server=localhost;user id=root;password=rdtimbangMysql1;database=adminmain")
            Dim cmd As New MySqlCommand

            Try
                dataInfo.Open()
                cmd.Connection = dataInfo

                Dim petID As Integer

                ' Check if we're rebooking an existing pet or adding a new one
                If TemporaryData.petID > 0 Then
                    ' Use the existing petID for rebooking
                    petID = TemporaryData.petID
                Else
                    ' Insert new pet information
                    cmd.CommandText = "INSERT INTO petinformation(ownerID, petName, petSex, petType, petAge, petBirthday, petWeight, petBreed, petVacStatus)
                        VALUES (@ownerID, @petName, @petSex, @petType, @petAge, @petBirthday, @petWeight, @petBreed, @petVacStatus)"
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@ownerID", TemporaryData.LoggedInOwnerID)
                    cmd.Parameters.AddWithValue("@petName", TemporaryData.petName)
                    cmd.Parameters.AddWithValue("@petSex", TemporaryData.petSex)
                    cmd.Parameters.AddWithValue("@petType", TemporaryData.petType)
                    cmd.Parameters.AddWithValue("@petAge", TemporaryData.petAge)
                    cmd.Parameters.AddWithValue("@petBirthday", TemporaryData.petBirthday)
                    cmd.Parameters.AddWithValue("@petWeight", TemporaryData.petWeight)
                    cmd.Parameters.AddWithValue("@petBreed", TemporaryData.petBreed)
                    cmd.Parameters.AddWithValue("@petVacStatus", TemporaryData.petvacStatus)
                    cmd.ExecuteNonQuery()

                    petID = Convert.ToInt32(cmd.LastInsertedId)
                End If

                ' Find or create service ID
                Dim serviceID As Integer = 0

                ' First check if this service already exists
                cmd.CommandText = "SELECT servicesId FROM services WHERE serviceName = @serviceName"
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@serviceName", TemporaryData.ServiceType)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        serviceID = Convert.ToInt32(reader("servicesId"))
                    End If
                End Using

                ' If service doesn't exist, create it
                If serviceID = 0 Then
                    cmd.CommandText = "INSERT INTO services(serviceName, servicePrice)
                        VALUES (@serviceName, @servicePrice)"
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@serviceName", TemporaryData.ServiceType)
                    cmd.Parameters.AddWithValue("@servicePrice", TemporaryData.ServicePrice)
                    cmd.ExecuteNonQuery()

                    serviceID = Convert.ToInt32(cmd.LastInsertedId)
                End If

                If serviceID = 0 Then
                    Throw New Exception("Error: ServiceID was not correctly retrieved.")
                End If

                ' Insert booking info
                cmd.CommandText = "INSERT INTO bookingtable(petID, serviceID, bookingDate, bookingStatus)
                    VALUES (@petID, @serviceID, @bookingDate, @bookingStatus)"
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@petID", petID)
                cmd.Parameters.AddWithValue("@serviceID", serviceID)
                cmd.Parameters.AddWithValue("@bookingStatus", "Confirmed")
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

                MessageBox.Show("Booking submitted successfully!")
                customerAccount.RefreshCustomerAccount()
                customerAccount.Show()
                TemporaryData.Clear()
                Me.Close()

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

    ' Removed duplicate btnValidateCode3_Click method as it appears to be redundant
    ' and is causing a compilation error due to duplicate handler for btnValidateCode.Click
End Class