Imports MySql.Data.MySqlClient
Imports System.Drawing.Drawing2D

Public Class customerAccount


    Private WithEvents scrollTimer As New Timer With {.Interval = 10}
    Private isMouseOver As Boolean = False
    Private petPanelCount As Integer = 0
    Private Const PANEL_HEIGHT As Integer = 150
    Private Const PANEL_SPACING As Integer = 20



    Private Sub customerACcount(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelAboveSlide.InitializePanel(pnlAbovebuttons2, pnlTimer2)
        Me.WindowState = FormWindowState.Maximized
        AddHandler btnAddPet.Paint, AddressOf btnBookNow_Paint
        positonsPanels.btnAddPetCA(btnAddPet)

        MakeButtonRounded(btnAddPet, 65)
    End Sub



    Public Class RoundedPanel
        Inherits Panel

        Private _cornerRadius As Integer = 15
        Private _petID As Integer

        Public Property CornerRadius As Integer
            Get
                Return _cornerRadius
            End Get
            Set(value As Integer)
                _cornerRadius = value
                Me.Invalidate()
            End Set
        End Property

        Public Property PetID As Integer
            Get
                Return _petID
            End Get
            Set(value As Integer)
                _petID = value
            End Set
        End Property

        Public Sub New()
            Me.DoubleBuffered = True
            Me.BackColor = Color.White

            ' Remove the Margin property as we're now using Location for spacing
            ' Me.Margin = New Padding(0, 0, 0, PANEL_SPACING)
        End Sub
    End Class

    Private Sub ucSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Apply modern styling to the form
        ApplyModernStyling()
        ' Load client summary data
        LoadSummary(TemporaryData.LoggedInOwnerID)
    End Sub

    Private Sub ApplyModernStyling()
        ' Style the main form elements
        Me.BackColor = Color.FromArgb(245, 245, 247)

        ' Style the client name label
        lblClientName.Font = New Font("Segoe UI", 14, FontStyle.Bold)
        lblClientName.ForeColor = Color.FromArgb(50, 50, 50)

        ' Style the pets container panel
        pnlPetList.BackColor = Color.FromArgb(220, 205, 187)
        MakePanelRounded(pnlPetList, 48)
        pnlPetList.AutoScroll = True
        pnlPetList.Padding = New Padding(10)
    End Sub

    Public Sub LoadSummary(ownerId As Integer)
        Try
            If ownerId <= 0 Then
                MessageBox.Show("Invalid owner ID provided.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim connStr As String = "server=localhost;user id=root;password=rdtimbangMysql1;database=adminmain"
            Using conn As New MySqlConnection(connStr)
                conn.Open()

                ' First query to get owner details
                Dim ownerQuery As String = "SELECT ownerName FROM ownerinformation WHERE ownerID = @ownerID"
                Using cmdOwner As New MySqlCommand(ownerQuery, conn)
                    cmdOwner.Parameters.Add("@ownerID", MySqlDbType.Int32).Value = ownerId
                    Dim ownerName As Object = cmdOwner.ExecuteScalar()

                    If ownerName IsNot Nothing Then
                        lblClientName.Text = ((ownerName.ToString()))
                    Else
                        lblClientName.Text = "Owner Not Found"
                        Return
                    End If
                End Using

                ' Now get pet information
                Dim petQuery As String = "
                SELECT petID, petName, petSex, petAge, petBirthday, petWeight, petBreed, petVacStatus
                FROM petinformation
                WHERE ownerID = @ownerID
                ORDER BY petName"

                Using cmdPet As New MySqlCommand(petQuery, conn)
                    cmdPet.Parameters.Add("@ownerID", MySqlDbType.Int32).Value = ownerId
                    Using reader As MySqlDataReader = cmdPet.ExecuteReader()
                        ' Clear previous content
                        pnlPetList.Controls.Clear()
                        petPanelCount = 0

                        If reader.HasRows Then
                            While reader.Read()
                                AddPetPanel(
                                    reader("petID").ToString(),
                                    reader("petName").ToString(),
                                    reader("petBreed").ToString(),
                                    reader("petSex").ToString()
                                )
                            End While

                            If petPanelCount > 0 Then
                                ' Set the AutoScrollMinSize to accommodate all panels plus their spacing
                                pnlPetList.AutoScrollMinSize = New Size(0, petPanelCount * (PANEL_HEIGHT + PANEL_SPACING))
                            End If

                        End If
                    End Using
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("An unexpected error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AddPetPanel(petID As String, petName As String, petBreed As String, petSex As String)
        ' Create a custom rounded panel for the pet
        Dim petPanel As New RoundedPanel()
        petPanel.Size = New Size(pnlPetList.Width - 40, PANEL_HEIGHT)
        petPanel.Dock = DockStyle.None
        Dim topOffset As Integer = 20 ' adjust as needed
        petPanel.Location = New Point(23, topOffset + petPanelCount * (PANEL_HEIGHT + PANEL_SPACING))
        petPanel.Cursor = Cursors.Hand
        petPanel.PetID = Integer.Parse(petID)
        petPanel.Tag = petID
        petPanel.Padding = New Padding(15, 10, 15, 10)
        ApplyRoundedCorners(petPanel, 60)



        ' Pet name label
        Dim lblPetName As New Label()
        lblPetName.Text = petName
        lblPetName.Font = New Font("Segoe UI", 30, FontStyle.Bold)
        lblPetName.ForeColor = Color.FromArgb(50, 50, 50)
        lblPetName.Location = New Point(170, 20)
        lblPetName.AutoSize = True

        ' Pet details label
        Dim lblPetDetails As New Label()
        lblPetDetails.Text = $"{petBreed} • {petSex}"
        lblPetDetails.Font = New Font("Segoe UI", 12, FontStyle.Regular)
        lblPetDetails.ForeColor = Color.FromArgb(100, 100, 100)
        lblPetDetails.Location = New Point(175, 72)
        lblPetDetails.AutoSize = True

        ' Get pet info from database
        Dim lastVisit As String = GetLastVisitDate(Integer.Parse(petID))
        Dim bookingStatus As String = GetBookingStatus(Integer.Parse(petID))

        ' Last visit and booking status label
        Dim lblStatusInfo As New Label()
        lblStatusInfo.Text = $"Visit: {lastVisit} | Booking: {bookingStatus}"
        lblStatusInfo.Font = New Font("Segoe UI", 9, FontStyle.Regular)
        lblStatusInfo.ForeColor = Color.FromArgb(120, 120, 120)
        lblStatusInfo.Location = New Point(175, 99)
        lblStatusInfo.AutoSize = True


        ' Picture box for pet type image
        Dim picPetType As New PictureBox()
        picPetType.Size = New Size(145, 145)
        picPetType.Location = New Point(13, 4)
        picPetType.SizeMode = PictureBoxSizeMode.Zoom

        ' Get pet type from the database
        Dim petType As String = GetPetType(Integer.Parse(petID)) ' Make sure petID is valid




        ' Update image based on pet type
        Select Case petType.ToLower()
            Case "feline"
                picPetType.Image = My.Resources.Feline
            Case "canine"
                picPetType.Image = My.Resources.Canine
            Case "reptile"
                picPetType.Image = My.Resources.Reptile
        End Select


        ' Add picture to panel
        petPanel.Controls.Add(picPetType)


        ' First button (top-right)
        Dim btnDetails As New Button()
        btnDetails.Text = "VIEW DETAILS"
        btnDetails.Size = New Size(180, 65)
        btnDetails.Tag = petID
        btnDetails.Location = New Point(1010, 7)
        btnDetails.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnDetails.FlatStyle = FlatStyle.Flat
        btnDetails.FlatAppearance.BorderSize = 0
        btnDetails.BackColor = Color.FromArgb(230, 194, 191)
        btnDetails.ForeColor = Color.FromArgb(99, 88, 55)
        btnDetails.Font = New Font("Glacial Indifference", 15, FontStyle.Bold)
        MakeButtonRounded(btnDetails, 55)


        ' Second button (below the btnDetails)
        Dim btnAppointment As New Button()
        btnAppointment.Text = "VIEW APPOINTMENT"
        btnAppointment.Size = New Size(180, 65)
        btnAppointment.Location = New Point(1010, 77)
        btnAppointment.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        MakeButtonRounded(btnAppointment, 55)
        btnAppointment.FlatStyle = FlatStyle.Flat
        btnAppointment.FlatAppearance.BorderSize = 0
        btnAppointment.BackColor = Color.FromArgb(126, 156, 94)
        btnAppointment.ForeColor = Color.FromArgb(32, 62, 18)
        btnAppointment.Font = New Font("Glacial Indifference", 15, FontStyle.Bold)

        ' Add buttons to the panel
        petPanel.Controls.Add(btnDetails)
        petPanel.Controls.Add(btnAppointment)



        ' Important: Add click event handlers directly in-line instead of using AddressOf
        AddHandler pnlPetList.Click, Sub(sender As Object, e As EventArgs)
                                         Dim clickedButton As Button = TryCast(sender, Button)
                                         If clickedButton IsNot Nothing Then
                                             Dim clickedPetID As Integer = Integer.Parse(clickedButton.Tag.ToString())

                                             ' Show loading cursor
                                             Cursor = Cursors.WaitCursor

                                             Try
                                                 ' Show pet information form
                                                 Dim frmPetInfo As New petInformation()
                                                 frmPetInfo.PetID = clickedPetID
                                                 frmPetInfo.ShowDialog()
                                             Catch ex As Exception
                                                 MessageBox.Show("Error opening pet information: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                             Finally
                                                 ' Restore cursor
                                                 Cursor = Cursors.Default
                                             End Try
                                         End If
                                     End Sub

        ' Add the labels and button to the panel
        petPanel.Controls.Add(lblPetName)
        petPanel.Controls.Add(lblPetDetails)
        petPanel.Controls.Add(lblStatusInfo)


        ' Important: Add panel click handler directly in-line instead of using AddressOf
        AddHandler btnDetails.Click, Sub(sender As Object, e As EventArgs)
                                         Dim clickedButton As Button = TryCast(sender, Button)
                                         If clickedButton IsNot Nothing Then
                                             Dim clickedPetID As Integer = Integer.Parse(clickedButton.Tag.ToString())

                                             Cursor = Cursors.WaitCursor
                                             Try
                                                 Dim frmPetInfo As New petInformation()
                                                 frmPetInfo.PetID = clickedPetID
                                                 frmPetInfo.ShowDialog()
                                             Catch ex As Exception
                                                 MessageBox.Show("Error opening pet information: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                             Finally
                                                 Cursor = Cursors.Default
                                             End Try
                                         End If
                                     End Sub


        ' Add the panel to the container
        pnlPetList.Controls.Add(petPanel)
        petPanelCount += 1
    End Sub


    Private Function GetPetType(petID As Integer) As String
        Try
            Dim connStr As String = "server=localhost;user id=root;password=rdtimbangMysql1;database=adminmain"
            Using conn As New MySqlConnection(connStr)
                conn.Open()
                Dim query As String = "SELECT petType FROM petinformation WHERE petID = @petID"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@petID", petID)
                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing Then Return result.ToString()
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine("Error getting pet type: " & ex.Message)
        End Try
        Return ""
    End Function


    ' Function to get the last visit date for a pet
    Private Function GetLastVisitDate(petID As Integer) As String
        Try
            Dim lastVisitDate As String = "None"

            Dim connStr As String = "server=localhost;user id=root;password=rdtimbangMysql1;database=adminmain"
            Using conn As New MySqlConnection(connStr)
                conn.Open()

                ' Query to get the most recent visit date
                Dim query As String = "
                SELECT bookingDate
                FROM bookingtable 
                WHERE petID = @petID"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.Add("@petID", MySqlDbType.Int32).Value = petID
                    Dim result As Object = cmd.ExecuteScalar()

                    If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                        ' Format the date as desired
                        Dim visitDate As DateTime = Convert.ToDateTime(result)
                        lastVisitDate = visitDate.ToString("MMM d, yyyy")
                    End If
                End Using
            End Using

            Return lastVisitDate
        Catch ex As Exception
            ' Log the error but don't disrupt the UI
            Console.WriteLine("Error getting last visit date: " & ex.Message)
            Return "N/A"
        End Try
    End Function

    ' Function to get the booking status for a pet
    Private Function GetBookingStatus(petID As Integer) As String
        Try
            Dim bookingStatus As String = "None"

            Dim connStr As String = "server=localhost;user id=root;password=rdtimbangMysql1;database=adminmain"
            Using conn As New MySqlConnection(connStr)
                conn.Open()

                ' Query to get the latest booking status
                Dim query As String = "
                SELECT bookingStatus 
                FROM bookingtable
                WHERE petID = @petID 
                "

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.Add("@petID", MySqlDbType.Int32).Value = petID
                    Dim result As Object = cmd.ExecuteScalar()

                    If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                        bookingStatus = result.ToString()

                        ' You can customize how the status is displayed based on your booking statuses
                        ' For example, if you store status codes, you can map them to friendly names
                        Select Case bookingStatus.ToLower()
                            Case "Confirmed"
                                bookingStatus = "Confirmed"
                            Case "Pending"
                                bookingStatus = "Pending"
                            Case "Completed"
                                bookingStatus = "Completed"
                            Case "Cancelled"
                                bookingStatus = "Cancelled"
                                ' Add more cases as needed
                        End Select
                    End If
                End Using
            End Using

            Return bookingStatus
        Catch ex As Exception
            ' Log the error but don't disrupt the UI
            Console.WriteLine("Error getting booking status: " & ex.Message)
            Return "N/A"
        End Try
    End Function





    Private Sub btnBookNow_Paint(sender As Object, e As PaintEventArgs)
        If isMouseOver Then
            GradientHelper.DrawGradientButton(sender, e, Color.FromArgb(0, 151, 178), Color.FromArgb(126, 217, 87), Drawing2D.LinearGradientMode.Horizontal)
        Else
            GradientHelper.DrawGradientButton(sender, e, Color.FromArgb(126, 217, 87), Color.FromArgb(0, 151, 178), Drawing2D.LinearGradientMode.Horizontal)
        End If
    End Sub

    Private Sub btnBookNow_MouseEnter(sender As Object, e As EventArgs) Handles btnAddPet.MouseEnter
        isMouseOver = True
        btnAddPet.Invalidate() ' Force the button to repaint
    End Sub

    Private Sub btnBookNow_MouseLeave(sender As Object, e As EventArgs) Handles btnAddPet.MouseLeave
        isMouseOver = False
        btnAddPet.Invalidate() ' Force the button to repaint
    End Sub





    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        Form1.Close()
    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub pnlAboveTimer_Tick(sender As Object, e As EventArgs) Handles pnlTimer2.Tick
        PanelAboveSlide.SlidePanel(pnlAbovebuttons2, pnlTimer2)
    End Sub



    'pnl Button Mouse enter
    Private Sub pctHomePage_MouseEnter(sender As Object, e As EventArgs) Handles pctMain.MouseEnter
        PanelAboveSlide.MouseEnter(pnlAbovebuttons2, pnlTimer2)
    End Sub


    'pnl Button Mouse Move
    Private Sub MouseMovePanel(sender As Object, e As MouseEventArgs) Handles pctMain.MouseMove
        PanelAboveSlide.MouseMove(pnlAbovebuttons2, e, pnlTimer2)
    End Sub


End Class