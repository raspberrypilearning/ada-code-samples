# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0


def main():
    # Declare and initialise the two-dimensional list of words
    spelling_words = [
        ["me", "do", "it", "her", "him"],
        ["put", "ask", "says", "red", "any"],
        ["they", "where", "friend", "fast", "class"]
    ]

    # Output the word for Level 3 at index 4
    word = spelling_words[2][4]
    print(f"The word for Level 3 at index 4 is {word}")


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    main()
