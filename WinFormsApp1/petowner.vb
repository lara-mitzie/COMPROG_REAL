Imports MySql.Data.MySqlClient
Imports System.Drawing.Drawing2D

Public Class petowner

    Dim conn As New MySqlConnection("server=localhost;userid=root;password=Michymichy_27;database=admin_main2")

    Private Sub petowner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPetOwners()

        txtName.BackColor = Color.FromArgb(246, 243, 238)
        btnSearch.BackColor = Color.FromArgb(141, 167, 148)
        btnCancel.BackColor = Color.FromArgb(141, 167, 148)

        MakeRoundedButton(btnSearch, 15)
        MakeRoundedButton(btnCancel, 15)
    End Sub

    Private Sub LoadPetOwners(Optional searchTerm As String = "")
        pnlOwnerContainer.Controls.Clear()
        Dim query As String = "
        SELECT 
            o.ownerID, 
            o.ownerName, 
            o.EmailAddress, 
            COUNT(b.bookingID) AS bookingCount
        FROM ownerinformation o
        LEFT JOIN petinformation p ON o.ownerID = p.ownerID
        LEFT JOIN bookingtable b ON p.petID = b.petID
        WHERE o.ownerName LIKE @search OR o.EmailAddress LIKE @search
        GROUP BY o.ownerID, o.ownerName, o.EmailAddress
        ORDER BY bookingCount DESC
    "

        Try
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@search", "%" & searchTerm & "%")

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        ' Create dynamic panel for each owner
                        Dim ownerPanel As New Panel With {
                            .Width = 500,
                            .Height = 60,
                            .BackColor = Color.FromArgb(246, 243, 238),
                            .Margin = New Padding(5),
                            .Tag = reader("ownerID") ' Store ownerID in the Tag property
                        }

                        Dim lblName As New Label With {
                            .Text = reader("ownerName").ToString(),
                            .AutoSize = True,
                            .Font = New Font("Segoe UI", 10, FontStyle.Bold),
                            .Location = New Point(10, 10)
                        }

                        Dim lblPetCount As New Label With {
                            .Text = "Total Bookings: " & reader("bookingCount").ToString(),
                            .AutoSize = True,
                            .Location = New Point(10, 30)
                        }

                        AddHandler ownerPanel.Click, Sub(sender, e)
                                                         Dim ownerID As String = ownerPanel.Tag.ToString()
                                                         Dim detailForm As New ownerDetailsForm(ownerID)
                                                         detailForm.ShowDialog()
                                                     End Sub

                        ownerPanel.Controls.Add(lblName)
                        ownerPanel.Controls.Add(lblPetCount)
                        pnlOwnerContainer.Controls.Add(ownerPanel)
                    End While
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading pet owners: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        LoadPetOwners(txtName.Text.Trim())
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtName.Clear()
        LoadPetOwners()
    End Sub

    ' Helper method to round buttons
    Private Sub MakeRoundedButton(btn As Button, radius As Integer)
        Dim path As New GraphicsPath()
        path.AddArc(0, 0, radius, radius, 180, 90)
        path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90)
        path.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90)
        path.AddArc(0, btn.Height - radius, radius, radius, 90, 90)
        path.CloseAllFigures()
        btn.Region = New Region(path)
    End Sub

End Class
