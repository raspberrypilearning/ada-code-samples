' Raspberry Pi Foundation
' Usage licensed under CC BY-SA 4
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


    ' Constructor
    Public Sub New(ByVal givenName As String, ByVal givenType As String, ByVal givenColour As String)
        name = givenName
        petType = givenType
        colour = givenColour
        Dim allMoods = {"playful", "hungry", "sleepy"}
        Dim rnd As Random = New Random()
        Dim index = rnd.[Next](allMoods.Length)
        mood = allMoods(index)
        sleeping = False
    End Sub


    Public Function GetName() As String
        Return name
    End Function


    Public Function GetPetType() As String
        Return petType
    End Function


    Public Function GetColour() As String
        Return colour
    End Function


    Public Function GetMood() As String
        Return mood
    End Function


    Public Function IsSleeping() As Boolean
        Return sleeping
    End Function


    Public Sub Describe()
        Console.WriteLine($"I am a {mood}, {colour} {petType} called {name}")
    End Sub


    Public Sub SetName(ByVal newName As String)
        name = newName
    End Sub


    Public Sub SetType(ByVal newType As String)
        petType = newType
    End Sub


    Public Sub SetColour(ByVal newColour As String)
        colour = newColour
    End Sub


    Public Sub Play()
        If sleeping = True Then
            Console.WriteLine("Zzzzzzz. I am sleeping")
        ElseIf mood = "hungry" Then
            Console.WriteLine("I am too hungry to play")
        ElseIf mood = "tired" Then
            Console.WriteLine("I am too tired to play")
        Else
            Console.WriteLine("This is fun, I love playing")
            Dim allMoods = {"playful", "hungry", "sleepy"}
            Dim rnd As Random = New Random()
            Dim index = rnd.[Next](allMoods.Length)
            mood = allMoods(index)
        End If
    End Sub


    Public Sub Feed()
        If sleeping = True Then
            Console.WriteLine("Zzzzzzz. I am sleeping")
        End If
        If mood = "tired" Then
            Console.WriteLine("I am too sleepy to eat anything now")
        ElseIf mood = "playful" Then
            Console.WriteLine("I am not hungry - I want to play")
        Else
            Console.WriteLine("Yum - yum - that tastes great")
            mood = "playful"
        End If
    End Sub


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
