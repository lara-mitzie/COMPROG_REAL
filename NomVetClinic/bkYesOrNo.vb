Public Class bkYesOrNo


    ' btn Location
    Private Sub buttonLocation(sender As Object, e As EventArgs) Handles MyBase.Load
        positonsPanels.buttonYes(btnYes)
        positonsPanels.buttonNo(btnNo)
    End Sub

    ' butons rounded
    Private Sub buttonRound(sender As Object, e As EventArgs) Handles MyBase.Load
        MakeButtonRounded(btnYes, 50)
        MakeButtonRounded(btnNo, 50)
    End Sub

    ' Color Buttons
    Private Sub ColorButtons(sender As Object, e As EventArgs) Handles MyBase.Load
        backgroundcolor.yesorno(btnYes)
        backgroundcolor.yesorno(btnNo)
    End Sub

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        Login.Show()
        booking.Close()
    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        Ownerinformation.Show()
        booking.Close()
    End Sub
End Class
