# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0


def display_all_words(spelling_words):
    """Display the words of each level in the 2D list"""
        
    # Repeat for each level
    for i in range(0, len(spelling_words)):
        level_num = i + 1  # Level index starts from 0
        print(f"\nLevel {level_num}:")
        
        # Output each word for the current level
        for j in range(0, len(spelling_words[i])):
             print(spelling_words[i][j])


def main():
    # Declare and initialise the two-dimensional list of words
    spelling_words = [
        ["me", "do", "her", "it", "him"],
        ["put", "ask", "says", "red", "any"],
        ["they", "where", "friend", "fast", "class"]
    ]

    # Output every word in the list
    print("Display each word along with the level:")
    display_all_words(spelling_words)


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == '__main__':
    main()
