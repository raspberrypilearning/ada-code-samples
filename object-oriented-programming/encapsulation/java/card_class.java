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

class PlayingCard
{
    private String suit;
    private String rank;
    private int value;

    // Constructor method
    public PlayingCard(String givenSuit, String givenRank, int givenValue) {
        suit = givenSuit;
        rank = givenRank;
        value = givenValue;
    }

    public String getSuit() {
        return suit;
    }

    public String getRank() {
        return rank;
    }

    public int getValue() {
        return value;
    }
}


class Testing
{
    // The main method is the entry point for all Java programs
    public static void main(String[] args) {
        // Instantiate a new card object
        PlayingCard myCard = new PlayingCard("clubs", "2", 2);
        System.out.println("Suit is: " + myCard.getSuit());
        System.out.println("Rank is: " + myCard.getRank());
        System.out.println("Value is: " + myCard.getValue());
    }


}