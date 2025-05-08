Imports System.Drawing.Drawing2D
Imports Microsoft.Web.WebView2.WinForms



'timing ng pagbaba ng panel na ansa taas yung may x don 
Public Module PanelAboveSlide
    Dim slideTargetHeight As Integer = 21
    Dim slidingDown As Boolean = False
    Dim slidingUp As Boolean = False
    Dim slideSpeed As Integer = 2


    Public Sub InitializePanel(ByRef panel As Panel, ByVal timer As Timer)
        panel.Height = 0
        timer.Interval = 1
    End Sub
    Public Sub MouseMove(panel As Panel, e As MouseEventArgs, timer As Timer)

        If e.Y <= 5 AndAlso panel.Height = 0 Then
            slidingDown = True
            slidingUp = False
            timer.Start()
        End If
    End Sub


    Public Sub MouseEnter(ByRef panel As Panel, ByVal timer As Timer)
        If panel.Height < slideTargetHeight Then
            slidingDown = False
            slidingUp = True
            timer.Start()
        Else
            slidingDown = False
            slidingUp = True
            timer.Start()

        End If
    End Sub

    Public Sub SlidePanel(ByRef panel As Panel, ByVal timer As Timer)
        If slidingDown Then
            If panel.Height < slideTargetHeight Then
                panel.Height += slideSpeed
            Else
                panel.Height = slideTargetHeight
                slidingDown = False
                timer.Stop()
            End If
        ElseIf slidingUp Then
            If panel.Height > 0 Then
                panel.Height -= slideSpeed
            Else
                panel.Height = 0
                slidingUp = False
                timer.Stop()
            End If
        End If
    End Sub
End Module



'making the panels and button rounded 
Module UIHelpers


    Public Sub MakeFormRounded(frm As Form, radius As Integer)
        Dim path As New GraphicsPath()
        Dim rect As Rectangle = frm.ClientRectangle
        Dim diameter As Integer = radius * 2

        path.StartFigure()
        path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90)
        path.AddLine(rect.X + radius, rect.Y, rect.Right - radius, rect.Y)
        path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90)
        path.AddLine(rect.Right, rect.Y + radius, rect.Right, rect.Bottom - radius)
        path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90)
        path.AddLine(rect.Right - radius, rect.Bottom, rect.X + radius, rect.Bottom)
        path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90)
        path.AddLine(rect.X, rect.Bottom - radius, rect.X, rect.Y + radius)
        path.CloseFigure()

        frm.FormBorderStyle = FormBorderStyle.None
        frm.Region = New Region(path)
    End Sub


    Public Sub MakeButtonRounded(btn As Button, radius As Integer)
        Dim path As New GraphicsPath()
        path.AddArc(0, 0, radius, radius, 180, 90)
        path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90)
        path.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90)
        path.AddArc(0, btn.Height - radius, radius, radius, 90, 90)
        path.CloseAllFigures()
        btn.Region = New Region(path)
    End Sub


    Public Sub MakePictureBoxRounded(btn As PictureBox, radius As Integer)
        Dim path As New GraphicsPath()
        path.AddArc(0, 0, radius, radius, 180, 90)
        path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90)
        path.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90)
        path.AddArc(0, btn.Height - radius, radius, radius, 90, 90)
        path.CloseAllFigures()
        btn.Region = New Region(path)
    End Sub

    Public Sub MakePanelRounded(pnl As Panel, radius As Integer)
        Dim path As New GraphicsPath()
        path.AddArc(0, 0, radius, radius, 180, 90)
        path.AddArc(pnl.Width - radius, 0, radius, radius, 270, 90)
        path.AddArc(pnl.Width - radius, pnl.Height - radius, radius, radius, 0, 90)
        path.AddArc(0, pnl.Height - radius, radius, radius, 90, 90)
        path.CloseAllFigures()
        pnl.Region = New Region(path)
    End Sub

    Public Sub MakeWebViewRounded(webView As WebView2, radius As Integer)
        Dim path As New GraphicsPath()
        path.AddArc(0, 0, radius, radius, 180, 90)
        path.AddArc(webView.Width - radius, 0, radius, radius, 270, 90)
        path.AddArc(webView.Width - radius, webView.Height - radius, radius, radius, 0, 90)
        path.AddArc(0, webView.Height - radius, radius, radius, 90, 90)
        path.CloseAllFigures()
        webView.Region = New Region(path)
    End Sub

    Public Sub MakeTextBoxRounded(txt As TextBox, radius As Integer)
        Dim path As New GraphicsPath()
        path.AddArc(0, 0, radius, radius, 180, 90)
        path.AddArc(txt.Width - radius, 0, radius, radius, 270, 90)
        path.AddArc(txt.Width - radius, txt.Height - radius, radius, radius, 0, 90)
        path.AddArc(0, txt.Height - radius, radius, radius, 90, 90)
        path.CloseAllFigures()
        txt.Region = New Region(path)
    End Sub

    Public Sub ApplyRoundedCorners(panel As Panel, radius As Integer)
        Dim path As New GraphicsPath()
        path.StartFigure()
        path.AddArc(New Rectangle(0, 0, radius, radius), 180, 90)
        path.AddArc(New Rectangle(panel.Width - radius, 0, radius, radius), 270, 90)
        path.AddArc(New Rectangle(panel.Width - radius, panel.Height - radius, radius, radius), 0, 90)
        path.AddArc(New Rectangle(0, panel.Height - radius, radius, radius), 90, 90)
        path.CloseFigure()
        panel.Region = New Region(path)
    End Sub

    Public Sub RoundPictureBox(picture As PictureBox)
        Dim path As New GraphicsPath()
        path.StartFigure()
        Dim gp As New GraphicsPath()
        gp.AddEllipse(0, 0, picture.Width, picture.Height)
        picture.Region = New Region(gp)

    End Sub

