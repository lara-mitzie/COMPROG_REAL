Imports MySql.Data.MySqlClient

Public Class dashboard

    Dim conn As New MySqlConnection("server=localhost;userid=root;password=Michymichy_27;database=admin_main2")

    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblAppointments.BackColor = Color.FromArgb(246, 243, 238)
        lblpets.BackColor = Color.FromArgb(220, 205, 187)
        lblRevenueToday.BackColor = Color.FromArgb(95, 131, 104)
        lblVaccineSession.BackColor = Color.FromArgb(201, 230, 208)
        lblAllOutRevenue.BackColor = Color.FromArgb(141, 167, 148)
        lblCheckupSessions.BackColor = Color.FromArgb(139, 179, 152)

        Try
            LoadAppointmentsThisWeek()
            LoadTotalPets()
            LoadTodayRevenue()
            LoadSessionCounts()
            LoadAllOutRevenue()
        Catch ex As Exception
            MessageBox.Show("Dashboard load error: " & ex.Message)
        End Try
    End Sub

    ' Appointments This Week
    Private Sub LoadAppointmentsThisWeek()
        Dim query As String = "SELECT COUNT(*) FROM bookingtable WHERE YEARWEEK(bookingDate) = YEARWEEK(CURDATE())"
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

    ' Vaccine & Checkup Sessions
    Private Sub LoadSessionCounts()
        Dim query As String = "SELECT serviceName FROM bookingtable JOIN services ON bookingtable.serviceId = services.servicesId"

        Try
            conn.Open()

            Using cmd As New MySqlCommand(query, conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    ' Loop through the data and check the serviceName for each record
                    While reader.Read()
                        Dim serviceName As String = reader("serviceName").ToString()

                        ' Check the serviceName and update the labels accordingly
                        If serviceName = "VACCINATION" Then
                            lblVaccineSession.Text = (Convert.ToInt32(lblVaccineSession.Text) + 1).ToString()
                        ElseIf serviceName = "CHECK-UP" Then
                            lblCheckupSessions.Text = (Convert.ToInt32(lblCheckupSessions.Text) + 1).ToString()
                        ElseIf serviceName = "VACCINATION,CHECK-UP" Then
                            lblVaccineSession.Text = (Convert.ToInt32(lblVaccineSession.Text) + 1).ToString()
                            lblCheckupSessions.Text = (Convert.ToInt32(lblCheckupSessions.Text) + 1).ToString()
                        End If
                    End While

                    lblCheckupSessions.Text = Val(lblCheckupSessions.Text) / 2
                    lblVaccineSession.Text = Val(lblVaccineSession.Text) / 2
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading session counts: " & ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub

    ' Today's Revenue
    Private Sub LoadTodayRevenue()
        Dim query As String = "SELECT IFNULL(SUM(servicePrice), 0) FROM services JOIN bookingtable ON services.servicesId = bookingtable.bookingId WHERE DATE(bookingDate) = CURDATE()"
        Try
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                Dim revenueToday As Decimal = Convert.ToDecimal(cmd.ExecuteScalar())
                lblRevenueToday.Text = "₱" & revenueToday.ToString("N2")
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading today's revenue: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' All Out Revenue
    Private Sub LoadAllOutRevenue()
        Dim query As String = "SELECT IFNULL(SUM(servicePrice), 0) FROM services"
        Try
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                Dim totalRevenue As Decimal = Convert.ToDecimal(cmd.ExecuteScalar())
                lblAllOutRevenue.Text = "₱" & totalRevenue.ToString("N2")
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading total revenue: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

End Class
