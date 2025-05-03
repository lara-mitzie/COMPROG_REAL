Public Class petInfo


    Private isMouseOver As Boolean = False
    Private WithEvents scrollTimer As New Timer With {.Interval = 10}

    Private selectedSex As String = ""
    Private selectedPetType As String = ""


    Private breedsList As New Dictionary(Of String, List(Of String))

    Private Sub PopulateBreedsList()
        ' Initialize breed lists for each pet type
        breedsList = New Dictionary(Of String, List(Of String))

        ' Canine breeds
        Dim canineBreeds As New List(Of String)
        canineBreeds.AddRange(New String() {
            "Labrador Retriever", "German Shepherd", "Golden Retriever", "Bulldog", "Beagle",
            "Poodle", "Rottweiler", "Yorkshire Terrier", "Boxer", "Dachshund",
            "Shih Tzu", "Siberian Husky", "Chihuahua", "Great Dane", "Doberman",
            "Maltese", "Pomeranian", "Pug", "Cocker Spaniel", "Border Collie"
        })
        canineBreeds.Sort()
        breedsList.Add("Canine", canineBreeds)

        ' Feline breeds
        Dim felineBreeds As New List(Of String)
        felineBreeds.AddRange(New String() {
            "Persian", "Maine Coon", "Siamese", "Bengal", "Ragdoll",
            "British Shorthair", "Sphynx", "Scottish Fold", "Norwegian Forest Cat", "Abyssinian",
            "Russian Blue", "Burmese", "Oriental Shorthair", "Devon Rex", "Himalayan"
        })
        felineBreeds.Sort()
        breedsList.Add("Feline", felineBreeds)

        ' Reptile types
        Dim reptileBreeds As New List(Of String)
        reptileBreeds.AddRange(New String() {
            "Bearded Dragon", "Ball Python", "Leopard Gecko", "Corn Snake", "Red-Eared Slider",
            "Green Iguana", "Crested Gecko", "Boa Constrictor", "Chameleon", "Blue-Tongued Skink",
            "Water Dragon", "Uromastyx", "Milk Snake", "Tegu", "Garter Snake"
        })
        reptileBreeds.Sort()
        breedsList.Add("Reptile", reptileBreeds)
    End Sub

    Private Sub SetupBreedAutocomplete()
        ' Set up autocomplete for the breed textbox
        txtBreed.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txtBreed.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtBreed.AutoCompleteCustomSource = New AutoCompleteStringCollection()
    End Sub

    ' Modify your existing pet type button click methods to update the breed suggestions



    ' Update this method to not reset the breed textbox when updating suggestions
    Private Sub UpdateBreedAutocompleteSource()
        ' Create a new autocomplete source
        Dim autoCompleteSource As New AutoCompleteStringCollection()

        ' If we have breeds for this pet type, add them to the source
        If breedsList.ContainsKey(selectedPetType) Then
            autoCompleteSource.AddRange(breedsList(selectedPetType).ToArray())
        End If

        ' Update the textbox's autocomplete source
        txtBreed.AutoCompleteCustomSource = autoCompleteSource

        ' Only reset the text if it's not empty and not the placeholder
        If Not String.IsNullOrEmpty(txtBreed.Text) AndAlso txtBreed.Text <> CStr(txtBreed.Tag) Then
            ' If user was already typing something, clear it when pet type changes
            txtBreed.Text = ""
        End If
    End Sub





    Private Sub MainLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler btnNext.Paint, AddressOf btnBookNow_Paint
        PanelAboveSlide.InitializePanel(pnlAbovebuttons3, pnlTimer7)
        Me.WindowState = FormWindowState.Maximized
        PopulateBreedsList()
        SetupBreedAutocomplete()

        'Font Color Button
        For Each tb As Button In {btnMale, btnFemale, btnFeline, btnCanine, btnReptile}
            tb.ForeColor = Color.FromArgb(138, 120, 120)
        Next

        'Back Color Button
        For Each tb As Button In {btnMale, btnFemale, btnFeline, btnCanine, btnReptile}
            tb.BackColor = Color.FromArgb(239, 232, 224)
        Next

        'Back COlor TExtBOx
        cbVetStat.BackColor = Color.FromArgb(239, 232, 224)
        For Each tb As TextBox In {txtPetName, txtAge, txtWeight, txtBreed, txtGetDate, txtgetVac}
            tb.BackColor = Color.FromArgb(239, 232, 224)
        Next

        'font color textbox
        cbVetStat.ForeColor = Color.FromArgb(138, 120, 120)
        For Each tb As TextBox In {txtPetName, txtAge, txtWeight, txtBreed, txtGetDate, txtgetVac}
            tb.ForeColor = Color.FromArgb(138, 120, 120)
        Next


        'Panel Positions
        positonsPanels.txtPetNamePI(txtPetName)
        positonsPanels.dtpBirthdayPI(dtpBirthday)
        positonsPanels.txtAgePI(txtAge)
        positonsPanels.txtWeightPI(txtWeight)
        positonsPanels.btnMalePI(btnMale)
        positonsPanels.btnFemalePI(btnFemale)
        positonsPanels.btnFelinePI(btnFeline)
        positonsPanels.btnCaninePI(btnCanine)
        positonsPanels.btnReptilePI(btnReptile)
        positonsPanels.txtBreedPI(txtBreed)
        positonsPanels.cbVacStatusPI(cbVetStat)
        positonsPanels.btnNextPI(btnNext)
        positonsPanels.txtGetDatePI(txtGetDate)
        positonsPanels.btnBackPI(btnBack)
        positonsPanels.getVacStasPI(txtgetVac)


        'Making Button ROunded
        MakeButtonRounded(btnMale, 45)
        MakeButtonRounded(btnFemale, 45)
        MakeButtonRounded(btnFeline, 45)
        MakeButtonRounded(btnCanine, 45)
        MakeButtonRounded(btnReptile, 45)
        MakeButtonRounded(btnNext, 45)



        'Labels for textboox

        txtPetName.Tag = "PET NAME"
        txtPetName.Text = CStr(txtPetName.Tag)
        txtAge.Tag = "AGE"
        txtAge.Text = CStr(txtAge.Tag)
        txtBreed.Tag = "BREED"
        txtBreed.Text = CStr(txtBreed.Tag)
        txtWeight.Tag = "WEIGHT(kg)"
        txtWeight.Text = CStr(txtWeight.Tag)
        txtGetDate.Text = "BIRTHDAY"
        txtgetVac.Text = "VACCINATION"



        'Para Lumabas ulit yung mga text ex: USername

        If Not String.IsNullOrWhiteSpace(TemporaryData.petName) Then
            txtPetName.Text = TemporaryData.petName
        Else
            txtPetName.Text = CStr(txtPetName.Tag)
        End If

        If TemporaryData.petAge <> 0 Then
            txtAge.Text = TemporaryData.petAge
        Else
            txtAge.Text = CStr(txtAge.Tag)
        End If

        If Not String.IsNullOrWhiteSpace(TemporaryData.petBreed) Then
            txtBreed.Text = TemporaryData.Address
        Else
            txtBreed.Text = CStr(txtBreed.Tag)
        End If

        If TemporaryData.petWeight <> 0 Then
            txtWeight.Text = TemporaryData.petWeight.ToString()
        Else
            txtWeight.Text = CStr(txtWeight.Tag)
        End If


        For Each tb As TextBox In {txtPetName, txtAge, txtBreed, txtWeight}
            tb.ForeColor = Color.FromArgb(138, 120, 120)
        Next



        'Button Back Color

        For Each tb As Button In {btnMale, btnFemale, btnFeline, btnCanine, btnReptile}
            tb.BackColor = Color.FromArgb(239, 232, 224)
        Next



    End Sub



    Private Sub nextCLcike(sender As Object, e As EventArgs) Handles btnNext.Click

        TemporaryData.petName = txtPetName.Text
        TemporaryData.petSex = selectedSex
        TemporaryData.petType = selectedPetType
        TemporaryData.petWeight = CInt(txtWeight.Text)
        TemporaryData.petBirthday = dtpBirthday.Text
        TemporaryData.petAge = CInt(txtAge.Text)
        TemporaryData.petBreed = txtBreed.Text
        TemporaryData.petvacStatus = cbVetStat.Text

    End Sub


    Private Sub dtpBirthday_ValueChanged(sender As Object, e As EventArgs) Handles dtpBirthday.ValueChanged
        Dim birthDate As Date = dtpBirthday.Value
        Dim today As Date = Date.Today

        Dim age As Integer = today.Year - birthDate.Year

        If birthDate > today Then
            MessageBox.Show("Birthday cannot be in the future.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAge.Text = ""
            Exit Sub
        Else
            txtGetDate.Text = dtpBirthday.Value.ToString("MM/dd/yyyy")
        End If


        If birthDate > today.AddYears(-age) Then
            age -= 1
        End If

        txtAge.Text = age.ToString()
    End Sub


    Private Sub btnMale_Click(sender As Object, e As EventArgs) Handles btnMale.Click
        selectedSex = "Male"
        highlightGender()
    End Sub


    Private Sub btnFemale_Click(sender As Object, e As EventArgs) Handles btnFemale.Click
        selectedSex = "Female"
        highlightGender()
    End Sub

    Private Sub btnCaline_Click(sender As Object, e As EventArgs) Handles btnCanine.Click
        selectedPetType = "Canine"
        highlightType()
        UpdateBreedAutocompleteSource() ' Add this line
    End Sub

    Private Sub btnFeline_Click(sender As Object, e As EventArgs) Handles btnFeline.Click
        selectedPetType = "Feline"
        highlightType()
        UpdateBreedAutocompleteSource() ' Add this line
    End Sub

    Private Sub btnReptile_Click(sender As Object, e As EventArgs) Handles btnReptile.Click
        selectedPetType = "Reptile"
        highlightType()
        UpdateBreedAutocompleteSource() ' Add this line
    End Sub

    Private Sub highlightGender()
        btnMale.BackColor = If(selectedSex = "Male", Color.FromArgb(255, 227, 196), Color.FromArgb(239, 232, 224))
        btnFemale.BackColor = If(selectedSex = "Female", Color.FromArgb(255, 227, 196), Color.FromArgb(239, 232, 224))
    End Sub

    Private Sub highlightType()
        btnCanine.BackColor = If(selectedPetType = "Canine", Color.FromArgb(255, 227, 196), Color.FromArgb(239, 232, 224))
        btnFeline.BackColor = If(selectedPetType = "Feline", Color.FromArgb(255, 227, 196), Color.FromArgb(239, 232, 224))
        btnReptile.BackColor = If(selectedPetType = "Reptile", Color.FromArgb(255, 227, 196), Color.FromArgb(239, 232, 224))

    End Sub



    Private Sub TextBox_VAcStatus_TExtChange(sender As Object, e As EventArgs) Handles cbVetStat.TextChanged
        txtgetVac.Text = cbVetStat.Text
    End Sub



    Private Sub TextBox_Enter(sender As Object, e As EventArgs) Handles txtPetName.Enter, txtAge.Enter, txtBreed.Enter, txtWeight.Enter, txtGetDate.Enter, txtgetVac.Enter
        Dim tb As TextBox = CType(sender, TextBox)
        If tb.Text = CStr(tb.Tag) Then
            tb.Text = ""
            tb.ForeColor = Color.FromArgb(138, 120, 120)

            ' If this is the breed textbox and a pet type is selected, update the autocomplete
            If tb Is txtBreed AndAlso Not String.IsNullOrEmpty(selectedPetType) Then
                UpdateBreedAutocompleteSource()
            End If
        End If
    End Sub

    Private Sub TextBox_Leave(sender As Object, e As EventArgs) Handles txtPetName.Leave, txtAge.Leave, txtBreed.Leave, txtWeight.Leave, txtGetDate.Leave, txtgetVac.Enter
        Dim tb As TextBox = CType(sender, TextBox)
        If tb.Text.Trim() = "" Then
            tb.Text = CStr(tb.Tag)
            tb.ForeColor = Color.FromArgb(138, 120, 120)
        End If
    End Sub


    Private Sub btnBookNow_Paint(sender As Object, e As PaintEventArgs)
        If isMouseOver Then
            GradientHelper.DrawGradientButton(sender, e, Color.FromArgb(0, 151, 178), Color.FromArgb(126, 217, 87), Drawing2D.LinearGradientMode.Horizontal)
        Else
            GradientHelper.DrawGradientButton(sender, e, Color.FromArgb(126, 217, 87), Color.FromArgb(0, 151, 178), Drawing2D.LinearGradientMode.Horizontal)
        End If
    End Sub

    Private Sub btnBookNow_MouseEnter(sender As Object, e As EventArgs) Handles btnNext.MouseEnter
        isMouseOver = True
        btnNext.Invalidate() ' Force the button to repaint
    End Sub

    Private Sub btnBookNow_MouseLeave(sender As Object, e As EventArgs) Handles btnNext.MouseLeave
        isMouseOver = False
        btnNext.Invalidate() ' Force the button to repaint
    End Sub

    Private Sub pnlAboveTimer_Tick(sender As Object, e As EventArgs) Handles pnlTimer7.Tick
        PanelAboveSlide.SlidePanel(pnlAbovebuttons3, pnlTimer7)
    End Sub


    'pnl Button Mouse enter
    Private Sub pctHomePage_MouseEnter(sender As Object, e As EventArgs) Handles pctMain.MouseEnter
        PanelAboveSlide.MouseEnter(pnlAbovebuttons3, pnlTimer7)
    End Sub


    'pnl Button Mouse Move
    Private Sub MouseMovePanel(sender As Object, e As MouseEventArgs) Handles pctMain.MouseMove
        PanelAboveSlide.MouseMove(pnlAbovebuttons3, e, pnlTimer7)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        Form1.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Ownerinformation.Show()
        Me.Close()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If txtPetName.Text = CStr(txtPetName.Tag) OrElse String.IsNullOrWhiteSpace(txtPetName.Text) Then
            MessageBox.Show("Pet Name cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If txtBreed.Text = CStr(txtBreed.Tag) OrElse String.IsNullOrWhiteSpace(txtBreed.Text) Then
            MessageBox.Show("Breed cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Not txtWeight.Text.All(Function(c) Char.IsDigit(c)) Then
            MessageBox.Show("Weight must contain only numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Not txtAge.Text.All(Function(c) Char.IsDigit(c)) Then
            MessageBox.Show("Age must contain only numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
    End Sub



End Class