Imports MySql.Data.MySqlClient

Public Class bookSummary3

    Private WithEvents scrollTimer As New Timer With {.Interval = 10}
    Private isMouseOver As Boolean = False
    Private Sub ucSummaryInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler btnConfirm.Paint, AddressOf btnBookNow_Paint
        MakeFormRounded(Me, 48)
        PanelAboveSlide.InitializePanel(pnlAbovebuttons2, TimerPanel2)
        MakeButtonRounded(btnConfirm, 48)


        Dim labels As Label() = {
        lblPetName, lblPSex, lblPAge, lblBookingdate, lblPType, lblPWeight, lblService, lblServicePrice, lblPVacStatus, lblPBrithday,
        lblPbreed}

        For Each tb As Label In labels
            tb.BackColor = Color.FromArgb(239, 232, 224)
            tb.ForeColor = Color.FromArgb(173, 159, 155)
        Next

        ' Load pet details
        If TemporaryData.petID > 0 Then
            ' If this is a rebooking (petID was set from viewAppointment)
            LoadPetDetailsFromDatabase()
        Else
            ' Display the existing temporary data if it's a new pet booking
            DisplayPetDetails()
        End If

        ' Always display the service and booking date information
        lblService.Text = TemporaryData.ServiceType
        lblServicePrice.Text = "₱" & TemporaryData.ServicePrice.ToString("N2")
        lblBookingdate.Text = TemporaryData.BookingDate.ToShortDateString()
    End Sub

    Private Sub LoadPetDetailsFromDatabase()
        Try
            Dim connStr As String = "server=localhost;user id=root;password=rdtimbangMysql1;database=adminmain"
            Using conn As New MySqlConnection(connStr)
                conn.Open()

                ' Query to get pet details based on petID
                Dim query As String = "SELECT * FROM petinformation WHERE petID = @petID"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.Add("@petID", MySqlDbType.Int32).Value = TemporaryData.petID

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' Store pet details in TemporaryData
                            TemporaryData.petName = reader("petName").ToString()
                            TemporaryData.petSex = reader("petSex").ToString()
                            TemporaryData.petType = reader("petType").ToString()
                            TemporaryData.petWeight = Convert.ToDecimal(reader("petWeight"))
                            TemporaryData.petAge = Convert.ToInt32(reader("petAge"))
                            TemporaryData.petBreed = reader("petBreed").ToString()
                            TemporaryData.petvacStatus = reader("petVacStatus").ToString()

                            ' Check if petBirthday column exists and has a value
                            If Not reader.IsDBNull(reader.GetOrdinal("petBirthday")) Then
                                TemporaryData.petBirthday = Convert.ToDateTime(reader("petBirthday"))
                            End If

                            ' Also store the owner ID if needed
                            TemporaryData.LoggedInOwnerID = Convert.ToInt32(reader("ownerID"))

                            ' Display the pet details
                            DisplayPetDetails()
                        Else
                            MessageBox.Show("Pet information not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading pet details: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DisplayPetDetails()
        ' Display pet details in labels
        lblPetName.Text = TemporaryData.petName
        lblPSex.Text = TemporaryData.petSex
        lblPType.Text = TemporaryData.petType
        lblPWeight.Text = TemporaryData.petWeight.ToString() & " kg"
        lblPAge.Text = TemporaryData.petAge.ToString() & " yrs"
        lblPbreed.Text = TemporaryData.petBreed
        lblPVacStatus.Text = TemporaryData.petvacStatus

        ' Check if birthday is valid before formatting
        If TemporaryData.petBirthday <> DateTime.MinValue Then
            lblPBrithday.Text = TemporaryData.petBirthday.ToShortDateString()
        Else
            lblPBrithday.Text = "Not available"
        End If
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
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

            MessageBox.Show("Booking submitted successfully!")
            customerAccount.RefreshCustomerAccount()
            customerAccount.Show()
            TemporaryData.Clear()
            Form1.Hide()
            Me.Hide()

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