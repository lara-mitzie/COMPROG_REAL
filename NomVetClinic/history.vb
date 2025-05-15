Imports MySql.Data.MySqlClient


Public Class history

    Dim conn As New MySqlConnection("server=localhost;user id=root;password=rdtimbangMysql1;database=adminmain")

    Private Sub history_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadHistory()
        MakeButtonRounded(btnSearch, 20)
        btnSearch.BackColor = Color.FromArgb(233, 221, 207)

        dvgBookingHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dvgBookingHistory.RowTemplate.Height = 40
        dvgBookingHistory.AllowUserToResizeColumns = False
        dvgBookingHistory.AllowUserToResizeRows = False
        dvgBookingHistory.DefaultCellStyle.Font = New Font("Segoe UI", 10)
        dvgBookingHistory.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        dvgBookingHistory.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        dvgBookingHistory.Columns("petName").HeaderText = "Pet Name"
        dvgBookingHistory.Columns("ownerName").HeaderText = "Owner Name"
        dvgBookingHistory.Columns("serviceName").HeaderText = "Service Availed"
        dvgBookingHistory.Columns("bookingDate").HeaderText = "Booking Date"
        dvgBookingHistory.Columns("bookingStatus").HeaderText = "Booking Status" ' 👈 Add this
    End Sub


    Private Sub LoadHistory(Optional searchTerm As String = "")
        Dim query As String = "
            SELECT  
                p.petName,
                o.ownerName,
                s.serviceName,
                b.bookingDate,
                b.bookingStatus

            FROM bookingtable b
            LEFT JOIN petinformation p ON b.petID = p.petID
            LEFT JOIN ownerinformation o ON p.OwnerID = o.ownerID
            LEFT JOIN services s ON b.serviceID = s.servicesID
            WHERE p.petName LIKE @search OR o.ownerName LIKE @search
            ORDER BY b.bookingDate DESC
        "

        Try
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@search", "%" & searchTerm & "%")
                Dim adapter As New MySqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)
                dvgBookingHistory.DataSource = table
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading history: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        LoadHistory(txtSearch.Text.Trim())
    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            LoadHistory(txtSearch.Text.Trim())
        End If
    End Sub


End Class
