' Raspberry Pi Foundation
' Usage licensed under CC BY-SA 4
' Note: This file is designed to be copied out and compiled on your machine.
' To run this file you need to:
' 1. Copy the contents
' 2. Paste them into the Visual Basic IDE of your choice (Visual Studio, for example)
' 3. Compile the program
' 4. Run the program

Module Program

    ' The Main subroutine is the default entry point for a VB program
    Sub Main()
        Dim testItems As Integer() = {43, 21, 2, 50, 3, 80, 35, 7, 64} 'Array of test data
        'Dim testItems As Integer() = {80, 64, 50, 43, 35, 21, 7, 3, 2}; 'Least sorted
        'Dim testItems As Integer() = {2, 3, 7, 35, 43, 21, 50, 64, 80}; 'Nearly sorted
        'Dim testItems As Integer() = {2, 3, 7, 21, 35, 43, 50, 64, 80}; 'Sorted
        'Dim testItems As Integer() = {43, 21, 2, 50, 3, 80, 35, 7, 64}; 'Random
        Console.WriteLine("### Bubble sort version 3 (while and for loops improved) ###")
        Console.WriteLine("[{0}]", String.Join(", ", testItems)) 'Display array of test data
        BubbleSortVersion3(testItems)
    End Sub

    Sub BubbleSortVersion3(ByVal items As Integer())
        Dim numItems As Integer = items.Length
        Dim swapped As Boolean = True
        Dim passNum As Integer = 1

        While swapped = True
            swapped = False

            For index As Integer = 0 To numItems - passNum - 1

                If items(index) > items(index + 1) Then
                    Dim temp As Integer = items(index)
                    items(index) = items(index + 1)
                    items(index + 1) = temp
                    swapped = True
                End If
            Next

            passNum = passNum + 1
            Console.WriteLine("[{0}]", String.Join(", ", items))
        End While
    End Sub

End Module
