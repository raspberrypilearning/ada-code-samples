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

// A class to represent the data and pointer of a single item. The class is
// used to store multiple return values with different data types
class Item
{
    private String data;
    private int topPointer;

    public Item(String data, int topPointer) {
        this.data = data;
        this.topPointer = topPointer;
    }

    public String getData() {
        return data;
    }

    public int getTopPointer() {
        return topPointer;
    }
}


class StacksExample
{
    public static final int MAX_SIZE = 4;

    // The main method is the entry point for all Java programs
    public static void main(String[] args) {
        System.out.println("### Stack ###");

        // Initialise the stack and pointers
        String[] stack = new String[MAX_SIZE];
        int top = -1;

        // Insert test data into the stack
        top = push(stack, top, "Julie");
        outputStack(stack, top);

        top = push(stack, top, "Rey");
        outputStack(stack, top);

        top = push(stack, top, "Habib");
        outputStack(stack, top);

        top = push(stack, top, "Sabrina");
        outputStack(stack, top);

        // Trying to push - should say stack is full
        top = push(stack, top, "Mina");
        outputStack(stack, top);

        // Peek the top item of the stack
        String peekedItem = peek(stack, top);
        System.out.print("\nPeeked top of the stack " + peekedItem);
        outputStack(stack, top);

        // Pop all of the items
        for (int i = 0; i < stack.length; i++) {
            // Item object is used to store multiple return values
            Item poppedValues; // data, top

            poppedValues = pop(stack, top);
            top = poppedValues.getTopPointer();
            System.out.print("\nPopped " + poppedValues.getData());
            outputStack(stack, top);
        }

        // Try to pop - should say stack is empty
        Item finalPoppedValues; // data, top
        finalPoppedValues = pop(stack, top);
        top = finalPoppedValues.getTopPointer();
        System.out.println("Top pointer: " + top);
    }

    // Check if the stack is empty
    public static boolean isEmpty(int top) {
        if (top == -1)
            return true;
        else
            return false;
    }

    // Check if the stack is full
    public static boolean isFull(int top) {
        if (top == MAX_SIZE - 1)
            return true;
        else
            return false;
    }

    // Push data onto the top of the stack
    public static int push(String[] stack, int top, String data) {
        if (isFull(top))
            System.out.println("\nStack is full - " + data + " not added");
        else {
            top = top + 1;
            stack[top] = data;
        }
        return top;
    }

    // Return a copy of the item from the top of stack without removing it
    public static String peek(String[] stack, int top) {
        String peekedItem;

        if (isEmpty(top)) {
            System.out.println("\nStack is empty - nothing to peek");
            peekedItem = "";
        }
        else {
            peekedItem = stack[top];
        }

        return peekedItem;
    }

    // Return the item from the top of stack and remove it from the stack
    public static Item pop(String[] stack, int top) {
        String poppedItem;

        if (isEmpty(top)) {
            System.out.println("\nStack is empty - nothing to pop");
            poppedItem = "";
        }
        else {
            poppedItem = stack[top];
            stack[top] = ""; // Testing
            top = top - 1;
        }

        return new Item(poppedItem, top);
    }

    // Output the state of the stack
    public static void outputStack(String[] stack, int top) {
        // Testing
        System.out.println("\n------ State of the stack (first item is the top) ------");

        for (int i = MAX_SIZE - 1; i >= 0; i--) {
            String item = stack[i];
            if (item == null || item.isEmpty()) {
                item = "null";
            }
            System.out.println(item);
        }

        System.out.println("Top pointer: " + top);
    }

}