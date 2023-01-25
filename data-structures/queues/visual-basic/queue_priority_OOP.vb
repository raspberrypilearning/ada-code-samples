' Raspberry Pi Foundation
' Usage licensed under CC BY-SA 4
' Note: This file is designed to be copied out and compiled on your machine.
' To run this file you need to:
' 1. Copy the contents
' 2. Paste them into the Visual Basic IDE of your choice (Visual Studio, for example)
' 3. Compile the program
' 4. Run the program


' A class for a node in a linked list
Class Node
    Private data As String
    Private priority As Integer
    Private nextItem As Node

    ' Constructor method
    Public Sub New(ByVal itemData As String, ByVal itemPriority As Integer)
        data = itemData
        priority = itemPriority
    End Sub


    Public Function GetData() As String
        Return data
    End Function


    Public Function GetPriority() As Integer
        Return priority
    End Function


    Public Function GetNext() As Node
        Return nextItem
    End Function


    Public Sub SetNext(ByVal newNext As Node)
        nextItem = newNext
    End Sub


    ' Testing
    Public Sub OutputNode()
        Dim nextData = "null"
        If nextItem IsNot Nothing Then
            nextData = nextItem.data
        End If
        Console.WriteLine($"Data: {data}, priority: {priority}, next: {nextData}")
    End Sub


End Class


' A priority queue stored as a linked list
Class PriorityQueue
    Private front As Node
    Private rear As Node

    Public Function GetFront() As Node
        Return front
    End Function


    Public Sub SetFront(ByVal newFront As Node)
        front = newFront
    End Sub


    Public Function GetRear() As Node
        Return rear
    End Function


    Public Sub SetRear(ByVal newRear As Node)
        rear = newRear
    End Sub


    ' Check if the queue is empty
    Public Function IsEmpty() As Boolean
        If front Is Nothing Then
            Return True
        Else
            Return False
        End If
    End Function


    ' Enqueue an item based on the priority
    Public Sub Enqueue(ByVal data As String, ByVal itemPriority As Integer)
        Dim newNode As Node = New Node(data, itemPriority)

        ' Check if the queue is empty
        If IsEmpty() Then
            front = newNode
            rear = newNode
        Else
            ' Check if new node should be the new front of queue
            If newNode.GetPriority() > front.GetPriority() Then
                ' Change the current head pointer
                newNode.SetNext(front)
                front = newNode
                ' Check if new node should be added to the end of the queue
            ElseIf newNode.GetPriority() <= rear.GetPriority() Then
                rear.SetNext(newNode)
                rear = newNode
            Else
                ' Find the insertion point
                Dim current = front
                Dim previous As Node = Nothing
                While current.GetPriority() >= newNode.GetPriority()
                    previous = current
                    current = current.GetNext()
                End While
                newNode.SetNext(current)
                previous.SetNext(newNode)
            End If
        End If
    End Sub


    ' Dequeue an item
    Public Function Dequeue() As String
        Dim dequeuedItem As String

        If IsEmpty() Then
            Console.WriteLine(vbLf & "Queue is empty - nothing to dequeue")
            dequeuedItem = ""
        Else
            ' Get data and change pointer to next item
            dequeuedItem = front.GetData()
            front = front.GetNext()
        End If

        Return dequeuedItem
    End Function


    ' Output the state of the queue
    Public Sub OutputQueue()
        ' Testing
        If front IsNot Nothing Then
            Console.WriteLine("------ State of the queue ------")
            Console.Write("Head ")
            Dim currentNode = front
            currentNode.OutputNode()
            While currentNode.GetNext() IsNot Nothing
                currentNode = currentNode.GetNext()
                currentNode.OutputNode()
            End While
            Console.WriteLine()
        End If
    End Sub


End Class


Module Program
    ' The Main method is the default entry point for all VB programs
    Sub Main()
        Console.WriteLine("### Priority queue (OOP) ###" & vbLf)

        ' Initialise the queue
        Dim myQueue As PriorityQueue = New PriorityQueue()

        ' Insert test data into the queue
        TestEnqueue(myQueue)

        ' Remove test data from the queue
        TestDequeue(myQueue)
    End Sub

    Sub TestEnqueue(ByVal myQueue As PriorityQueue)
        Console.WriteLine("Adding A with priority 3")
        myQueue.Enqueue("A", 3)
        myQueue.OutputQueue()

        Console.WriteLine("Adding B with priority 2 - should be behind A")
        myQueue.Enqueue("B", 2)
        myQueue.OutputQueue()

        Console.WriteLine("Adding C with priority 3 - should be in front of B")
        myQueue.Enqueue("C", 3)
        myQueue.OutputQueue()

        Console.WriteLine("Adding D with priority 3 - should be after C")
        myQueue.Enqueue("D", 3)
        myQueue.OutputQueue()

        Console.WriteLine("Adding E with priority 3 - should be after D")
        myQueue.Enqueue("E", 3)
        myQueue.OutputQueue()

        Console.WriteLine("Adding F with priority 1 - should be after B")
        myQueue.Enqueue("F", 1)
        myQueue.OutputQueue()

        Console.WriteLine("Adding G with priority 4 - should be head of queue")
        myQueue.Enqueue("G", 4)
        myQueue.OutputQueue()

        Console.WriteLine("Adding H with priority 5 - should be head of queue")
        myQueue.Enqueue("H", 5)
        myQueue.OutputQueue()

        Console.WriteLine("Adding I with priority 5 - should be after H")
        myQueue.Enqueue("I", 5)
        myQueue.OutputQueue()
    End Sub


    Sub TestDequeue(ByVal myQueue As PriorityQueue)
        Console.WriteLine(vbLf & "------ Dequeuing 10 items ------" & vbLf)

        For i = 0 To 9
            myQueue.Dequeue()
            myQueue.OutputQueue()
        Next
    End Sub


End Module
