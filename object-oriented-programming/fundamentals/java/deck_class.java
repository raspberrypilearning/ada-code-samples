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
}


class Deck
{
    private PlayingCard[] cards = new PlayingCard[52]; // Declare an array of 52 elements
    private String[] suits = { "Clubs", "Diamonds", "Hearts", "Spades" };
    private String[] ranks = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
    private int[] values = { 11, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10 };

    // Constructor method
    public Deck() {
        int cardNumber = 0;

        // Repeat for all 4 suits
        for (int i = 0; i < suits.length; i++) {
            // Repeat for all 13 ranks of a suit
            for (int j = 0; j < ranks.length; j++) {
                PlayingCard newCard = new PlayingCard(suits[i], ranks[j], values[j]);
                cards[cardNumber] = newCard;
                cardNumber += 1;
            }
        }

        // Show that all 52 playing cards have been initialised
        System.out.println("Initialised " + cardNumber + " playing cards");
    }


}


class Testing
{
    // The main method is the entry point for all Java programs
    public static void main(String[] args) {
        // Instantiate a new deck object
        Deck myDeck = new Deck();
    }


}