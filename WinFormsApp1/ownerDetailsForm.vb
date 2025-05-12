Imports MySql.Data.MySqlClient
Imports System.Drawing.Drawing2D

Public Class ownerDetailsForm
    Private _ownerID As String
    Private conn As New MySqlConnection("server=localhost;userid=root;password=Michymichy_27;database=admin_main2")

    ' Constructor
    Public Sub New(ownerID As String)
        InitializeComponent()
        _ownerID = ownerID
    End Sub

    ' Load event
    Private Sub ownerDetailsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadOwnerDetails()
        ApplyRoundedCorners()
        txtName.BackColor = Color.FromArgb(246, 243, 238)
        txtAge.BackColor = Color.FromArgb(246, 243, 238)
        txtAddress.BackColor = Color.FromArgb(246, 243, 238)
        txtSex.BackColor = Color.FromArgb(246, 243, 238)
        txtEmail.BackColor = Color.FromArgb(246, 243, 238)
        txtContact.BackColor = Color.FromArgb(246, 243, 238)
        Panel1.BackColor = Color.FromArgb(246, 243, 238)
        Panel1.BackColor = Color.FromArgb(246, 243, 238)

    End Sub

    ' Load owner info from DB
    Private Sub LoadOwnerDetails()
        Dim query As String = "
            SELECT 
                o.ownerName, 
                o.EmailAddress, 
                o.contactNumber, 
                o.Address, 
                o.ownerAge,
                o.ownerSex,
                COUNT(b.bookingID) AS bookingCount
            FROM ownerinformation o
            LEFT JOIN petinformation p ON o.ownerID = p.OwnerID
            LEFT JOIN bookingtable b ON p.petID = b.petID
            WHERE o.ownerID = @ownerID
            GROUP BY o.ownerID, o.ownerName, o.EmailAddress, o.contactNumber, o.Address, o.ownerAge, o.ownerSex
        "

        Try
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ownerID", _ownerID)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        txtName.Text = reader("ownerName").ToString()
                        txtEmail.Text = reader("EmailAddress").ToString()
                        txtContact.Text = reader("contactNumber").ToString()
                        txtAddress.Text = reader("Address").ToString()
                        txtAge.Text = reader("ownerAge").ToString()
                        txtSex.Text = reader("ownerSex").ToString()
                        lblTotalBookings.Text = "Total Bookings: " & reader("bookingCount").ToString()
                    Else
                        MessageBox.Show("No owner found with the given ID.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading owner details: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Save changes to DB
    Private Sub btnSaveChanges_Click(sender As Object, e As EventArgs) Handles btnSaveChanges.Click
        Dim updateQuery As String = "
            UPDATE ownerinformation
            SET 
                ownerName = @name,
                EmailAddress = @email,
                contactNumber = @contact,
                Address = @address,
                ownerAge = @age,
                ownerSex = @sex
            WHERE ownerID = @ownerID
        "

        Try
            conn.Open()
            Using cmd As New MySqlCommand(updateQuery, conn)
                cmd.Parameters.AddWithValue("@name", txtName.Text.Trim())
                cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim())
                cmd.Parameters.AddWithValue("@contact", txtContact.Text.Trim())
                cmd.Parameters.AddWithValue("@address", txtAddress.Text.Trim())
                cmd.Parameters.AddWithValue("@age", txtAge.Text.Trim())
                cmd.Parameters.AddWithValue("@sex", txtSex.Text.Trim())
                cmd.Parameters.AddWithValue("@ownerID", _ownerID)

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("Owner details updated successfully.")
                Else
                    MessageBox.Show("No changes were made.")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating owner details: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Apply rounded corners to textboxes and panels
    Private Sub ApplyRoundedCorners()
        Dim radius As Integer = 15
        MakeRoundedControl(txtName, radius)
        MakeRoundedControl(txtEmail, radius)
        MakeRoundedControl(txtContact, radius)
        MakeRoundedControl(txtAddress, radius)
        MakeRoundedControl(txtAge, radius)
        MakeRoundedControl(txtSex, radius)

        ' Example: if you have Panel1, Panel2 etc. you can round them like:
        ' MakeRoundedControl(Panel1, radius)
        ' MakeRoundedControl(Panel2, radius)
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

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        ' Optional logic
    End Sub
End Class
