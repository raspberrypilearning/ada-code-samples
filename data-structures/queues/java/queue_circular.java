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

import java.util.Arrays;

// A class to represent the data and pointer of a single item. The class is
// used to store multiple return values with different data types
class Item {
    private String data;
    private int frontPointer;
    private int rearPointer;

    public Item(String data, int frontPointer, int rearPointer) {
        this.data = data;
        this.frontPointer = frontPointer;
        this.rearPointer = rearPointer;
    }

    public String getData() {
        return data;
    }

    public int getFrontPointer() {
        return frontPointer;
    }

    public int getRearPointer() {
        return rearPointer;
    }
}


class QueuesCircularExample {
    public static final int MAX_SIZE = 4;

    // The main method is the entry point for all Java programs
    public static void main(String[] args) {
        System.out.println("### Circular queue ###");

        // Initialise the queue and pointers
        String[] queue = new String[MAX_SIZE];
        int front = -1;
        int rear = -1;

        // Array is used to store multiple return values of the same data type
        int[] enqueuedValues; // front, rear

        // Item object is used to store multiple return values with different data types
        Item dequeuedValues; // data, front, rear

        // Insert test data into the queue
        enqueuedValues = enqueue(queue, front, rear, "Julie");
        front = enqueuedValues[0];
        rear = enqueuedValues[1];
        outputQueue(queue, front, rear);

        enqueuedValues = enqueue(queue, front, rear, "Rey");
        front = enqueuedValues[0];
        rear = enqueuedValues[1];
        outputQueue(queue, front, rear);

        enqueuedValues = enqueue(queue, front, rear, "Habib");
        front = enqueuedValues[0];
        rear = enqueuedValues[1];
        outputQueue(queue, front, rear);

        enqueuedValues = enqueue(queue, front, rear, "Sabrina");
        front = enqueuedValues[0];
        rear = enqueuedValues[1];
        outputQueue(queue, front, rear);

        // Trying to enqueue - should say queue is full
        enqueuedValues = enqueue(queue, front, rear, "Mina");
        front = enqueuedValues[0];
        rear = enqueuedValues[1];
        outputQueue(queue, front, rear);

        // Dequeue some of the items
        dequeuedValues = dequeue(queue, front, rear);
        front = dequeuedValues.getFrontPointer();
        rear = dequeuedValues.getRearPointer();
        System.out.println("\nDequeued " + dequeuedValues.getData());
        outputQueue(queue, front, rear);

        dequeuedValues = dequeue(queue, front, rear);
        front = dequeuedValues.getFrontPointer();
        rear = dequeuedValues.getRearPointer();
        System.out.println("\nDequeued " + dequeuedValues.getData());
        outputQueue(queue, front, rear);

        // Insert data into the empty slots in the queue
        enqueuedValues = enqueue(queue, front, rear, "Eirini");
        front = enqueuedValues[0];
        rear = enqueuedValues[1];
        outputQueue(queue, front, rear);

        enqueuedValues = enqueue(queue, front, rear, "Diane");
        front = enqueuedValues[0];
        rear = enqueuedValues[1];
        outputQueue(queue, front, rear);

        // Trying to enqueue - should say queue is full
        enqueuedValues = enqueue(queue, front, rear, "Fergus");
        front = enqueuedValues[0];
        rear = enqueuedValues[1];
        outputQueue(queue, front, rear);
    }

    // Check if the queue is empty
    public static boolean isEmpty(int front) {
        if (front == -1)
            return true;
        else
            return false;
    }

    // Check if the queue is full
    public static boolean isFull(int front, int rear) {
        if ((rear + 1) % MAX_SIZE == front)
            return true;
        else
            return false;
    }

    // Enqueue an item
    public static int[] enqueue(String[] queue, int front, int rear, String data) {
        if (isFull(front, rear))
            System.out.println("\nQueue is full - " + data + " not added");
        else {
            rear = (rear + 1) % MAX_SIZE;
            queue[rear] = data;
            if (front == -1) // First item to be queued
                front = 0;
        }
        return new int[] {front, rear};
    }

    // Dequeue an item
    public static Item dequeue(String[] queue, int front, int rear) {
        String dequeuedItem;

        if (isEmpty(front)) {
            System.out.println("\nQueue is empty - nothing to dequeue");
            dequeuedItem = "";
        }
        else {
            dequeuedItem = queue[front];
            queue[front] = ""; // Testing
            // Check if the queue is empty
            if (front == rear) {
                front = -1;
                rear = -1;
            }
            else
                front = (front + 1) % MAX_SIZE;
        }

        return new Item(dequeuedItem, front, rear);
    }

    // Output the state of the queue
    public static void outputQueue(String[] queue, int front, int rear) {
        // Testing
        System.out.print("\nQueue: ");
        System.out.println(Arrays.toString(queue));
        System.out.println("Front: " + front);
        System.out.println("Rear: " + rear);
    }


}