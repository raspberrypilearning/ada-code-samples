' Raspberry Pi Foundation
' Developed as part of Ada Computer Science
' Usage licensed under CC BY-NC-SA 4.0
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

    Public Sub New(ByVal givenData As String)
        data = givenData
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
End Class


' A class to represent a linked list
Class LinkedList
    Private head As Node  ' Do not intialise yet as the linked list is empty


    ' Insert a node to the front of the list
    Public Sub InsertAtFront(ByVal data As String)

        ' Create a new node
        Dim newNode As Node = New Node(data)

        ' Check if the head node exists
        If head Is Nothing Then
            head = newNode
        Else
            ' Update the pointers so the new node is the head
            newNode.SetNext(head)
            head = newNode
        End If
    End Sub


    ' Insert a node into the correct position in an ordered list
    Public Sub InsertInOrder(ByVal data As String)

        ' Create a new node
        Dim newNode As Node = New Node(data)

        ' Start at the head of the list
        Dim current As Node = head

        ' Check if there are no nodes in the list
        If current Is Nothing Then
            head = newNode

            ' Check if the new node data is before the head data
        ElseIf String.Compare(newNode.GetData(), current.GetData()) < 0 Then
            ' Set the new node as the head of the list
            newNode.SetNext(head)
            head = newNode
            ' Otherwise find where the new node should be positioned
        Else
            ' Repeat until the point of insertion is found
            While current.GetNext() IsNot Nothing AndAlso String.Compare(current.GetNext().GetData(), newNode.GetData()) < 0
                ' Get the next node
                current = current.GetNext()
            End While
            ' Update the pointers of the new and current nodes
            newNode.SetNext(current.GetNext())
            current.SetNext(newNode)
        End If
    End Sub


    ' Traverse the list and output the data from each node
    Public Sub Traverse()
        ' Set the current node as the head
        Dim current As Node = head

        ' Repeat until there are no more linked nodes
        While current IsNot Nothing
            Console.WriteLine(current.GetData())
            current = current.GetNext()
        End While
    End Sub

    ' Delete a node. This assumes that the node does exist in the list
    Public Sub Delete(ByVal data As String)
        ' Start at the head of the list
        Dim current As Node = head

        ' Check if the current node is the node to be deleted
        If current.GetData() = data Then
            ' Update the head pointer
            head = current.GetNext()
        Else
            ' Repeat until the node has been found
            While current.GetNext().GetData() <> data
                ' Change the current node to be the next node
                current = current.GetNext()
            End While
            ' Set the pointer to be the next node's pointer
            current.SetNext(current.GetNext().GetNext())
        End If
    End Sub


End Class

Module Program
    ' The Main subroutine is the default entry point for a VB program
    Sub Main()
        Console.WriteLine("### Linked list (OOP) ###")

        ' Instantiate an empty linked list object
        Dim myList As LinkedList = New LinkedList()

        ' Insert test data into the linked list
        Console.WriteLine(vbLf & "Insert test data into the linked list in order:")
        InsertTestData(myList)
        myList.Traverse()

        ' Testing - insert at front
        Console.WriteLine(vbLf & "Insert a node to the front of the list:")
        myList.InsertAtFront("Albus")
        myList.Traverse()

        ' Testing - insert at end
        Console.WriteLine(vbLf & "Insert a node to the end of the list:")
        myList.InsertInOrder("Zeb")
        myList.Traverse()

        ' Testing - delete a node
        Console.WriteLine(vbLf & "Delete a node from the list:")
        myList.Delete("Sabrina")
        myList.Traverse()
    End Sub


    ' Insert test data into the linked list
    Sub InsertTestData(ByVal myList As LinkedList)
        myList.InsertInOrder("Julie")
        myList.InsertInOrder("Rey")
        myList.InsertInOrder("Habib")
        myList.InsertInOrder("Sabrina")
        myList.InsertInOrder("Mina")
    End Sub


End Module
