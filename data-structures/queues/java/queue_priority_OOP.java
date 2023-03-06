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

// A class for a node in a linked list
class Node {
    private String data;
    private int priority;
    private Node next;

    // Constructor method
    public Node(String itemData, int itemPriority) {
        data = itemData;
        priority = itemPriority;
    }

    public String getData() {
        return data;
    }

    public int getPriority() {
        return priority;
    }

    public Node getNext() {
        return next;
    }

    public void setNext(Node newNext) {
        next = newNext;
    }

    // Testing
    public void outputNode() {
        String nextData = "null";
        if (next != null)
            nextData = next.data;
        System.out.println("Data: " + data + ", priority: " + priority + ", next: " + nextData);
    }
}


// A priority queue stored as a linked list
class PriorityQueue {
    private Node front;
    private Node rear;

    public Node getFront() {
        return front;
    }

    public void setFront(Node newFront) {
        front = newFront;
    }

    public Node getRear() {
        return rear;
    }

    public void setRear(Node newRear) {
        rear = newRear;
    }

    // Check if the queue is empty
    public boolean isEmpty() {
        if (front == null)
            return true;
        else
            return false;
    }

    // Enqueue an item based on the priority
    public void enqueue(String data, int itemPriority) {
        Node newNode = new Node(data, itemPriority);

        // Check if the queue is empty
        if (isEmpty()) {
            front = newNode;
            rear = newNode;
        }
        else {
            // Check if new node should be the new front of queue
            if (newNode.getPriority() > front.getPriority()) {
                // Change the current head pointer
                newNode.setNext(front);
                front = newNode;
            }
            // Check if new node should be added to the end of the queue
            else if (newNode.getPriority() <= rear.getPriority()) {
                rear.setNext(newNode);
                rear = newNode;
            }
            else {
                // Find the insertion point
                Node current = front;
                Node previous = null;
                while (current.getPriority() >= newNode.getPriority()) {
                    previous = current;
                    current = current.getNext();
                }
                newNode.setNext(current);
                previous.setNext(newNode);
            }
        }
    }

    // Dequeue an item
    public String dequeue() {
        String dequeuedItem;

        if (isEmpty()) {
            System.out.println("\nQueue is empty - nothing to dequeue");
            dequeuedItem = "";
        }
        else {
            // Get data and change pointer to next item
            dequeuedItem = front.getData();
            front = front.getNext();
        }

        return dequeuedItem;
    }

    // Output the state of the queue
    public void outputQueue() {
        // Testing
        if (front != null) {
            System.out.println("------ State of the queue ------");
            System.out.print("Head ");
            Node currentNode = front;
            currentNode.outputNode();
            while (currentNode.getNext() != null) {
                currentNode = currentNode.getNext();
                currentNode.outputNode();
            }
            System.out.println();
        }
    }
}


class Queues {
    // The main method is the entry point for all Java programs
    public static void main(String[] args) {
        System.out.println("### Priority queue (OOP) ###\n");

        // Initialise the queue
        PriorityQueue myQueue = new PriorityQueue();

        // Insert test data into the queue
        testEnqueue(myQueue);

        // Remove test data from the queue
        testDequeue(myQueue);
    }

    public static void testEnqueue(PriorityQueue myQueue) {
        System.out.println("Adding A with priority 3");
        myQueue.enqueue("A", 3);
        myQueue.outputQueue();

        System.out.println("Adding B with priority 2 - should be behind A");
        myQueue.enqueue("B", 2);
        myQueue.outputQueue();

        System.out.println("Adding C with priority 3 - should be in front of B");
        myQueue.enqueue("C", 3);
        myQueue.outputQueue();

        System.out.println("Adding D with priority 3 - should be after C");
        myQueue.enqueue("D", 3);
        myQueue.outputQueue();

        System.out.println("Adding E with priority 3 - should be after D");
        myQueue.enqueue("E", 3);
        myQueue.outputQueue();

        System.out.println("Adding F with priority 1 - should be after B");
        myQueue.enqueue("F", 1);
        myQueue.outputQueue();

        System.out.println("Adding G with priority 4 - should be head of queue");
        myQueue.enqueue("G", 4);
        myQueue.outputQueue();

        System.out.println("Adding H with priority 5 - should be head of queue");
        myQueue.enqueue("H", 5);
        myQueue.outputQueue();

        System.out.println("Adding I with priority 5 - should be after H");
        myQueue.enqueue("I", 5);
        myQueue.outputQueue();
    }

    public static void testDequeue(PriorityQueue myQueue) {
        System.out.println("\n------ Dequeuing 10 items ------\n");

        for (int i = 0; i < 10; i++) {
            myQueue.dequeue();
            myQueue.outputQueue();
        }
    }


}