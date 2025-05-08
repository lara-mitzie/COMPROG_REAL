Imports MySql.Data.MySqlClient

Public Class Calendar2
    Private WithEvents scrollTimer As New Timer With {.Interval = 10}
    Private isMouseOver As Boolean = False

    Private Sub Calendar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler btnNextDate.Paint, AddressOf btnBookNow_Paint
        AddHandler btnBackDate.Paint, AddressOf btnBookNow_Paint
        AddHandler btnConfirm.Paint, AddressOf btnBookNow_Paint


        PanelAboveSlide.InitializePanel(pnlAbovebuttons2, pnlTimer9)
        Me.WindowState = FormWindowState.Maximized



        MakeButtonRounded(btnBackDate, 48)
        MakeButtonRounded(btnConfirm, 48)
        MakeButtonRounded(btnNextDate, 48)


        positonsPanels.btnNextDateCAl(btnNextDate)
        positonsPanels.btnConfirmCAl(btnConfirm)
        positonsPanels.btnBackDateCAl(btnBackDate)
        positonsPanels.tlpCalendarCAl(tableCalendar)
        positonsPanels.lblMonthCAL(lblMonth)


        tableCalendar.BackColor = Color.FromArgb(253, 253, 248)
        lblMonth.BackColor = Color.FromArgb(253, 253, 248)
        lblMonth.ForeColor = Color.FromArgb(80, 89, 80)

    End Sub



    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If TemporaryData.BookingDate = Date.MinValue Then
            MessageBox.Show("Please select a date before confirming the booking.", "Missing Date", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        bookSummary2vb.Show()
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
                                cellLabel.BackColor = Color.FromArgb(255, 116, 108)
                                cellLabel.ForeColor = Color.White
                                cellLabel.Enabled = False
                                cellLabel.Text &= vbCrLf & "booked"
                            ElseIf status = "cancelled" Then

                                AddHandler cellLabel.Click, AddressOf Day_Click
                            End If

                        Else
                            ' Available date
                            AddHandler cellLabel.Click, AddressOf Day_Click
                        End If



                        ' Highlight today's date
                        If thisDate = Date.Today Then
                            cellLabel.Font = New Font(cellLabel.Font, FontStyle.Bold)
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
        lblMonth.Text = targetDate.ToString("MMMM")
    End Sub


    Private Function CalculateFirstDayOffset(dateToCalculate As Date) As Integer
        Return CInt(dateToCalculate.DayOfWeek) Mod 7
    End Function

    Private Sub Day_Click(sender As Object, e As EventArgs)
        Dim clickedLabel As Label = DirectCast(sender, Label)

        If String.IsNullOrWhiteSpace(clickedLabel.Text) Then
            Return
        End If

        Dim dayNumber As Integer = Integer.Parse(clickedLabel.Text)
        Dim selectedDate As New Date(_currentYear, _currentMonth, dayNumber)

        ' SAVE the clicked date into TemporaryData
        TemporaryData.BookingDate = selectedDate

        ' (Optional) You can show confirmation
        MessageBox.Show("Selected Date: " & selectedDate.ToShortDateString(), "Date Selected", MessageBoxButtons.OK, MessageBoxIcon.Information)


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

        Using conn As New MySqlConnection(connStr)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@month", month)
                cmd.Parameters.AddWithValue("@year", year)

                conn.Open()
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim dateValue As Date = CDate(reader("bookingDate"))
                        Dim status As String = reader("bookingStatus").ToString()
                        bookedStatusDates(dateValue) = status
                    End While
                End Using
            End Using
        End Using

        Return bookedStatusDates
    End Function















    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
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


End Class
