' Raspberry Pi Foundation
' Usage licensed under CC BY-NC-SA 4.0
' Note: This file is designed to be copied out and compiled on your machine.
' To run this file you need to:
' 1. Copy the contents
' 2. Paste them into the Visual Basic IDE of your choice (Visual Studio, for example)
' 3. Compile the program
' 4. Run the program


Module Program


    ' The Main method is the entry point for all C# programs
    Sub Main()
        Console.WriteLine("Enter a name for your pet ")
        Dim petName As String = Console.ReadLine()
        Console.WriteLine($"What type of animal is {petName}? ")
        Dim petType As String = Console.ReadLine()
        Console.WriteLine($"What colour is {petName}? ")
        Dim petColour As String = Console.ReadLine()
        Dim myPet As Pet = New Pet(petName, petType, petColour) ' Makes a pet object
        Dim finished = False
        While finished = False
            ShowGameOptions()
            Console.WriteLine(" What do you want to do? ")
            Dim choice As String = Console.ReadLine()
            Console.WriteLine(vbLf)
            If Equals(choice, "1") Then
                myPet.Feed()
            ElseIf Equals(choice, "2") Then
                myPet.Play()
            ElseIf Equals(choice, "3") Then
                myPet.Sleep()
            ElseIf Equals(choice, "4") Then
                myPet.Wake()
            ElseIf Equals(choice, "5") Then
                Program.ChangePet(myPet)
            ElseIf Equals(choice, "9") Then
                finished = True ' This will cause game to end
                Console.WriteLine("Thanks for playing the pet game")
            Else
                Console.WriteLine("That is not a menu option")
            End If
        End While
    End Sub


    ' Display options for playing game
    Sub ShowGameOptions()
        Console.WriteLine(vbLf)
        Console.WriteLine("  1. Feed your pet")
        Console.WriteLine("  2. Play with your pet")
        Console.WriteLine("  3. Put your pet to bed")
        Console.WriteLine("  4. Wake your pet up")
        Console.WriteLine("  5. Change pet")
        Console.WriteLine("  9. Finish the game")
    End Sub


    ' Allows pet to be changed
    Sub ChangePet(ByVal myPet As Pet)
        Console.WriteLine(vbLf & "Do you want to change the name of your pet(y/n)? ")
        Dim answer As String = Console.ReadLine()
        If Equals(answer.ToLower(), "y") Then
            Console.WriteLine("Enter a new name for your pet ")
            Dim newName As String = Console.ReadLine()
            myPet.SetName(newName)
        End If
        Console.WriteLine(vbLf & "Do you want to change the type of pet you have(y/n)? ")
        answer = Console.ReadLine()
        If Equals(answer.ToLower(), "y") Then
            Dim petName As String = myPet.GetName()
            Console.WriteLine($"What type of animal is {petName}? ")
            Dim newType As String = Console.ReadLine()
            myPet.SetType(newType)
        End If
        Console.WriteLine(vbLf & "Do you want to change the colour of your pet(y/n)? ")
        answer = Console.ReadLine()
        If Equals(answer.ToLower(), "y") Then
            Dim petName As String = myPet.GetName()
            Console.WriteLine($"What colour is {petName}? ")
            Dim newColour As String = Console.ReadLine()
            myPet.SetColour(newColour)
        End If
        Console.WriteLine(vbLf)
        myPet.Describe()
    End Sub


End Module

