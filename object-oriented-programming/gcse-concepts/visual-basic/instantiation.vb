' Raspberry Pi Foundation
' Usage licensed under CC BY-NC-SA 4.0
' Note: This file is designed to be copied out and compiled on your machine.
' To run this file you need to:
' 1. Copy the contents
' 2. Paste them into the Visual Basic IDE of your choice (Visual Studio, for example)
' 3. Compile the program
' 4. Run the program

Class Pet

    Private name As String
    Private petType As String
    Private colour As String
    Private mood As String
    Private sleeping As Boolean

    ' Constructor method
    Public Sub New(ByVal givenName As String, ByVal givenType As String, ByVal givenColour As String)
        name = givenName
        petType = givenType
        colour = givenColour
        sleeping = False

        ' Randomly choose a starting mood
        Dim allMoods = {"playful", "hungry", "tired"}
        Dim rnd As Random = New Random()
        Dim index = rnd.[Next](allMoods.Length)
        mood = allMoods(index)
    End Sub

    Public Function GetName() As String
        Return name
    End Function

    Public Sub SetName(ByVal newName As String)
        name = newName
    End Sub

    Public Function GetPetType() As String
        Return petType
    End Function

    Public Sub SetPetType(ByVal newType As String)
        petType = newType
    End Sub

    Public Function GetColour() As String
        Return colour
    End Function

    Public Sub SetColour(ByVal newColour As String)
        colour = newColour
    End Sub

    Public Function GetMood() As String
        Return mood
    End Function

    Public Function IsSleeping() As Boolean
        Return sleeping
    End Function

    Public Sub Describe()
        Console.WriteLine($"I am a {mood}, {colour} {petType} called {name}")
    End Sub

End Class


Module program

    ' The Main method is the default entry point for all VB programs
    Sub Main()
        ' Ask the user to input the pet's information
        Console.WriteLine("Enter a name for your pet ")
        Dim petName As String = Console.ReadLine()

        Console.WriteLine($"What type of animal is {petName}? ")
        Dim petType As String = Console.ReadLine()

        Console.WriteLine($"What colour is {petName}? ")
        Dim petColour As String = Console.ReadLine()

        ' Make a new pet object
        Dim myPet = New Pet(petName, petType, petColour)
        
        ' Show that the pet object has been created
        Console.WriteLine(myPet)
    End Sub


End Module
