Imports MySql.Data.MySqlClient

Public Class Biiling

    ' Database connection
    Private conn As New MySqlConnection("server=localhost;user id=root;password=rdtimbangMysql1;database=adminmain")

    Private Sub userControl1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBillingData()
        MakeButtonRounded(btnSarch, 30)
        MakeButtonRounded(btnUpdate, 30)
        btnSarch.BackColor = Color.FromArgb(141, 167, 148)
        btnUpdate.BackColor = Color.FromArgb(141, 167, 148)

        For Each txt As TextBox In {txtName, txtTotalCOst, txtPet, txtPaymentStatus}
            txt.BackColor = Color.FromArgb(220, 226, 225)
        Next
    End Sub

    Private Sub LoadBillingData()
        Try
            conn.Open()

            Dim query As String = "
SELECT 
    b.bookingID,
    o.ownerName AS OwnerName,
    p.petName AS PetName,
    s.servicePrice AS TotalCost,
    pay.downpayment AS Downpayment,
    (s.servicePrice - pay.downpayment) AS RemainingBalance,
    pay.paymentStatus AS PaymentStatus
FROM bookingtable b
JOIN petinformation p ON b.petID = p.petID
JOIN ownerinformation o ON p.ownerID = o.ownerID
JOIN services s ON b.serviceID = s.servicesId
JOIN payment pay ON b.bookingID = pay.bookingID;"

            Dim adapter As New MySqlDataAdapter(query, conn)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            dgvViewBilling.DataSource = dt

            ' Hide internal ID
            If dgvViewBilling.Columns.Contains("bookingID") Then
                dgvViewBilling.Columns("bookingID").Visible = False
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnsSarch_Click(sender As Object, e As EventArgs) Handles btnSarch.Click
        Dim nameFilter As String = txtName.Text.Trim()
        Dim petFilter As String = txtPet.Text.Trim()

        Try
            conn.Open()

            Dim query As String = "
SELECT 
    b.bookingID,
    o.ownerName AS OwnerName,
    p.petName AS PetName,
    s.servicePrice AS TotalCost,
    pay.downpayment AS Downpayment,
    (s.servicePrice - pay.downpayment) AS RemainingBalance,
    pay.paymentStatus AS PaymentStatus
FROM bookingtable b
JOIN petinformation p ON b.petID = p.petID
JOIN ownerinformation o ON p.ownerID = o.ownerID
JOIN services s ON b.serviceID = s.servicesId
JOIN payment pay ON b.bookingID = pay.bookingID
WHERE o.ownerName LIKE @ownerName AND p.petName LIKE @petName;"

            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@ownerName", "%" & nameFilter & "%")
            cmd.Parameters.AddWithValue("@petName", "%" & petFilter & "%")

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            dgvViewBilling.DataSource = dt

            If dgvViewBilling.Columns.Contains("bookingID") Then
                dgvViewBilling.Columns("bookingID").Visible = False
            End If

            If dt.Rows.Count = 0 Then
                MessageBox.Show("No matching records found.")
            Else
                txtTotalCOst.Text = dt.Rows(0)("RemainingBalance").ToString()
                txtPaymentStatus.Text = dt.Rows(0)("PaymentStatus").ToString()
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        txtPaymentStatus.Text = ""

        If String.IsNullOrWhiteSpace(txtTotalCOst.Text) OrElse Not IsNumeric(txtTotalCOst.Text) Then
            MessageBox.Show("Please enter a valid total cost.")
            Exit Sub
        End If

        If dgvViewBilling.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a row in the table.")
            Exit Sub
        End If

        Dim selectedBookingId As Integer
        Try
            selectedBookingId = Convert.ToInt32(dgvViewBilling.CurrentRow.Cells("bookingID").Value)
        Catch ex As Exception
            MessageBox.Show("Could not get booking ID from the selected row.")
            Exit Sub
        End Try

        If txtPaymentStatus.Text.ToLower() = "paid" Then
            MessageBox.Show("This payment is already marked as paid.")
            Exit Sub
        End If

        Try
            Using conn As New MySqlConnection("server=localhost;user id=root;password=rdtimbangMysql1;database=adminmain")
                conn.Open()

                Dim query As String = "UPDATE payment SET paymentStatus = 'paid' WHERE bookingID = @bookingId"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@bookingId", selectedBookingId)

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Payment status updated successfully.")
                    LoadBillingData()
                    txtPaymentStatus.Text = "paid"
                Else
                    MessageBox.Show("No matching payment record found.")
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub dgvViewBilling_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvViewBilling.CellFormatting
        If e.Value IsNot Nothing AndAlso e.Value IsNot DBNull.Value Then
            If dgvViewBilling.Columns(e.ColumnIndex).Name = "PaymentStatus" Then
                Dim paymentStatus = e.Value.ToString
                If paymentStatus = "paid" Then
                    dgvViewBilling.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightGreen
                ElseIf paymentStatus = "denied" Then
                    dgvViewBilling.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightGray
                End If
            End If
        End If
    End Sub

End Class
