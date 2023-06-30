# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0


# Index values of each level
LEVEL1 = 0 
LEVEL2 = 1
LEVEL3 = 2


def main():
    # Declare and initialise the two-dimensional list of words
    spelling_words = [
        ["me", "do", "her", "it", "him"],
        ["put", "ask", "says", "red", "any"],
        ["they", "where", "friend", "fast", "class"]
    ]

    # Ask the user for the new word
    new_word = input("Enter the new word: ")

    # Store the original word for Level 3 at index 4
    word_index = 4
    old_word = spelling_words[LEVEL3][word_index]

    # Update the word for Level 3 at index 4
    spelling_words[LEVEL3][word_index] = new_word

    # Output the updated word
    updated_word = spelling_words[LEVEL3][word_index]
    print(f"The word {old_word} has been updated to {updated_word}")


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    main()
