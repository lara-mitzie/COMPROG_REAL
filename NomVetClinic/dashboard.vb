Imports MySql.Data.MySqlClient

Public Class dashboard

    Dim conn As New MySqlConnection("server=localhost;user id=root;password=rdtimbangMysql1;database=adminmain")

    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblAppointments.BackColor = Color.FromArgb(246, 243, 238)
        lblpets.BackColor = Color.FromArgb(220, 205, 187)
        txtRevenueToday.BackColor = Color.FromArgb(95, 131, 104)
        lblVaccineSession.BackColor = Color.FromArgb(201, 230, 208)
        txtAllOutRevenue.BackColor = Color.FromArgb(141, 167, 148)
        lblCheckupSessions.BackColor = Color.FromArgb(139, 179, 152)

        Try
            LoadAppointments() ' Now loads all appointments, excluding cancelled or done ones
            LoadTotalPets()
            LoadTodayRevenue()
            LoadSessionCounts()
            LoadAllOutRevenue()
        Catch ex As Exception
            MessageBox.Show("Dashboard load error: " & ex.Message)
        End Try
    End Sub

    ' Load all appointments (excluding cancelled and done)
    Private Sub LoadAppointments()
        Dim query As String = "
        SELECT COUNT(*) 
        FROM bookingtable 
        WHERE bookingStatus NOT IN ('Cancelled', 'Done')"

        Try
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                Dim appointmentCount As Object = cmd.ExecuteScalar()
                lblAppointments.Text = If(appointmentCount IsNot Nothing, Convert.ToInt32(appointmentCount).ToString(), "0")
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading appointments: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Total Pets
    Private Sub LoadTotalPets()
        Dim query As String = "SELECT COUNT(*) FROM petinformation"
        Try
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                Dim petCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                lblpets.Text = petCount.ToString()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading pet count: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Vaccine & Checkup Sessions (No week filter anymore)
    Private Sub LoadSessionCounts()
        lblVaccineSession.Text = "0"
        lblCheckupSessions.Text = "0"

        Dim query As String = "
        SELECT serviceName 
        FROM bookingtable 
        JOIN services ON bookingtable.serviceId = services.servicesId 
        WHERE bookingStatus NOT IN ('Cancelled', 'Done')"

        Try
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim serviceName As String = reader("serviceName").ToString().Trim().ToUpper()

                        ' Count separately or together
                        If serviceName.Contains("VACCINATION") Then
                            lblVaccineSession.Text = (Convert.ToInt32(lblVaccineSession.Text) + 1).ToString()
                        End If
                        If serviceName.Contains("CHECK-UP") Then
                            lblCheckupSessions.Text = (Convert.ToInt32(lblCheckupSessions.Text) + 1).ToString()
                        End If
                    End While
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading session counts: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Today's Revenue (Add downpayment if booked today)
    Private Sub LoadTodayRevenue()
        ' Query to add downpayment if booked today
        Dim query As String = "
        SELECT IFNULL(SUM(
            CASE 
                WHEN p.paymentStatus = 'paid' THEN s.servicePrice
                WHEN p.paymentStatus = 'pending' THEN p.downpayment
                ELSE 0
            END
        ), 0) AS revenueToday
        FROM payment p
        JOIN services s ON p.servicesId = s.servicesId
        JOIN bookingtable b ON b.bookingId = p.bookingID
        WHERE DATE(b.bookingDate) = CURDATE()"

        Try
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                Dim revenueToday As Decimal = Convert.ToDecimal(cmd.ExecuteScalar())
                txtRevenueToday.Text = "₱" & revenueToday.ToString("N2")
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading today's revenue: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub




    Private Sub LoadAllOutRevenue()
        ' Sum up service price when paymentStatus is paid, and downpayment when pending
        Dim query As String = "
        SELECT IFNULL(SUM(
            CASE 
                WHEN paymentStatus = 'paid' THEN s.servicePrice
                WHEN paymentStatus = 'pending' THEN p.downpayment
                ELSE 0
            END
        ), 0) AS totalRevenue
        FROM payment p
        JOIN services s ON p.servicesId = s.servicesId
        JOIN bookingtable b ON p.bookingID = b.bookingId
    "

        Try
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                Dim totalRevenue As Decimal = Convert.ToDecimal(cmd.ExecuteScalar())
                txtAllOutRevenue.Text = "₱" & totalRevenue.ToString("N2")
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading total revenue: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub



End Class
