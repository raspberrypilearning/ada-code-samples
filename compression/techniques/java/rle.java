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

class CompressionTechniques
{
    // The main method is the entry point for all Java programs
    public static void main(String[] args) {
        // Test data - normal data
        String text = "aaaabbbccdddeee";
        System.out.println(text);
        System.out.println(rle(text));

        text = "Bobby";
        System.out.println(text);
        System.out.println(rle(text));

        // Test data - boundary data
        text = "a";
        System.out.println(text);
        System.out.println(rle(text));

        text = "aaaaaa";
        System.out.println(text);
        System.out.println(rle(text));

        text = "aaaae";
        System.out.println(text);
        System.out.println(rle(text));

        text = "aeeeee";
        System.out.println(text);
        System.out.println(rle(text));
    }


    // A simple version of Run Length Encoding for text strings
    public static String rle(String textString) {
        char currentToken = textString.charAt(0);
        String compressed = Character.toString(currentToken);
        int counter = 1;

        for (int i = 1; i < textString.length(); i++) {
            char nextToken = textString.charAt(i);
            if (nextToken != currentToken) {
                compressed = compressed + Integer.toString(counter) + nextToken;
                counter = 1;
            }
            else {
                counter = counter + 1;
            }
            currentToken = nextToken;
        }
        compressed = compressed + Integer.toString(counter);
        return compressed;
    }


}