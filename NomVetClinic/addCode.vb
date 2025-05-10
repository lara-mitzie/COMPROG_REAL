Public Class addCode

    Private WithEvents scrollTimer As New Timer With {.Interval = 10}
    Private Sub addcodeLoad(sender As Object, e As EventArgs) Handles MyBase.Load

        PanelAboveSlide.InitializePanel(pnlAbovebuttons2, timerPanel10)
        Me.WindowState = FormWindowState.Maximized

        positonsPanels.btnCode1AC(txtCode1v2)
        positonsPanels.btnCode2AC(txtCode2v2)
        positonsPanels.btnCode3AC(txtCode3v2)
        positonsPanels.btnCode4AC(txtCode4v2)
        positonsPanels.btnCode5AC(txtCode5v2)
        positonsPanels.btnCode6AC(txtCode6v2)
        positonsPanels.btnConfirmAC(btnConfirm)
        positonsPanels.btnBackAC(btnBack)

        MakeButtonRounded(btnConfirm, 48)

        For Each tb As TextBox In {txtCode1v2, txtCode2v2, txtCode3v2, txtCode4v2, txtCode5v2, txtCode6v2}
            tb.BackColor = Color.FromArgb(155, 177, 129)
        Next

        btnConfirm.BackColor = Color.FromArgb(159, 214, 118)

        MakeButtonRounded(btnConfirm, 48)

    End Sub




    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click


        Dim textbox As New List(Of TextBox) From {txtCode1v2, txtCode2v2, txtCode3v2, txtCode4v2, txtCode5v2, txtCode6v2}

        For Each txt In textbox
            If String.IsNullOrEmpty(txt.Text) Then
                MessageBox.Show("Please enter valid integers in all required fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt.Focus()
                Return
            End If
        Next

        Dim codeAll As String = txtCode1v2.Text & txtCode2v2.Text & txtCode3v2.Text & txtCode4v2.Text & txtCode5v2.Text & txtCode6v2.Text
        TemporaryData.userCode = codeAll


        pctBlur.Visible = True
        pctBlur.BringToFront()

        Dim bookSum As New bookSummary
        bookSum.ShowDialog()


        pctBlur.Visible = False
        pctBlur.SendToBack()



    End Sub

    Private Sub TextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCode1v2.KeyPress, txtCode2v2.KeyPress, txtCode3v2.KeyPress, txtCode4v2.KeyPress, txtCode5v2.KeyPress, txtCode6v2.KeyPress

        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub



    Private Sub handles_keycode(sender As Object, e As KeyEventArgs) Handles txtCode1v2.KeyUp, txtCode2v2.KeyUp, txtCode3v2.KeyUp, txtCode4v2.KeyUp, txtCode5v2.KeyUp, txtCode6v2.KeyUp
        Dim currentTextBox As TextBox = CType(sender, TextBox)


        If currentTextBox.Text.Length = 1 AndAlso Char.IsDigit(currentTextBox.Text(0)) Then
            Select Case currentTextBox.Name
                Case "txtCode1v2"
                    txtCode2v2.Focus()
                Case "txtCode2v2"
                    txtCode3v2.Focus()
                Case "txtCode3v2"
                    txtCode4v2.Focus()
                Case "txtCode4v2"
                    txtCode5v2.Focus()
                Case "txtCode5v2"
                    txtCode6v2.Focus()
                Case "txtCode6v2"

            End Select
        End If
        ' If user pressed Backspace babalik boi sa prior textbox
        If e.KeyCode = Keys.Back AndAlso currentTextBox.Text = "" Then
            Select Case currentTextBox.Name
                Case "txtCode6v2"
                    txtCode5v2.Focus()
                Case "txtCode5v2"
                    txtCode4v2.Focus()
                Case "txtCode4v2"
                    txtCode3v2.Focus()
                Case "txtCode3v2"
                    txtCode2v2.Focus()
                Case "txtCode2v2"
                    txtCode1v2.Focus()
            End Select
        End If


    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        Form1.Close()
    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub pnlAboveTimer_Tick(sender As Object, e As EventArgs) Handles timerPanel10.Tick
        PanelAboveSlide.SlidePanel(pnlAbovebuttons2, timerPanel10)
    End Sub



    'pnl Button Mouse enter
    Private Sub pctHomePage_MouseEnter(sender As Object, e As EventArgs) Handles pctMain.MouseEnter
        PanelAboveSlide.MouseEnter(pnlAbovebuttons2, timerPanel10)
    End Sub


    'pnl Button Mouse Move
    Private Sub MouseMovePanel(sender As Object, e As MouseEventArgs) Handles pctMain.MouseMove
        PanelAboveSlide.MouseMove(pnlAbovebuttons2, e, timerPanel10)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Calendar.Show()
        Me.Close()
    End Sub
End Class