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


def display_first_word(spelling_words, year, level):
    # Display the first word for given year and level
    display_year = year + 1
    display_level = level + 1
    print(f"*** Displaying the first word for Year{display_year}, Level{display_level} ***")
    print(spelling_words[year][level][0])
    


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

    # Display the first word for year 2, level 3
    display_first_word(spelling_words, YEAR2, LEVEL3)



# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    main()
