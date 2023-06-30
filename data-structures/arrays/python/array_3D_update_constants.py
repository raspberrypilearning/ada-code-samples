# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0


# Index values of each year
YEAR1 = 0
YEAR2 = 1

# Index values of each level
LEVEL1 = 0 
LEVEL2 = 1
LEVEL3 = 2


def main():
    # Declare and initialise the three-dimensional list of words
    spelling_words = [
        [
            ["me", "do", "her", "it", "him"],
            ["put", "ask", "says", "red", "any"],
            ["they", "where", "friend", "fast", "class"]
        ],
        [
            ["door", "find", "most", "bath", "eye"],
            ["every", "great", "climb", "prove", "behind"],
            ["clothes", "again", "improve", "should", "parents"]
        ]
    ]

    # Ask the user for the new word
    new_word = input("Enter the new word: ")

    # Store the original word for Year 1, Level 3 at index 4
    word_index = 4
    old_word = spelling_words[YEAR1][LEVEL3][word_index]

    # Update the word for Year 1, Level 3 at index 4
    spelling_words[YEAR1][LEVEL3][word_index] = new_word
    
    # Output the updated word
    updated_word = spelling_words[YEAR1][LEVEL3][word_index]
    print(f"The word {old_word} has been updated to {updated_word}")


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    main()
