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

    # Output the word for Level 3 at index 4
    index = 4
    word = spelling_words[LEVEL3][index]
    print(f"The word for Level 3 at index {index} is {word}")


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == '__main__':
    main()
