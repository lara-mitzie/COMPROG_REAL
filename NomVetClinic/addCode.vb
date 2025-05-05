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


End Class