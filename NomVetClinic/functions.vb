Imports System.Drawing.Drawing2D
Imports Microsoft.VisualBasic.Logging


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

    Public Sub MakeButtonRounded(btn As Button, radius As Integer)
        Dim path As New GraphicsPath()
        path.AddArc(0, 0, radius, radius, 180, 90)
        path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90)
        path.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90)
        path.AddArc(0, btn.Height - radius, radius, radius, 90, 90)
        path.CloseAllFigures()
        btn.Region = New Region(path)
    End Sub

    Public Sub RoundPanel(panel As Panel, radius As Integer)
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
    ' Public Sub PosPanels(panel As Panel)
    'Dim xPosition As Integer = 442
    'Dim yPosition As Integer = 25


    '  panel.Location = New Point(xPosition, yPosition)


    ' End Sub

    Public Sub posProfPic(picture As PictureBox)
        Dim x As Integer = 1300
        Dim y As Integer = 18

        picture.Location = New Point(x, y)


    End Sub

    Public Sub BookPosition(button As Button)
        Dim x As Integer = 320
        Dim y As Integer = 590

        button.Location = New Point(x, y)
    End Sub


    '  Public Sub panelProfilepos(panel As Panel)
    'Dim x As Integer = 1300
    'Dim y As Integer = 25

    'panel.Location = New Point(x, y)

    'End Sub

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

'colors ng buttons or panels
Module GradientHelper
    Public Sub DrawGradientButton(sender As Object, e As PaintEventArgs, color1 As Color, color2 As Color, Optional direction As Drawing2D.LinearGradientMode = Drawing2D.LinearGradientMode.Horizontal)
        Dim btn As Button = CType(sender, Button)
        Dim rect As Rectangle = btn.ClientRectangle

        Using brush As New Drawing2D.LinearGradientBrush(rect, color1, color2, direction)
            e.Graphics.FillRectangle(brush, rect)
        End Using

        TextRenderer.DrawText(e.Graphics, btn.Text, btn.Font, rect, btn.ForeColor, TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter)
    End Sub

End Module


'syempre font color nakalgay na eh
Module fontcolor

    Public Sub buttonTextColor(button As Button)
        button.ForeColor = Color.FromArgb(52, 52, 52)
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
