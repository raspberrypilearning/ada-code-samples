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

// A node in a binary search tree
class Node {
    public int data;
    public Node left;
    public Node right;

    // Constructor method
    public Node(int data) {
        this.data = data;
    }
}

// A class for constructing a binary search tree (BST)
class BST {
    private Node root; // Do not initialise the root yet as the tree is empty

    // Return the root node
    public Node getRoot() {
        return root;
    }

    // Insert a new node
    public void insert(int item) {
        // Create a new node
        Node newNode = new Node(item);

        // Check if the root node exists
        if (root == null) {
            // Set the root to be the new node
            root = newNode;
        }
        // Find the correct place to insert the new node
        else {
            Node current = root;
            boolean placed = false;

            // Repeat while the data has not been inserted
            while (placed == false) {
                // Check if the new item is greater than the current node data
                if (item > current.data) {
                    // Check if the current node does not have a right child node
                    if (current.right == null) {
                        // Insert the new node to the right of the current node
                        current.right = newNode;
                        placed = true;
                    }
                    // Otherwise repeat with the current right node
                    else {
                        current = current.right;
                    }
                }

                // Otherwise the new item is less than or equal to the current node
                else {
                    // Check if the current node does not have a left child node
                    if (current.left == null) {
                        // Insert the new node to the left of the current node
                        current.left = newNode;
                        placed = true;
                    }
                    // Otherwise repeat with the current left node
                    else {
                        current = current.left;
                    }
                }
            }
        }
    }


    // Recursively searches for an item in a binary search tree
    public boolean search(Node node, int searchItem) {
        // Base case for recursion:
        // The recursion will stop if the search item has been found
        if (searchItem == node.data) {
            return true;
        }

        // Check if the search item is greater than the node data
        // and there is another node to the right to check
        else if (searchItem > node.data && node.right != null) {
            System.out.println("Checking right branch of node " + node.data);
            return search(node.right, searchItem);
        }

        // Check if the search item is less than the node data
        // and there is another node to the left to check
        else if (searchItem < node.data && node.left != null) {
            System.out.println("Checking left branch of node " + node.data);
            return search(node.left, searchItem);
        }

        // Base case for recursion:
        // Otherwise the search item does not exist
        else {
            return false;
        }
    }
}

class SearchingAlgorithms {
    // The main method is the entry point for all Java programs
    public static void main(String[] args) {
        // Instantiate a new tree object
        BST bst = new BST();

        // Insert test data into the binary search tree
        insertTestData(bst);

        // Get the root node
        Node root = bst.getRoot();

        // Testing
        System.out.println("### Output the tree structure ###");
        System.out.println("The root is the left-most value and the children are to the right\n");
        outputTree(root, 0);

        // Search for a value and return if it has been found
        int itemToFind = 7;
        System.out.println("\nThe search item is " + itemToFind + "\n");
        boolean found = bst.search(root, itemToFind);

        // Output the search result
        if (found == true) {
            System.out.println("\n" + itemToFind + " was found in the binary search tree");
        }
        else {
            System.out.println("\n" + itemToFind + " was NOT found in the binary search tree");
        }
    }


    // Insert test data into the binary search tree
    public static void insertTestData(BST bst) {
        bst.insert(8);  // This will be the root node
        bst.insert(3);
        bst.insert(6);
        bst.insert(10);
        bst.insert(1);
        bst.insert(5);
        bst.insert(18);
        bst.insert(7);
        bst.insert(12);
    }


    // Output the tree with the root to the left and children to the right
    public static void outputTree(Node node, int level) {
        if (node != null) {
            outputTree(node.right, level + 1);

            String spaces = ""; // String of spaces
            if (level > 0) {
                int numSpaces = 4 * level;
                spaces = String.format("%-" + numSpaces + "s", "");
            }
            System.out.println(spaces + "-> " + node.data);

            outputTree(node.left, level + 1);
        }
    }


}