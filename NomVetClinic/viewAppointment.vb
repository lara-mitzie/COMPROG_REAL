Imports MySql.Data.MySqlClient
Imports NomVetClinic.customerAccount

Public Class viewAppointment

    Private WithEvents scrollTimer As New Timer With {.Interval = 10}

    Private _selectedBookingId As Integer = -1
    Private hasUpcomingBooking As Boolean = False


    Private Sub MainLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelAboveSlide.InitializePanel(pnlAbovebuttons2, TimerPanel)
        MakeButtonRounded(btnBookAgain, 48)
        MakeButtonRounded(btnCancel, 48)
        MakeFormRounded(Me, 48)
        pnlPast.BackColor = Color.FromArgb(203, 212, 187)
        pnlNearest.BackColor = Color.FromArgb(203, 212, 187)

    End Sub


    Private _petId As Integer = -1


    Public Property PetId As Integer
        Get
            Return _petId
        End Get
        Set(value As Integer)
            _petId = value
        End Set
    End Property

    Private Sub YourAppointmentFormName_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If PetId <= 0 Then
            MessageBox.Show("Invalid pet ID. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        End If

        Try

            UpdatePastBookingsStatus(PetId)


            LoadNearestBooking(PetId)


            LoadPastBookings(PetId)


            PanelAboveSlide.InitializePanel(pnlAbovebuttons2, TimerPanel)
            MakeFormRounded(Me, 48)
        Catch ex As Exception
            MessageBox.Show("Error initializing form: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' New method to update booking status for past dates
    Private Sub UpdatePastBookingsStatus(petId As Integer)
        Try
            Dim connStr As String = "server=localhost;user id=root;password=rdtimbangMysql1;database=adminmain"
            Using conn As New MySqlConnection(connStr)
                conn.Open()

                ' Update query to set status to "Done" for past bookings that aren't cancelled
                Dim query As String = "
                    UPDATE bookingtable 
                    SET bookingStatus = 'Done' 
                    WHERE petID = @petID 
                    AND DATE(bookingDate) < CURDATE() 
                    AND bookingStatus <> 'Cancelled' 
                    AND bookingStatus <> 'Done'"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.Add("@petID", MySqlDbType.Int32).Value = petId
                    Dim rowsAffected = cmd.ExecuteNonQuery()
                    Debug.WriteLine($"Updated {rowsAffected} past bookings to 'Done' status")
                End Using
            End Using
        Catch ex As Exception
            Debug.WriteLine($"Error updating past bookings: {ex.Message}")
            ' Don't show a message box here to avoid interrupting the form load
        End Try
    End Sub

    Private Sub LoadNearestBooking(petId As Integer)
        ' Clear any previous content in pnlNearest
        pnlNearest.Controls.Clear()

        ' Reset selected booking ID and hide cancel button by default
        _selectedBookingId = -1
        btnCancel.Visible = False
        btnCancel.Enabled = False

        ' Create a list to hold future appointments
        Dim futureAppointments As New List(Of KeyValuePair(Of DateTime, String))
        Dim bookingIds As New List(Of Integer)  ' To store the booking IDs

        ' --- 1. Load appointments from the database ---
        Try
            ' Use the same connection string as your other functions
            Dim connStr As String = "server=localhost;user id=root;password=rdtimbangMysql1;database=adminmain"
            Using conn As New MySqlConnection(connStr)
                conn.Open()

                ' Query to get bookings for this pet - explicitly filter for future dates
                Dim query As String = "
                  SELECT b.bookingID, b.bookingDate, s.serviceName 
                  FROM bookingtable b
                  JOIN services s ON b.serviceID = s.servicesId
                  WHERE b.petID = @petID 
                  AND DATE(b.bookingDate) >= CURDATE()
                  AND b.bookingStatus <> 'Cancelled'"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.Add("@petID", MySqlDbType.Int32).Value = petId

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            ' Add proper error handling for date conversion
                            Dim bookingDate As DateTime
                            Try
                                Dim bookingId As Integer = Convert.ToInt32(reader("bookingID"))
                                bookingDate = Convert.ToDateTime(reader("bookingDate"))
                                ' Add debugging - check that the date is actually in the future
                                If bookingDate >= DateTime.Today Then
                                    Dim serviceType As String = reader("serviceName").ToString()
                                    futureAppointments.Add(New KeyValuePair(Of DateTime, String)(bookingDate, serviceType))
                                    bookingIds.Add(bookingId)  ' Store the booking ID
                                    ' Debug message to see the date that was found
                                    Debug.WriteLine($"Found future booking: {bookingDate.ToString("yyyy-MM-dd")} for service {serviceType}")
                                Else
                                    Debug.WriteLine($"Skipping non-future date: {bookingDate.ToString("yyyy-MM-dd")}")
                                End If
                            Catch ex As Exception
                                Debug.WriteLine($"Error converting date: {ex.Message}")
                                ' Continue to next record if there's a date conversion error
                                Continue While
                            End Try
                        End While
                    End Using
                End Using
            End Using


            If futureAppointments.Any() Then
                hasUpcomingBooking = True

                ' Sort the future appointments by booking date (ascending)
                Dim sortedBookings = futureAppointments.Select(Function(b, i) New With {.Date = b.Key, .Service = b.Value, .BookingId = bookingIds(i)}) _
                                                        .OrderBy(Function(a) a.Date).ToList()

                Dim nearestBooking = sortedBookings.First()
                _selectedBookingId = nearestBooking.BookingId  ' Store the booking ID for the cancel button

                ' Create a label for the nearest booking
                Dim label As New Label With {
                    .Text = nearestBooking.Date.ToString("MMMM dd, yyyy") & " for " & nearestBooking.Service,
                    .AutoSize = True,
                    .Font = New Font("Glacial Indeferrence", 10, FontStyle.Regular),
                    .ForeColor = Color.FromArgb(67, 66, 49)
                }
                pnlNearest.Controls.Add(label)

                ' Show cancel button
                btnCancel.Visible = True
                btnCancel.Enabled = True

                ' (Optional debug) Count of future bookings
                Dim countLabel As New Label With {
                    .Text = "Total future bookings: " & futureAppointments.Count.ToString(),
                    .AutoSize = True,
                    .Font = New Font("Glacial Indeferrence", 9, FontStyle.Italic),
                    .ForeColor = Color.FromArgb(67, 66, 49)
                }
                pnlNearest.Controls.Add(countLabel)
            Else
                hasUpcomingBooking = False

                ' Show "No upcoming booking"
                Dim label As New Label With {
                    .Text = "No upcoming booking",
                    .AutoSize = True,
                    .Location = New Point(2, 2),
                    .Font = New Font("Glacial Indeferrence", 12, FontStyle.Regular),
                    .ForeColor = Color.FromArgb(67, 66, 49)
                }
                pnlNearest.Controls.Add(label)

                ' Hide cancel button and ensure it's disabled
                btnCancel.Visible = False
                btnCancel.Enabled = False
            End If

        Catch ex As Exception
            MessageBox.Show("Error loading bookings: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            ' On error, show "No upcoming booking" and hide cancel button
            hasUpcomingBooking = False

            Dim label As New Label With {
                .Text = "No upcoming booking (Error loading data)",
                .AutoSize = True,
                .Location = New Point(2, 2),
                .Font = New Font("Glacial Indeferrence", 12, FontStyle.Regular),
                .ForeColor = Color.FromArgb(178, 8, 55) ' Red color to indicate error
            }
            pnlNearest.Controls.Add(label)

            btnCancel.Visible = False
            btnCancel.Enabled = False
        End Try
    End Sub

    Private Sub LoadPastBookings(petId As Integer)
        ' Clear any previous content in the past bookings panel
        pnlPast.Controls.Clear()

        ' Variables to track panel positioning
        Dim panelCount As Integer = 0
        Const PANEL_HEIGHT As Integer = 80
        Const PANEL_SPACING As Integer = 10

        Try
            ' Use the same connection string as your other functions
            Dim connStr As String = "server=localhost;user id=root;password=rdtimbangMysql1;database=adminmain"
            Using conn As New MySqlConnection(connStr)
                conn.Open()

                ' Query to get past bookings (completed or dates in the past)
                Dim query As String = "
                  SELECT b.bookingDate, s.serviceName, b.bookingStatus 
                      FROM bookingtable b
                      JOIN services s ON b.serviceID = s.servicesId
                      WHERE b.petID = @petID AND 
                      (b.bookingStatus = 'Done' OR b.bookingStatus = 'Cancelled' OR DATE(b.bookingDate) < CURDATE())
                      ORDER BY b.bookingDate DESC"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.Add("@petID", MySqlDbType.Int32).Value = petId

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.HasRows Then
                            While reader.Read()
                                ' Get booking details
                                Dim bookingDate As DateTime = Convert.ToDateTime(reader("bookingDate"))
                                ' Fix: Changed "serviceType" to "serviceName" to match the column name
                                Dim serviceType As String = reader("serviceName").ToString()
                                Dim bookingStatus As String = reader("bookingStatus").ToString()

                                ' Add panel for this past booking
                                AddPastBookingPanel(bookingDate, serviceType, bookingStatus, panelCount)
                                panelCount += 1
                            End While

                            ' Set the AutoScrollMinSize to accommodate all panels plus their spacing
                            If panelCount > 0 Then
                                pnlPast.AutoScrollMinSize = New Size(0, panelCount * (PANEL_HEIGHT + PANEL_SPACING))
                            End If
                        Else
                            ' No past bookings found - add a message
                            Dim noBookingsLabel As New Label With {
                                .Text = "No past bookings found",
                                .AutoSize = True,
                                .Location = New Point(10, 10),
                                .Font = New Font("Segoe UI", 12, FontStyle.Regular),
                                .ForeColor = Color.FromArgb(100, 100, 100)
                            }
                            pnlPast.Controls.Add(noBookingsLabel)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading past bookings: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AddPastBookingPanel(bookingDate As DateTime, serviceType As String, bookingStatus As String, index As Integer)
        ' Constants for panel dimensions
        Const PANEL_HEIGHT As Integer = 80
        Const PANEL_SPACING As Integer = 10

        ' Create a rounded panel for the past booking
        Dim bookingPanel As New RoundedPanel()
        bookingPanel.Size = New Size(pnlPast.Width - 40, PANEL_HEIGHT)
        bookingPanel.Dock = DockStyle.None
        bookingPanel.Location = New Point(20, 20 + index * (PANEL_HEIGHT + PANEL_SPACING))
        bookingPanel.Padding = New Padding(15, 10, 15, 10)
        ApplyRoundedCorners(bookingPanel, 20)

        ' Determine background color based on booking status
        Select Case bookingStatus.ToLower()
            Case "done"
                bookingPanel.BackColor = Color.FromArgb(200, 230, 200) ' Light green for completed
            Case "cancelled"
                bookingPanel.BackColor = Color.FromArgb(230, 200, 200) ' Light red for cancelled
            Case Else
                bookingPanel.BackColor = Color.FromArgb(230, 230, 230) ' Light gray for others
        End Select

        ' Date label
        Dim lblDate As New Label()
        lblDate.Text = bookingDate.ToString("MMMM dd, yyyy")
        lblDate.Font = New Font("Glacial Indeferrence", 12, FontStyle.Bold)
        lblDate.ForeColor = Color.FromArgb(50, 50, 50)
        lblDate.Location = New Point(15, 12)
        lblDate.AutoSize = True

        ' Service type label
        Dim lblService As New Label()
        lblService.Text = serviceType
        lblService.Font = New Font("Glacial Indeferrence", 11, FontStyle.Regular)
        lblService.ForeColor = Color.FromArgb(80, 80, 80)
        lblService.Location = New Point(15, 40)
        lblService.AutoSize = True

        ' Status label (right side)
        Dim lblStatus As New Label()
        lblStatus.Text = bookingStatus
        lblStatus.Font = New Font("Glacial Indeferrence", 10, FontStyle.Regular)
        lblStatus.ForeColor = Color.FromArgb(80, 80, 80)
        lblStatus.AutoSize = True

        ' Position the status label at the right side of the panel
        lblStatus.Location = New Point(bookingPanel.Width - lblStatus.Width - 20, 30)
        lblStatus.Anchor = AnchorStyles.Top Or AnchorStyles.Right

        ' Add labels to the panel
        bookingPanel.Controls.Add(lblDate)
        bookingPanel.Controls.Add(lblService)
        bookingPanel.Controls.Add(lblStatus)

        ' Add the panel to the container
        pnlPast.Controls.Add(bookingPanel)
    End Sub


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ' Check if we have a valid booking ID and if the cancel button is visible
        If Not btnCancel.Visible OrElse _selectedBookingId <= 0 Then
            MessageBox.Show("No upcoming booking to cancel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Ask for confirmation before cancelling
        Dim result = MessageBox.Show("Are you sure you want to cancel this appointment?",
                                    "Confirm Cancellation",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question)

        If result = DialogResult.No Then
            Return
        End If

        Try
            ' Update the booking status to 'Cancelled' in the database
            Dim connStr As String = "server=localhost;user id=root;password=rdtimbangMysql1;database=adminmain"
            Using conn As New MySqlConnection(connStr)
                conn.Open()

                Dim query As String = "UPDATE bookingtable SET bookingStatus = 'Cancelled' WHERE bookingID = @bookingID"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.Add("@bookingID", MySqlDbType.Int32).Value = _selectedBookingId
                    Dim rowsAffected = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Appointment has been cancelled successfully.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        ' Refresh the bookings display
                        LoadNearestBooking(PetId)
                        LoadPastBookings(PetId)
                    Else
                        MessageBox.Show("Could not cancel the appointment. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error cancelling appointment: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub







    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub pnlAboveTimer_Tick(sender As Object, e As EventArgs) Handles TimerPanel.Tick
        PanelAboveSlide.SlidePanel(pnlAbovebuttons2, TimerPanel)
    End Sub

    'pnl Button Mouse enter
    Private Sub pctHomePage_MouseEnter(sender As Object, e As EventArgs) Handles pctMain.MouseEnter
        PanelAboveSlide.MouseEnter(pnlAbovebuttons2, TimerPanel)
    End Sub

    'pnl Button Mouse Move
    Private Sub MouseMovePanel(sender As Object, e As MouseEventArgs) Handles pctMain.MouseMove
        PanelAboveSlide.MouseMove(pnlAbovebuttons2, e, TimerPanel)
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles btnBookAgain.Click
        If hasUpcomingBooking Then
            MessageBox.Show("This pet already has a booking. Please cancel it first before booking again.", "Booking Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Get the pet type from the database before opening the pickServices3 form
        Try
            Dim connStr As String = "server=localhost;user id=root;password=rdtimbangMysql1;database=adminmain"
            Using conn As New MySqlConnection(connStr)
                conn.Open()

                ' Query to get the pet type based on the petId
                Dim query As String = "SELECT petType FROM petinformation WHERE petID = @petID"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.Add("@petID", MySqlDbType.Int32).Value = PetId

                    Dim petType As String = cmd.ExecuteScalar()?.ToString()

                    If String.IsNullOrEmpty(petType) Then
                        MessageBox.Show("Could not retrieve pet type information. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If

                    ' Set the pet type in TemporaryData
                    TemporaryData.petType = petType
                    Debug.WriteLine($"Pet type set to: {petType}")

                    ' Reset any previous service selections
                    TemporaryData.ServiceType = ""
                    TemporaryData.ServicePrice = 0

                    ' Store the pet ID for later use
                    TemporaryData.petID = PetId

                    ' Now open the pickServices3 form
                    pickServices3.Show()
                    Me.Close()
                    customerAccount.Close()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error retrieving pet information: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class