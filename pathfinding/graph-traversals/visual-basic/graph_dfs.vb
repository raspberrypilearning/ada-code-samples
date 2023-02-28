' Raspberry Pi Foundation
' Developed as part of Ada Computer Science
' Usage licensed under CC BY-NC-SA 4.0
' Note: This file is designed to be copied out and compiled on your machine.
' To run this file you need to:
' 1. Copy the contents
' 2. Paste them into the Visual Basic IDE of your choice (Visual Studio, for example)
' 3. Compile the program
' 4. Run the program


Module program


    ' The Main method is the default entry point for all VB programs
    Sub Main()
        ' Use a dictionary to represent the graph as an adjacency list.
        ' Each key is a node in the graph.
        ' Each value is a list of the node's neighbours
        Dim testGraph = New Dictionary(Of String, List(Of String))() From {
            {"1", New List(Of String)() From {"2", "9"}},
            {"2", New List(Of String)() From {"1"}},
            {"3", New List(Of String)() From {"4", "5", "6", "9"}},
            {"4", New List(Of String)() From {"3"}},
            {"5", New List(Of String)() From {"3", "8"}},
            {"6", New List(Of String)() From {"3", "7"}},
            {"7", New List(Of String)() From {"6", "8"}},
            {"8", New List(Of String)() From {"5", "7"}},
            {"9", New List(Of String)() From {"1", "3", "7"}}
        }

        Console.WriteLine("### Depth-first search (DFS) - Graph implementation ###")

        ' Search for a value and return true if it has been found
        Dim itemToFind = "4"
        Dim start = "1"
        Console.WriteLine()
        Console.WriteLine($"Starting at {start}: The target node is {itemToFind}")
        Dim found = DepthFirstSearch(testGraph, start, itemToFind)

        ' Output the search result
        If found = True Then
            Console.WriteLine()
            Console.WriteLine($"{itemToFind} was found in the graph")
        Else
            Console.WriteLine()
            Console.WriteLine($"{itemToFind} was NOT found in the graph")
        End If
    End Sub

    ' A depth-first search performed on a graph stored as a dictionary
    Function DepthFirstSearch(ByVal graph As Dictionary(Of String, List(Of String)), ByVal startNode As String, ByVal targetNode As String) As Boolean
        ' Initialisation
        Dim stack As List(Of String) = New List(Of String)() From {startNode}
        Dim discovered As List(Of String) = New List(Of String)() From {startNode}
        Dim neighbours As List(Of String)
        Dim found = False

        ' Repeat while there are items in the stack
        ' and the target node has not been found 
        While stack.Count <> 0 AndAlso found = False

            ' Set the current node to the top item in the stack
            Dim currentNode = stack(stack.Count - 1)

            ' Remove the current node from the top of the stack
            stack.RemoveAt(stack.Count - 1)

            ' Get the current node's list of neighbours
            neighbours = graph(currentNode)

            ' Testing
            Console.WriteLine();
            Console.WriteLine($">>> Current Node: {currentNode}")
            Console.Write(vbLf & "Stack: ")
            Console.WriteLine("[{0}]", String.Join(", ", stack))
            Console.Write("Discovered: ")
            Console.WriteLine("[{0}]", String.Join(", ", discovered))
            Console.Write("Neighbours: ")
            Console.WriteLine("[{0}]", String.Join(", ", neighbours))

            ' Repeat for each node in the neighbours list
            For Each node In neighbours
                ' Check if the node has not already been discovered
                If discovered.Contains(node) = False Then
                    ' Check if the target node has been found
                    If Equals(node, targetNode) Then
                        found = True
                    Else
                        ' Push the node onto the stack 
                        ' and add it to the discovered list
                        stack.Add(node)
                        discovered.Add(node)

                        ' Testing
                        Console.WriteLine();
                        Console.WriteLine($"Discovered neighbour: {node}")
                        Console.Write("Stack: ")
                        Console.WriteLine("[{0}]", String.Join(", ", stack))
                        Console.Write("Discovered: ")
                        Console.WriteLine("[{0}]", String.Join(", ", discovered))
                        Console.Write("Neighbours: ")
                        Console.WriteLine("[{0}]", String.Join(", ", neighbours))
                    End If
                End If
            Next
        End While
        Return found
    End Function


End Module
