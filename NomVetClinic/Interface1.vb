Public Class Interface1
    Private isMouseOver As Boolean = False
    Private Sub Postions(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler btnBookNow1.Paint, AddressOf btnBookNow_Paint

        MakeButtonRounded(btnBookNow1, 55)
        'positonsPanels.PosPanels(pnlButtons)
        positonsPanels.BookPosition(btnBookNow1)

    End Sub

    'GRADIENT BOOK NOW COLOR CHANGER MWEHHEH
    Private Sub btnBookNow_Paint(sender As Object, e As PaintEventArgs)
        If isMouseOver Then
            GradientHelper.DrawGradientButton(sender, e, Color.FromArgb(0, 151, 178), Color.FromArgb(126, 217, 87), Drawing2D.LinearGradientMode.Horizontal)
        Else
            GradientHelper.DrawGradientButton(sender, e, Color.FromArgb(126, 217, 87), Color.FromArgb(0, 151, 178), Drawing2D.LinearGradientMode.Horizontal)
        End If
    End Sub

    Private Sub btnBookNow_MouseEnter(sender As Object, e As EventArgs) Handles btnBookNow1.MouseEnter
        isMouseOver = True
        btnBookNow1.Invalidate() '
    End Sub

    Private Sub btnBookNow_MouseLeave(sender As Object, e As EventArgs) Handles btnBookNow1.MouseLeave
        isMouseOver = False
        btnBookNow1.Invalidate()
    End Sub

    Private Sub btnBookNow1_Click(sender As Object, e As EventArgs) Handles btnBookNow1.Click

        booking.Show()
        Form1.Hide()
    End Sub




End Class
