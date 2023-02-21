' Raspberry Pi Foundation
' Usage licensed under CC BY-NC-SA 4.0
' Note: This file is designed to be copied out and compiled on your machine.
' To run this file you need to:
' 1. Copy the contents
' 2. Paste them into the Visual Basic IDE of your choice (Visual Studio, for example)
' 3. Compile the program
' 4. Run the program


Module program

    ' Index values for g-score, f-score and previous node
    Public Const GSCORE As Integer = 0
    Public Const FSCORE As Integer = 1
    Public Const PREVIOUS As Integer = 2


    ' The Main method is the default entry point for all VB programs
    Sub Main()
        ' Use a dictionary to represent the graph as an adjacency list
        ' and the g-score and f-score of each neighbour
        Dim testGraph = New Dictionary(Of String, Dictionary(Of String, Integer)) From {
            {"A", New Dictionary(Of String, Integer) From {{"B", 10}, {"C", 12}, {"D", 5}}},
            {"B", New Dictionary(Of String, Integer) From {{"A", 10}, {"E", 11}}},
            {"C", New Dictionary(Of String, Integer) From {{"A", 12}, {"D", 6}, {"E", 11}, {"F", 8}}},
            {"D", New Dictionary(Of String, Integer) From {{"A", 5}, {"C", 6}, {"F", 14}}},
            {"E", New Dictionary(Of String, Integer) From {{"B", 11}, {"C", 11}}},
            {"F", New Dictionary(Of String, Integer) From {{"C", 8}, {"D", 14}}}
        }

        Console.WriteLine("### A* algorithm ###")
        Console.WriteLine(vbLf & "Display graph: " & vbLf)
        DisplayGraph(testGraph)

        ' Perform the A* algorithm between nodes A and F
        Dim visitedList = AStar(testGraph, "A", "F")

        ' Display the shortest path using the visited list
        DisplayShortestPath(visitedList, "A", "F")
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


    ' Display a list of nodes with their closest neighbour and scores
    Sub DisplayList(ByVal adjacencyList As Dictionary(Of String, List(Of Object)))
        Console.WriteLine("   (g-score, f-score, previous)")

        ' Repeat for each node in the given adjacency list
        For Each kvp In adjacencyList
            Dim node = kvp.Key
            Dim neighbours = kvp.Value

            ' If the neighbour node (nNode) does not exist then set the string to "Nothing"
            Dim nNode = If(neighbours(PREVIOUS) Is Nothing, Nothing, CStr(neighbours(PREVIOUS)))

            Console.WriteLine($"{node}: {neighbours(GSCORE)}, {neighbours(FSCORE)}, {nNode}")
        Next
        Console.WriteLine()
    End Sub

    ' Display the shortest path from start node to target node
    Sub DisplayShortestPath(ByVal visited As Dictionary(Of String, List(Of Object)), ByVal startNode As String, ByVal targetNode As String)
        ' Set the current node and the path as the key node
        Dim currentNode = targetNode
        Dim path = targetNode

        ' Repeat until the current node reaches the start node
        While Not Equals(currentNode, startNode)
            ' Add the previous node to the start of the path
            Dim previousNode = CStr(visited(currentNode)(PREVIOUS))
            path = previousNode & path

            ' Update the current node to be the previous node
            currentNode = previousNode
        End While

        ' Testing
        Dim cost As Integer = visited(targetNode)(GSCORE)
        Console.WriteLine($"The shortest path from {startNode} to {targetNode} is:")
        Console.WriteLine($"Path: {path}")
        Console.WriteLine($"Cost: {cost}")
    End Sub

    ' Returns heuristic values for the graph as used on the Isaac CS platform
    Function GetHeuristic(ByVal node As String) As Integer
        Dim estimatedDistanceToTarget As Integer

        If Equals(node, "A") Then
            estimatedDistanceToTarget = 10
        ElseIf Equals(node, "B") Then
            estimatedDistanceToTarget = 15
        ElseIf Equals(node, "C") Then
            estimatedDistanceToTarget = 5
        ElseIf Equals(node, "D") Then
            estimatedDistanceToTarget = 5
        ElseIf Equals(node, "E") Then
            estimatedDistanceToTarget = 10
        ElseIf Equals(node, "F") Then
            estimatedDistanceToTarget = 0
        Else
            estimatedDistanceToTarget = 0
        End If

        Return estimatedDistanceToTarget
    End Function

    ' Returns the node with the lowest f-score
    Function GetMinimum(ByVal unvisited As Dictionary(Of String, List(Of Object))) As String
        ' Set the lowest value to Int32.MaxValue for infinity
        Dim lowestValueNode = Integer.MaxValue
        Dim lowestKey = Nothing

        ' Repeat for each node in the unvisited list
        For Each kvp In unvisited
            Dim node = kvp.Value

            ' Get the f-score value
            Dim fScoreValue As Integer = node(FSCORE)

            ' Check if the f-score is less than the lowest value
            If fScoreValue < lowestValueNode Then
                ' Update lowest value and lowest key
                lowestValueNode = fScoreValue
                lowestKey = kvp.Key
            End If
        Next
        Return lowestKey
    End Function

    ' Apply the A* algorithm on a graph stored as a dictionary
    Function AStar(ByVal graph As Dictionary(Of String, Dictionary(Of String, Integer)), ByVal startNode As String, ByVal targetNode As String) As Dictionary(Of String, List(Of Object))
        ' Declare the visited and unvisited lists as dictionaries
        Dim unvisited As Dictionary(Of String, List(Of Object)) = New Dictionary(Of String, List(Of Object))()
        Dim visited As Dictionary(Of String, List(Of Object)) = New Dictionary(Of String, List(Of Object))()

        ' Add and initialise every node to the unvisited list
        For Each kvp In graph
            ' Get the node
            Dim node = kvp.Key

            ' Initialise g-score and f-score to Int32.MaxValue (for infinity)
            '  and the previous node to null
            unvisited(node) = New List(Of Object)() From {Integer.MaxValue, Integer.MaxValue, Nothing}
        Next

        ' Update the values for the start node in the unvisited list
        Dim fScoreValue = GetHeuristic(startNode)
        unvisited(startNode) = New List(Of Object)() From {0, fScoreValue, Nothing}

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
                ' Return the unvisited node with the lowest f-score
                Dim currentNode = GetMinimum(unvisited)
                Console.WriteLine($"Current node >>> {currentNode}") ' Testing

                ' Check if the current node is the target node
                If Equals(currentNode, targetNode) Then
                    ' Add the current node to the visited list
                    finished = True
                    visited(currentNode) = unvisited(currentNode)
                Else
                    ' Get the current node's list of neighbours
                    Dim neighbours = graph(currentNode)

                    ' Repeat for each neighbour node in the neighbours list
                    For Each kvp In neighbours
                        ' Get the neighbour node
                        Dim node = kvp.Key

                        ' Check if the neighbour node has already been visited
                        If visited.ContainsKey(node) = False Then
                            ' Calculate the new g-score
                            Dim newGScore = CInt(unvisited(currentNode)(GSCORE)) + neighbours(node)

                            ' Check if the new g-score is less
                            If newGScore < CInt(unvisited(node)(GSCORE)) Then
                                ' Update g-score, f-score and previous node
                                unvisited(node)(GSCORE) = newGScore
                                unvisited(node)(FSCORE) = newGScore + GetHeuristic(node)
                                unvisited(node)(PREVIOUS) = currentNode
                            End If
                        End If
                    Next
                    ' Testing
                    Console.WriteLine("--- Unvisited list ---")
                    DisplayList(unvisited)

                    ' Add the current node to the visited list
                    visited(currentNode) = unvisited(currentNode)

                    ' Remove the current node from the unvisited list
                    unvisited.Remove(currentNode)

                    ' Testing
                    Console.WriteLine($"Moved {currentNode} to visited list")
                    Console.WriteLine("--- Visited list ---")
                    DisplayList(visited)
                End If
            End If
        End While
        ' Testing
        Console.WriteLine("--- Visited list ---")
        DisplayList(visited)

        ' Return the final visited list
        Return visited
    End Function


End Module
