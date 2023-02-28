' Raspberry Pi Foundation
' Developed as part of Ada Computer Science
' Usage licensed under CC BY-NC-SA 4.0
' To run this file you need to:
' 1. Copy the contents
' 2. Paste them into the Visual Basic IDE of your choice (Visual Studio, for example)
' 3. Compile the program
' 4. Run the program


Module Program

    ' The Main subroutine is the default entry point for a VB program
    Sub Main()
        Dim index As Integer
        Dim itemToFind As Integer = 3 ' Search for a specific value
        Dim testItems As Integer() = {11, 25, 10, 29, 15, 13, 18} ' Test data

        Console.WriteLine("### Linear search version 1 (for loop) ###")
        Console.WriteLine("[{0}]", String.Join(", ", testItems))

        Console.WriteLine($"The search item is {itemToFind}")
        index = LinearSearchVersion1(testItems, itemToFind)

        If index = -1 Then
            Console.WriteLine($"{itemToFind} was not found in the array")
        Else
            Console.WriteLine($"{itemToFind} was found at index {index}")
        End If
        Console.ReadLine()
    End Sub


    ' A linear search algorithm that iterates through every item in the array
    Function LinearSearchVersion1(ByRef items As Integer(), ByVal searchItem As Integer) As Integer

        ' Declare and initialise the foundIndex variable		
        Dim foundIndex As Integer = -1

        ' Repeat until the end of the array is reached
        For current = 0 To items.Length - 1

            ' Compare the item at the current index to the search item
            If items(current) = searchItem Then
                ' If the item has been found, store the current index 
                foundIndex = current
            End If
        Next
        ' Return the index where the search_item was found or -1 if not found
        Return foundIndex
    End Function


End Module
