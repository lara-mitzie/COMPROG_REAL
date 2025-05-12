Imports MySql.Data.MySqlClient

Public Class search



    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        ' Clear anything previously shown
        pnlContainer.Controls.Clear()

        ' Create and configure the dashboard control
        Dim dash As New dashboard()
        dash.Dock = DockStyle.Fill

        ' Show the dashboard in the panel
        pnlContainer.Controls.Add(dash)
    End Sub

    Private Sub btnAppointment_Click(sender As Object, e As EventArgs) Handles btnAppointment.Click
        pnlContainer.Controls.Clear()
        Dim app As New appointment()
        app.Dock = DockStyle.Fill
        pnlContainer.Controls.Add(app)
    End Sub

    Private Sub btnPetowner_Click(sender As Object, e As EventArgs) Handles btnPetowner.Click
        pnlContainer.Controls.Clear()
        Dim owner As New petowner()
        owner.Dock = DockStyle.Fill
        pnlContainer.Controls.Add(owner)
    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        pnlContainer.Controls.Clear()
        Dim hist As New history()
        hist.Dock = DockStyle.Fill
        pnlContainer.Controls.Add(hist)
    End Sub
End Class

