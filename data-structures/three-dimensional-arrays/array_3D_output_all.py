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


def display_each_word(spelling_list):
    """Display every word in the two-dimensional list"""
    
    print("### Displaying each word in the 3D list ###")

    # For each year
    for year in spelling_list:
        # For each level
        for level in year:
        # Output each word in the level
            for word in level:
                print(word)


def display_each_word_by_year_and_level(spelling_list):
    """Display every word by year level in the two-dimensional list"""
    
    print("### Displaying each word by level ###")

    # For each year
    for year in spelling_list:
        print("*** Next year ***")
        # For each level
        for level in year:
            print("*** Next level ***")
            # Display each word
            for word in level:
                print(word)

    


def main():
    """Create a list and output every element"""

    # Create a three-dimensional list of words
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

    # Display every word 
    display_each_word(spelling_words)

    # Display words by year and level
    display_each_word_by_year_and_level(spelling_words)



# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    main()
