' Raspberry Pi Foundation
' Developed as part of Ada Computer Science
' Usage licensed under CC BY-NC-SA 4.0
' Note: This file is designed to be copied out and compiled on your machine.
' To run this file you need to:
' 1. Copy the contents
' 2. Paste them into the Visual Basic IDE of your choice (Visual Studio, for example)
' 3. Compile the program
' 4. Run the program


' A structure to represent a node in a linked list
Class NodeRecord
    Public data As String
    Public nextItem As NodeRecord
End Class


' A structure to represent a linked list
Class LinkedList
    Public head As NodeRecord
End Class


Module Program

    ' The Main subroutine is the default entry point for a VB program
    Sub Main()
        Console.WriteLine("### Linked list (Record) ###")
        
        ' Create a new linked list
        Dim myList As LinkedList = New LinkedList()
        
        ' Insert test data and display list
        Console.WriteLine(vbLf & "Insert test data into the linked list in order:")
        InsertTestData(myList)
        Traverse(myList)
        
        'Insert a node at the front of the list
        Console.WriteLine(vbLf & "Insert a node to the front of the list:")
        InsertAtFront(myList, "Albus")
        Traverse(myList)
        
        'Insert a node at the end of the list
        Console.WriteLine(vbLf & "Insert a node to the end of the list:")
        InsertInOrder(myList, "Zeb")
        Traverse(myList)
        
        'Delete a node from the list
        Console.WriteLine(vbLf & "Delete a node from the list:")
        Delete(myList, "Sabrina")
        Traverse(myList)
    End Sub

    
    'Insert a node at the front of a linked list
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

    'Insert a node in correct position within a linked list
    Sub InsertInOrder(ByVal myList As LinkedList, ByVal data As String)
        Dim newNode As NodeRecord = New NodeRecord()
        newNode.data = data
        Dim current As NodeRecord = myList.head

        'List is empty
        If current Is Nothing Then
            myList.head = newNode
        ElseIf String.Compare(newNode.data, current.data) < 0 Then ' Item must be first in list
            newNode.nextItem = myList.head
            myList.head = newNode
        Else  ' Need to find insertion point
            While current.nextItem IsNot Nothing AndAlso String.Compare(current.nextItem.data, newNode.data) < 0  ' Keep searching
                current = current.nextItem
            End While
            ' Insertion point found
            newNode.nextItem = current.nextItem
            current.nextItem = newNode
        End If
    End Sub
    
    
    ' Display linked list
    Sub Traverse(ByVal myList As LinkedList)
        Dim current As NodeRecord = myList.head

        While current IsNot Nothing
            Console.WriteLine(current.data)
            current = current.nextItem
        End While
    End Sub
    
    
    ' Delete item from a linked list
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

    
    ' Create a set of test data
    Sub InsertTestData(ByVal myList As LinkedList)
        InsertInOrder(myList, "Julie")
        InsertInOrder(myList, "Rey")
        InsertInOrder(myList, "Habib")
        InsertInOrder(myList, "Sabrina")
        InsertInOrder(myList, "Mina")
    End Sub


End Module
