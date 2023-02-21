' Raspberry Pi Foundation
' Usage licensed under CC BY-NC-SA 4.0
' Note: This file is designed to be copied out and compiled on your machine.
' To run this file you need to:
' 1. Copy the contents
' 2. Paste them into the Visual Basic IDE of your choice (Visual Studio, for example)
' 3. Compile the program
' 4. Run the program

Module Program

    ' The Main subroutine is the default entry point for a VB program
    Sub Main()
        Console.WriteLine(vbLf & "### Bubble sort version 1 (for loops) ###")
        Dim dataToSort = GetTestData()
        BubbleSortVersion1(dataToSort)
        Console.WriteLine(vbLf & "### Bubble sort version 2 (while and for loops) ###")
        BubbleSortVersion2(dataToSort)
        Console.WriteLine(vbLf & "### Bubble sort version 3 (while and for loops improved) ###")
        BubbleSortVersion3(dataToSort)
    End Sub

    Function GetTestData() As Integer()
        Dim testItems As Integer() = {43, 21, 2, 50, 3, 80, 35, 7, 64} 'Random data
        'Dim testItems As Integer() = {80, 64, 50, 43, 35, 21, 7, 3, 2}; 'Least sorted
        'Dim testItems As Integer() = {2, 3, 7, 35, 43, 21, 50, 64, 80}; 'Nearly sorted
        'Dim testItems As Integer() = {2, 3, 7, 21, 35, 43, 50, 64, 80}; 'Sorted
        Console.Write($"Data: ")
        Console.WriteLine("[{0}]", String.Join(", ", testItems)) 'Display test data
        Return testItems
    End Function

    Sub BubbleSortVersion1(ByVal items As Integer())
        Dim numItems As Integer = items.Length
        Dim passNum As Integer

        For passNum = 1 To numItems - 1
            Dim index As Integer = 0

            For index = 0 To numItems - 2

                If items(index) > items(index + 1) Then
                    Dim temp As Integer = items(index)
                    items(index) = items(index + 1)
                    items(index + 1) = temp
                End If
            Next

            Console.Write($"Pass {passNum}: ")
            Console.Write("[{0}]", String.Join(", ", items))
            Console.WriteLine($"  Comparisons: {index + 1}")
        Next
    End Sub

    Sub BubbleSortVersion2(ByVal items As Integer())
        Dim numItems As Integer = items.Length
        Dim swapped As Boolean = True
        Dim passNum As Integer = 1

        While swapped = True
            swapped = False
            Dim index As Integer = 0

            For index = 0 To numItems - 2

                If items(index) > items(index + 1) Then
                    Dim temp As Integer = items(index)
                    items(index) = items(index + 1)
                    items(index + 1) = temp
                    swapped = True
                End If
            Next

            Console.Write($"Pass {passNum}: ")
            Console.Write("[{0}]", String.Join(", ", items))
            Console.WriteLine($"  Comparisons: {index + 1}")
            passNum = passNum + 1
        End While
    End Sub

    Sub BubbleSortVersion3(ByVal items As Integer())
        Dim numItems As Integer = items.Length
        Dim swapped As Boolean = True
        Dim passNum As Integer = 1

        While swapped = True
            swapped = False
            Dim index As Integer = 0

            For index = 0 To numItems - passNum - 1

                If items(index) > items(index + 1) Then
                    Dim temp As Integer = items(index)
                    items(index) = items(index + 1)
                    items(index + 1) = temp
                    swapped = True
                End If
            Next

            Console.Write($"Pass {passNum}: ")
            Console.Write("[{0}]", String.Join(", ", items))
            Console.WriteLine($"  Comparisons: {index + 1}")
            passNum = passNum + 1
        End While
    End Sub

End Module
