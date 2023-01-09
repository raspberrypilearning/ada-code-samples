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
        Dim testItems As Integer() = {11, 25, 10, 29, 15, 13, 18}  ' Test data
        Console.WriteLine("### Linear search version 2 (while loop) ###")
        Console.WriteLine("[{0}]", String.Join(", ", testItems))
        Dim testData As Integer = 15  ' Test data - item in list
        Dim index As Integer = LinearSearchVersion2(testItems, testData)

        If index = -1 Then
            Console.WriteLine($"{testData} was not found in the array")
        Else
            Console.WriteLine($"{testData} was found at index position {index}")
        End If

        testData = 12  ' Test data - item not in list
        index = LinearSearchVersion2(testItems, testData)

        If index = -1 Then
            Console.WriteLine($"{testData} was not found in the array")
        Else
            Console.WriteLine($"{testData} was found at index position {index}")
        End If
    End Sub

    Function LinearSearchVersion2(ByVal items As Integer(), ByVal searchItem As Integer) As Integer
        Dim found_index As Integer = -1
        Dim current As Integer = 0
        Dim found As Boolean = False

        While found = False AndAlso current < items.Length

            If items(current) = searchItem Then
                found_index = current
                found = True
            End If

            current = current + 1
        End While

        Return found_index
    End Function

End Module
