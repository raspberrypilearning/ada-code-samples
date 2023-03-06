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
class Item
{
    private String data;
    private int frontPointer;

    public Item(String data, int frontPointer) {
        this.data = data;
        this.frontPointer = frontPointer;
    }

    public String getData() {
        return data;
    }

    public int getFrontPointer() {
        return frontPointer;
    }
}


class QueuesExample
{
    public static final int MAX_SIZE = 4;

    // The main method is the entry point for all Java programs
    public static void main(String[] args) {
        System.out.println("### Queue ###");

        // Initialise the queue and pointers
        String[] queue = new String[MAX_SIZE];
        int front = 0;
        int rear = -1;

        // Insert test data into the queue
        rear = enqueue(queue, rear, "Julie");
        outputQueue(queue, front, rear);

        rear = enqueue(queue, rear, "Rey");
        outputQueue(queue, front, rear);

        rear = enqueue(queue, rear, "Habib");
        outputQueue(queue, front, rear);

        rear = enqueue(queue, rear, "Sabrina");
        outputQueue(queue, front, rear);

        // Trying to enqueue - should say queue is full
        rear = enqueue(queue, rear, "Mina");
        outputQueue(queue, front, rear);

        // Dequeue all of the items
        for (int i = 0; i < queue.length; i++) {
            // Item object is used to store multiple return values
            Item dequeuedValues; // data, front

            dequeuedValues = dequeue(queue, front, rear);
            front = dequeuedValues.getFrontPointer();
            System.out.println("\nDequeued " + dequeuedValues.getData());
        }

        // This shouldn't enqueue Eirini since there is no implementation for
        // writing over any dequeued elements
        rear = enqueue(queue, rear, "Eirini");
        System.out.println("Rear: " + rear);
    }

    // Check if the queue is empty
    public static boolean isEmpty(int front, int rear) {
        if (front > rear)
            return true;
        else
            return false;
    }

    // Check if the queue is full
    public static boolean isFull(int rear) {
        if (rear + 1 == MAX_SIZE)
            return true;
        else
            return false;
    }

    // Enqueue an item
    public static int enqueue(String[] queue, int rear, String data) {
        if (isFull(rear)) {
            System.out.println("\nQueue is full - " + data + " not added");
        }
        else {
            rear = rear + 1;
            queue[rear] = data;
        }
        return rear;
    }

    // Dequeue an item
    public static Item dequeue(String[] queue, int front, int rear) {
        String dequeuedItem;

        if (isEmpty(front, rear)) {
            System.out.println("\nQueue is empty - nothing to dequeue");
            dequeuedItem = "";
        }
        else {
            dequeuedItem = queue[front];
            front = front + 1;
        }

        return new Item(dequeuedItem, front);
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