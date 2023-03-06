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

class Pathfinding {
    // Index values for g-score, f-score and previous node
    public static final int G_SCORE = 0;
    public static final int F_SCORE = 1;
    public static final int PREVIOUS = 2;

    // The main method is the entry point for all Java programs
    public static void main(String[] args) {
        // Use a hashmap to represent the graph as an adjacency list
        // and the g-score and f-score of each neighbour
        var testGraph = new HashMap<String, HashMap<String, Integer>>();

        var nodeA = new HashMap<String, Integer>();
        nodeA.put("B", 10);
        nodeA.put("C", 12);
        nodeA.put("D", 5);
        testGraph.put("A", nodeA);

        var nodeB = new HashMap<String, Integer>();
        nodeB.put("A", 10);
        nodeB.put("E", 11);
        testGraph.put("B", nodeB);

        var nodeC = new HashMap<String, Integer>();
        nodeC.put("A", 12);
        nodeC.put("D", 6);
        nodeC.put("E", 11);
        nodeC.put("F", 8);
        testGraph.put("C", nodeC);

        var nodeD = new HashMap<String, Integer>();
        nodeD.put("A", 5);
        nodeD.put("C", 6);
        nodeD.put("F", 14);
        testGraph.put("D", nodeD);

        var nodeE = new HashMap<String, Integer>();
        nodeE.put("B", 11);
        nodeE.put("C", 11);
        testGraph.put("E", nodeE);

        var nodeF = new HashMap<String, Integer>();
        nodeF.put("C", 8);
        nodeF.put("D", 14);
        testGraph.put("F", nodeF);

        System.out.println("### A* algorithm ###");
        System.out.println("\nDisplay graph: \n");
        displayGraph(testGraph);

        // Perform the A* algorithm between nodes A and F
        var visitedList = aStar(testGraph, "A", "F");

        // Display the shortest path using the visited list
        displayShortestPath(visitedList, "A", "F");
    }

