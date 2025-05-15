Imports MySql.Data.MySqlClient
Imports System.Drawing.Drawing2D

Public Class petDetails

    Dim conn As New MySqlConnection("server=localhost;user id=root;password=rdtimbangMysql1;database=adminmain")

    Private Sub petowner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPetOwners()

        txtName.BackColor = Color.FromArgb(246, 243, 238)
        btnSearch.BackColor = Color.FromArgb(141, 167, 148)
        btnCancel.BackColor = Color.FromArgb(141, 167, 148)

        MakeRoundedButton(btnSearch, 48)
        MakeRoundedButton(btnCancel, 48)
        MakeFlowLayooutRounded(pnlOwnerContainer, 10)
        txtName.BackColor = Color.FromArgb(208, 217, 213)
    End Sub

    Private Sub LoadPetOwners(Optional searchTerm As String = "")
        pnlOwnerContainer.Controls.Clear()
        Dim query As String = "
        SELECT 
            p.petName,
            o.ownerName,
            o.ownerID
        FROM petinformation p
        INNER JOIN ownerinformation o ON p.ownerID = o.ownerID
        WHERE o.ownerName LIKE @search OR p.petName LIKE @search
        ORDER BY p.petName ASC
    "

        Try
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@search", "%" & searchTerm & "%")

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        ' Create a panel for each pet-owner pair
                        Dim petOwnerPanel As New Panel With {
                            .Width = 425,
                            .Height = 60,
                            .BackColor = Color.FromArgb(246, 243, 238),
                            .Tag = reader("ownerID")
                        }

                        MakePanelRounded(petOwnerPanel, 40)

                        ' Pet name label with text "Pet name: "
                        Dim lblPetNameLabel As New Label With {
                            .Text = "Pet name: ",
                            .AutoSize = True,
                            .Font = New Font("Segoe UI", 9, FontStyle.Regular),
                            .Location = New Point(10, 8)
                        }

                        ' Pet name value (from database)
                        Dim lblPetName As New Label With {
                            .Text = reader("petName").ToString(),
                            .AutoSize = True,
                            .Font = New Font("Segoe UI", 10, FontStyle.Bold),
                            .Location = New Point(lblPetNameLabel.Right + 5, 8) ' Positioned next to the "Pet name: " label
                        }

                        ' Owner name label with text "Owner name: "
                        Dim lblOwnerNameLabel As New Label With {
                            .Text = "Owner name: ",
                            .AutoSize = True,
                            .Font = New Font("Segoe UI", 9, FontStyle.Regular),
                            .Location = New Point(10, lblPetName.Bottom + 5)
                        }

                        ' Owner name value (from database)
                        Dim lblOwnerName As New Label With {
                            .Text = reader("ownerName").ToString(),
                            .AutoSize = True,
                            .Font = New Font("Segoe UI", 9, FontStyle.Regular),
                            .Location = New Point(lblOwnerNameLabel.Right + 5, lblPetName.Bottom + 5)
                        }

                        ' Add to panel
                        petOwnerPanel.Controls.Add(lblPetNameLabel)
                        petOwnerPanel.Controls.Add(lblPetName)
                        petOwnerPanel.Controls.Add(lblOwnerNameLabel)
                        petOwnerPanel.Controls.Add(lblOwnerName)

                        ' Add click event if needed
                        AddHandler petOwnerPanel.Click, Sub(sender2, e2)
                                                            Dim ownerID As String = petOwnerPanel.Tag.ToString()
                                                            Dim detailControl As New petDetailsForm(ownerID)
                                                            detailControl.Dock = DockStyle.Fill
                                                            mainAdmin.Panel1.Controls.Clear()
                                                            mainAdmin.Panel1.Controls.Add(detailControl)
                                                        End Sub

                        pnlOwnerContainer.Controls.Add(petOwnerPanel)
                    End While
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading pet-owner info: " & ex.Message)
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
