# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0


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

    # Update the word for Year 1, Level 3 at index 4
    spelling_words[0][2][4] = new_word

    # Output the updated word
    updated_word = spelling_words[0][2][4]
    print(f"The word has been updated to {updated_word}")


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    main()
