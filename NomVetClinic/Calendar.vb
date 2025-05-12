Imports MySql.Data.MySqlClient

Public Class Calendar
    Private WithEvents scrollTimer As New Timer With {.Interval = 10}
    Private isMouseOver As Boolean = False
    Private previouslySelectedLabel As Label = Nothing
    Private Sub Calendar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler btnNextDate.Paint, AddressOf btnBookNow_Paint
        AddHandler btnBackDate.Paint, AddressOf btnBookNow_Paint
        AddHandler btnConfirm.Paint, AddressOf btnBookNow_Paint


        PanelAboveSlide.InitializePanel(pnlAbovebuttons2, pnlTimer9)
        Me.WindowState = FormWindowState.Maximized


        MakeButtonRounded(btnBackDate, 48)
        MakeButtonRounded(btnConfirm, 48)
        MakeButtonRounded(btnNextDate, 48)
        MakeButtonRounded(btnBack, 48)

        positonsPanels.btnNextDateCAl(btnNextDate)
        positonsPanels.btnConfirmCAl(btnConfirm)
        positonsPanels.btnBackDateCAl(btnBackDate)
        positonsPanels.tlpCalendarCAl(tableCalendar)
        positonsPanels.lblMonthCAL(lblMonth)

        tableCalendar.BackColor = Color.FromArgb(253, 253, 248)
        lblMonth.BackColor = Color.FromArgb(253, 253, 248)
        lblMonth.ForeColor = Color.FromArgb(80, 89, 80)

        btnBack.BackColor = Color.FromArgb(166, 147, 140)

    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If TemporaryData.BookingDate = Date.MinValue Then
            MessageBox.Show("Please select a date before confirming the booking.", "Missing Date", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If



        addCode.Show()
        Me.Close()



    End Sub

    Private _currentMonth As Integer = Date.Today.Month
    Private _currentYear As Integer = Date.Today.Year

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeCalendar()
    End Sub

    Private Sub InitializeCalendar()
        BuildCalendar(New Date(_currentYear, _currentMonth, 1))
    End Sub

    Private Sub BuildCalendar(targetDate As Date)
        tableCalendar.ColumnStyles.Clear()
        tableCalendar.RowStyles.Clear()

        For i As Integer = 1 To 7
            tableCalendar.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100 / 7))
        Next

        For i As Integer = 1 To 6
            tableCalendar.RowStyles.Add(New RowStyle(SizeType.Percent, 100 / 6))
        Next

        Try
            ' Clear existing controls
            tableCalendar.Controls.Clear()

            Dim calendarDate As New Date(targetDate.Year, targetDate.Month, 1)
            Dim firstDayOffset As Integer = CalculateFirstDayOffset(calendarDate)

            ' Constants for better maintainability
            Const MAX_ROWS As Integer = 6
            Const DAYS_IN_WEEK As Integer = 7

            ' Get booked dates from the database
            Dim bookedDates As Dictionary(Of Date, String) = GetBookedDates(calendarDate.Month, calendarDate.Year)

            For row As Integer = 0 To MAX_ROWS - 1
                For col As Integer = 0 To DAYS_IN_WEEK - 1
                    Dim cellLabel As New Label With {
                        .Dock = DockStyle.Fill,
                        .TextAlign = ContentAlignment.MiddleCenter,
                        .BorderStyle = BorderStyle.FixedSingle,
                        .Font = New Font("Glacial Indifference", 12, FontStyle.Regular),
                        .BackColor = Color.White,
                        .Padding = New Padding(2)
                    }

                    Dim cellIndex As Integer = row * DAYS_IN_WEEK + col

                    If cellIndex >= firstDayOffset AndAlso
                       cellIndex < firstDayOffset + Date.DaysInMonth(calendarDate.Year, calendarDate.Month) Then

                        Dim dayNumber As Integer = cellIndex - firstDayOffset + 1
                        cellLabel.Text = dayNumber.ToString()

                        Dim thisDate As New Date(calendarDate.Year, calendarDate.Month, dayNumber)

                        If thisDate < Date.Today Then
                            ' Past dates
                            cellLabel.BackColor = Color.LightGray
                            cellLabel.ForeColor = Color.DarkGray
                            cellLabel.Enabled = False
                            cellLabel.Text &= vbCrLf & "Past"
                        ElseIf thisDate.DayOfWeek = DayOfWeek.Sunday Then
                            ' Closed on Sundays
                            cellLabel.BackColor = Color.LightGray
                            cellLabel.ForeColor = Color.Red
                            cellLabel.Enabled = False
                            cellLabel.Text &= vbCrLf & "Closed"
                        ElseIf bookedDates.ContainsKey(thisDate.Date) Then
                            Dim status As String = bookedDates(thisDate.Date)

                            If status = "confirmed" Then
                                ' Confirmed bookings - not available
                                cellLabel.BackColor = Color.FromArgb(255, 116, 108)
                                cellLabel.ForeColor = Color.White
                                cellLabel.Enabled = False
                                cellLabel.Text &= vbCrLf & "Booked"
                            ElseIf status = "cancelled" Then
                                ' Cancelled bookings - just make them clickable like regular dates
                                ' No special styling, just normal appearance
                                AddHandler cellLabel.Click, AddressOf Day_Click
                                cellLabel.Cursor = Cursors.Hand
                            End If
                        Else
                            ' Regular available date
                            cellLabel.BackColor = Color.White
                            cellLabel.Cursor = Cursors.Hand
                            AddHandler cellLabel.Click, AddressOf Day_Click
                        End If

                        ' Highlight today's date
                        If thisDate = Date.Today Then
                            cellLabel.Font = New Font(cellLabel.Font, FontStyle.Bold)
                            If Not cellLabel.Text.Contains("Past") AndAlso
                               Not cellLabel.Text.Contains("Closed") AndAlso
                               Not cellLabel.Text.Contains("Booked") Then
                                cellLabel.Text &= vbCrLf & "Today"
                            End If
                        End If
                    End If

                    tableCalendar.Controls.Add(cellLabel, col, row)
                Next
            Next

        Catch ex As Exception
            MessageBox.Show($"Error building calendar: {ex.Message}",
                          "Calendar Error",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Error)
        End Try

        ' Update the month label
        lblMonth.Text = targetDate.ToString("MMMM yyyy")  ' Added year for better context
    End Sub

    Private Function CalculateFirstDayOffset(dateToCalculate As Date) As Integer
        Return CInt(dateToCalculate.DayOfWeek) Mod 7
    End Function

    Private Sub Day_Click(sender As Object, e As EventArgs)
        Dim clickedLabel As Label = DirectCast(sender, Label)

        ' Extract day number from label text (it may contain additional text)
        Dim parts() As String = clickedLabel.Text.Split(New String() {vbCrLf}, StringSplitOptions.None)
        Dim dayNumber As Integer

        If Integer.TryParse(parts(0), dayNumber) Then
            Dim selectedDate As New Date(_currentYear, _currentMonth, dayNumber)

            Dim result As DialogResult = MessageBox.Show("Selected Date: " & selectedDate.ToShortDateString(), "Date Selected", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

            If result = DialogResult.OK Then
                ' Unselect the previous label if it's not the same one
                If previouslySelectedLabel IsNot Nothing AndAlso previouslySelectedLabel IsNot clickedLabel Then
                    previouslySelectedLabel.BackColor = Color.White

                    ' Remove "Selected" text
                    Dim oldParts() As String = previouslySelectedLabel.Text.Split(New String() {vbCrLf}, StringSplitOptions.None)
                    previouslySelectedLabel.Text = oldParts(0)
                End If

                ' Update new selected label
                clickedLabel.BackColor = Color.FromArgb(159, 214, 118)
                clickedLabel.Text = parts(0) & vbCrLf & "Selected"
                TemporaryData.BookingDate = selectedDate

                ' Remember this label for next time
                previouslySelectedLabel = clickedLabel
            End If
        End If
    End Sub


    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnBackDate.Click
        NavigateMonths(-1)
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNextDate.Click
        NavigateMonths(1)
    End Sub

    Private Sub NavigateMonths(direction As Integer)
        _currentMonth += direction

        If _currentMonth < 1 Then
            _currentMonth = 12
            _currentYear -= 1
        ElseIf _currentMonth > 12 Then
            _currentMonth = 1
            _currentYear += 1
        End If

        BuildCalendar(New Date(_currentYear, _currentMonth, 1))
    End Sub

    Private Function GetBookedDates(month As Integer, year As Integer) As Dictionary(Of Date, String)
        Dim bookedStatusDates As New Dictionary(Of Date, String)
        Dim connStr As String = "server=localhost;user id=root;password=rdtimbangMysql1;database=adminmain"
        Dim query As String = "SELECT bookingDate, bookingStatus FROM bookingtable WHERE MONTH(bookingDate) = @month AND YEAR(bookingDate) = @year"

        Try
            Using conn As New MySqlConnection(connStr)
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@month", month)
                    cmd.Parameters.AddWithValue("@year", year)

                    conn.Open()
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim dateValue As Date = CDate(reader("bookingDate"))
                            Dim status As String = reader("bookingStatus").ToString().ToLower()
                            bookedStatusDates(dateValue) = status
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Database error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return bookedStatusDates
    End Function



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        Form1.Close()
    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub pnlAboveTimer_Tick(sender As Object, e As EventArgs) Handles pnlTimer9.Tick
        PanelAboveSlide.SlidePanel(pnlAbovebuttons2, pnlTimer9)
    End Sub



    'pnl Button Mouse enter
    Private Sub pctHomePage_MouseEnter(sender As Object, e As EventArgs) Handles pctMain.MouseEnter
        PanelAboveSlide.MouseEnter(pnlAbovebuttons2, pnlTimer9)
    End Sub


    'pnl Button Mouse Move
    Private Sub MouseMovePanel(sender As Object, e As MouseEventArgs) Handles pctMain.MouseMove
        PanelAboveSlide.MouseMove(pnlAbovebuttons2, e, pnlTimer9)
    End Sub


    Private Sub btnBookNow_Paint(sender As Object, e As PaintEventArgs)
        If isMouseOver Then
            GradientHelper.DrawGradientButton(sender, e, Color.FromArgb(0, 151, 178), Color.FromArgb(126, 217, 87), Drawing2D.LinearGradientMode.Horizontal)
        Else
            GradientHelper.DrawGradientButton(sender, e, Color.FromArgb(126, 217, 87), Color.FromArgb(0, 151, 178), Drawing2D.LinearGradientMode.Horizontal)
        End If
    End Sub



    Private Sub btnNextNow_MouseLeave(sender As Object, e As EventArgs) Handles btnNextDate.MouseLeave
        isMouseOver = False

        btnNextDate.Invalidate()

    End Sub

    Private Sub btnNExtNow_MouseEnter(sender As Object, e As EventArgs) Handles btnNextDate.MouseEnter
        isMouseOver = True
        btnNextDate.Invalidate()

    End Sub

    Private Sub btnConfirmNow_MouseLeave(sender As Object, e As EventArgs) Handles btnConfirm.MouseLeave
        isMouseOver = False

        btnNextDate.Invalidate()
        btnConfirm.Invalidate()
        btnBackDate.Invalidate()
    End Sub
    Private Sub btnCnnfirmNow_MouseEnter(sender As Object, e As EventArgs) Handles btnConfirm.MouseEnter
        isMouseOver = True
        btnConfirm.Invalidate()
    End Sub

    Private Sub btnBookNow_MouseLeave(sender As Object, e As EventArgs) Handles btnBackDate.MouseLeave
        isMouseOver = False

        btnNextDate.Invalidate()
        btnConfirm.Invalidate()
        btnBackDate.Invalidate()
    End Sub
    Private Sub btnBackDateNow_MouseEnter(sender As Object, e As EventArgs) Handles btnBackDate.MouseLeave
        isMouseOver = False

        btnBackDate.Invalidate()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        pickServices2.Show()
        Me.Close()

    End Sub

End Class
