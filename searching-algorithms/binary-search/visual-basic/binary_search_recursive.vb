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
        Dim testItems As Integer() = {10, 11, 13, 15, 18, 25, 29}  ' Test data
        Dim firstIndex As Integer = 0
        Dim lastIndex As Integer = testItems.Length - 1
        Console.WriteLine("### Binary search (recursive) ###")
        Console.WriteLine("[{0}]", String.Join(", ", testItems))
        Dim testData As Integer = 15  ' Test data
        Dim index As Integer = BinarySearchRecursive(testItems, testData, firstIndex, lastIndex)

        If index = -1 Then
            Console.WriteLine($"{testData} was not found in the list")
        Else
            Console.WriteLine($"{testData} was found at index position {index}")
        End If

        testData = 12  ' Test data
        index = BinarySearchRecursive(testItems, testData, firstIndex, lastIndex)

        If index = -1 Then
            Console.WriteLine($"{testData} was not found in the list")
        Else
            Console.WriteLine($"{testData} was found at index position {index}")
        End If
    End Sub

    Function BinarySearchRecursive(ByVal items As Integer(), ByVal searchItem As Integer, ByVal first As Integer, ByVal last As Integer) As Integer
        If first > last Then
            Return -1
        Else
            Dim midpoint As Integer = (first + last) \ 2

            If items(midpoint) = searchItem Then
                Return midpoint
            ElseIf searchItem > items(midpoint) Then
                first = midpoint + 1
                Return BinarySearchRecursive(items, searchItem, first, last)
            Else
                last = midpoint - 1
                Return BinarySearchRecursive(items, searchItem, first, last)
            End If
        End If
    End Function


End Module

