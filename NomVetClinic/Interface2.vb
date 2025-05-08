Public Class Interface2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GradientHelper.pictureBox1Color(pctLocation)
        positonsPanels.locPostion(pctLocation)
        MakePictureBoxRounded(pctLocation, 48)
    End Sub



    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pctLocation.Click
        Dim localMap As New Location
        localMap.Show()
        Form1.Hide()
    End Sub

    Private Sub pctMouseEnter(sender As Object, e As EventArgs) Handles pctLocation.MouseEnter
        pctLocation.BackColor = Color.FromArgb(220, 205, 187)
    End Sub

    Private Sub pctMouseLeave(sender As Object, e As EventArgs) Handles pctLocation.MouseLeave
        pctLocation.BackColor = Color.FromArgb(240, 234, 226)
    End Sub



End Class
