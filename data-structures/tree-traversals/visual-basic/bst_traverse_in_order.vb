' Raspberry Pi Foundation
' Developed as part of Ada Computer Science
' Usage licensed under CC BY-NC-SA 4.0
' Note: This file is designed to be copied out and compiled on your machine.
' To run this file you need to:
' 1. Copy the contents
' 2. Paste them into the Visual Basic IDE of your choice (Visual Studio, for example)
' 3. Compile the program
' 4. Run the program


' A class to represent a node in a binary search tree
Class Node
    Private data As Integer ' Tree is storing integer values
    Private left As Node
    Private right As Node

    ' Constructor method
    Public Sub New(ByVal data As Integer)
        Me.data = data
    End Sub

    Public Function GetData() As Integer
        Return data
    End Function

    Public Function GetLeft() As Node
        Return left
    End Function

    Public Sub SetLeft(ByVal newLeft As Node)
        left = newLeft
    End Sub

    Public Function GetRight() As Node
        Return right
    End Function

    Public Sub SetRight(ByVal newRight As Node)
        right = newRight
    End Sub
End Class


' A class for constructing a binary search tree (BST)
Class BST
    Private root As Node ' Do not intialise the root yet as the tree is empty

    ' Return the root node
    Public Function GetRoot() As Node
        Return root
    End Function

    ' Insert a new node
    Public Sub Insert(ByVal item As Integer)
        ' Create a new node
        Dim newNode As Node = New Node(item)

        ' Check if the root node exists
        If root Is Nothing Then
            ' Set the root to be the new node
            ' Find the correct place to insert the new node
            root = newNode
        Else
            Dim current As Node = root
            Dim placed As Boolean = False

            ' Repeat while the data has not been inserted
            While placed = False
                ' Check if the new item is greater than the current node data
                If item > current.GetData() Then
                    ' Check if the current node does not have a right child node
                    If current.GetRight() Is Nothing Then
                        ' Insert the new node to the right of the current node
                        current.SetRight(newNode)
                        placed = True
                    ' Otherwise repeat with the current right node
                    Else
                        current = current.GetRight()
                    End If
                
                ' Otherwise the new item is less than or equal to the current node
                Else
                    ' Check if the current node does not have a left child node
                    If current.GetLeft() Is Nothing Then
                        ' Insert the new node to the left of the current node
                        current.SetLeft(newNode)
                        placed = True
                    ' Otherwise repeat with the current left node
                    Else
                        current = current.GetLeft()
                    End If
                End If
            End While
        End If
    End Sub


    ' An in-order traversal of the binary search tree
    Public Sub InOrderTraversal(ByVal node As Node)
        ' Check any nodes to the left of the current node
        If node.GetLeft() IsNot Nothing Then
            InOrderTraversal(node.GetLeft())
        End If

        ' Output the data of the current node
        Console.WriteLine(node.GetData())

        ' Check any nodes to the right of the current node
        If node.GetRight() IsNot Nothing Then
            InOrderTraversal(node.GetRight())
        End If
    End Sub
End Class


Module program

    ' The Main method is the entry point for all VB programs
    Sub Main()
        ' Instantiate a new tree object
        Dim bst As BST = New BST()

        ' Insert test data into the binary search tree
        InsertTestData(bst)

        ' Get the root node
        Dim root As Node = bst.GetRoot()

        ' Testing
        Console.WriteLine("### Output the tree structure ###")
        Console.WriteLine("The root is the left-most value and the children are to the right" & vbLf)
        OutputTree(root)

        ' Output the binary search tree using an in-order traversal
        Console.WriteLine(vbLf & "### Binary search tree (in-order traversal) ###")
        bst.InOrderTraversal(root)
    End Sub


    ' Insert test data into the binary search tree
    Sub InsertTestData(ByVal bst As BST)
        bst.Insert(8)  ' This will be the root node
        bst.Insert(3)
        bst.Insert(6)
        bst.Insert(10)
        bst.Insert(1)
        bst.Insert(5)
        bst.Insert(18)
        bst.Insert(7)
        bst.Insert(12)
    End Sub


    ' Output the tree with the root to the left and children to the right
    Sub OutputTree(ByVal node As Node, ByVal Optional level As Integer = 0)
        If node IsNot Nothing Then
            OutputTree(node.GetRight(), level + 1)

            Dim spaces As String = New String(" "c, 4 * level) ' String of spaces
            
            Console.WriteLine($"{spaces}-> {node.GetData()}")
            OutputTree(node.GetLeft(), level + 1)
        End If
    End Sub


End Module
