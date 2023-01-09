' Raspberry Pi Foundation
' Usage licensed under CC BY-SA 4
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
        Console.WriteLine("### Merge sort (recursive) ###")
        Console.Write("Original items ")
        Console.WriteLine("[{0}]", String.Join(", ", testItems))
        Dim sortedItems As Integer() = MergeSort(testItems)
        Console.Write("Sorted items ")
        Console.WriteLine("[{0}]", String.Join(", ", sortedItems))
    End Sub

    Function MergeSort(ByVal items As Integer()) As Integer()
        Dim leftHalf As Integer()
        Dim rightHalf As Integer()
        Dim mergedItems As Integer() = New Integer(items.Length - 1) {}

        If items.Length <= 1 Then
            Return items
        Else
            Console.Write("Splitting ")
            Console.WriteLine("[{0}]", String.Join(", ", items))
            Dim midpoint As Integer = (items.Length - 1) \ 2  'Integer division
            Dim leftSize As Integer = midpoint + 1
            Dim rightSize As Integer

            If items.Length Mod 2 = 0 Then
                rightSize = midpoint + 1
            Else
                rightSize = midpoint
            End If

            leftHalf = New Integer(leftSize - 1) {}
            rightHalf = New Integer(rightSize - 1) {}

            For i As Integer = 0 To leftSize - 1
                leftHalf(i) = items(i)
            Next

            Dim indexItems As Integer = midpoint + 1

            For i As Integer = 0 To rightSize - 1
                rightHalf(i) = items(indexItems)
                indexItems += 1
            Next

            leftHalf = MergeSort(leftHalf)
            rightHalf = MergeSort(rightHalf)
            Console.WriteLine("Merging: ")
            Console.WriteLine($"[{String.Join(", ", leftHalf)}] and [{String.Join(", ", rightHalf)}]")
            mergedItems = Merge(leftHalf, rightHalf)
            Console.WriteLine("Merged items:")
            Console.WriteLine("[{0}]", String.Join(", ", mergedItems))
            Console.WriteLine()
            Return mergedItems
        End If
    End Function


    Function Merge(ByVal left As Integer(), ByVal right As Integer()) As Integer()
        Dim mergedSize As Integer = left.Length + right.Length
        Dim merged As Integer() = New Integer(mergedSize - 1) {}
        Dim indexLeft As Integer = 0
        Dim indexRight As Integer = 0
        Dim indexMerged As Integer = 0

        While indexLeft < left.Length AndAlso indexRight < right.Length

            If left(indexLeft) < right(indexRight) Then
                merged(indexMerged) = left(indexLeft)
                indexLeft += 1
                indexMerged += 1
            Else
                merged(indexMerged) = right(indexRight)
                indexRight += 1
                indexMerged += 1
            End If
        End While

        While indexLeft < left.Length
            merged(indexMerged) = left(indexLeft)
            indexLeft += 1
            indexMerged += 1
        End While

        While indexRight < right.Length
            merged(indexMerged) = right(indexRight)
            indexRight += 1
            indexMerged += 1
        End While

        Return merged
    End Function


End Module
