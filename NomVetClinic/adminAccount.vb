    Imports System.Drawing.Drawing2D
    Imports MySql.Data.MySqlClient

    Public Class adminAccount
        Dim connectionString As String = "server=localhost;user id=root;password=rdtimbangMysql1;database=adminmain"
        Dim hover As Boolean = False
        Private isMouseOver As Boolean = False

        Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            AddHandler btnLogin.Paint, AddressOf btnBookNow_Paint

        MakeFormRounded(Me, 20)
        MakeButtonRounded(btnTogglePassword, 30)

        For Each tb As TextBox In {txtUsername, txtPassword}
                tb.BackColor = Color.FromArgb(212, 237, 193)
                tb.ForeColor = Color.FromArgb(184, 188, 164)
            Next

            PanelAboveSlide.InitializePanel(pnlAbovebuttons, pnlAboveTimer)
            ' UI Setup
            txtUsername.BackColor = Color.FromArgb(212, 237, 193)
            txtUsername.ForeColor = Color.FromArgb(138, 120, 120)
            txtPassword.BackColor = Color.FromArgb(212, 237, 193)
            txtPassword.ForeColor = Color.FromArgb(138, 120, 120)
            btnLogin.Font = New Font("League Spartan", 14)
            btnLogin.ForeColor = Color.White
            btnLogin.BackColor = Color.FromArgb(212, 237, 193)

            ' Toggle Password Button Design
            btnTogglePassword.FlatStyle = FlatStyle.Flat
            btnTogglePassword.FlatAppearance.BorderSize = 0
            btnTogglePassword.BackColor = Color.FromArgb(212, 237, 193)
            btnTogglePassword.Font = New Font("Segoe UI", 10, FontStyle.Bold)


        ' Placeholder Text
        txtUsername.Text = "USERNAME"
            txtPassword.Text = "PASSWORD"
            txtPassword.UseSystemPasswordChar = False

            btnLogin.FlatStyle = FlatStyle.Flat
            btnLogin.FlatAppearance.BorderSize = 0
            btnLogin.ForeColor = Color.White
        End Sub

        Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
            MakeButtonRounded(btnLogin, 48)
        End Sub

        ' Username Placeholder
        Private Sub txtusername_Enter(sender As Object, e As EventArgs) Handles txtUsername.Enter
            If txtUsername.Text = "USERNAME" Then
                txtUsername.Text = ""
            End If
        End Sub

        Private Sub txtusername_Leave(sender As Object, e As EventArgs) Handles txtUsername.Leave
            If String.IsNullOrWhiteSpace(txtUsername.Text) Then txtUsername.Text = "USERNAME"
        End Sub

        ' Password Placeholder
        Private Sub txtpassword_Enter(sender As Object, e As EventArgs) Handles txtPassword.Enter
            If txtPassword.Text = "PASSWORD" Then
                txtPassword.Text = ""
                txtPassword.PasswordChar = "•"
            End If
        End Sub

        Private Sub txtpassword_Leave(sender As Object, e As EventArgs) Handles txtPassword.Leave
            If String.IsNullOrWhiteSpace(txtPassword.Text) Then
                txtPassword.Text = "PASSWORD"
                txtPassword.PasswordChar = ControlChars.NullChar
            End If
        End Sub

        ' Enter Key Navigation
        Private Sub txtusername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown
            If e.KeyCode = Keys.Enter Then
                txtPassword.Focus()
                e.SuppressKeyPress = True
            End If
        End Sub

        Private Sub txtpassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
            If e.KeyCode = Keys.Enter Then
                btnLogin.PerformClick()
                e.SuppressKeyPress = True
            End If
        End Sub

        ' Toggle password visibility using button
        Private Sub btnTogglePassword_Click(sender As Object, e As EventArgs) Handles btnTogglePassword.Click
            If txtPassword.Text <> "PASSWORD" Then
                If txtPassword.PasswordChar = ControlChars.NullChar Then
                    txtPassword.PasswordChar = "•"
                    btnTogglePassword.Image = My.Resources.eye_green
                Else
                    txtPassword.PasswordChar = ControlChars.NullChar
                    btnTogglePassword.Image = My.Resources.eye_white
                End If
            End If
        End Sub

        ' Login Button Click
        Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
            Dim username = txtUsername.Text.Trim()
            Dim password = txtPassword.Text.Trim()

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

                        Form1.pctBlur.Visible = True
                        Form1.pctBlur.BringToFront()


                        mainAdmin.ShowDialog()

                        Form1.pctBlur.Visible = False
                        Form1.pctBlur.SendToBack()


                        Me.Close()
                    Else
                            MessageBox.Show("Invalid username or password.")
                        End If
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Sub


        Private Sub pctHomePage_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox1.MouseEnter
            PanelAboveSlide.MouseEnter(pnlAbovebuttons, pnlAboveTimer)
        End Sub



        'pnl Button Mouse Move
        Private Sub MouseMovePanel(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
            PanelAboveSlide.MouseMove(pnlAbovebuttons, e, pnlAboveTimer)
        End Sub



        'pnlAboveTimer tick

        Private Sub pnlAboveTimer_Tick(sender As Object, e As EventArgs) Handles pnlAboveTimer.Tick
            PanelAboveSlide.SlidePanel(pnlAbovebuttons, pnlAboveTimer)
        End Sub

        ' Button Hover Color Gradient
        Private Sub btnlogin_MouseEnter(sender As Object, e As EventArgs) Handles btnLogin.MouseEnter
            hover = True
            btnLogin.Invalidate()
        End Sub

        Private Sub btnlogin_MouseLeave(sender As Object, e As EventArgs) Handles btnLogin.MouseLeave
            hover = False
            btnLogin.Invalidate()
        End Sub

        Private Sub btnlogin_Paint(sender As Object, e As PaintEventArgs) Handles btnLogin.Paint
            Dim rect As Rectangle = btnLogin.ClientRectangle
            Dim color1 As Color = If(hover, Color.FromArgb(126, 217, 87), Color.FromArgb(0, 151, 178))
            Dim color2 As Color = If(hover, Color.FromArgb(0, 151, 178), Color.FromArgb(126, 217, 87))

            Using brush As New LinearGradientBrush(rect, color1, color2, LinearGradientMode.Horizontal)
                e.Graphics.FillRectangle(brush, rect)
            End Using

            TextRenderer.DrawText(e.Graphics, btnLogin.Text, btnLogin.Font, rect, Color.White, TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter)
        End Sub


        'GRADIENT BOOK NOW COLOR CHANGER MWEHHEH
        Private Sub btnBookNow_Paint(sender As Object, e As PaintEventArgs)
            If isMouseOver Then
                GradientHelper.DrawGradientButton(sender, e, Color.FromArgb(0, 151, 178), Color.FromArgb(126, 217, 87), Drawing2D.LinearGradientMode.Horizontal)
            Else
                GradientHelper.DrawGradientButton(sender, e, Color.FromArgb(126, 217, 87), Color.FromArgb(0, 151, 178), Drawing2D.LinearGradientMode.Horizontal)
            End If
        End Sub

        Private Sub btnBookNow_MouseEnter(sender As Object, e As EventArgs) Handles btnLogin.MouseEnter
            isMouseOver = True
            btnLogin.Invalidate() '
        End Sub

        Private Sub btnBookNow_MouseLeave(sender As Object, e As EventArgs) Handles btnLogin.MouseLeave
            isMouseOver = False
            btnLogin.Invalidate()
        End Sub
        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
            Me.Close()
        End Sub


        Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnMinimize.Click
            Me.WindowState = FormWindowState.Minimized
        End Sub


    End Class
