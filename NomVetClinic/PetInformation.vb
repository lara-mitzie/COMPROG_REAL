Imports MySql.Data.MySqlClient

Public Class petInformation
    Public Property PetID As Integer
    Private WithEvents scrollTimer As New Timer With {.Interval = 10}
    Private Sub petInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Log the pet ID for debugging
        Console.WriteLine("Loading pet information for Pet ID: " & PetID)
        LoadPetData(PetID)

        PanelAboveSlide.InitializePanel(pnlAbovebuttons2, TimerPanel2)
        For Each tb As Label In {lblPetName, lblPetType, lblPetAge, lblPetBirthday, lblPetSex, lblPetWeight, lblpetVacStatus, lblPEtBreed}
            tb.BackColor = Color.FromArgb(237, 232, 225)
            tb.ForeColor = Color.FromArgb(173, 159, 155)
        Next
        MakeFormRounded(Me, 55)

    End Sub

    ' Method to load pet data with proper error handling
    Public Sub LoadPetData(petID As Integer)
        Try
            ' Set the ID to the class property
            Me.PetID = petID

            Dim connStr As String = "server=localhost;user id=root;password=rdtimbangMysql1;database=adminmain"
            Using conn As New MySqlConnection(connStr)
                conn.Open()

                ' First query: Get basic pet information (ALWAYS REQUIRED)
                LoadBasicPetInfo(conn)


            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading pet information: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Load the basic pet information (always required)
    Private Sub LoadBasicPetInfo(conn As MySqlConnection)
        Try
            ' Query to get only pet details (no joins)
            Dim query As String = "
            SELECT 
                petName, 
                petSex, 
                petType, 
                petAge, 
                petBirthday, 
                petWeight, 
                petBreed, 
                petVacStatus
            FROM 
                petinformation
            WHERE 
                petID = @petID"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.Add("@petID", MySqlDbType.Int32).Value = PetID

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        ' Display pet information
                        lblPetName.Text = reader("petName").ToString()
                        lblPetSex.Text = reader("petSex").ToString()
                        lblPetType.Text = reader("petType").ToString()
                        lblPetAge.Text = reader("petAge").ToString()

                        ' FIXED: Use the actual petBirthday field
                        If Not IsDBNull(reader("petBirthday")) Then
                            lblPetBirthday.Text = Convert.ToDateTime(reader("petBirthday")).ToString("MMMM dd, yyyy")
                        Else
                            lblPetBirthday.Text = "Not recorded"
                        End If

                        lblPetWeight.Text = reader("petWeight").ToString()
                        lblPEtBreed.Text = reader("petBreed").ToString()
                        lblpetVacStatus.Text = reader("petVacStatus").ToString()
                    Else
                        MessageBox.Show("Pet not found in database. Pet ID: " & PetID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Me.Close()
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading basic pet info: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub pnlAboveTimer_Tick(sender As Object, e As EventArgs) Handles TimerPanel2.Tick
        PanelAboveSlide.SlidePanel(pnlAbovebuttons2, TimerPanel2)
    End Sub



    'pnl Button Mouse enter
    Private Sub pctHomePage_MouseEnter(sender As Object, e As EventArgs) Handles pctMain.MouseEnter
        PanelAboveSlide.MouseEnter(pnlAbovebuttons2, TimerPanel2)
    End Sub


    'pnl Button Mouse Move
    Private Sub MouseMovePanel(sender As Object, e As MouseEventArgs) Handles pctMain.MouseMove
        PanelAboveSlide.MouseMove(pnlAbovebuttons2, e, TimerPanel2)
    End Sub


End Class