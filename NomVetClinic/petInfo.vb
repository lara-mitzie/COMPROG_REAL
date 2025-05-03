Public Class petInfo


    Private isMouseOver As Boolean = False
    Private WithEvents scrollTimer As New Timer With {.Interval = 10}
    Private Sub MainLoad(sender As Object, e As EventArgs) Handles MyBase.Load
            PanelAboveSlide.InitializePanel(pnlAbovebuttons3, pnlTimer7)
        Me.WindowState = FormWindowState.Maximized
    End Sub


    Private Sub POSITIONS(sender As Object, e As EventArgs) Handles MyBase.Load
        positonsPanels.txtPetNamePI(txtPetName)
        positonsPanels.dtpBirthdayPI(dtpBirthday)
        positonsPanels.txtAgePI(txtAge)
        positonsPanels.txtWeightPI(txtWeight)
    End Sub

    Private Sub ROuding(sender As Object, e As EventArgs) Handles MyBase.Load
        MakeButtonRounded(btnMale, 48)
        MakeButtonRounded(btnFemale, 48)
        MakeButtonRounded(btnFeline, 48)
        MakeButtonRounded(btnCanine, 48)
        MakeButtonRounded(btnReptile, 48)
    End Sub



    Private Sub pnlAboveTimer_Tick(sender As Object, e As EventArgs) Handles pnlTimer7.Tick
        PanelAboveSlide.SlidePanel(pnlAbovebuttons3, pnlTimer7)
    End Sub


    'pnl Button Mouse enter
    Private Sub pctHomePage_MouseEnter(sender As Object, e As EventArgs) Handles pctMain.MouseEnter
        PanelAboveSlide.MouseEnter(pnlAbovebuttons3, pnlTimer7)
    End Sub


    'pnl Button Mouse Move
    Private Sub MouseMovePanel(sender As Object, e As MouseEventArgs) Handles pctMain.MouseMove
        PanelAboveSlide.MouseMove(pnlAbovebuttons3, e, pnlTimer7)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        Form1.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


End Class