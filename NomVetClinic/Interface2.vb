Public Class Interface2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GradientHelper.pictureBox1Color(pctLocation)
        positonsPanels.locPostion(pctLocation)
    End Sub



    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pctLocation.Click
        Dim localMap As New Location
        localMap.Show()
        Form1.Hide()
    End Sub
End Class
