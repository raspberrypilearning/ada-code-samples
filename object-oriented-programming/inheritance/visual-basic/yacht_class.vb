' Raspberry Pi Foundation
' Usage licensed under CC BY-SA 4
' Note: This file is designed to be copied out and compiled on your machine.
' To run this file you need to:
' 1. Copy the contents
' 2. Paste them into the Visual Basic IDE of your choice (Visual Studio, for example)
' 3. Compile the program
' 4. Run the program


Class Boat

    Private name As String
    Private length As Single
    Private capacity As Integer
    Private berths As Integer
    Protected unitCost As Single

    ' Constructor method
    Public Sub New(ByVal givenName As String, ByVal givenLength As Single, ByVal givenCapacity As Integer, ByVal givenBerths As Integer, ByVal givenUnitCost As Single)
        name = givenName
        length = givenLength
        capacity = givenCapacity
        berths = givenBerths
        unitCost = givenUnitCost
    End Sub

End Class


Class Yacht
    Inherits Boat  ' Inherits from Boat

    Private masts As Integer

    ' Constructor method
    Public Sub New(ByVal givenName As String, ByVal givenLength As Single, ByVal givenCapacity As Integer, ByVal givenBerths As Integer, ByVal givenUnitCost As Single, ByVal givenMasts As Integer)
        MyBase.New(givenName, givenLength, givenCapacity, givenBerths, givenUnitCost)
        masts = givenMasts
    End Sub

End Class


Module Program

    ' The Main method is the default entry point for all VB programs
    Sub Main()
        Dim myYacht As Yacht = New Yacht("Mary Sue", 15.7F, 300, 6, 54.5F, 2)
    End Sub


End Module
