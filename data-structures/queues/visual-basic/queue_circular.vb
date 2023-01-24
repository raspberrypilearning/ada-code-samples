' Raspberry Pi Foundation
' Usage licensed under CC BY-SA 4
' Note: This file is designed to be copied out and compiled on your machine.
' To run this file you need to:
' 1. Copy the contents
' 2. Paste them into the Visual Basic IDE of your choice (Visual Studio, for example)
' 3. Compile the program
' 4. Run the program


Module Program

    Public Const MAXSIZE As Integer = 4


    ' The Main subroutine is the default entry point for a VB program
    Sub Main()
        Console.WriteLine("### Circular queue ###")

        ' Initialise the queue and pointers
        Dim queue = New String(3) {}
        Dim front = -1
        Dim rear = -1

        ' Tuples are used to store multiple return values
        Dim enqueuedValues As Tuple(Of Integer, Integer) ' front, rear
        Dim dequeuedValues As Tuple(Of String, Integer, Integer) ' item, front, rear

        ' Insert test data into the queue
        enqueuedValues = Enqueue(queue, front, rear, "Julie")
        front = enqueuedValues.Item1
        rear = enqueuedValues.Item2
        OutputQueue(queue, front, rear)

        enqueuedValues = Enqueue(queue, front, rear, "Rey")
        front = enqueuedValues.Item1
        rear = enqueuedValues.Item2
        OutputQueue(queue, front, rear)

        enqueuedValues = Enqueue(queue, front, rear, "Habib")
        front = enqueuedValues.Item1
        rear = enqueuedValues.Item2
        OutputQueue(queue, front, rear)

        enqueuedValues = Enqueue(queue, front, rear, "Sabrina")
        front = enqueuedValues.Item1
        rear = enqueuedValues.Item2
        OutputQueue(queue, front, rear)

        ' Trying to enqueue - should say queue is full
        enqueuedValues = Enqueue(queue, front, rear, "Mina")
        front = enqueuedValues.Item1
        rear = enqueuedValues.Item2
        OutputQueue(queue, front, rear)

        ' Dequeue some of the items
        dequeuedValues = Dequeue(queue, front, rear)
        front = dequeuedValues.Item2
        rear = dequeuedValues.Item3
        Console.WriteLine($"Dequeued {dequeuedValues.Item1}")
        OutputQueue(queue, front, rear)

        dequeuedValues = Dequeue(queue, front, rear)
        front = dequeuedValues.Item2
        rear = dequeuedValues.Item3
        Console.WriteLine($"Dequeued {dequeuedValues.Item1}")
        OutputQueue(queue, front, rear)

        ' Insert data into the empty slots in the queue
        enqueuedValues = Enqueue(queue, front, rear, "Eirini")
        front = enqueuedValues.Item1
        rear = enqueuedValues.Item2
        OutputQueue(queue, front, rear)

        enqueuedValues = Enqueue(queue, front, rear, "Diane")
        front = enqueuedValues.Item1
        rear = enqueuedValues.Item2
        OutputQueue(queue, front, rear)

        ' Trying to enqueue - should say queue is full
        enqueuedValues = Enqueue(queue, front, rear, "Fergus")
        front = enqueuedValues.Item1
        rear = enqueuedValues.Item2
        OutputQueue(queue, front, rear)
    End Sub


    ' Check if the queue is empty
    Function IsEmpty(ByVal front As Integer) As Boolean
        If front = -1 Then
            Return True
        Else
            Return False
        End If
    End Function


    ' Check if the queue is full
    Function IsFull(ByVal front As Integer, ByVal rear As Integer) As Boolean
        If (rear + 1) Mod MAXSIZE = front Then
            Return True
        Else
            Return False
        End If
    End Function


    ' Enqueue an item
    Function Enqueue(ByVal queue As String(), ByVal front As Integer, ByVal rear As Integer, ByVal data As String) As Tuple(Of Integer, Integer)
        If IsFull(front, rear) = True Then
            Console.WriteLine($"Queue is full - {data} not added")
        Else
            rear = (rear + 1) Mod MAXSIZE
            queue(rear) = data
            If front = -1 Then front = 0 ' First item to be queued
        End If
        Return Tuple.Create(front, rear)
    End Function


    ' Dequeue an item
    Function Dequeue(ByVal queue As String(), ByVal front As Integer, ByVal rear As Integer) As Tuple(Of String, Integer, Integer)
        Dim dequeuedItem As String

        If IsEmpty(front) = True Then
            Console.WriteLine(vbLf & "Queue is empty - nothing to dequeue")
            dequeuedItem = ""
        Else
            dequeuedItem = queue(front)
            queue(front) = "" ' Testing
            ' Check if the queue is empty
            If front = rear Then
                front = -1
                rear = -1
            Else
                front = (front + 1) Mod MAXSIZE
            End If
        End If

        Return Tuple.Create(dequeuedItem, front, rear)
    End Function


    ' Output the state of the queue
    Sub OutputQueue(ByVal queue As String(), ByVal front As Integer, ByVal rear As Integer)
        ' Testing
        Console.Write(vbLf & "Queue: ")
        Console.WriteLine("[{0}]", String.Join(", ", queue))
        Console.WriteLine($"Front: {front}")
        Console.WriteLine($"Rear: {rear}")
    End Sub


End Module
