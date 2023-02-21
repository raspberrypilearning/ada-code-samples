' Raspberry Pi Foundation
' Usage licensed under CC BY-NC-SA 4.0
' Note: This file is designed to be copied out and compiled on your machine.
' To run this file you need to:
' 1. Copy the contents
' 2. Paste them into the Visual Basic IDE of your choice (Visual Studio, for example)
' 3. Compile the program
' 4. Run the program

Module Program

    ' The Main subroutine is the default entry point for a VB programModule Program
    Sub Main()
        Dim testItems As Integer() = {43, 21, 2, 50, 3, 80, 35, 7, 64}  'Test data - random
        ' Dim testItems As Integer() =  {80, 64, 50, 43, 35, 21, 7, 3, 2}; 'Test data - least sorted
        ' Dim testItems As Integer() =  {2, 3, 7, 35, 43, 21, 50, 64, 80}; 'Test data - nearly sorted
        ' Dim testItems As Integer() =  {2, 3, 7, 21, 35, 43, 50, 64, 80}; 'Test data - already sorted
        Console.WriteLine("### Quick sort (recursive) ###")
        Console.Write(vbLf & "Original items ")
        Console.WriteLine("[{0}]", String.Join(", ", testItems))
        Console.WriteLine()
        Dim sortedItems As Integer() = QuickSort(testItems, 0, testItems.Length - 1)
        Console.Write("Sorted items ")
        Console.WriteLine("[{0}]", String.Join(", ", sortedItems))
    End Sub

    Function QuickSort(ByVal items As Integer(), ByVal start As Integer, ByVal [end] As Integer) As Integer()
        If start >= [end] Then
            Return New Integer(-1) {}
        Else
            Dim pivotValue As Integer = items(start)
            Dim lowMark As Integer = start + 1
            Dim highMark As Integer = [end]
            Dim temp As Integer
            Dim finished As Boolean = False
            Console.Write("[{0}]", String.Join(", ", items))
            Console.WriteLine($" Pivot value: {pivotValue}  Low mark: {lowMark}  High mark: {highMark}")

            While finished = False

                While lowMark <= highMark AndAlso items(lowMark) <= pivotValue
                    lowMark = lowMark + 1
                End While

                While items(highMark) >= pivotValue AndAlso highMark >= lowMark
                    highMark = highMark - 1
                End While

                If lowMark < highMark Then
                    temp = items(lowMark)
                    items(lowMark) = items(highMark)
                    items(highMark) = temp
                    Console.Write("[{0}]", String.Join(", ", items))
                    Console.WriteLine($" Swapped the values {items(highMark)} and {items(lowMark)}")
                Else
                    finished = True
                End If
            End While

            temp = items(start)
            items(start) = items(highMark)
            items(highMark) = temp
            Console.Write("[{0}]", String.Join(", ", items))
            Console.WriteLine($" Swapped the pivot value {pivotValue} and {items(start)}" & vbLf)
            QuickSort(items, start, highMark - 1)
            QuickSort(items, highMark + 1, [end])
            Return items
        End If
    End Function

End Module
