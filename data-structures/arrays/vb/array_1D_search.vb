' Raspberry Pi Foundation
' Developed as part of Ada Computer Science
' Usage licensed under CC BY-NC-SA 4.0
' Note: This file is designed to be copied out and compiled on your machine.
' To run this file you need to:
' 1. Copy the contents
' 2. Paste them into the Visual Basic IDE of your choice (Visual Studio, for example)
' 3. Compile the program
' 4. Run the program


Module Program

    ' The Main subroutine is the entry point for all VB programs
    Sub Main()
        ' Declare and initialise the array of words
        Dim spellingWords = New String(4) {"me", "do", "it", "her", "him"}

        ' Ask the user for a word to find
        Console.WriteLine("Enter a word to find:")
        Dim wordToFind As String = Console.ReadLine()

        ' Check if the word matches a value in the spelling array
        Dim found = CheckWordExists(spellingWords, wordToFind)

        ' Output the search results
        If found Then
            Console.WriteLine("Word found!")
        Else
            Console.WriteLine("Word not found in the array")
        End If
    End Sub


    ' Return Boolean True if search word is found in the array
    Function CheckWordExists(ByVal spellingWords As String(), ByVal searchWord As String) As Boolean
        Dim i = 0
        Dim isFound = False

        ' Repeat while the search word has not been found
        While Not isFound AndAlso i < spellingWords.Length
            ' Check if the words match
            If spellingWords(i).Equals(searchWord) Then
                isFound = True
            End If
            i += 1 ' Increment the counter
        End While

        Return isFound
    End Function


End Module
