Public Class Location
    Private isMouseOver As Boolean = False
    Private WithEvents scrollTimer As New Timer With {.Interval = 10}
    Private Sub Location_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        MakeWebViewRounded(WebView21, 48)
        PanelAboveSlide.InitializePanel(pnlAbovebuttons3, pnlTimer4)
        positonsPanels.webView(WebView21)
        Dim formattedAddress As String = "GH3H+FRJ Tarlac State University - College of Computer Studies, Tarlac - Pangasinan Rd, Tarlac City, Tarlac".Replace(" ", "+")
        Dim mapsUrl As String = "https://www.google.com/maps/search/?api=1&query=" & formattedAddress
        WebView21.Source = New Uri(mapsUrl)
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        Form1.Close()
    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub pnlAboveTimer_Tick(sender As Object, e As EventArgs) Handles pnlTimer4.Tick
        PanelAboveSlide.SlidePanel(pnlAbovebuttons3, pnlTimer4)
    End Sub



    'pnl Button Mouse enter
    Private Sub pctHomePage_MouseEnter(sender As Object, e As EventArgs) Handles pctMain.MouseEnter
        PanelAboveSlide.MouseEnter(pnlAbovebuttons3, pnlTimer4)
    End Sub


    'pnl Button Mouse Move
    Private Sub MouseMovePanel(sender As Object, e As MouseEventArgs) Handles pctMain.MouseMove
        PanelAboveSlide.MouseMove(pnlAbovebuttons3, e, pnlTimer4)
    End Sub

    Private Sub pctBack_Click(sender As Object, e As EventArgs) Handles pctBack.Click
        Form1.Show()
        Me.Close()
    End Sub
End Class