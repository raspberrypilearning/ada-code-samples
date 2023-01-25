' Raspberry Pi Foundation
' Usage licensed under CC BY-SA 4
' Note: This file is designed to be copied out and compiled on your machine.
' To run this file you need to:
' 1. Copy the contents
' 2. Paste them into the Visual Basic IDE of your choice (Visual Studio, for example)
' 3. Compile the program
' 4. Run the program


' A class to represent a node in a linked list
Class Node
    Private data As String
    Private nextItem As Node

    ' Constructor method
    Public Sub New(ByVal itemData As String)
        data = itemData
    End Sub


    Public Function GetData() As String
        Return data
    End Function


    Public Function GetNext() As Node
        Return nextItem
    End Function


    Public Sub SetNext(ByVal newNext As Node)
        nextItem = newNext
    End Sub


    ' Code just for testing
    Public Sub OutputNode()
        Dim nextData = Nothing
        If nextItem IsNot Nothing Then
            nextData = nextItem.data
        End If
        Console.WriteLine($"Data: {data}, next: {nextData}")
    End Sub
End Class


' A class to represent a stack implemented as a linked list
Class Stack
    Private top As Node

    ' Check if the stack is empty
    Public Function IsEmpty() As Boolean
        If top Is Nothing Then
            Return True
        Else
            Return False
        End If
    End Function

    ' Push a new item onto the stack
    Public Sub Push(ByVal data As String)
        Dim newNode As Node = New Node(data)

        ' Check if the stack is NOT empty
        If Not IsEmpty() Then
            ' Adjust the pointer to the next node
            newNode.SetNext(top)
        End If

        ' Set top to point to the new node
        top = newNode
    End Sub

    ' Pop the item from the top of the stack
    Public Function Pop() As String
        Dim poppedItem As String

        If IsEmpty() Then
            Console.WriteLine(vbLf & "Stack is empty - nothing to pop")
            poppedItem = Nothing
        Else
            ' Get data and change pointer to next item
            poppedItem = top.GetData()
            top = top.GetNext()
        End If

        Return poppedItem
    End Function

    ' Peek the item at the top of the stack
    Public Function Peek() As String
        Dim peekedItem As String

        If IsEmpty() Then
            Console.WriteLine(vbLf & "Stack is empty - nothing to peek")
            peekedItem = Nothing
        Else
            ' Get data from the top of the stack
            peekedItem = top.GetData()
        End If

        Return peekedItem
    End Function

    ' Output the state of the stack
    Public Sub OutputStack()
        ' Testing
        If top IsNot Nothing Then
            Console.WriteLine("------ State of the stack ------")
            Dim currentNode = top
            currentNode.OutputNode()
            While currentNode.GetNext() IsNot Nothing
                currentNode = currentNode.GetNext()
                currentNode.OutputNode()
            End While
            Console.WriteLine()
        End If
    End Sub
End Class

Module program

    ' The Main method is the entry point for all C# programs
    Sub Main()
        ' Initialise the stack
        Dim myStack As Stack = New Stack()

        ' Insert test data onto the stack
        myStack.Push("Julie")
        myStack.OutputStack()

        myStack.Push("Rey")
        myStack.OutputStack()

        ' Peek the top item of the stack
        Dim peekedItem As String = myStack.Peek()
        Console.WriteLine($"Peeked top of the stack: {peekedItem}")
        myStack.OutputStack()

        ' Insert more test data onto the stack
        myStack.Push("Habib")
        myStack.OutputStack()

        myStack.Push("Sabrina")
        myStack.OutputStack()

        ' Pop the top item from the stack
        Dim poppedItem As String = myStack.Pop()
        Console.WriteLine($"Popped {poppedItem}")
        myStack.OutputStack()

        ' Insert more test data onto the stack
        myStack.Push("Mina")
        myStack.OutputStack()

        myStack.Push("Eirini")
        myStack.OutputStack()
    End Sub


End Module
