Public Shared Sub Main()
        Dim testItems As Integer() = New Integer() {43, 21, 2, 50, 3, 80, 35, 7, 64}
        Console.WriteLine("### Bubble sort version 1 (for loops) ###")
        Console.WriteLine("[{0}]", String.Join(", ", testItems))
        BubbleSortVersion1(testItems)
    End Sub

    Public Shared Sub BubbleSortVersion1(ByVal items As Integer())
        Dim numItems As Integer = items.Length

        For passNum As Integer = 1 To numItems - 1

            For index As Integer = 0 To numItems - 1 - 1

                If items(index) > items(index + 1) Then
                    Dim temp As Integer = items(index)
                    items(index) = items(index + 1)
                    items(index + 1) = temp
                End If
            Next

            Console.WriteLine("[{0}]", String.Join(", ", items))
        Next
    End Sub