End Module



'postion ng panels and buttons
Module positonsPanels


    Public Sub posProfPic(picture As PictureBox)
        Dim x As Integer = 1300
        Dim y As Integer = 18

        picture.Location = New Point(x, y)


    End Sub

    Public Sub BookPosition(button As Button)
        Dim x As Integer = 330
        Dim y As Integer = 605

        button.Location = New Point(x, y)
    End Sub


    Public Sub locPostion(picturebox As PictureBox)
        Dim x As Integer = 110
        Dim y As Integer = 36


        picturebox.Location = New Point(x, y)
    End Sub



    Public Sub buttonYes(button As Button)
        Dim x As Integer = 450
        Dim y As Integer = 498

        button.Location = New Point(x, y)
    End Sub

    Public Sub buttonNo(button As Button)
        Dim x As Integer = 820
        Dim y As Integer = 498

        button.Location = New Point(x, y)
    End Sub


    Public Sub btnLoginLogin(button As Button)
        Dim x As Integer = 930
        Dim y As Integer = 570

        button.Location = New Point(x, y)
    End Sub

    Public Sub btnbackLogin(button As Button)
        Dim x As Integer = 800
        Dim y As Integer = 37

        button.Location = New Point(x, y)
    End Sub

    Public Sub textBoxUSername(textbox As TextBox)
        Dim x As Integer = 970
        Dim y As Integer = 370

        textbox.Location = New Point(x, y)
    End Sub

    Public Sub btnCode1(textbox As TextBox)
        Dim x As Integer = 999
        Dim y As Integer = 468

        textbox.Location = New Point(x, y)
    End Sub

    Public Sub btnCode2(textbox As TextBox)
        Dim x As Integer = 1066
        Dim y As Integer = 468

        textbox.Location = New Point(x, y)
    End Sub

    Public Sub btnCode3(textbox As TextBox)
        Dim x As Integer = 1134
        Dim y As Integer = 468

        textbox.Location = New Point(x, y)
    End Sub

    Public Sub btnCode4(textbox As TextBox)
        Dim x As Integer = 1201
        Dim y As Integer = 468

        textbox.Location = New Point(x, y)
    End Sub

    Public Sub btnCode5(textbox As TextBox)
        Dim x As Integer = 1266
        Dim y As Integer = 468

        textbox.Location = New Point(x, y)
    End Sub

    Public Sub btnCode6(textbox As TextBox)
        Dim x As Integer = 1334
        Dim y As Integer = 468

        textbox.Location = New Point(x, y)
    End Sub

    Public Sub webView(webView As WebView2)
        Dim x As Integer = 780
        Dim y As Integer = 190

        webView.Location = New Point(x, y)
    End Sub

    Public Sub btnBackLocation(button As Button)
        Dim x As Integer = 46
        Dim y As Integer = 23

        button.Location = New Point(x, y)
    End Sub


    Public Sub txtFullNameON(textbox As TextBox)
        Dim x As Integer = 210
        Dim y As Integer = 318

        textbox.Location = New Point(x, y)
    End Sub
    Public Sub txtEAddressOn(textbox As TextBox)
        Dim x As Integer = 210
        Dim y As Integer = 415

        textbox.Location = New Point(x, y)
    End Sub
    Public Sub txtAddressOn(textbox As TextBox)
        Dim x As Integer = 210
        Dim y As Integer = 513

        textbox.Location = New Point(x, y)
    End Sub
    Public Sub txtCNumberON(textbox As TextBox)
        Dim x As Integer = 210
        Dim y As Integer = 608

        textbox.Location = New Point(x, y)
    End Sub


    Public Sub btnNextON(button As Button)
        Dim x As Integer = 122
        Dim y As Integer = 690

        button.Location = New Point(x, y)
    End Sub

    Public Sub buttonBackON(button As Button)
        Dim x As Integer = 578
        Dim y As Integer = 33

        button.Location = New Point(x, y)
    End Sub


    'pentinfo2
    Public Sub txtPetNamePI(textbox As TextBox)
        Dim x As Integer = 150
        Dim y As Integer = 163

        textbox.Location = New Point(x, y)
    End Sub

    Public Sub dtpBirthdayPI(dtp As DateTimePicker)
        Dim x As Integer = 153
        Dim y As Integer = 239

        dtp.Location = New Point(x, y)
    End Sub

    Public Sub txtGetDatePI(textbox As TextBox)
        Dim x As Integer = 150
        Dim y As Integer = 238

        textbox.Location = New Point(x, y)
    End Sub


    Public Sub txtAgePI(textbox As TextBox)
        Dim x As Integer = 150
        Dim y As Integer = 310

        textbox.Location = New Point(x, y)
    End Sub
    Public Sub txtWeightPI(textbox As TextBox)
        Dim x As Integer = 437
        Dim y As Integer = 310

        textbox.Location = New Point(x, y)
    End Sub
    Public Sub btnMalePI(button As Button)
        Dim x As Integer = 126
        Dim y As Integer = 411

        button.Location = New Point(x, y)
    End Sub


    Public Sub btnFemalePI(button As Button)
        Dim x As Integer = 420
        Dim y As Integer = 411

        button.Location = New Point(x, y)
    End Sub

    Public Sub btnFelinePI(button As Button)
        Dim x As Integer = 128
        Dim y As Integer = 515

        button.Location = New Point(x, y)
    End Sub

    Public Sub btnCaninePI(button As Button)
        Dim x As Integer = 325
        Dim y As Integer = 515

        button.Location = New Point(x, y)
    End Sub


    Public Sub btnReptilePI(button As Button)
        Dim x As Integer = 518
        Dim y As Integer = 515

        button.Location = New Point(x, y)
    End Sub


    Public Sub btnNextPI(button As Button)
        Dim x As Integer = 150
        Dim y As Integer = 765

        button.Location = New Point(x, y)
    End Sub

    Public Sub txtBreedPI(textbox As TextBox)


        Dim x As Integer = 150
        Dim y As Integer = 671

        textbox.Location = New Point(x, y)
    End Sub

    Public Sub cbVacStatusPI(cb As ComboBox)
        Dim x As Integer = 150
        Dim y As Integer = 597

        cb.Location = New Point(x, y)
    End Sub

    Public Sub getVacStasPI(textbox As TextBox)
        Dim x As Integer = 150
        Dim y As Integer = 597

        textbox.Location = New Point(x, y)
    End Sub

    Public Sub btnBackPI(button As Button)
        Dim x As Integer = 535
        Dim y As Integer = 16

        button.Location = New Point(x, y)
    End Sub



    'calendar
    Public Sub btnAddPetCA(button As Button)
        Dim x As Integer = 600
        Dim y As Integer = 767

        button.Location = New Point(x, y)
    End Sub


    Public Sub btnVAccinePS(Button As Button)
        Dim x As Integer = 250
        Dim y As Integer = 565

        Button.Location = New Point(x, y)
    End Sub


    Public Sub btnCheckUPPS(Button As Button)
        Dim x As Integer = 910
        Dim y As Integer = 565

        Button.Location = New Point(x, y)
    End Sub

    Public Sub btnNextPS(Button As Button)
        Dim x As Integer = 845
        Dim y As Integer = 703

        Button.Location = New Point(x, y)
    End Sub


    Public Sub lblPRicePS(lbl As Label)
        Dim x As Integer = 328
        Dim y As Integer = 720

        lbl.Location = New Point(x, y)
    End Sub

    Public Sub btnBackPS(btn As Button)
        Dim x As Integer = 1320
        Dim y As Integer = 35

        btn.Location = New Point(x, y)
    End Sub

    Public Sub btnBackDateCAl(btn As Button)
        Dim x As Integer = 170
        Dim y As Integer = 690

        btn.Location = New Point(x, y)
    End Sub

    Public Sub btnConfirmCAl(btn As Button)
        Dim x As Integer = 395
        Dim y As Integer = 685

        btn.Location = New Point(x, y)
    End Sub

    Public Sub btnNextDateCAl(btn As Button)
        Dim x As Integer = 630
        Dim y As Integer = 690

        btn.Location = New Point(x, y)
    End Sub


    Public Sub tlpCalendarCAl(tlp As TableLayoutPanel)
        Dim x As Integer = 170
        Dim y As Integer = 295

        tlp.Location = New Point(x, y)
    End Sub


    Public Sub lblMonthCAL(lbl As Label)
        Dim x As Integer = 265
        Dim y As Integer = 140

        lbl.Location = New Point(x, y)
    End Sub



    'add code form


    Public Sub btnCode1AC(txt As TextBox)
        Dim x As Integer = 599
        Dim y As Integer = 395

        txt.Location = New Point(x, y)
    End Sub

    Public Sub btnCode2AC(txt As TextBox)
        Dim x As Integer = 696
        Dim y As Integer = 395

        txt.Location = New Point(x, y)
    End Sub

    Public Sub btnCode3AC(txt As TextBox)
        Dim x As Integer = 793
        Dim y As Integer = 395

        txt.Location = New Point(x, y)
    End Sub

    Public Sub btnCode4AC(txt As TextBox)
        Dim x As Integer = 891
        Dim y As Integer = 395

        txt.Location = New Point(x, y)
    End Sub

    Public Sub btnCode5AC(txt As TextBox)
        Dim x As Integer = 988
        Dim y As Integer = 395

        txt.Location = New Point(x, y)
    End Sub

    Public Sub btnCode6AC(txt As TextBox)
        Dim x As Integer = 1085
        Dim y As Integer = 395

        txt.Location = New Point(x, y)
    End Sub


    Public Sub btnConfirmAC(btn As Button)
        Dim x As Integer = 660
        Dim y As Integer = 533

        btn.Location = New Point(x, y)
    End Sub

    Public Sub btnBackAC(btn As Button)
        Dim x As Integer = 375
        Dim y As Integer = 198

        btn.Location = New Point(x, y)
    End Sub

    'pentinfo2


