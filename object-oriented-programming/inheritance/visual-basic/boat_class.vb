' Raspberry Pi Foundation
' Usage licensed under CC BY-NC-SA 4.0
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


Module Program

    ' The Main method is the default entry point for all VB programs
    Sub Main()
        Dim name = "Sir David Attenborough"
        Dim length = 128.9F
        Dim capacity = 88
        Dim berths = 90
        Dim cost = 2.0E+8F

        ' Instantiate a new boat object
        Dim boaty As Boat = New Boat(name, length, capacity, berths, cost)
            
        ' Show that the boat object has been created
        Console.WriteLine(boaty);
    End Sub


End Module
