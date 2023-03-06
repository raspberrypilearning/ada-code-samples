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

// A class for a node in the linked list
class Node {
    private String data;
    private Node nextItem;

    // Constructor method
    public Node(String givenData) {
        data = givenData;
    }

    public String getData() {
        return data;
    }

    public Node getNext() {
        return nextItem;
    }

    public void setNext(Node newNext) {
        nextItem = newNext;
    }
}


// A class for the linked list
class LinkedList {
    private Node head; // Do not initialise yet as the linked list is empty

    public Node getHead() {
        return head;
    }

    public void setHead(Node newHead) {
        head = newHead;
    }

    // Insert a node to the front of the list
    public void insertAtFront(String data) {
        // Create a new node
        Node newNode = new Node(data);

        // Check if the head node exists
        if (head == null) {
            setHead(newNode);
        }
        else {
            // Update the pointers so the new node is the head
            newNode.setNext(head);
            setHead(newNode);
        }
    }


    // Insert a node into the correct position in an ordered list
    public void insertInOrder(String data) {
        // Create a new node
        Node newNode = new Node(data);

        // Start at the head of the list
        Node current = getHead();

        // Check if there are no nodes in the list
        if (current == null) {
            setHead(newNode);
        }

        // Check if the new node data is before the head data
        else if (newNode.getData().compareTo(current.getData()) < 0) {
            // Set the new node as the head of the list
            newNode.setNext(head);
            setHead(newNode);
        }

        // Otherwise find where the new node should be positioned
        else {
            // Repeat until the point of insertion is found
            while (current.getNext() != null
                    && current.getNext().getData().compareTo(newNode.getData()) < 0) {
                // Get the next node
                current = current.getNext();
            }
            // Update the pointers of the new and current nodes
            newNode.setNext(current.getNext());
            current.setNext(newNode);
        }
    }


    // Traverse the list and output the data from each node
    public void traverse() {
        // Set the current node as the head
        Node current = getHead();

        // Repeat until there are no more linked nodes
        while (current != null) {
            System.out.println(current.getData());
            current = current.getNext();
        }
    }


    // Delete a node. This assumes that the node does exist in the list
    public void delete(String data) {
        // Start at the head of the list
        Node current = getHead();

        // Check if the head node is to be deleted
        if (current.getData().equals(data)) {
            // Update the head pointer
            setHead(current.getNext());
        }
        else {
            // Repeat until the node has been found
            while (!current.getNext().getData().equals(data)) {
                // Change the current node to be the next node
                current = current.getNext();
            }
            // Set the pointer to be the next node's pointer
            current.setNext(current.getNext().getNext());
        }
    }


}


class DataStructures {
    // The main method is the entry point for all Java programs
    public static void main(String[] args) {
        System.out.println("### Linked list (OOP) ###");

        // Instantiate an empty linked list object
        LinkedList myList = new LinkedList();

        // Insert test data into the linked list
        System.out.println("\nInsert test data into the linked list in order:");
        insertTestData(myList);
        myList.traverse();

        // Testing - insert at front
        System.out.println("\nInsert a node to the front of the list:");
        myList.insertAtFront("Albus");
        myList.traverse();

        // Testing - insert in order
        System.out.println("\nInsert a node to the end of the list:");
        myList.insertInOrder("Zeb");
        myList.traverse();

        // Testing - delete a node
        System.out.println("\nDelete a node from the list:");
        myList.delete("Sabrina");
        myList.traverse();
    }


    // Insert test data into the linked list
    public static void insertTestData(LinkedList myList) {
        myList.insertInOrder("Julie");
        myList.insertInOrder("Rey");
        myList.insertInOrder("Habib");
        myList.insertInOrder("Sabrina");
        myList.insertInOrder("Mina");
    }


}