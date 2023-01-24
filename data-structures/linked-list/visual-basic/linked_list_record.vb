' Raspberry Pi Foundation
' Usage licensed under CC BY-SA 4
' Note: This file is designed to be copied out and compiled on your machine.
' To run this file you need to:
' 1. Copy the contents
' 2. Paste them into the Visual Basic IDE of your choice (Visual Studio, for example)
' 3. Compile the program
' 4. Run the program


' A class to represent a node as a record in a linked list
Class NodeRecord
    Public data As String
    Public nextItem As NodeRecord
End Class

' A class for a linked list
Class LinkedList
    Public head As NodeRecord
End Class

Module Program

    ' The Main subroutine is the default entry point for a VB program
    Sub Main()
        Console.WriteLine("### Linked list (Record) ###")
        Dim myList As LinkedList = New LinkedList()
        Console.WriteLine(vbLf & "Insert test data into the linked list in order:")
        InsertTestData(myList)
        Traverse(myList)
        Console.WriteLine(vbLf & "Insert a node to the front of the list:")
        InsertAtFront(myList, "Albus")
        Traverse(myList)
        Console.WriteLine(vbLf & "Insert a node to the end of the list:")
        InsertInOrder(myList, "Zeb")
        Traverse(myList)
        Console.WriteLine(vbLf & "Delete a node from the list:")
        Delete(myList, "Sabrina")
        Traverse(myList)
    End Sub

    Sub InsertAtFront(ByVal myList As LinkedList, ByVal data As String)
        Dim newNode As NodeRecord = New NodeRecord()
        newNode.data = data

        If myList.head Is Nothing Then
            myList.head = newNode
        Else
            newNode.nextItem = myList.head
            myList.head = newNode
        End If
    End Sub

    Sub InsertInOrder(ByVal myList As LinkedList, ByVal data As String)
        Dim newNode As NodeRecord = New NodeRecord()
        newNode.data = data
        Dim current As NodeRecord = myList.head

        If current Is Nothing Then
            myList.head = newNode
        ElseIf String.Compare(newNode.data, current.data) < 0 Then
            newNode.nextItem = myList.head
            myList.head = newNode
        Else

            While current.nextItem IsNot Nothing AndAlso String.Compare(current.nextItem.data, newNode.data) < 0
                current = current.nextItem
            End While

            newNode.nextItem = current.nextItem
            current.nextItem = newNode
        End If
    End Sub

    Sub Traverse(ByVal myList As LinkedList)
        Dim current As NodeRecord = myList.head

        While current IsNot Nothing
            Console.WriteLine(current.data)
            current = current.nextItem
        End While
    End Sub

    Sub Delete(ByVal myList As LinkedList, ByVal data As String)
        Dim current As NodeRecord = myList.head

        If current.data = data Then
            myList.head = current.nextItem
        Else

            While current.nextItem.data <> data
                current = current.nextItem
            End While

            current.nextItem = current.nextItem.nextItem
        End If
    End Sub

    Sub InsertTestData(ByVal myList As LinkedList)
        InsertInOrder(myList, "Julie")
        InsertInOrder(myList, "Rey")
        InsertInOrder(myList, "Habib")
        InsertInOrder(myList, "Sabrina")
        InsertInOrder(myList, "Mina")
    End Sub


End Module
