' Raspberry Pi Foundation
' Usage licensed under CC BY-SA 4
' Note: This file is designed to be copied out and compiled on your machine.
' To run this file you need to:
' 1. Copy the contents
' 2. Paste them into the Visual Basic IDE of your choice (Visual Studio, for example)
' 3. Compile the program
' 4. Run the program


Module program


    ' Index values for cost and previous node
    Public Const COST As Integer = 0
    Public Const PREVIOUS As Integer = 1

    ' The Main method is the default entry point for all VB programs
    Sub Main()
        ' Use a dictionary to represent the graph as an adjacency list
        ' and the cost of each neighbour
        Dim testGraph = New Dictionary(Of String, Dictionary(Of String, Integer)) From {
            {"A", New Dictionary(Of String, Integer) From {{"B", 8}, {"C", 5}}},
            {"C", New Dictionary(Of String, Integer) From {{"A", 5}, {"D", 6}, {"E", 9}}},
            {"B", New Dictionary(Of String, Integer) From {{"A", 8}, {"D", 1}}},
            {"D", New Dictionary(Of String, Integer) From {{"C", 6}, {"B", 1}, {"E", 2}}},
            {"E", New Dictionary(Of String, Integer) From {{"C", 9}, {"D", 2}}}
        }

        Console.WriteLine("### Dijkstra's shortest path algorithm ###")
        Console.WriteLine(vbLf & "Display graph: " & vbLf)
        DisplayGraph(testGraph)

        ' Perform the shortest path algorithm on each node starting from node A
        Dim visitedList = DijkstrasShortestPath(testGraph, "A")

        ' Display the shortest paths from node A using the visited list
        DisplayShortestPaths(visitedList, "A")
    End Sub


    ' Display each node with it's neighbours and costs
    Sub DisplayGraph(ByVal graph As Dictionary(Of String, Dictionary(Of String, Integer)))
        ' Repeat for each node in the graph
        For Each kvp In graph
            Dim node = kvp.Key
            Dim neighbours = kvp.Value

            Console.WriteLine($"Node: {kvp.Key}")
            Console.Write("Neighbours: ")

            ' Repeat for each neighbour node in the neighbours list
            For Each n_node In neighbours
                Console.Write($"{n_node.Key}:{n_node.Value} ")
            Next
            Console.WriteLine(vbLf)
        Next
    End Sub


    ' Display a list of nodes with their closest neighbour and cost
    Sub DisplayList(ByVal adjacencyList As Dictionary(Of String, List(Of Object)))
        Console.WriteLine("   (cost, previous)")

        ' Repeat for each node in the given adjacency list
        For Each kvp In adjacencyList
            Dim node = kvp.Key
            Dim neighbours = kvp.Value

            ' If the neighbour node (nNode) does not exist then set the string to "Nothing"
            Dim nNode = If(neighbours(PREVIOUS) Is Nothing, Nothing, CStr(neighbours(PREVIOUS)))

            Console.WriteLine($"{node}: {neighbours(COST)}, {nNode}")
        Next
        Console.WriteLine()
    End Sub


    ' Display the shortest path from the start node to other nodes
    Sub DisplayShortestPaths(ByVal visited As Dictionary(Of String, List(Of Object)), ByVal startNode As String)
        Console.WriteLine(vbLf & "Shortest paths:")

        ' Repeat for each node in the visited list
        For Each kvp In visited
            ' Don't print the path for the start node
            If Not Equals(kvp.Key, startNode) Then
                ' Set the current node and the path as the key node
                Dim currentNode = kvp.Key
                Dim path = kvp.Key

                ' Repeat until the current node reaches the start node
                While Not Equals(currentNode, startNode)
                    ' Add the previous node to the start of the path
                    Dim previousNode = CStr(visited(currentNode)(PREVIOUS))
                    path = previousNode & path

                    ' Update the current node to be the previous node
                    currentNode = previousNode
                End While

                ' Testing
                Console.Write($"Path for {kvp.Key} with cost {visited(kvp.Key)(COST)}: ")
                Console.WriteLine(path)
            End If

        Next
    End Sub


    ' Apply Dijkstra's shortest path algorithm on a graph stored as a dictionary
    Function DijkstrasShortestPath(ByVal graph As Dictionary(Of String, Dictionary(Of String, Integer)), ByVal startNode As String) As Dictionary(Of String, List(Of Object))
        ' Declare the visited and unvisited lists as dictionaries
        Dim unvisited As Dictionary(Of String, List(Of Object)) = New Dictionary(Of String, List(Of Object))()
        Dim visited As Dictionary(Of String, List(Of Object)) = New Dictionary(Of String, List(Of Object))()

        ' Add and initialise every node to the unvisited list
        For Each kvp In graph
            ' Get the node
            Dim node = kvp.Key

            ' Initialise the node's distance to Int32.MaxValue (for infinity)
            ' and the previous node to null
            unvisited(node) = New List(Of Object)() From {
                Integer.MaxValue,
                Nothing
            }
        Next

        ' Set the cost of the start node to 0
        unvisited(startNode)(COST) = 0

        ' Testing
        Console.WriteLine("--- Initialised state of unvisited list ---")
        DisplayList(unvisited)

        ' Repeat until there are no more nodes in the unvisited list
        Dim finished = False
        While finished = False
            ' Check if there are no more nodes left to evaluate
            If unvisited.Count = 0 Then
                finished = True
            Else
                ' Get the unvisited node with the lowest cost
                Dim min = unvisited.Min(Function(item) CInt(item.Value(COST)))
                Dim currentNode As String = Enumerable.FirstOrDefault(Of KeyValuePair(Of String, List(Of Object)))(Enumerable.Where(Of KeyValuePair(Of String, List(Of Object)))(unvisited, CType(Function(pair) CBool(pair.Value.Contains(CObj(min))), Func(Of KeyValuePair(Of String, List(Of Object)), Boolean)))).Key
                Console.WriteLine($"Current node >>> {currentNode}") ' Testing

                ' Get the current node's list of neighbours
                Dim neighbours = graph(currentNode)

                ' Repeat for each node in the neighbours list
                For Each kvp In neighbours
                    ' Get the neighbour node
                    Dim node = kvp.Key

                    ' Check if the neighbour node has already been visited
                    If visited.ContainsKey(node) = False Then
                        ' Calculate the new cost
                        Dim newCost = CInt(unvisited(currentNode)(COST)) + neighbours(node)

                        ' Check if the new cost is less
                        If newCost < CInt(unvisited(node)(COST)) Then
                            ' Update cost and previous node
                            unvisited(node)(COST) = newCost
                            unvisited(node)(PREVIOUS) = currentNode

                            ' Testing
                            Console.WriteLine($"Updated unvisited list with min distances from node {currentNode}")
                            Console.WriteLine("--- Unvisited list ---")
                            DisplayList(unvisited)
                        End If
                    End If
                Next
                ' Add the current node to the visited list
                visited(currentNode) = unvisited(currentNode)

                ' Remove the current node from the unvisited list
                unvisited.Remove(currentNode)

                ' Testing
                Console.WriteLine($"Updated visited list with node {currentNode}")
                Console.WriteLine("--- Visited list ---")
                DisplayList(visited)
            End If
        End While
        ' Return the final visited list
        Return visited
    End Function


End Module
