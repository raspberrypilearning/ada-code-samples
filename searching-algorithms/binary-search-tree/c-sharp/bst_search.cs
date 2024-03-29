/*
Raspberry Pi Foundation
Developed as part of Ada Computer Science 
Usage licensed under CC BY-NC-SA 4.0

Note: This file is designed to be copied out and compiled on your machine.
In order for it to compile properly you need to ensure that the project name is the same as the "namespace" in this file.
To run this file you need to:
1. Copy the contents
2. Paste them into the C# IDE of your choice (Visual Studio, for example)
3. Change the namespace to match your project (if necessary)
4. Compile the program
5. Run the program
*/

using System;

namespace AdaCodeSamples {
    // A node in a binary search tree
    class Node {
        private int data;
        private Node left;
        private Node right;

        // Constructor method
        public Node(int data) {
            this.data = data;
        }

        public int GetData() {
            return data;
        }

        public Node GetLeft() {
            return left;
        }

        public void SetLeft(Node newLeft) {
            left = newLeft;
        }

        public Node GetRight() {
            return right;
        }

        public void SetRight(Node newRight) {
            right = newRight;
        }
    }

    // A class for constructing a binary search tree (BST)
    class BST {
        private Node root; // Do not initialise the root yet as the tree is empty

        // Return the root node
        public Node GetRoot() {
            return root;
        }

        // Insert a new node
        public void Insert(int item) {
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
                bool placed = false;

                // Repeat while the data has not been inserted
                while (placed == false) {
                    // Check if the new item is greater than the current node data
                    if (item > current.GetData()) {
                        // Check if the current node does not have a right child node
                        if (current.GetRight() == null) {
                            // Insert the new node to the right of the current node
                            current.SetRight(newNode);
                            placed = true;
                        }
                        // Otherwise repeat with the current right node
                        else {
                            current = current.GetRight();
                        }
                    }

                    // Otherwise the new item is less than or equal to the current node
                    else {
                        // Check if the current node does not have a left child node
                        if (current.GetLeft() == null) {
                            // Insert the new node to the left of the current node
                            current.SetLeft(newNode);
                            placed = true;
                        }
                        // Otherwise repeat with the current left node
                        else {
                            current = current.GetLeft();
                        }
                    }
                }
            }
        }


        // Recursively searches for an item in a binary search tree
        public bool Search(Node node, int searchItem) {
            // Base case for recursion:
            // The recursion will stop if the search item has been found
            if (searchItem == node.GetData()) {
                return true;
            }

            // Check if the search item is greater than the node data
            // and there is another node to the right to check
            else if (searchItem > node.GetData() && node.GetRight() != null) {
                Console.WriteLine($"Checking right branch of node {node.GetData()}");
                return Search(node.GetRight(), searchItem);
            }

            // Check if the search item is less than the node data
            // and there is another node to the left to check
            else if (searchItem < node.GetData() && node.GetLeft() != null) {
                Console.WriteLine($"Checking left branch of node {node.GetData()}");
                return Search(node.GetLeft(), searchItem);
            }

            // Base case for recursion:
            // Otherwise the search item does not exist
            else {
                return false;
            }
        }


    }

    class SearchingAlgorithms {
        // The Main method is the entry point for all C# programs
        public static void Main() {
            // Instantiate a new tree object
            BST bst = new BST();

            // Insert test data into the binary search tree
            InsertTestData(bst);

            // Get the root node
            Node root = bst.GetRoot();

            // Testing
            Console.WriteLine("### Output the tree structure ###");
            Console.WriteLine("The root is the left-most value and the children are to the right\n");
            OutputTree(root);

            // Search for a value and return if it has been found
            int itemToFind = 7;
            Console.WriteLine($"\nThe search item is {itemToFind}\n");
            bool found = bst.Search(root, itemToFind);

            // Output the search result
            if (found == true) {
                Console.WriteLine($"\n{itemToFind} was found in the binary search tree");
            }
            else {
                Console.WriteLine($"\n{itemToFind} was NOT found in the binary search tree");
            }
        }


        // Insert test data into the binary search tree
        public static void InsertTestData(BST bst) {
            bst.Insert(8);  // This will be the root node
            bst.Insert(3);
            bst.Insert(6);
            bst.Insert(10);
            bst.Insert(1);
            bst.Insert(5);
            bst.Insert(18);
            bst.Insert(7);
            bst.Insert(12);
        }


        // Output the tree with the root to the left and children to the right
        public static void OutputTree(Node node, int level = 0) {
            if (node != null) {
                OutputTree(node.GetRight(), level + 1);
                
                string spaces = new String(' ', 4 * level); // String of spaces
                Console.WriteLine($"{spaces}-> {node.GetData()}");

                OutputTree(node.GetLeft(), level + 1);
            }
        }

        
    }
}