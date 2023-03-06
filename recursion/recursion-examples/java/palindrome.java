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

class RecursionExamples {
    // The main method is the entry point for all Java programs
    public static void main(String[] args) {
        String testWord = "kayak"; // Test data
        boolean isPalindrome = palindrome(testWord);
        System.out.println(testWord + ": " + isPalindrome);

        testWord = "apple"; // Test data
        isPalindrome = palindrome(testWord);
        System.out.println(testWord + ": " + isPalindrome);
    }


    // Returns True if string is a palindrome
    public static boolean palindrome(String word) {
        int length = word.length();
        if (length == 0 || length == 1) {
            return true;
        }
        else if (word.charAt(0) == word.charAt(length - 1)) {
            String newWord = word.substring(1, length - 1);
            return palindrome(newWord);
        }
        else {
            return false;
        }
    }


}