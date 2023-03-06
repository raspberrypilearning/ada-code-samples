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

// Use a class to represent a node as a record in the linked list
class NodeRecord {
    public String data;
    public NodeRecord nextItem;
}


// A class for the linked list
class LinkedList {
    public NodeRecord head; // Do not initialise yet as the linked list is empty
}


class DataStructures {
    // The main method is the entry point for all Java programs
    public static void main(String[] args) {
        System.out.println("### Linked list (Record) ###");

        // Instantiate an empty linked list object
        LinkedList myList = new LinkedList();

        // Insert test data into the linked list
        System.out.println("\nInsert test data into the linked list in order:");
        insertTestData(myList);
        traverse(myList);

        // Testing - insert at front
        System.out.println("\nInsert a node to the front of the list:");
        insertAtFront(myList, "Albus");
        traverse(myList);

        // Testing - insert in order
        System.out.println("\nInsert a node to the end of the list:");
        insertInOrder(myList, "Zeb");
        traverse(myList);

        // Testing - delete a node
        System.out.println("\nDelete a node from the list:");
        delete(myList, "Sabrina");
        traverse(myList);
    }


    // Insert a node to the front of the list
    public static void insertAtFront(LinkedList myList, String data) {
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
    public static void insertInOrder(LinkedList myList, String data) {
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
        else if (newNode.data.compareTo(current.data) < 0) {
            // Set the new node as the head of the list
            newNode.nextItem = myList.head;
            myList.head = newNode;
        }

        // Otherwise find where the new node should be positioned
        else {
            // Repeat until the point of insertion is found
            while (current.nextItem != null
                    && current.nextItem.data.compareTo(newNode.data) < 0) {
                // Get the next node
                current = current.nextItem;
            }
            // Update the pointers of the new and current nodes
            newNode.nextItem = current.nextItem;
            current.nextItem = newNode;
        }
    }


    // Traverse the list and output the data from each node
    public static void traverse(LinkedList myList) {
        // Set the current node as the head
        NodeRecord current = myList.head;

        // Repeat until there are no more linked nodes
        while (current != null) {
            System.out.println(current.data);
            current = current.nextItem;
        }
    }


    // Delete a node. This assumes that the node does exist in the list
    public static void delete(LinkedList myList, String data) {
        // Start at the head of the list
        NodeRecord current = myList.head;

        // Check if the head node is to be deleted
        if (current.data.equals(data)) {
            // Update the head pointer
            myList.head = current.nextItem;
        }
        else {
            // Repeat until the node has been found
            while (!current.nextItem.data.equals(data)) {
                // Change the current node to be the next node
                current = current.nextItem;
            }
            // Set the pointer to be the next node's pointer
            current.nextItem = current.nextItem.nextItem;
        }
    }


    // Insert test data into the linked list
    public static void insertTestData(LinkedList myList) {
        insertInOrder(myList, "Julie");
        insertInOrder(myList, "Rey");
        insertInOrder(myList, "Habib");
        insertInOrder(myList, "Sabrina");
        insertInOrder(myList, "Mina");
    }


}