    // Display each node with it's neighbours and costs
    public static void displayGraph(HashMap<String, HashMap<String, Integer>> graph) {
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

    // Display a list of nodes with their closest neighbour and scores
    public static void displayList(HashMap<String, ArrayList<Object>> adjacencyList) {
        System.out.println("   (g-score, f-score, previous)");

        // Repeat for each node in the given adjacency list
        for (String node : adjacencyList.keySet()) {
            ArrayList<Object> neighbours = adjacencyList.get(node);

            // If the neighbour node (nNode) does not exist then set the String to "null"
            String nNode = neighbours.get(PREVIOUS) == null ? "null" : (String)neighbours.get(PREVIOUS);

            System.out.println(node + ": " + neighbours.get(G_SCORE) + ", " + neighbours.get(F_SCORE) + ", " + nNode);
        }
        System.out.println();
    }

    // Display the shortest path from start node to target node
    public static void displayShortestPath(HashMap<String, ArrayList<Object>> visited,
                                           String startNode, String targetNode) {
        // Set the current node and the path as the key node
        String currentNode = targetNode;
        String path = targetNode;

        // Repeat until the current node reaches the start node
        while (!currentNode.equals(startNode)) {
            // Add the previous node to the start of the path
            String previousNode = (String)visited.get(currentNode).get(PREVIOUS);
            path = previousNode + path;

            // Update the current node to be the previous node
            currentNode = previousNode;
        }

        // Testing
        int cost = (int)visited.get(targetNode).get(G_SCORE);
        System.out.println("The shortest path from " + startNode + " to " + targetNode + " is:");
        System.out.println("Path: " + path);
        System.out.println("Cost: " + cost);
    }

    // Returns heuristic values for the graph as used on the Ada CS platform
    public static int getHeuristic(String node) {
        int estimatedDistanceToTarget;

        if ("A".equals(node)) {
            estimatedDistanceToTarget = 10;
        }
        else if ("B".equals(node)) {
            estimatedDistanceToTarget = 15;
        }
        else if ("C".equals(node)) {
            estimatedDistanceToTarget = 5;
        }
        else if ("D".equals(node)) {
            estimatedDistanceToTarget = 5;
        }
        else if ("E".equals(node)) {
            estimatedDistanceToTarget = 10;
        }
        else if ("F".equals(node)) {
            estimatedDistanceToTarget = 0;
        }
        else {
            estimatedDistanceToTarget = 0;
        }

        return estimatedDistanceToTarget;
    }

    // Returns the node with the lowest f-score
    public static String getMinimum(HashMap<String, ArrayList<Object>> unvisited) {
        // Set the lowest value to Integer.MAX_VALUE for infinity
        int lowestValueNode = Integer.MAX_VALUE;
        String lowestKey = "";

        // Repeat for each node in the unvisited list
        for (Map.Entry<String, ArrayList<Object>> entry : unvisited.entrySet()) {
            ArrayList<Object> node = entry.getValue();

            // Get the f-score value
            int fScoreValue = (int)node.get(F_SCORE);

            // Check if the f-score is less than the lowest value
            if (fScoreValue < lowestValueNode) {
                // Update lowest value and lowest key
                lowestValueNode = fScoreValue;
                lowestKey = entry.getKey();
            }
        }
        return lowestKey;
    }

    // Apply the A* algorithm on a graph stored as a hashmap
    public static HashMap<String, ArrayList<Object>> aStar(
            HashMap<String, HashMap<String, Integer>> graph, String startNode, String targetNode) {
        // Declare the visited and unvisited lists as hashmaps
        HashMap<String, ArrayList<Object>> unvisited = new HashMap<String, ArrayList<Object>>();
        HashMap<String, ArrayList<Object>> visited = new HashMap<String, ArrayList<Object>>();

        // Add and initialise every node to the unvisited list
        for (String node : graph.keySet()) {
            // Initialise g-score and f-score to Integer.MAX_VALUE (for infinity)
            // and the previous node to null
            unvisited.put(node, new ArrayList<Object>(Arrays.asList(Integer.MAX_VALUE, Integer.MAX_VALUE, null)));
        }

        // Update the values for the start node in the unvisited list
        int fScoreValue = getHeuristic(startNode);
        unvisited.put(startNode, new ArrayList<Object>(Arrays.asList(0, fScoreValue, null)));

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
                // Return the unvisited node with the lowest f-score
                String currentNode = getMinimum(unvisited);
                System.out.println("\nCurrent node >>> " + currentNode); // Testing

                // Check if the current node is the target node
                if (currentNode.equals(targetNode)) {
                    // Add the current node to the visited list
                    finished = true;
                    visited.put(currentNode, unvisited.get(currentNode));
                }
                else {
                    // Get the current node's list of neighbours
                    HashMap<String, Integer> neighbours = graph.get(currentNode);

                    // Repeat for each neighbour node in the neighbours list
                    for (String node : neighbours.keySet()) {
                        // Check if the neighbour node has already been visited
                        if (visited.containsKey(node) == false) {
                            // Calculate the new g-score
                            int newGScore = (int)unvisited.get(currentNode).get(G_SCORE) + neighbours.get(node);

                            // Check if the new g-score is less
                            if (newGScore < (int)unvisited.get(node).get(G_SCORE)) {
                                // Update g-score, f-score and previous node
                                unvisited.get(node).set(G_SCORE, newGScore);
                                unvisited.get(node).set(F_SCORE, newGScore + getHeuristic(node));
                                unvisited.get(node).set(PREVIOUS, currentNode);
                            }
                        }
                    }
                    // Testing
                    System.out.println("--- Unvisited list ---");
                    displayList(unvisited);

                    // Add the current node to the visited list
                    visited.put(currentNode, unvisited.get(currentNode));

                    // Remove the current node from the unvisited list
                    unvisited.remove(currentNode);

                    // Testing
                    System.out.println("Moved " + currentNode + " to visited list");
                    System.out.println("--- Visited list ---");
                    displayList(visited);
                }
            }
        }
        // Testing
        System.out.println("--- Visited list ---");
        displayList(visited);

        // Return the final visited list
        return visited;
    }


}