End Module



'smooth scroll nasa pangalan na oh
Module smoothScroll
    Public scrollTargetY As Integer

    Public Sub SmoothScrollToPage(targetPage As UserControl)
        scrollTargetY = CInt(targetPage.Tag)
    End Sub

    Public Sub ApplySmoothScroll(VScrollBar As VScrollBar, panel As Panel, scrollTimer As Timer)
        Dim currentY As Integer = VScrollBar.Value
        Dim stepSize As Integer = Math.Max(1, Math.Abs(scrollTargetY - currentY) \ 15)

        If currentY < scrollTargetY Then
            VScrollBar.Value = Math.Min(currentY + stepSize, scrollTargetY)
        ElseIf currentY > scrollTargetY Then
            VScrollBar.Value = Math.Max(currentY - stepSize, scrollTargetY)
        End If

        ' Apply scrolling effect
        For Each ctrl As Control In panel.Controls
            ctrl.Top = CInt(ctrl.Tag) - VScrollBar.Value
        Next

        ' Stop when we reach target
        If VScrollBar.Value = scrollTargetY Then
            scrollTimer.Stop()
        End If
    End Sub
End Module


'colors ng buttons or panels or picture box
Module GradientHelper
    Public Sub DrawGradientButton(sender As Object, e As PaintEventArgs, color1 As Color, color2 As Color, Optional direction As Drawing2D.LinearGradientMode = Drawing2D.LinearGradientMode.Horizontal)
        Dim btn As Button = CType(sender, Button)
        Dim rect As Rectangle = btn.ClientRectangle

        Using brush As New Drawing2D.LinearGradientBrush(rect, color1, color2, direction)
            e.Graphics.FillRectangle(brush, rect)
        End Using

        TextRenderer.DrawText(e.Graphics, btn.Text, btn.Font, rect, btn.ForeColor, TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter)
    End Sub

    Public Sub pictureBox1Color(PictureBox As PictureBox)
        PictureBox.BackColor = Color.FromArgb(244, 239, 234)
    End Sub





