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

    Public Const MAXSIZE As Integer = 4


    ' The Main subroutine is the default entry point for a VB program
    Sub Main()
        Console.WriteLine("### Queue ###")

        ' Initialise the queue and pointers
        Dim queue(3) As String
        Dim front = 0
        Dim rear = -1

        ' Insert test data into the queue
        rear = Enqueue(queue, rear, "Julie")
        OutputQueue(queue, front, rear)

        rear = Enqueue(queue, rear, "Rey")
        OutputQueue(queue, front, rear)

        rear = Enqueue(queue, rear, "Habib")
        OutputQueue(queue, front, rear)

        rear = Enqueue(queue, rear, "Sabrina")
        OutputQueue(queue, front, rear)

        ' Trying to enqueue - should say queue is full
        rear = Enqueue(queue, rear, "Mina")
        OutputQueue(queue, front, rear)

        ' Dequeue all of the items
        For Each item In queue
            ' Tuple is used to store multiple return values
            Dim dequeuedValues As Tuple(Of String, Integer) ' item, front

            dequeuedValues = Dequeue(queue, front, rear)
            front = dequeuedValues.Item2
            Console.WriteLine($"Dequeued {dequeuedValues.Item1}")
        Next

        ' This shouldn't enqueue Eirini since there is no implementation for
        ' writing over any dequeued elements
        rear = Enqueue(queue, rear, "Eirini")
    End Sub


    ' Check if the queue is empty
    Function IsEmpty(ByVal front As Integer, ByVal rear As Integer) As Boolean
        If front > rear Then
            Return True
        Else
            Return False
        End If
    End Function


    ' Check if the queue is full
    Function IsFull(ByVal rear As Integer) As Boolean
        If rear + 1 = MAXSIZE Then
            Return True
        Else
            Return False
        End If
    End Function


    ' Enqueue an item
    Function Enqueue(ByVal queue As String(), ByVal rear As Integer, ByVal data As String) As Integer
        If IsFull(rear) = True Then
            Console.WriteLine($"Queue is full - {data} not added")
        Else
            rear = rear + 1
            queue(rear) = data
        End If
        Return rear
    End Function


    ' Dequeue an item
    Function Dequeue(ByVal queue As String(), ByVal front As Integer, ByVal rear As Integer) As Tuple(Of String, Integer)
        Dim dequeuedItem As String

        If IsEmpty(front, rear) = True Then
            Console.WriteLine(vbLf & "Queue is empty - nothing to dequeue")
            dequeuedItem = ""
        Else
            dequeuedItem = queue(front)
            front = front + 1
        End If

        Return Tuple.Create(dequeuedItem, front)
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
