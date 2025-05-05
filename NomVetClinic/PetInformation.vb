Imports MySql.Data.MySqlClient

Public Class petInformation
    Public Property PetID As Integer

    Private Sub petInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Log the pet ID for debugging
        Console.WriteLine("Loading pet information for Pet ID: " & PetID)
        LoadPetData(PetID)
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

                ' Second query: Get latest booking info (IF AVAILABLE)
                LoadLatestBookingInfo(conn)
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

    ' Load the latest booking information (if available)
    Private Sub LoadLatestBookingInfo(conn As MySqlConnection)
        Try
            ' Query to get the most recent booking and its service
            Dim query As String = "
            SELECT 
                b.bookingDate,
                s.serviceName
            FROM 
                bookingtable b
            LEFT JOIN 
                services s ON b.serviceID = s.servicesId
            WHERE 
                b.petID = @petID
            ORDER BY 
                b.bookingDate DESC
            LIMIT 1"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.Add("@petID", MySqlDbType.Int32).Value = PetID

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then



                        ' Pet has booking data
                        lblDateofVIsit.Text = Convert.ToDateTime(reader("bookingDate")).ToString("MMMM dd, yyyy")

                        If Not IsDBNull(reader("serviceName")) Then
                            lblService.Text = reader("serviceName").ToString()
                        Else
                            lblService.Text = "No service specified"
                        End If
                    Else



                        ' No booking data found - set default values
                        lblDateofVIsit.Text = "No visits recorded"
                        lblService.Text = "N/A"
                    End If
                End Using
            End Using
        Catch ex As Exception
            ' Just log the error but don't stop the form from showing
            Console.WriteLine("Error loading booking info: " & ex.Message)

            ' Set default values
            lblDateofVIsit.Text = "No visits recorded"
            lblService.Text = "Error loading service data"
        End Try
    End Sub


End Class