End Module


'syempre background color nakalgay na eh
Module backgroundcolor

    Public Sub buttonTextColor(button As Button)
        button.ForeColor = Color.FromArgb(52, 52, 52)
    End Sub

    Public Sub yesorno(button As Button)
        button.BackColor = Color.FromArgb(159, 214, 118)
    End Sub

End Module



Module ButtonColorChanger
    ' Method to change the button color based on the current page
    Public Sub ChangeButtonColor(currentPage As String, btnServices As Button, btnHmm As Button, btnHome As Button, btnAboutUs As Button)
        ' Reset all buttons to white
        btnServices.BackColor = Color.White
        btnHmm.BackColor = Color.White
        btnHome.BackColor = Color.White
        btnAboutUs.BackColor = Color.White

        ' Set the button corresponding to the current page to green
        Select Case currentPage
            Case "Interface1"
                btnHome.BackColor = Color.FromArgb(185, 219, 185)
            Case "Interface2"
                btnServices.BackColor = Color.FromArgb(185, 219, 185)
            Case "Interface3"
                btnHmm.BackColor = Color.FromArgb(185, 219, 185)
            Case "Interface4"
                btnAboutUs.BackColor = Color.FromArgb(185, 219, 185)
        End Select
    End Sub
End Module


'shadow below the panel
Module DropShadow

    Public Sub pnlButtonsShadow(graphics As Graphics, panel As Control)
        Dim shadowHeight As Integer = 3

        Dim rect As New Rectangle(0, panel.Height - shadowHeight, panel.Width, shadowHeight)
        Using brush As New LinearGradientBrush(rect,
           Color.FromArgb(70, 0, 0, 0),
           Color.Transparent,
           LinearGradientMode.Vertical)
            graphics.FillRectangle(brush, rect)

        End Using




    End Sub

End Module


Module Helpers
    Public Sub CenterPictureBoxHorizontally(pic As PictureBox, container As Panel)
        If pic Is Nothing Then Exit Sub

        ' Only center on X-axis
        pic.Location = New Point(
            (container.Width - pic.Width) \ 2,
            pic.Location.Y ' Keep original Y position
        )
    End Sub
End Module

