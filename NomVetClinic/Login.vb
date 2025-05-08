
Imports MySql.Data.MySqlClient

Public Class Login
    Private isMouseOver As Boolean = False
    Private WithEvents scrollTimer As New Timer With {.Interval = 10}
    Dim dataInfo As String = ("server=localhost;user id=root;password=rdtimbangMysql1;database=adminmain")
    Dim conn As New MySqlConnection




    Private Sub bookingLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler btnLogin.Paint, AddressOf btnBookNow_Paint
        Me.WindowState = FormWindowState.Maximized
        PanelAboveSlide.InitializePanel(pnlAbovebuttons3, timerPanel3)
        txtUsername.Text = "Username"

    End Sub


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "Username" OrElse String.IsNullOrWhiteSpace(txtUsername.Text) Then
            MessageBox.Show("Username cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim codeBoxes As TextBox() = {txtCode1, txtCode2, txtCode3, txtCode4, txtCode5, txtCode6}

        For Each tb As TextBox In codeBoxes
            If String.IsNullOrWhiteSpace(tb.Text) Then
                MessageBox.Show("All code fields must be filled.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                tb.Focus()
                Exit Sub
            End If
            If Not Char.IsDigit(tb.Text(0)) Then
                MessageBox.Show("Code fields must contain numbers only.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                tb.Focus()
                Exit Sub
            End If
        Next

        Dim codeAll As String = txtCode1.Text & txtCode2.Text & txtCode3.Text & txtCode4.Text & txtCode5.Text & txtCode6.Text
        Dim customerUsername As String = txtUsername.Text.Trim

        Try
            conn = New MySqlConnection(dataInfo)
            conn.Open()

            Dim loginQuery As String = "
        SELECT oi.ownerID, oi.ownerName, oi.ownerCode
        FROM ownerinformation oi
        WHERE oi.ownerName = @ownerName AND oi.ownerCode = @ownerCode"

            Using cmd As New MySqlCommand(loginQuery, conn)
                cmd.Parameters.AddWithValue("@ownerName", customerUsername)
                cmd.Parameters.AddWithValue("@ownerCode", codeAll)

                Dim sqlReader As MySqlDataReader = cmd.ExecuteReader

                If sqlReader.Read Then
                    ' ✅ Store owner ID and name
                    TemporaryData.LoggedInOwnerID = sqlReader("ownerID")
                    TemporaryData.LoggedInOwnerName = sqlReader("ownerName").ToString()

                    MessageBox.Show("Login successful!")
                    customerAccount.Show()
                    Me.Close()
                Else
                    MessageBox.Show("Invalid username or code.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

                sqlReader.Close()
            End Using

        Catch ex As Exception
            MessageBox.Show("Database error: " & ex.Message)
        End Try

    End Sub



    Private Sub POSITIONS(sender As Object, e As EventArgs) Handles MyBase.Load
        positonsPanels.textBoxUSername(txtUsername)
        positonsPanels.btnLoginLogin(btnLogin)
        positonsPanels.btnbackLogin(btnBackLogin)
        positonsPanels.btnCode1(txtCode1)
        positonsPanels.btnCode2(txtCode2)
        positonsPanels.btnCode3(txtCode3)
        positonsPanels.btnCode4(txtCode4)
        positonsPanels.btnCode5(txtCode5)
        positonsPanels.btnCode6(txtCode6)

    End Sub

    Private Sub LoginColors(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsername.BackColor = Color.FromArgb(212, 237, 193)
        txtUsername.ForeColor = Color.FromArgb(138, 120, 120)
        txtCode1.BackColor = Color.FromArgb(212, 237, 193)
        txtCode2.BackColor = Color.FromArgb(212, 237, 193)
        txtCode3.BackColor = Color.FromArgb(212, 237, 193)
        txtCode4.BackColor = Color.FromArgb(212, 237, 193)
        txtCode5.BackColor = Color.FromArgb(212, 237, 193)
        txtCode6.BackColor = Color.FromArgb(212, 237, 193)
    End Sub

    Private Sub FOntLoginColors(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each tb As TextBox In {txtCode1, txtCode2, txtCode3, txtCode4, txtCode5, txtCode6}
            tb.ForeColor = Color.FromArgb(138, 120, 120)
        Next

    End Sub
    Private Sub logInRounding(sender As Object, e As EventArgs) Handles MyBase.Load
        MakeButtonRounded(btnLogin, 50)

    End Sub


    Private Sub textBoxEnter(sender As Object, e As EventArgs) Handles txtUsername.Enter
        If txtUsername.Text = "Username" Then
            txtUsername.Text = ""
            txtUsername.ForeColor = Color.FromArgb(138, 120, 120)
        End If
    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles txtUsername.Leave
        If txtUsername.Text.Trim() = "" Then
            txtUsername.Text = "Username"
            txtUsername.ForeColor = Color.FromArgb(138, 120, 120)
        End If
    End Sub



    Private Sub btnBookNow_Paint(sender As Object, e As PaintEventArgs)
        If isMouseOver Then
            GradientHelper.DrawGradientButton(sender, e, Color.FromArgb(0, 151, 178), Color.FromArgb(126, 217, 87), Drawing2D.LinearGradientMode.Horizontal)
        Else
            GradientHelper.DrawGradientButton(sender, e, Color.FromArgb(126, 217, 87), Color.FromArgb(0, 151, 178), Drawing2D.LinearGradientMode.Horizontal)
        End If
    End Sub

    Private Sub btnBookNow_MouseEnter(sender As Object, e As EventArgs) Handles btnLogin.MouseEnter
        isMouseOver = True
        btnLogin.Invalidate() ' Force the button to repaint
    End Sub

    Private Sub btnBookNow_MouseLeave(sender As Object, e As EventArgs) Handles btnLogin.MouseLeave
        isMouseOver = False
        btnLogin.Invalidate() ' Force the button to repaint
    End Sub

    Private Sub pnlAboveTimer_Tick(sender As Object, e As EventArgs) Handles timerPanel3.Tick
        PanelAboveSlide.SlidePanel(pnlAbovebuttons3, timerPanel3)
    End Sub



    'pnl Button Mouse enter
    Private Sub pctHomePage_MouseEnter(sender As Object, e As EventArgs) Handles pctBoxMain.MouseEnter
        PanelAboveSlide.MouseEnter(pnlAbovebuttons3, timerPanel3)
    End Sub




    'pnl Button Mouse Move
    Private Sub MouseMovePanel(sender As Object, e As MouseEventArgs) Handles pctBoxMain.MouseMove
        PanelAboveSlide.MouseMove(pnlAbovebuttons3, e, timerPanel3)
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        booking.Close()
        Form1.Close()
    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnBackLogin_Click(sender As Object, e As EventArgs) Handles btnBackLogin.Click
        booking.Show()
        Me.Close()
    End Sub

    Private Sub handles_keyUSername(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtCode1.Focus()

        End If
    End Sub




    Private Sub handles_keycode(sender As Object, e As KeyEventArgs) Handles txtCode1.KeyUp, txtCode2.KeyUp, txtCode3.KeyUp, txtCode4.KeyUp, txtCode5.KeyUp, txtCode6.KeyUp
        Dim currentTextBox As TextBox = CType(sender, TextBox)


        If currentTextBox.Text.Length = 1 AndAlso Char.IsDigit(currentTextBox.Text(0)) Then
            Select Case currentTextBox.Name
                Case "txtCode1"
                    txtCode2.Focus()
                Case "txtCode2"
                    txtCode3.Focus()
                Case "txtCode3"
                    txtCode4.Focus()
                Case "txtCode4"
                    txtCode5.Focus()
                Case "txtCode5"
                    txtCode6.Focus()
                Case "txtCode6"
                    ' All digits entered, optionally trigger validation
            End Select
        End If
        ' If user pressed Backspace and the textbox is empty, move back
        If e.KeyCode = Keys.Back AndAlso currentTextBox.Text = "" Then
            Select Case currentTextBox.Name
                Case "txtCode6"
                    txtCode5.Focus()
                Case "txtCode5"
                    txtCode4.Focus()
                Case "txtCode4"
                    txtCode3.Focus()
                Case "txtCode3"
                    txtCode2.Focus()
                Case "txtCode2"
                    txtCode1.Focus()
            End Select
        End If


    End Sub


End Class