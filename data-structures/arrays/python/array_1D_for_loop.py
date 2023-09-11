# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0


def display_words(spelling_words):
    """Display the words from the given spelling list"""

    print("Spelling words:")
    
    # Repeat for all the values in the list using the index i
    num_words = len(spelling_words)
    for i in range(num_words):
        value = spelling_words[i]
        print(f"The element at index {i} contains the value {value}")
    print(f"There are {num_words} words in the list")


def main():
    # Declare and initialise the list of words
    spelling_words = ["me", "do", "it", "her", "him"]

    # Output the spelling words list
    display_words(spelling_words)


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    main()
