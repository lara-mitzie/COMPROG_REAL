Imports System.Drawing.Drawing2D
Imports MySql.Data.MySqlClient

Public Class Form1
    Dim connectionString As String = "server=localhost;userid=root;password=Michymichy_27;database=user_pass_db"
    Dim hover As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' UI Setup
        txtusername.BackColor = Color.FromArgb(212, 237, 193)
        txtusername.ForeColor = Color.FromArgb(138, 120, 120)
        txtpassword.BackColor = Color.FromArgb(212, 237, 193)
        txtpassword.ForeColor = Color.FromArgb(138, 120, 120)
        btnlogin.Font = New Font("League Spartan", 14)
        btnlogin.ForeColor = Color.White
        btnlogin.BackColor = Color.FromArgb(212, 237, 193)
        cbsee.BackColor = Color.FromArgb(212, 237, 193)

        ' Placeholder Text 0, 74, 173
        txtusername.Text = "USERNAME"
        txtpassword.Text = "PASSWORD"
        txtpassword.UseSystemPasswordChar = False

        btnlogin.FlatStyle = FlatStyle.Flat
        btnlogin.FlatAppearance.BorderSize = 0
        btnlogin.ForeColor = Color.White

    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ' Rounded Button
        Dim radius As Integer = 40
        Dim path As New GraphicsPath()
        path.AddArc(0, 0, radius, radius, 180, 90)
        path.AddArc(btnlogin.Width - radius, 0, radius, radius, 270, 90)
        path.AddArc(btnlogin.Width - radius, btnlogin.Height - radius, radius, radius, 0, 90)
        path.AddArc(0, btnlogin.Height - radius, radius, radius, 90, 90)
        path.CloseFigure()
        btnlogin.Region = New Region(path)
    End Sub

    ' Username Placeholder
    Private Sub txtusername_Enter(sender As Object, e As EventArgs) Handles txtusername.Enter
        If txtusername.Text = "USERNAME" Then
            txtusername.Text = ""
        End If
    End Sub

    Private Sub txtusername_Leave(sender As Object, e As EventArgs) Handles txtusername.Leave
        If String.IsNullOrWhiteSpace(txtusername.Text) Then txtusername.Text = "USERNAME"
    End Sub

    ' Password Placeholder
    Private Sub txtpassword_Enter(sender As Object, e As EventArgs) Handles txtpassword.Enter
        If txtpassword.Text = "PASSWORD" Then
            txtpassword.Text = ""
            txtpassword.PasswordChar = "•"
        End If
    End Sub

    Private Sub txtpassword_Leave(sender As Object, e As EventArgs) Handles txtpassword.Leave
        If String.IsNullOrWhiteSpace(txtpassword.Text) Then
            txtpassword.Text = "PASSWORD"
            txtpassword.PasswordChar = ControlChars.NullChar
        End If
    End Sub

    ' Enter Key Navigation
    Private Sub txtusername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtusername.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtpassword.Focus()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub txtpassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnlogin.PerformClick()
            e.SuppressKeyPress = True
        End If
    End Sub

    ' Show/Hide Password
    Private Sub cbsee_CheckedChanged(sender As Object, e As EventArgs) Handles cbsee.CheckedChanged
        If txtpassword.Text <> "PASSWORD" Then
            txtpassword.PasswordChar = If(cbsee.Checked, ControlChars.NullChar, "•")
        End If
    End Sub

    ' Login Button
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim username = txtusername.Text.Trim()
        Dim password = txtpassword.Text.Trim()

        If username = "USERNAME" OrElse password = "PASSWORD" Then
            MessageBox.Show("Please enter your username and password.")
            Return
        End If

        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Dim query = "SELECT * FROM users WHERE username=@username AND password=@password"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@password", password)
                    Dim reader = cmd.ExecuteReader()
                    If reader.HasRows Then
                        MessageBox.Show("Login successful!")
                        Me.Hide()
                        search.Show()
                    Else
                        MessageBox.Show("Invalid username or password.")
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnlogin_MouseEnter(sender As Object, e As EventArgs) Handles btnlogin.MouseEnter
        hover = True
        btnlogin.Invalidate()
    End Sub

    Private Sub btnlogin_MouseLeave(sender As Object, e As EventArgs) Handles btnlogin.MouseLeave
        hover = False
        btnlogin.Invalidate()
    End Sub

    Private Sub btnlogin_Paint(sender As Object, e As PaintEventArgs) Handles btnlogin.Paint
        Dim rect As Rectangle = btnlogin.ClientRectangle
        Dim color1 As Color = If(hover, Color.FromArgb(126, 217, 87), Color.FromArgb(0, 151, 178))
        Dim color2 As Color = If(hover, Color.FromArgb(0, 151, 178), Color.FromArgb(126, 217, 87))

        Using brush As New Drawing2D.LinearGradientBrush(rect, color1, color2, Drawing2D.LinearGradientMode.Horizontal)
            e.Graphics.FillRectangle(brush, rect)
        End Using

        TextRenderer.DrawText(e.Graphics, btnlogin.Text, btnlogin.Font, rect, Color.White, TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
