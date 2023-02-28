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

    ' The Main subroutine is the default entry point for a VB program
    Sub Main()
        Dim dataToSort = GetTestData()
        Console.WriteLine(vbLf & "### Bubble sort (while and for loops improved) ###")
        BubbleSort(dataToSort)
        dataToSort = GetTestData()
        Console.WriteLine(vbLf & "### Insertion sort ###")
        InsertionSort(dataToSort)
    End Sub

    Function GetTestData() As Integer()
        Dim testItems As Integer() = New Integer() {43, 21, 2, 50, 3, 80, 35, 7, 64}  'Random
        'Dim testItems As Integer() = {80, 64, 50, 43, 35, 21, 7, 3, 2} 'Least sorted
        'Dim testItems As Integer() = {2, 3, 7, 35, 43, 21, 50, 64, 80} 'Nearly sorted
        'Dim testItems As Integer() = {2, 3, 7, 21, 35, 43, 50, 64, 80} 'Sorted
        Console.Write($"Data: ")
        Console.WriteLine("[{0}]", String.Join(", ", testItems))
        Return testItems
    End Function

    Sub BubbleSort(ByVal items As Integer())
        Dim numItems As Integer = items.Length
        Dim swapped As Boolean = True
        Dim passNum As Integer = 1
        Dim totalComparisons As Integer = 0

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

                totalComparisons = totalComparisons + 1
            Next

            Console.Write($"Pass {passNum}: ")
            Console.Write("[{0}]", String.Join(", ", items))
            Console.WriteLine($"  Comparisons: {index}")
            passNum = passNum + 1
        End While

        Console.WriteLine($"Total comparisons: {totalComparisons}")
    End Sub

    Sub InsertionSort(ByVal items As Integer())
        Dim numItems As Integer = items.Length
        Dim totalComparisons As Integer = 0

        For index As Integer = 1 To numItems - 1
            Dim itemToInsert As Integer = items(index)
            Dim position As Integer = index - 1
            Dim comparisons As Integer = 1
            totalComparisons = totalComparisons + 1

            While position >= 0 AndAlso items(position) > itemToInsert
                items(position + 1) = items(position)
                position = position - 1
                comparisons = comparisons + 1
                totalComparisons = totalComparisons + 1
            End While

            items(position + 1) = itemToInsert
            Console.Write($"Pass {index}: ")
            Console.Write("[{0}]", String.Join(", ", items))
            Console.WriteLine($"  Comparisons: {comparisons}")
        Next

        Console.WriteLine($"Total comparisons: {totalComparisons}")
    End Sub

End Module
