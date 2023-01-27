' Raspberry Pi Foundation
' Usage licensed under CC BY-SA 4
' Note: This file is designed to be copied out and compiled on your machine.
' To run this file you need to:
' 1. Copy the contents
' 2. Paste them into the Visual Basic IDE of your choice (Visual Studio, for example)
' 3. Compile the program
' 4. Run the program


Module Program


    ' The Main method is the default entry point for all VB programs
    Sub Main()
        Console.WriteLine("Enter a name for your pet ")
        Dim petName As String = Console.ReadLine()
        Console.WriteLine($"What type of animal is {petName}? ")
        Dim petType As String = Console.ReadLine()
        Console.WriteLine($"What colour is {petName}? ")
        Dim petColour As String = Console.ReadLine()
        Dim myPet = New Pet(petName, petType, petColour) ' Makes a pet object

        Dim name As String = myPet.GetName()
        If myPet.IsSleeping() = True Then
            Console.WriteLine($"Shhhhhh, {name} is asleep")
        Else
            Console.WriteLine($"{name} is awake")
        End If
    End Sub


End Module

