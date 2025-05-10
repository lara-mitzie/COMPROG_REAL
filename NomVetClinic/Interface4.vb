Public Class Interface4

    Private Sub Mainloadont4(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim lbl As Label() = {lblAboutUs, lblHome, lblServices, lblInfo}

        For Each tb As Label In lbl
            tb.ForeColor = Color.FromArgb(80, 89, 80)
            tb.BackColor = Color.FromArgb(204, 185, 163)

        Next

    End Sub

    Private Sub lblHomepageEnter(sender As Object, e As EventArgs) Handles lblHome.MouseEnter
        lblHome.Font = New Font(lblHome.Font, FontStyle.Underline)
    End Sub


    Private Sub lblHomepageLeave(sender As Object, e As EventArgs) Handles lblHome.MouseLeave
        lblHome.Font = New Font(lblHome.Font, FontStyle.Regular)
    End Sub



    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblHome.Click

        Dim mainForm As Form1 = CType(Me.FindForm(), Form1)
        mainForm.GoToPage(mainForm.homePage, "Interface1")
    End Sub


    Private Sub lblInfoEnter(sender As Object, e As EventArgs) Handles lblInfo.MouseEnter
        lblInfo.Font = New Font(lblInfo.Font, FontStyle.Underline)
    End Sub


    Private Sub lblInfoLeave(sender As Object, e As EventArgs) Handles lblInfo.MouseLeave
        lblInfo.Font = New Font(lblInfo.Font, FontStyle.Regular)
    End Sub

    Private Sub lblInfo_Click(sender As Object, e As EventArgs) Handles lblInfo.Click
        Dim mainForm As Form1 = CType(Me.FindForm(), Form1)
        mainForm.GoToPage(mainForm.animalsPage, "Interface2")
    End Sub



    Private Sub lblServicesEnter(sender As Object, e As EventArgs) Handles lblServices.MouseEnter
        lblServices.Font = New Font(lblServices.Font, FontStyle.Underline)
    End Sub


    Private Sub lblServicesLeave(sender As Object, e As EventArgs) Handles lblServices.MouseLeave
        lblServices.Font = New Font(lblServices.Font, FontStyle.Regular)
    End Sub

    Private Sub lblServices_Click(sender As Object, e As EventArgs) Handles lblServices.Click
        Dim mainForm As Form1 = CType(Me.FindForm(), Form1)
        mainForm.GoToPage(mainForm.page3, "Interface3")
    End Sub


    Private Sub lblAboutUseEnter(sender As Object, e As EventArgs) Handles lblAboutUs.MouseEnter
        lblAboutUs.Font = New Font(lblAboutUs.Font, FontStyle.Underline)
    End Sub


    Private Sub lblAboutUsLeave(sender As Object, e As EventArgs) Handles lblAboutUs.MouseLeave
        lblAboutUs.Font = New Font(lblAboutUs.Font, FontStyle.Regular)
    End Sub

    Private Sub lblAboutUs_Click(sender As Object, e As EventArgs) Handles lblAboutUs.Click
        Dim mainForm As Form1 = CType(Me.FindForm(), Form1)
        mainForm.GoToPage(mainForm.AboutUs, "Interface4")
    End Sub
End Class
