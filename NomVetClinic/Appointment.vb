Imports MySql.Data.MySqlClient

Public Class Appointment

    Dim con As New MySqlConnection("server=localhost;user id=root;password=rdtimbangMysql1;database=adminmain")
    Dim currentFilter As String = "all"

    Private Sub Appointments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBookings(currentFilter)
        MakePanelRounded(ParentPanel, 48)
        MakeButtonRounded(btnAll, 20)
        MakeButtonRounded(btnThisWeek, 20)

        btnAll.BackColor = Color.FromArgb(251, 250, 255)
        btnThisWeek.BackColor = Color.FromArgb(251, 250, 255)
        txtSearch.BackColor = Color.FromArgb(251, 250, 255)

        MakeButtonRounded(btnSearch, 20)
        btnSearch.BackColor = Color.FromArgb(251, 250, 255)
        btnAll.BackColor = Color.FromArgb(251, 250, 255)
        btnThisWeek.BackColor = Color.FromArgb(251, 250, 255)
        txtSearch.BackColor = Color.FromArgb(251, 250, 255)
    End Sub

    Private Sub LoadBookings(filter As String, Optional search As String = "")
        ParentPanel.Controls.Clear()
        currentFilter = filter

        Dim query As String = "
            SELECT b.bookingId, o.ownerName, p.petName, b.bookingDate, b.bookingStatus
            FROM bookingtable b
            LEFT JOIN petinformation p ON b.petID = p.petID
            LEFT JOIN ownerinformation o ON p.ownerID = o.ownerID
            WHERE b.bookingStatus NOT IN ('Done', 'Cancelled')
        "

        If filter = "thisweek" Then
            query &= "
                AND b.bookingDate >= CURDATE() 
                AND b.bookingDate < CURDATE() + INTERVAL 7 DAY
            "
        ElseIf filter = "all" Then
            query &= "
                AND b.bookingDate >= CURDATE()
            "
        End If

        If Not String.IsNullOrEmpty(search) Then
            query &= " AND (o.ownerName LIKE @search OR p.petName LIKE @search) "
        End If

        query &= " ORDER BY b.bookingDate ASC"

        Try
            Using cmd As New MySqlCommand(query, con)
                If Not String.IsNullOrEmpty(search) Then
                    cmd.Parameters.AddWithValue("@search", "%" & search & "%")
                End If

                con.Open()
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                Dim found As Boolean = False
                Dim topPosition As Integer = 10
                Dim leftPosition As Integer = 13

                While reader.Read()
                    found = True

                    Dim bookingPanel As New Panel With {
                        .Width = ParentPanel.Width - 40,
                        .Height = 70,
                        .BackColor = Color.FromArgb(156, 178, 132),
                        .Margin = New Padding(10),
                        .Top = topPosition,
                        .Left = leftPosition,
                        .Tag = reader("bookingId")
                    }

                    Dim lblOwner As New Label With {
                        .Text = "Owner: " & reader("ownerName").ToString(),
                        .AutoSize = True,
                        .Location = New Point(10, 10),
                        .Font = New Font("Glacial Indifference", 15, FontStyle.Regular)
                    }

                    Dim lblPet As New Label With {
                        .Text = "Pet: " & reader("petName").ToString(),
                        .AutoSize = True,
                        .Location = New Point(10, 38),
                        .Font = New Font("Glacial Indifference", 11, FontStyle.Regular)
                    }

                    Dim bookingDate As Date = Convert.ToDateTime(reader("bookingDate"))
                    Dim lblDate As New Label With {
                        .Text = "Date: " & bookingDate.ToString("yyyy-MM-dd"),
                        .AutoSize = True,
                        .Location = New Point(200, 10),
                        .Font = New Font("Glacial Indifference", 13, FontStyle.Regular)
                    }

                    MakePanelRounded(bookingPanel, 48)
                    bookingPanel.Controls.Add(lblOwner)
                    bookingPanel.Controls.Add(lblPet)
                    bookingPanel.Controls.Add(lblDate)

                    Dim btnDone As New Button With {
                        .Text = "Done",
                        .Width = 70,
                        .Height = 40,
                        .BackColor = Color.LightGreen,
                        .Location = New Point(bookingPanel.Width - 160, 15),
                        .Tag = reader("bookingId"),
                        .Enabled = (bookingDate.Date = Date.Today),
                        .FlatStyle = FlatStyle.Flat,
                        .Font = New Font("Glacial Indifference", 10, FontStyle.Bold)
                    }
                    AddHandler btnDone.Click, AddressOf MarkDone

                    btnDone.FlatAppearance.BorderSize = 0
                    btnDone.ForeColor = Color.White


                    Dim btnCancel As New Button With {
                        .Text = "Cancel",
                        .Width = 70,
                        .Height = 40,
                        .BackColor = Color.IndianRed,
                        .Location = New Point(bookingPanel.Width - 80, 15),
                        .Tag = reader("bookingId"),
                        .FlatStyle = FlatStyle.Flat,
                        .Font = New Font("Glacial Indifference", 10, FontStyle.Bold)
                    }
                    AddHandler btnCancel.Click, AddressOf MarkCancelled

                    btnCancel.FlatAppearance.BorderSize = 0
                    btnCancel.ForeColor = Color.White

                    MakeButtonRounded(btnDone, 20)
                    MakeButtonRounded(btnCancel, 20)
                    bookingPanel.Controls.Add(btnDone)
                    bookingPanel.Controls.Add(btnCancel)
                    ParentPanel.Controls.Add(bookingPanel)

                    topPosition += bookingPanel.Height + bookingPanel.Margin.Top + bookingPanel.Margin.Bottom
                End While

                If Not found Then
                    Dim lblNone As New Label With {
                        .Text = If(filter = "thisweek", "No bookings this week.", "No bookings found."),
                        .AutoSize = True,
                        .Font = New Font("Segoe UI", 12, FontStyle.Bold),
                        .ForeColor = Color.DarkGray,
                        .Location = New Point(20, 20)
                    }
                    ParentPanel.Controls.Add(lblNone)
                End If

                con.Close()
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Error loading bookings: " & ex.Message)
        End Try
    End Sub

    Private Sub MarkDone(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        Dim bookingId As Integer = CInt(btn.Tag)

        If UpdateBookingStatus(bookingId, "Done") Then
            Dim parentPanel As Panel = CType(btn.Parent, Panel)
            RemoveBookingPanel(parentPanel)
        End If
    End Sub

    Private Sub MarkCancelled(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        Dim bookingId As Integer = CInt(btn.Tag)

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to cancel this booking?", "Cancel Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            If UpdateBookingStatus(bookingId, "Cancelled") Then
                Dim parentPanel As Panel = CType(btn.Parent, Panel)
                RemoveBookingPanel(parentPanel)
            End If
        End If
    End Sub

    Private Sub RemoveBookingPanel(bookingPanel As Panel)
        Dim panelTotalHeight As Integer = bookingPanel.Height + bookingPanel.Margin.Top + bookingPanel.Margin.Bottom
        Dim panelsBelowCurrent As New List(Of Panel)
        Dim indexToRemove As Integer = ParentPanel.Controls.IndexOf(bookingPanel)

        For i As Integer = 0 To ParentPanel.Controls.Count - 1
            Dim control As Control = ParentPanel.Controls(i)
            If TypeOf control Is Panel AndAlso i > indexToRemove Then
                panelsBelowCurrent.Add(CType(control, Panel))
            End If
        Next

        ParentPanel.Controls.Remove(bookingPanel)

        For Each panel As Panel In panelsBelowCurrent
            panel.Top -= panelTotalHeight
        Next

        If ParentPanel.Controls.Count = 0 Then
            Dim lblNone As New Label With {
                .Text = If(currentFilter = "thisweek", "No bookings this week.", "No bookings found."),
                .AutoSize = True,
                .Font = New Font("Segoe UI", 12, FontStyle.Bold),
                .ForeColor = Color.DarkGray,
                .Location = New Point(20, 20)
            }
            ParentPanel.Controls.Add(lblNone)
        End If

        ParentPanel.Refresh()
    End Sub

    Private Function UpdateBookingStatus(bookingId As Integer, newStatus As String) As Boolean
        Try
            Using cmd As New MySqlCommand("UPDATE bookingtable SET bookingStatus = @status WHERE bookingId = @id", con)
                cmd.Parameters.AddWithValue("@status", newStatus)
                cmd.Parameters.AddWithValue("@id", bookingId)

                If con.State = ConnectionState.Closed Then
                    con.Open()
                End If

                cmd.ExecuteNonQuery()

                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
            End Using

            Return True
        Catch ex As MySqlException
            MessageBox.Show("Error updating booking status: " & ex.Message)
            Return False
        End Try
    End Function

    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
        LoadBookings("all", txtSearch.Text.Trim())
    End Sub

    Private Sub btnThisWeek_Click(sender As Object, e As EventArgs) Handles btnThisWeek.Click
        LoadBookings("thisweek", txtSearch.Text.Trim())
    End Sub

    ' 🔍 Search button click
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        LoadBookings(currentFilter, txtSearch.Text.Trim())
    End Sub

End Class
