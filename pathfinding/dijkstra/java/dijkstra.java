/*
Raspberry Pi Foundation
Developed as part of Ada Computer Science
Usage licensed under CC BY-NC-SA 4.0

Note: This file is designed to be copied out and compiled on your machine.
In order for the program to compile properly in some IDEs, you need to ensure that the
class filename is the same as the class name with the main method in it.

To run this file you need to:
1. Copy the contents
2. Create a Java project in the IDE of your choice (Eclipse, for example)
3. Create a new Java Class that uses the same name as the class containing the main method in this program
4. Paste the contents into the new Java Class
5. Save and run the program
*/

import java.util.ArrayList;
import java.util.Arrays;
import java.util.HashMap;
import java.util.Map;

class Pathfinding
{
    // Index values for cost and previous node
    public static final int COST = 0;
    public static final int PREVIOUS = 1;

    // The main method is the entry point for all Java programs
    public static void main(String[] args)
    {
        // Use a hashmap to represent the graph as an adjacency list
        // and the cost of each neighbour
        var testGraph = new HashMap<String, HashMap<String, Integer>>();

        var nodeA = new HashMap<String, Integer>();
        nodeA.put("B", 8);
        nodeA.put("C", 5);
        testGraph.put("A", nodeA);

        var nodeB = new HashMap<String, Integer>();
        nodeB.put("A", 8);
        nodeB.put("D", 1);
        testGraph.put("B", nodeB);

        var nodeC = new HashMap<String, Integer>();
        nodeC.put("A", 5);
        nodeC.put("D", 6);
        nodeC.put("E", 9);
        testGraph.put("C", nodeC);

        var nodeD = new HashMap<String, Integer>();
        nodeD.put("C", 6);
        nodeD.put("B", 1);
        nodeD.put("E", 2);
        testGraph.put("D", nodeD);

        var nodeE = new HashMap<String, Integer>();
        nodeE.put("C", 9);
        nodeE.put("D", 2);
        testGraph.put("E", nodeE);

        System.out.println("### Dijkstra's shortest path algorithm ###");
        System.out.println("\nDisplay graph: \n");
        displayGraph(testGraph);

        // Perform the shortest path algorithm on each node starting from node A
        var visitedList = dijkstrasShortestPath(testGraph, "A");

        // Display the shortest paths from node A using the visited list
        displayShortestPaths(visitedList, "A");
    }

    // Display each node with it's neighbours and costs
    public static void displayGraph(HashMap<String, HashMap<String, Integer>> graph)
    {
        // Repeat for each node in the graph
        for (String node : graph.keySet()) {
            HashMap<String, Integer> neighbours = graph.get(node);

            System.out.println("Node: " + node);
            System.out.print("Neighbours: ");

            // Repeat for each neighbour node in the neighbours list
            for (String n_node : neighbours.keySet()) {
                System.out.print(n_node + ":" + neighbours.get(n_node) + " ");
            }
            System.out.println("\n");
        }
    }

    // Display a list of nodes with their closest neighbour and cost
    public static void displayList(HashMap<String, ArrayList<Object>> adjacencyList)
    {
        System.out.println("   (cost, previous)");

        // Repeat for each node in the given adjacency list
        for (String node : adjacencyList.keySet()) {
            ArrayList<Object> neighbours = adjacencyList.get(node);

            // If the neighbour node (nNode) does not exist then set the String to "null"
            String nNode = neighbours.get(PREVIOUS) == null ? "null" : (String)neighbours.get(PREVIOUS);

            System.out.println(node + ": " + neighbours.get(COST) + ", " + nNode);
        }
        System.out.println();
    }

    // Display the shortest path from the start node to other nodes
    public static void displayShortestPaths(HashMap<String, ArrayList<Object>> visited,
                                            String startNode)
    {
        System.out.println("\nShortest paths:");

        // Repeat for each node in the visited list
        for (String key : visited.keySet()) {
            // Don't print the path for the start node
            if (!key.equals(startNode)) {
                // Set the current node and the path as the key node
                String currentNode = key;
                String path = key;

                // Repeat until the current node reaches the start node
                while (!currentNode.equals(startNode)) {
                    // Add the previous node to the start of the path
                    String previousNode = (String)visited.get(currentNode).get(PREVIOUS);
                    path = previousNode + path;

                    // Update the current node to be the previous node
                    currentNode = previousNode;
                }

                // Testing
                System.out.print("Path for " + key + " with cost " + visited.get(key).get(COST) + ": ");
                System.out.println(path);
            }

        }
    }

    // Apply Dijkstra's shortest path algorithm on a graph stored as a hashmap
    public static HashMap<String, ArrayList<Object>> dijkstrasShortestPath(
            HashMap<String, HashMap<String, Integer>> graph, String startNode)
    {
        // Declare the visited and unvisited lists as dictionaries
        HashMap<String, ArrayList<Object>> unvisited = new HashMap<String, ArrayList<Object>>();
        HashMap<String, ArrayList<Object>> visited = new HashMap<String, ArrayList<Object>>();

        // Add and initialise every node to the unvisited list
        for (String node : graph.keySet()) {
            // Initialise the node's distance to Integer.MAX_VALUE (for infinity)
            // and the previous node to null
            unvisited.put(node, new ArrayList<Object>(Arrays.asList(Integer.MAX_VALUE, null)));
        }

        // Set the cost of the start node to 0
        unvisited.get(startNode).set(COST, 0);

        // Testing
        System.out.println("--- Initialised state of unvisited list ---");
        displayList(unvisited);

        // Repeat until there are no more nodes in the unvisited list
        boolean finished = false;
        while (finished == false) {
            // Check if there are no more nodes left to evaluate
            if (unvisited.size() == 0)
                finished = true;
            else {
                // Get the unvisited node with the lowest cost
                String currentNode = null;
                int min = Integer.MAX_VALUE;
                for(String key : unvisited.keySet()) {
                    int value = (int)unvisited.get(key).get(COST);
                    if(value < min) {
                        min = value;
                        currentNode = key;
                    }
                }
                System.out.println("\nCurrent node >>> " + currentNode); // Testing

                // Get the current node's list of neighbours
                Map<String, Integer> neighbours = graph.get(currentNode);

                // Repeat for each node in the neighbours list
                for (String node : neighbours.keySet()) {
                    // Check if the neighbour node has already been visited
                    if (visited.containsKey(node) == false) {
                        // Calculate the new cost
                        int newCost = (int)unvisited.get(currentNode).get(COST) + neighbours.get(node);

                        // Check if the new cost is less
                        if (newCost < (int)unvisited.get(node).get(COST)) {
                            // Update cost and previous node
                            unvisited.get(node).set(COST, newCost);
                            unvisited.get(node).set(PREVIOUS, currentNode);

                            // Testing
                            System.out.println("Updated unvisited list with min distances from node " + currentNode);
                            System.out.println("--- Unvisited list ---");
                            displayList(unvisited);
                        }
                    }
                }
                // Add the current node to the visited list
                visited.put(currentNode, unvisited.get(currentNode));

                // Remove the current node from the unvisited list
                unvisited.remove(currentNode);

                // Testing
                System.out.println("Updated visited list with node " + currentNode);
                System.out.println("--- Visited list ---");
                displayList(visited);
            }
        }
        // Return the final visited list
        return visited;
    }


}