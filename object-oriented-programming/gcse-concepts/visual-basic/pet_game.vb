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


    ' A method for trying to play with the pet
    Public Sub Play()
        If sleeping = True Then
            Console.WriteLine("Zzzzzzz. I am sleeping")
        ElseIf mood = "hungry" Then
            Console.WriteLine("I am too hungry to play")
        ElseIf mood = "tired" Then
            Console.WriteLine("I am too tired to play")
        Else
            Console.WriteLine("This is fun, I love playing")

            ' Randomly choose a new mood
            Dim allMoods = {"playful", "hungry", "tired"}
            Dim rnd As Random = New Random()
            Dim index = rnd.[Next](allMoods.Length)
            mood = allMoods(index)
        End If
    End Sub


    ' A method for trying to feed the pet
    Public Sub Feed()
        If sleeping = True Then
            Console.WriteLine("Zzzzzzz. I am sleeping")
        ElseIf mood = "tired" Then
            Console.WriteLine("I am too sleepy to eat anything now")
        ElseIf mood = "playful" Then
            Console.WriteLine("I am not hungry - I want to play")
        Else
            Console.WriteLine("Yum - yum - that tastes great")
            mood = "playful"
        End If
    End Sub


    ' A method for trying to put the pet to bed
    Public Sub Sleep()
        If mood = "playful" Then
            Console.WriteLine("I am too playful to sleep")
        ElseIf mood = "hungry" Then
            Console.WriteLine("I need something to eat before I can go to sleep")
        Else
            Console.WriteLine("Zzzzzzzz")
            sleeping = True
        End If
    End Sub


    ' A method for trying to wake the pet up
    Public Sub Wake()
        If sleeping = False Then
            Console.WriteLine("I wasn't even asleep!")
        Else
            Console.WriteLine("I am awake and ready to play!")
            sleeping = False
            mood = "playful"
        End If
    End Sub

End Class


Module Program

    ' The Main method is the entry point for all C# programs
    Sub Main()
        ' Ask the user to input the pet's information
        Console.WriteLine("Enter a name for your pet: ")
        Dim petName As String = Console.ReadLine()

        Console.WriteLine($"What type of animal is {petName}? ")
        Dim petType As String = Console.ReadLine()

        Console.WriteLine($"What colour is {petName}? ")
        Dim petColour As String = Console.ReadLine()

        ' Make a new pet object
        Dim myPet As Pet = New Pet(petName, petType, petColour)

        ' Game loop for playing the game
        Dim finished = False
        While finished = False
            ShowGameOptions()

            ' Run a method depending on the user choice
            Console.WriteLine("What do you want to do? ")
            Dim choice As String = Console.ReadLine()
            Console.WriteLine()
            
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
            ElseIf Equals(choice, "6") Then
                ' This will cause game to end
                finished = True
                Console.WriteLine("Thanks for playing the pet game")
            Else
                Console.WriteLine("That is not a menu option")
            End If
        End While
    End Sub


    ' Display options for playing game
    Sub ShowGameOptions()
        Console.WriteLine(vbLf)
        Console.WriteLine(" 1. Feed your pet")
        Console.WriteLine(" 2. Play with your pet")
        Console.WriteLine(" 3. Put your pet to bed")
        Console.WriteLine(" 4. Wake your pet up")
        Console.WriteLine(" 5. Change pet")
        Console.WriteLine(" 6. Finish the game")
    End Sub


    ' Allows pet to be changed
    Sub ChangePet(ByVal myPet As Pet)
        ' Ask the user to change the pet's name
        Console.WriteLine(vbLf & "Do you want to change the name of your pet(y/n)? ")
        Dim answer As String = Console.ReadLine()
        If Equals(answer.ToLower(), "y") Then
            Console.WriteLine("Enter a new name for your pet ")
            Dim newName As String = Console.ReadLine()
            myPet.SetName(newName)
        End If

        ' Ask the user to change the pet's type
        Console.WriteLine(vbLf & "Do you want to change the type of pet you have(y/n)? ")
        answer = Console.ReadLine()
        If Equals(answer.ToLower(), "y") Then
            Dim petName As String = myPet.GetName()
            Console.WriteLine($"What type of animal is {petName}? ")
            Dim newType As String = Console.ReadLine()
            myPet.SetType(newType)
        End If

        ' Ask the user to change the pet's colour
        Console.WriteLine(vbLf & "Do you want to change the colour of your pet(y/n)? ")
        answer = Console.ReadLine()
        If Equals(answer.ToLower(), "y") Then
            Dim petName As String = myPet.GetName()
            Console.WriteLine($"What colour is {petName}? ")
            Dim newColour As String = Console.ReadLine()
            myPet.SetColour(newColour)
        End If

        Console.WriteLine()
        myPet.Describe()
    End Sub


End Module

