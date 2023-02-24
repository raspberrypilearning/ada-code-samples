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
class Node
{
    private String data;
    private Node next;

    // Constructor method
    public Node(String itemData)
    {
        data = itemData;
    }

    public String getData()
    {
        return data;
    }

    public Node getNext()
    {
        return next;
    }

    public void setNext(Node newNext)
    {
        next = newNext;
    }

    // Testing
    public void outputNode()
    {
        String nextData = "null";
        if (next != null) {
            nextData = next.data;
        }
        System.out.println("Data: " + data + ", next: " + nextData);
    }
}


// A stack implemented as a linked list
class Stack
{
    private Node top;

    // Check if the stack is empty
    public boolean isEmpty()
    {
        if (top == null)
            return true;
        else
            return false;
    }

    // Push a new item onto the stack
    public void push(String data)
    {
        Node newNode = new Node(data);

        // Check if the stack is NOT empty
        if (!isEmpty()) {
            // Adjust the pointer to the next node
            newNode.setNext(top);
        }

        // Set top to point to the new node
        top = newNode;
    }

    // Pop the item from the top of the stack
    public String pop()
    {
        String poppedItem;

        if (isEmpty()) {
            System.out.println("\nStack is empty - nothing to pop");
            poppedItem = "";
        }
        else {
            // Get data and change pointer to next item
            poppedItem = top.getData();
            top = top.getNext();
        }

        return poppedItem;
    }

    // Peek the item at the top of the stack
    public String peek()
    {
        String peekedItem;

        if (isEmpty()) {
            System.out.println("\nStack is empty - nothing to peek");
            peekedItem = "";
        }
        else {
            // Get data from the top of the stack
            peekedItem = top.getData();
        }

        return peekedItem;
    }

    // Output the state of the stack
    public void outputStack()
    {
        // Testing
        if (top != null) {
            System.out.println("------ State of the stack ------");
            Node currentNode = top;
            currentNode.outputNode();
            while (currentNode.getNext() != null) {
                currentNode = currentNode.getNext();
                currentNode.outputNode();
            }
            System.out.println();
        }
    }
}


class StacksExample
{
    // The main method is the entry point for all Java programs
    public static void main(String[] args)
    {
        System.out.println("### Stack (OOP) ###\n");

        // Initialise the stack
        Stack myStack = new Stack();

        // Insert test data onto the stack
        myStack.push("Julie");
        myStack.outputStack();

        myStack.push("Rey");
        myStack.outputStack();

        // Peek the top item of the stack
        String peekedItem = myStack.peek();
        System.out.println("Peeked top of the stack: " + peekedItem);
        myStack.outputStack();

        // Insert more test data onto the stack
        myStack.push("Habib");
        myStack.outputStack();

        myStack.push("Sabrina");
        myStack.outputStack();

        // Pop the top item from the stack
        String poppedItem = myStack.pop();
        System.out.println("Popped " + poppedItem);
        myStack.outputStack();

        // Insert more test data onto the stack
        myStack.push("Mina");
        myStack.outputStack();

        myStack.push("Eirini");
        myStack.outputStack();
    }


}