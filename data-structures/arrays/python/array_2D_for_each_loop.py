# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0


def display_all_words(spelling_words):
    """Display the words of each level in the 2D list"""

    # Repeat for each level
    for level in spelling_words:
        # Output each word for the current level
        for word in level:
             print(word)


def main():
    # Declare and initialise the two-dimensional list of words
    spelling_words = [
        ["me", "do", "it", "her", "him"],
        ["put", "ask", "says", "red", "any"],
        ["they", "where", "friend", "fast", "class"]
    ]

    # Output every word in the list
    print("Display every word in the spelling words list:")
    display_all_words(spelling_words)


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    main()
