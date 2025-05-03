Imports System.Drawing.Drawing2D
Imports MySql.Data.MySqlClient

Public Class loginStaff
    ' Database connection string
    Dim connectionString As String = "server=localhost;userid=root;password=Michymichy_27;database=user_pass_db"

    ' Track if mouse is hovering over login button
    Dim hover As Boolean = False

    ' Form load - setup UI styling and placeholders
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set background and text colors
        txtusername.BackColor = Color.FromArgb(212, 237, 193)
        txtusername.ForeColor = Color.FromArgb(138, 120, 120)
        txtpassword.BackColor = Color.FromArgb(212, 237, 193)
        txtpassword.ForeColor = Color.FromArgb(138, 120, 120)

        ' Set button font and colors
        btnLogin.Font = New Font("League Spartan", 14)
        btnLogin.ForeColor = Color.White
        btnLogin.BackColor = Color.FromArgb(212, 237, 193)
        cbsee.BackColor = Color.FromArgb(212, 237, 193)

        ' Set placeholder text
        txtusername.Text = "USERNAME"
        txtpassword.Text = "PASSWORD"
        txtpassword.UseSystemPasswordChar = False

        ' Remove border from button
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.ForeColor = Color.White
    End Sub

    ' Round the login button when the form is shown
    Private Sub loginStaff_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim radius As Integer = 40
        Dim path As New GraphicsPath()
        path.AddArc(0, 0, radius, radius, 180, 90)
        path.AddArc(btnLogin.Width - radius, 0, radius, radius, 270, 90)
        path.AddArc(btnLogin.Width - radius, btnLogin.Height - radius, radius, radius, 0, 90)
        path.AddArc(0, btnLogin.Height - radius, radius, radius, 90, 90)
        path.CloseFigure()
        btnLogin.Region = New Region(path)
    End Sub

    ' Clear placeholder when entering username
    Private Sub txtusername_Enter(sender As Object, e As EventArgs) Handles txtusername.Enter
        If txtusername.Text = "USERNAME" Then
            txtusername.Text = ""
        End If
    End Sub

    ' Restore placeholder if username field is empty
    Private Sub txtusername_Leave(sender As Object, e As EventArgs) Handles txtusername.Leave
        If String.IsNullOrWhiteSpace(txtusername.Text) Then txtusername.Text = "USERNAME"
    End Sub

    ' Clear placeholder and mask password when entering password
    Private Sub txtpassword_Enter(sender As Object, e As EventArgs) Handles txtpassword.Enter
        If txtpassword.Text = "PASSWORD" Then
            txtpassword.Text = ""
            txtpassword.PasswordChar = "•"
        End If
    End Sub

    ' Restore placeholder if password field is empty
    Private Sub txtpassword_Leave(sender As Object, e As EventArgs) Handles txtpassword.Leave
        If String.IsNullOrWhiteSpace(txtpassword.Text) Then
            txtpassword.Text = "PASSWORD"
            txtpassword.PasswordChar = ControlChars.NullChar
        End If
    End Sub

    ' Pressing Enter in username field moves to password
    Private Sub txtusername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtusername.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtpassword.Focus()
            e.SuppressKeyPress = True
        End If
    End Sub

    ' Pressing Enter in password field clicks login
    Private Sub txtpassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin.PerformClick()
            e.SuppressKeyPress = True
        End If
    End Sub

    ' Toggle password visibility
    Private Sub cbsee_CheckedChanged(sender As Object, e As EventArgs) Handles cbsee.CheckedChanged
        If txtpassword.Text <> "PASSWORD" Then
            txtpassword.PasswordChar = If(cbsee.Checked, ControlChars.NullChar, "•")
        End If
    End Sub

    ' Login button click event - authenticate user
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username = txtusername.Text.Trim()
        Dim password = txtpassword.Text.Trim()

        ' Check if fields are filled
        If username = "USERNAME" OrElse password = "PASSWORD" Then
            MessageBox.Show("Please enter your username and password.")
            Return
        End If

        ' Connect to database and check credentials
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
                        ' Show next form here (e.g., Form2.Show())
                    Else
                        MessageBox.Show("Invalid username or password.")
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Set hover to true when mouse enters login button
    Private Sub btnlogin_MouseEnter(sender As Object, e As EventArgs) Handles btnLogin.MouseEnter
        hover = True
        btnLogin.Invalidate()
    End Sub

    ' Set hover to false when mouse leaves login button
    Private Sub btnlogin_MouseLeave(sender As Object, e As EventArgs) Handles btnLogin.MouseLeave
        hover = False
        btnLogin.Invalidate()
    End Sub

    ' Draw gradient background on login button
    Private Sub btnlogin_Paint(sender As Object, e As PaintEventArgs) Handles btnLogin.Paint
        Dim rect As Rectangle = btnLogin.ClientRectangle
        Dim color1 As Color = If(hover, Color.FromArgb(126, 217, 87), Color.FromArgb(0, 151, 178))
        Dim color2 As Color = If(hover, Color.FromArgb(0, 151, 178), Color.FromArgb(126, 217, 87))

        Using brush As New LinearGradientBrush(rect, color1, color2, LinearGradientMode.Horizontal)
            e.Graphics.FillRectangle(brush, rect)
        End Using

        ' Draw button text
        TextRenderer.DrawText(e.Graphics, btnLogin.Text, btnLogin.Font, rect, Color.White, TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter)
    End Sub

End Class
