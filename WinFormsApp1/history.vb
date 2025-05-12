Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Relational

Public Class history

    Dim conn As New MySqlConnection("server=localhost;userid=root;password=Michymichy_27;database=admin_main2")

    Private Sub history_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadHistory()


        ' Auto-size columns to fill the width of the DataGridView
        dvgBookingHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        ' Set a fixed row height for better appearance
        dvgBookingHistory.RowTemplate.Height = 40

        ' Optional: prevent users from resizing
        dvgBookingHistory.AllowUserToResizeColumns = False
        dvgBookingHistory.AllowUserToResizeRows = False

        ' Optional: improve font and alignment
        dvgBookingHistory.DefaultCellStyle.Font = New Font("Segoe UI", 10)
        dvgBookingHistory.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        dvgBookingHistory.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        dvgBookingHistory.Columns("petName").HeaderText = "Pet Name"
        dvgBookingHistory.Columns("ownerName").HeaderText = "Owner Name"
        dvgBookingHistory.Columns("serviceName").HeaderText = "Service Availed"
        dvgBookingHistory.Columns("bookingDate").HeaderText = "Booking Date"

    End Sub

    Private Sub LoadHistory(Optional searchTerm As String = "")
        Dim query As String = "
            SELECT 
                p.petName,
                o.ownerName,
                s.serviceName,
                b.bookingDate
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
