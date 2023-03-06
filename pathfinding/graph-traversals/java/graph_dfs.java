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
import java.util.List;

class GraphTraversals
{
    // The main method is the entry point for all Java programs
    public static void main(String[] args) {
        // Use a hashmap to represent the graph as an adjacency list.
        // Each key is a node in the graph.
        // Each value is a list of the node's neighbours
        var testGraph = new HashMap<String, List<String>>();
        testGraph.put("1", new ArrayList<String>(Arrays.asList("2", "9")));
        testGraph.put("2", new ArrayList<String>(Arrays.asList("1")));
        testGraph.put("3", new ArrayList<String>(Arrays.asList("4", "5", "6", "9")));
        testGraph.put("4", new ArrayList<String>(Arrays.asList("3")));
        testGraph.put("5", new ArrayList<String>(Arrays.asList("3", "8")));
        testGraph.put("6", new ArrayList<String>(Arrays.asList("3", "7")));
        testGraph.put("7", new ArrayList<String>(Arrays.asList("6", "8")));
        testGraph.put("8", new ArrayList<String>(Arrays.asList("5", "7")));
        testGraph.put("9", new ArrayList<String>(Arrays.asList("1", "3", "7")));

        System.out.println("### Graph traversal - depth-first search (DFS) ###");

        // Search for a value and return true if it has been found
        String itemToFind = "4";
        String start = "1";
        System.out.println("\nStarting at " + start + ": The target node is " + itemToFind);
        boolean found = depthFirstSearch(testGraph, start, itemToFind);

        // Output the search result
        if (found) {
            System.out.println("\n" + itemToFind + " was found in the graph");
        }
        else {
            System.out.println("\n" + itemToFind + " was NOT found in the graph");
        }
    }

    // A depth-first search performed on a graph stored as a hashmap
    public static boolean depthFirstSearch(HashMap<String, List<String>> graph,
                                           String startNode, String targetNode) {
        // Initialisation
        List<String> stack = new ArrayList<String>();
        stack.add(startNode);
        List<String> discovered = new ArrayList<String>();
        discovered.add(startNode);
        List<String> neighbours = new ArrayList<String>();
        boolean found = false;

        // Repeat while there are items in the stack
        // and the target node has not been found
        while (stack.size() != 0 && found == false) {

            // Set the current node to the top item in the stack
            String currentNode = stack.get(stack.size() - 1);

            // Remove the current node from the top of the stack
            stack.remove(stack.size() - 1);

            // Get the current node's list of neighbours
            neighbours = graph.get(currentNode);

            // Testing
            System.out.println("\n>>> Current Node: " + currentNode);
            System.out.print("Stack: ");
            System.out.println(Arrays.toString(stack.toArray()));
            System.out.print("Discovered: ");
            System.out.println(Arrays.toString(discovered.toArray()));
            System.out.print("Neighbours: ");
            System.out.println(Arrays.toString(neighbours.toArray()));

            // Repeat for each node in the neighbours list
            for (String node : neighbours) {
                // Check if the node has not already been discovered
                if (discovered.contains(node) == false) {
                    // Check if the target node has been found
                    if (node.equals(targetNode)) {
                        found = true;
                    }
                    else {
                        // Push the node onto the stack
                        // and to the discovered list
                        stack.add(node);
                        discovered.add(node);

                        // Testing
                        System.out.println("\nDiscovered neighbour: " + node);
                        System.out.print("Stack: ");
                        System.out.println(Arrays.toString(stack.toArray()));
                        System.out.print("Discovered: ");
                        System.out.println(Arrays.toString(discovered.toArray()));
                        System.out.print("Neighbours: ");
                        System.out.println(Arrays.toString(neighbours.toArray()));
                    }
                }
            }
        }
        return found;
    }


}