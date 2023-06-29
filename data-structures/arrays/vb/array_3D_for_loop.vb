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
        ' Declare and initialise the three-dimensional array of words
        Dim spellingWords = New String(1, 2, 4) {
            {
                {"me", "do", "her", "it", "him"},
                {"put", "ask", "says", "red", "any"},
                {"they", "where", "friend", "fast", "class"}
            },
            {
                {"door", "find", "most", "bath", "eye"},
                {"every", "great", "climb", "prove", "behind"},
                {"clothes", "again", "improve", "should", "parents"}
            }
        }


        ' Output every word in the array
        Console.WriteLine("Display each word along with the year group and level:")
        DisplayAllWords(spellingWords)
    End Sub


    ' Display the words of each year and level in the 3D array
    Sub DisplayAllWords(ByVal spellingWords As String(,,))

        ' Repeat for each year
        Dim numYears = spellingWords.GetLength(0)
        For i = 0 To numYears - 1
            Dim yearNum = i + 1  ' Year index starts from 0
            Console.WriteLine($"### Year {yearNum} ###")

            ' Repeat for each level
            Dim numLevels = spellingWords.GetLength(1)
            For j = 0 To numLevels - 1
                Dim levelNum = j + 1  ' Level index starts from 0
                Console.WriteLine($"Level {levelNum}:")

                ' Output each word for the current year and level
                Dim numWords = spellingWords.GetLength(2)
                For k = 0 To numWords - 1
                    Console.WriteLine(spellingWords(i, j, k))
                Next
            Next
        Next
    End Sub


End Module
