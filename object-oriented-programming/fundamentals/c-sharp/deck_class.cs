/*
Raspberry Pi Foundation
Developed as part of Ada Computer Science 
Usage licensed under CC BY-NC-SA 4.0

Note: This file is designed to be copied out and compiled on your machine.
In order for it to compile properly you need to ensure that the project name is the same as the "namespace" in this file.
To run this file you need to:
1. Copy the contents
2. Paste them into the C# IDE of your choice (Visual Studio, for example)
3. Change the namespace to match your project (if necessary)
4. Compile the program
5. Run the program
*/

using System;

namespace AdaCodeSamples {
    class PlayingCard {
        private string suit;
        public string rank;
        private int value;

        // Constructor method
        public PlayingCard(string givenSuit, string givenRank, int givenValue) {
            suit = givenSuit;
            rank = givenRank;
            value = givenValue;
        }
    }
    

    class Deck {
        private PlayingCard[] cards = new PlayingCard[52]; // Declare an array of 52 elements
        private string[] suits = { "Clubs", "Diamonds", "Hearts", "Spades" };
        private string[] ranks = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
        private int[] values = { 11, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10 };

        // Constructor method
        public Deck() {
            int cardNumber = 0;

            // Repeat for all 4 suits
            for (int i = 0; i < suits.Length; i++) {
                // Repeat for all 13 ranks of a suit
                for (int j = 0; j < ranks.Length; j++) {
                    PlayingCard newCard = new PlayingCard(suits[i], ranks[j], values[j]);
                    cards[cardNumber] = newCard;
                    cardNumber += 1;
                }
            }

            // Show that all 52 playing cards have been initialised
            Console.WriteLine($"Initialised {cardNumber} playing cards");
        }
        

    }


    class Testing {
        // The Main method is the entry point for all C# programs
        public static void Main() {
            // Instantiate a new deck object
            Deck myDeck = new Deck();
        }


    }
}