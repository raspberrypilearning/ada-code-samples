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

class Arrays3D  {
    // The main method is the entry point for all Java programs
    public static void main(String[] args) {
        // Declare and initialise the three-dimensional array of words
        String[][][] spellingWords = {
            {
                    { "me", "do", "her", "it", "him" },
                    { "put", "ask", "says", "red", "any" },
                    { "they", "where", "friend", "fast", "class" }
            },
            {
                    { "door", "find", "most", "bath", "eye" },
                    { "every", "great", "climb", "prove", "behind" },
                    { "clothes", "again", "improve", "should", "parents" }
            }
        };

        // Output the word for Year 1, Level 3 at index 4
        String word = spellingWords[0][2][4];
        System.out.println("The word for Year 1, Level 3 at index 4 is " + word);
    }
}