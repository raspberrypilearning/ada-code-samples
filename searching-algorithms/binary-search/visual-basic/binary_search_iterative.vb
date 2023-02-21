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
        Dim testItems As Integer() = {10, 11, 13, 15, 18, 25, 29}
        Console.WriteLine("### Binary search (iterative) ###")
        Console.WriteLine("[{0}]", String.Join(", ", testItems))
        Dim testData As Integer = 15  'Test data - item in list
        Dim index As Integer = BinarySearch(testItems, testData)

        If index = -1 Then
            Console.WriteLine($"{testData} was not found in the list")
        Else
            Console.WriteLine($"{testData} was found at index position {index}")
        End If


        testData = 12  'Test data - item not in list
        index = BinarySearch(testItems, testData)

        If index = -1 Then
            Console.WriteLine($"{testData} was not found in the list")
        Else
            Console.WriteLine($"{testData} was found at index position {index}")
        End If
    End Sub

    Function BinarySearch(ByVal items As Integer(), ByVal searchItem As Integer) As Integer
        Dim found As Boolean = False
        Dim foundIndex As Integer = -1
        Dim first As Integer = 0
        Dim last As Integer = items.Length - 1
        Dim midpoint As Integer = 0

        While first <= last AndAlso found = False
            midpoint = (first + last) / 2

            If items(midpoint) = searchItem Then
                foundIndex = midpoint
                found = True
            ElseIf items(midpoint) < searchItem Then
                first = midpoint + 1
            Else
                last = midpoint - 1
            End If
        End While

        Return foundIndex
    End Function


End Module
