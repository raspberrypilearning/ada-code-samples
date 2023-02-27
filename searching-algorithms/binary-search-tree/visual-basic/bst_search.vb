' Raspberry Pi Foundation
' Usage licensed under CC BY-NC-SA 4.0
' Note: This file is designed to be copied out and compiled on your machine.
' To run this file you need to:
' 1. Copy the contents
' 2. Paste them into the Visual Basic IDE of your choice (Visual Studio, for example)
' 3. Compile the program
' 4. Run the program

' Class definition for a node in a binary search tree
Class Node
    Public data As Integer
    Public left As Node
    Public right As Node

    Public Sub New(ByVal data As Integer)
        Me.data = data
    End Sub
End Class

' Class definition for a binary search tree
Class BST
    Private root As Node

    Public Function GetRoot() As Node
        Return root
    End Function

    Public Sub Insert(ByVal item As Integer)
        Dim newNode As Node = New Node(item)

        If root Is Nothing Then
            root = newNode
        Else
            Dim current As Node = root
            Dim placed As Boolean = False

            While placed = False

                If item > current.data Then

                    If current.right Is Nothing Then
                        current.right = newNode
                        placed = True
                    Else
                        current = current.right
                    End If
                Else

                    If current.left Is Nothing Then
                        current.left = newNode
                        placed = True
                    Else
                        current = current.left
                    End If
                End If
            End While
        End If
    End Sub

    Public Function Search(ByVal node As Node, ByVal searchItem As Integer) As Boolean
        If searchItem = node.data Then
            Return True
        ElseIf searchItem > node.data AndAlso node.right IsNot Nothing Then
            Console.WriteLine($"Checking right branch of node {node.data}");
            Return Search(node.right, searchItem)
        ElseIf searchItem < node.data AndAlso node.left IsNot Nothing Then
            Console.WriteLine($"Checking left branch of node {node.data}");
            Return Search(node.left, searchItem)
        Else
            Return False
        End If
    End Function
End Class

'Example of program that uses a binary search tree
Module Program

    Sub Main()
        Dim bst As BST = New BST()
        InsertTestData(bst)
        Dim root As Node = bst.GetRoot()
        Console.WriteLine("### Output the tree structure ###")
        Console.WriteLine("The root is the left-most value and the children are to the right" & vbLf)
        OutputTree(root)

    Dim itemToFind As Integer = 6  ' Test data - value is in tree
        Dim found As Boolean = bst.Search(root, itemToFind)
        Console.WriteLine($"The search item is {itemToFind}")

        If found = True Then
            Console.WriteLine($"{itemToFind} was found in the binary search tree")
        Else
            Console.WriteLine($"{itemToFind} does not exist in the binary search tree")
        End If

        itemToFind = 11  ' Test data - value is not in tree
        Console.WriteLine($"The search item is {itemToFind}")
        found = bst.Search(root, itemToFind)

        If found = True Then
            Console.WriteLine($"{itemToFind} was found in the binary search tree")
        Else
            Console.WriteLine($"{itemToFind} does not exist in the binary search tree")
        End If
    End Sub

    Sub InsertTestData(ByVal bst As BST)
        bst.Insert(8)
        bst.Insert(3)
        bst.Insert(6)
        bst.Insert(10)
        bst.Insert(1)
        bst.Insert(5)
        bst.Insert(18)
        bst.Insert(7)
        bst.Insert(12)
    End Sub

    Sub OutputTree(ByVal node As Node, ByVal Optional level As Integer = 0)
        If node IsNot Nothing Then
            OutputTree(node.right, level + 1)
            Dim spaces As String = New String(" "c, 4 * level)
            Console.WriteLine($"{spaces}-> {node.data}")
            OutputTree(node.left, level + 1)
        End If
    End Sub
End Module
