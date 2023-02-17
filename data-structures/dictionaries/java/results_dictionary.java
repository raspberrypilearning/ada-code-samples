/*
Raspberry Pi Foundation
Developed to be used alongside Isaac Computer Science,
part of the National Centre for Computing Education
Usage licensed under CC BY-SA 4

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

import java.util.HashMap;
import java.util.Map;

class Dictionaries
{
    // The main method is the entry point for all Java programs
    public static void main(String[] args)
    {
        // Initialise a new dictionary of students and results
        Map<String, Integer> results = new HashMap<String, Integer>();
        results.put("Detra", 17);
        results.put("Nova", 84);
        results.put("Charlie", 22);
        results.put("Hwa", 75);
        results.put("Roxann", 92);
        results.put("Elsa", 29);

        // Display the score of Charlie
        int score = results.get("Charlie");
        System.out.println("Charlie's score is " + score + "\n");

        // Insert a new key-value pair for Bob
        results.put("Bob", 78);
        System.out.println("Bob has been added with score " + results.get("Bob") + "\n");

        // Update the score of Hwa
        results.put("Hwa", 71);
        System.out.println("Hwa's new score is " + results.get("Hwa") + "\n");

        // Delete the key-value pair for Elsa
        results.remove("Elsa");
        System.out.println("Elsa has been deleted\n");

        // Repeat for each key-value pair in the dictionary
        for (String key : results.keySet()) {
            // Output the key-value pair of each item
            int value = results.get(key);
            System.out.println("Key: " + key + "  Value: " + value);
        }
    }


}