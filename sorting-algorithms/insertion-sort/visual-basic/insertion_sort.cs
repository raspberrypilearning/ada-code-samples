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
        Dim testItems As Integer() = {43, 21, 2, 50, 3, 80, 35, 7, 64}  'Random data
        'Dim testItems As Integer() = new int[] {80, 64, 50, 43, 35, 21, 7, 3, 2};  'Least sorted
        'Dim testItems As Integer() = new int[] {2, 3, 7, 35, 43, 21, 50, 64, 80};  'Nearly sorted
        'Dim testItems As Integer() = new int[] {2, 3, 7, 21, 35, 43, 50, 64, 80};  'Sorted
        Console.WriteLine(vbLf & "### Insertion sort ###")
        Console.WriteLine("Original array")
        Console.WriteLine("[{0}]", String.Join(", ", testItems))
        Dim returnedItems As Integer() = InsertionSort(testItems)
        Console.WriteLine(vbLf & "Sorted array")
        Console.WriteLine("[{0}]", String.Join(", ", returnedItems))
    End Sub

    Function InsertionSort(ByVal items As Integer()) As Integer()
        Dim numItems As Integer = items.Length

        For index As Integer = 1 To numItems - 1
            Dim itemToInsert As Integer = items(index)
            Console.WriteLine($"\nItem to insert: {itemToInsert}")
            Dim position As Integer = index - 1

            While position >= 0 AndAlso items(position) > itemToInsert
                Console.Write("[{0}]", String.Join(", ", items))
                Console.WriteLine($"  Current item: {items(position)} (index {position})")
                items(position + 1) = items(position)
                position = position - 1
            End While

            Console.Write("[{0}]", String.Join(", ", items))
            Console.WriteLine($"  Correct position found at index {position + 1}")
            items(position + 1) = itemToInsert
            Console.Write("[{0}]", String.Join(", ", items))
            Console.WriteLine($"  Item inserted into index {position + 1}")
        Next

        Return items
    End Function


End Module
