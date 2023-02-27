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

namespace AdaCodeSamples
{
    // Use a class to represent a node as a record in the linked list
    class NodeRecord
    {
        public string data;
        public NodeRecord nextItem;
    }


    // A class for the linked list
    class LinkedList
    {
        public NodeRecord head; // Do not initialise yet as the linked list is empty
    }


    class DataStructures
    {
        // The Main method is the entry point for all C# programs
        public static void Main()
        {
            Console.WriteLine("### Linked list (Record) ###");

            // Instantiate an empty linked list object
            LinkedList myList = new LinkedList();

            // Insert test data into the linked list
            Console.WriteLine("\nInsert test data into the linked list in order:");
            InsertTestData(myList);
            Traverse(myList);

            // Testing - insert at front
            Console.WriteLine("\nInsert a node to the front of the list:");
            InsertAtFront(myList, "Albus");
            Traverse(myList);

            // Testing - insert in order
            Console.WriteLine("\nInsert a node to the end of the list:");
            InsertInOrder(myList, "Zeb");
            Traverse(myList);
            
            // Testing - delete a node
            Console.WriteLine("\nDelete a node from the list:");
            Delete(myList, "Sabrina");
            Traverse(myList);
        }


        // Insert a node to the front of the list
        public static void InsertAtFront(LinkedList myList, string data)
        {
            // Create a new node
            NodeRecord newNode = new NodeRecord();
            newNode.data = data;

            // Check if the head node exists
            if (myList.head == null) {
                myList.head = newNode;
            }
            else {
                // Update the pointers so the new node is the head
                newNode.nextItem = myList.head;
                myList.head = newNode;
            }
        }


        // Insert a node into the correct position in an ordered list
        public static void InsertInOrder(LinkedList myList, string data)
        {
            // Create a new node
            NodeRecord newNode = new NodeRecord();
            newNode.data = data;

            // Start at the head of the list
            NodeRecord current = myList.head;

            // Check if there are no nodes in the list
            if (current == null) {
                myList.head = newNode;
            }

            // Check if the new node data is before the head data
            else if (String.Compare(newNode.data, current.data) < 0) {
                // Set the new node as the head of the list
                newNode.nextItem = myList.head;
                myList.head = newNode;
            }

            // Otherwise find where the new node should be positioned
            else {
                // Repeat until the point of insertion is found
                while (current.nextItem != null 
                    && String.Compare(current.nextItem.data, newNode.data) < 0) {
                    // Get the next node
                    current = current.nextItem;
                }
                // Update the pointers of the new and current nodes
                newNode.nextItem = current.nextItem;
                current.nextItem = newNode;
            }
        }


        // Traverse the list and output the data from each node
        public static void Traverse(LinkedList myList) 
        {
            // Set the current node as the head
            NodeRecord current = myList.head;

            // Repeat until there are no more linked nodes
            while (current != null) {
                Console.WriteLine(current.data);
                current = current.nextItem;
            }
        }


        // Delete a node. This assumes that the node does exist in the list
        public static void Delete(LinkedList myList, string data)
        {
            // Start at the head of the list
            NodeRecord current = myList.head;

            // Check if the head node is to be deleted
            if (current.data == data) {
                // Update the head pointer
                myList.head = current.nextItem;
            }
            else {
                // Repeat until the node has been found
                while (current.nextItem.data != data) {
                    // Change the current node to be the next node
                    current = current.nextItem;
                }
                // Set the pointer to be the next node's pointer
                current.nextItem = current.nextItem.nextItem;
            }
        }


        // Insert test data into the linked list
        public static void InsertTestData(LinkedList myList)
        {
                InsertInOrder(myList, "Julie");
                InsertInOrder(myList, "Rey");
                InsertInOrder(myList, "Habib");
                InsertInOrder(myList, "Sabrina");
                InsertInOrder(myList, "Mina");
        }

        
    }
}