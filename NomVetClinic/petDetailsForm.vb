Imports MySql.Data.MySqlClient
Imports System.Drawing.Drawing2D


Public Class petDetailsForm
    Private _petID As String
    Private conn As New MySqlConnection("server=localhost;user id=root;password=rdtimbangMysql1;database=adminmain")

    ' Constructor
    Public Sub New(petID As String)
        InitializeComponent()
        _petID = petID
    End Sub

    ' Load event
    Private Sub petDetailsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPetDetails()
        ApplyRoundedCorners()
        MakeButtonRounded(btnSaveChanges, 48)

        ' Set colors
        Dim bgColor As Color = Color.FromArgb(246, 243, 238)
        txtName.BackColor = bgColor
        txtAge.BackColor = bgColor
        txtSex.BackColor = bgColor
        txtWeight.BackColor = bgColor
        txtType.BackColor = bgColor
        txtVacStatus.BackColor = bgColor

    End Sub

    ' Load pet info from database
    Private Sub LoadPetDetails()
        Dim query As String = "
            SELECT 
                p.petName,
                p.petAge,
                p.petSex,
                p.petWeight,
                p.petType,
                p.petVacStatus,
                MAX(b.bookingDate) AS lastVisit,
                MAX(b.dateOfReturn) AS nextVisit
            FROM petinformation p
            LEFT JOIN bookingtable b ON p.petID = b.petID
            WHERE p.petID = @petID
            GROUP BY p.petID, p.petName, p.petAge, p.petSex, p.petWeight, p.petType, p.petVacStatus
        "

        Try
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@petID", _petID)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        txtName.Text = reader("petName").ToString()
                        txtAge.Text = reader("petAge").ToString()
                        txtSex.Text = reader("petSex").ToString()
                        txtWeight.Text = reader("petWeight").ToString()
                        txtType.Text = reader("petType").ToString()
                        txtVacStatus.Text = reader("petVacStatus").ToString()

                        ' Booking Dates
                        Dim lastVisitValue = reader("lastVisit")
                        Dim nextVisitValue = reader("nextVisit")


                    Else
                        MessageBox.Show("No pet found with the given ID.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading pet details: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Rounded corners
    Private Sub ApplyRoundedCorners()
        Dim radius As Integer = 15
        MakeRoundedControl(txtName, radius)
        MakeRoundedControl(txtAge, radius)
        MakeRoundedControl(txtSex, radius)
        MakeRoundedControl(txtWeight, radius)
        MakeRoundedControl(txtType, radius)
        MakeRoundedControl(txtVacStatus, radius)

    End Sub

    Private Sub MakeRoundedControl(ctrl As Control, radius As Integer)
        Dim path As New GraphicsPath()
        path.AddArc(0, 0, radius, radius, 180, 90)
        path.AddArc(ctrl.Width - radius, 0, radius, radius, 270, 90)
        path.AddArc(ctrl.Width - radius, ctrl.Height - radius, radius, radius, 0, 90)
        path.AddArc(0, ctrl.Height - radius, radius, radius, 90, 90)
        path.CloseAllFigures()
        ctrl.Region = New Region(path)
    End Sub

    Private Sub btnSaveChanges_Click(sender As Object, e As EventArgs) Handles btnSaveChanges.Click
        Dim updatePetQuery As String = "
        UPDATE petinformation 
        SET petName = @name,
            petAge = @age,
            petSex = @sex,
            petWeight = @weight,
            petType = @type,
            petVacStatus = @vacStatus
        WHERE petID = @petID
    "

        Dim getBookingIDQuery As String = "
        SELECT bookingID 
        FROM bookingtable 
        WHERE petID = @petID 
        ORDER BY bookingID DESC 
        LIMIT 1
    "

        ' 🟢 Now also sets bookingStatus = 'Confirmed'
        Dim updateBookingQuery As String = "
        UPDATE bookingtable 
        SET bookingDate = @newDate,
            bookingStatus = 'Confirmed'
        WHERE bookingID = @bookingID
    "

        Try
            conn.Open()

            ' ✅ Step 1: Update petinformation
            Using cmd As New MySqlCommand(updatePetQuery, conn)
                cmd.Parameters.AddWithValue("@name", txtName.Text)
                cmd.Parameters.AddWithValue("@age", txtAge.Text)
                cmd.Parameters.AddWithValue("@sex", txtSex.Text)
                cmd.Parameters.AddWithValue("@weight", txtWeight.Text)
                cmd.Parameters.AddWithValue("@type", txtType.Text)
                cmd.Parameters.AddWithValue("@vacStatus", txtVacStatus.Text)
                cmd.Parameters.AddWithValue("@petID", _petID)
                cmd.ExecuteNonQuery()
            End Using

            ' ✅ Step 2: Get latest bookingID
            Dim latestBookingID As Integer = -1
            Using cmdGetBookingID As New MySqlCommand(getBookingIDQuery, conn)
                cmdGetBookingID.Parameters.AddWithValue("@petID", _petID)
                Dim result = cmdGetBookingID.ExecuteScalar()
                If result IsNot Nothing Then
                    latestBookingID = Convert.ToInt32(result)
                End If
            End Using

            ' ✅ Step 3: Update bookingDate + bookingStatus if booking found
            If latestBookingID <> -1 Then
                Using cmdUpdateBooking As New MySqlCommand(updateBookingQuery, conn)
                    cmdUpdateBooking.Parameters.AddWithValue("@newDate", dtpDateUpdate.Value)
                    cmdUpdateBooking.Parameters.AddWithValue("@bookingID", latestBookingID)
                    cmdUpdateBooking.ExecuteNonQuery()
                End Using
            End If

            MessageBox.Show("Pet details and booking status updated successfully!")

        Catch ex As Exception
            MessageBox.Show("Error while updating: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub


End Class

