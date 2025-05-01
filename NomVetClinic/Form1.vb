

Class Form1

    Dim animalsPage As New Interface2()
    Dim page3 As New Interface3
    Dim homePage As New Interface1()
    Dim AboutUs As New Interface4

    Private WithEvents scrollTimer As New Timer With {.Interval = 10}

    'FONT COLOR FOR BUTTONS
    Private Sub buttonAndTextColor(sender As Object, e As EventArgs) Handles MyBase.Load

        fontcolor.buttonTextColor(btnHome)
        fontcolor.buttonTextColor(btnServices)
        fontcolor.buttonTextColor(btnhmm)
        fontcolor.buttonTextColor(btnAboutUs)
        fontcolor.buttonTextColor(btnSignIn)
    End Sub


    'Main load
    Private Sub MainLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        PanelAboveSlide.InitializePanel(pnlAbovebuttons, pnlAboveTimer)
        ButtonColorChanger.ChangeButtonColor("Interface1", btnServices, btnhmm, btnHome, btnAboutUs)
    End Sub


    'Interfaces

    Private Sub Interfaces(sender As Object, e As EventArgs) Handles MyBase.Load
        homePage = New Interface1()
        homePage.Size = New Size(Me.ClientSize.Width, Me.ClientSize.Height)
        homePage.Location = New Point(0, 0)
        homePage.Tag = homePage.Top
        pnlShowInt.Size = Me.ClientSize
        pnlShowInt.Controls.Add(homePage)



        animalsPage = New Interface2()
        animalsPage.Size = New Size(Me.ClientSize.Width, Me.ClientSize.Height)
        animalsPage.Location = New Point(0, homePage.Bottom)
        animalsPage.Tag = animalsPage.Top
        pnlShowInt.Controls.Add(animalsPage)


        page3 = New Interface3()
        page3.Size = New Size(Me.ClientSize.Width, Me.ClientSize.Height)
        page3.Location = New Point(0, animalsPage.Bottom)
        page3.Tag = page3.Top
        pnlShowInt.Controls.Add(page3)

        AboutUs = New Interface4
        AboutUs.Size = New Size(Me.ClientSize.Width, Me.ClientSize.Height)
        AboutUs.Location = New Point(0, page3.Bottom)
        AboutUs.Tag = AboutUs.Top
        pnlShowInt.Controls.Add(AboutUs)




        pnlShowInt.AutoScroll = False
        pnlShowInt.Height = Me.ClientSize.Height
        pnlShowInt.Width = Me.ClientSize.Width - VScrollBar.Width

        VScrollBar.Minimum = 0
        VScrollBar.Maximum = Math.Max(0, AboutUs.Bottom - pnlBack.Height)
        VScrollBar.SmallChange = 10
        VScrollBar.LargeChange = 50

    End Sub



    'Making panel and button round
    Private Sub ToRounded(sender As Object, e As EventArgs) Handles MyBase.Load


        MakeButtonRounded(btnHome, 48)
        MakeButtonRounded(btnServices, 48)
        MakeButtonRounded(btnhmm, 48)
        MakeButtonRounded(btnAboutUs, 48)
        MakeButtonRounded(btnSignIn, 48)


    End Sub



    'Scroll Bar
    Private Sub vScrollBar_Scroll(sender As Object, e As EventArgs) Handles VScrollBar.Scroll
        For Each ctrl As Control In pnlShowInt.Controls
            ctrl.Top = CInt(ctrl.Tag) - VScrollBar.Value
        Next
    End Sub




    'pnl Button Mouse enter
    Private Sub pctHomePage_MouseEnter(sender As Object, e As EventArgs) Handles pnlButtons.MouseEnter
        PanelAboveSlide.MouseEnter(pnlAbovebuttons, pnlAboveTimer)
    End Sub



    'pnl Button Mouse Move
    Private Sub MouseMovePanel(sender As Object, e As MouseEventArgs) Handles pnlButtons.MouseMove
        PanelAboveSlide.MouseMove(pnlAbovebuttons, e, pnlAboveTimer)
    End Sub



    'pnlAboveTimer tick

    Private Sub pnlAboveTimer_Tick(sender As Object, e As EventArgs) Handles pnlAboveTimer.Tick
        PanelAboveSlide.SlidePanel(pnlAbovebuttons, pnlAboveTimer)
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub


    Private Sub vScrollBar_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar.Scroll
        For Each ctrl As Control In pnlBack.Controls
            ctrl.Top = CInt(ctrl.Tag) - VScrollBar.Value
        Next
    End Sub



    'Click ewan di ko alam lalagay ko comment
    Private Sub btnGotoHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        ButtonColorChanger.ChangeButtonColor("Interface1", btnServices, btnhmm, btnHome, btnAboutUs)
        SmoothScrollToPage(homePage)
        scrollTimer.Start()
    End Sub

    Private Sub btnGoToAnimals_Click(sender As Object, e As EventArgs) Handles btnServices.Click
        ButtonColorChanger.ChangeButtonColor("Interface2", btnServices, btnhmm, btnHome, btnAboutUs)
        SmoothScrollToPage(animalsPage)
        scrollTimer.Start()
    End Sub

    Private Sub btnGoToPage3_Click(sender As Object, e As EventArgs) Handles btnhmm.Click
        ButtonColorChanger.ChangeButtonColor("Interface3", btnServices, btnhmm, btnHome, btnAboutUs)
        SmoothScrollToPage(page3)
        scrollTimer.Start()
    End Sub

    Private Sub btnAboutUs_Click(sender As Object, e As EventArgs) Handles btnAboutUs.Click
        ButtonColorChanger.ChangeButtonColor("Interface4", btnServices, btnhmm, btnHome, btnAboutUs)
        SmoothScrollToPage(AboutUs)
        scrollTimer.Start()
    End Sub

    'Scrolltimer Timer basta
    Private Sub scrollTimer_Tick(sender As Object, e As EventArgs) Handles scrollTimer.Tick
        ApplySmoothScroll(VScrollBar, pnlShowInt, scrollTimer)

    End Sub

    'linya sa baba ng panel button
    Private Sub PanelBtnShadow(sender As Object, graphic As PaintEventArgs) Handles pnlButtons.Paint
        DropShadow.pnlButtonsShadow(graphic.Graphics, pnlButtons)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
