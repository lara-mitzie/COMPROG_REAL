Module TemporaryData

    Public Property OwnerName As String
    Public Property EmailAddress As String
    Public Property ContactNumber As Long
    Public Property ownerSex As String
    Public Property ownerAge As Integer

    Public Property Address As String



    Public Property petName As String
    Public Property petSex As String
    Public Property petType As String
    Public Property petWeight As Integer
    Public Property petBirthday As Date
    Public Property petAge As Integer
    Public Property petBreed As String
    Public Property petvacStatus As String
    Public Property petID As String


    Public Property ServiceType As String
    Public Property ServicePrice As Double
    Public Property BookingDate As Date


    Public Property userCode As Integer

    Public LoggedInOwnerID As Integer
    Public LoggedInOwnerName As String

    Public Sub Clear()
        petName = ""
        petSex = ""
        petType = ""
        petAge = 0
        petBirthday = Date.MinValue
        petWeight = 0
        petBreed = ""
        petvacStatus = ""
        ServiceType = ""
        ServicePrice = 0
        BookingDate = Date.MinValue
    End Sub

End Module
