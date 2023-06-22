# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0


def display_all_words(spelling_words):
    """Display the words of each year and level in the 3D list"""

    # Repeat for each year
    for year in range(0, len(spelling_words)):
        year_num = year + 1 # Year index starts from 0
        print(f"\n### Year {year_num} ###")
        
        # Repeat for each level
        for level in range(0, len(spelling_words[year])):
            level_num = level + 1 # Level index starts from 0
            print(f"\nLevel {level_num}:")
            
            # Output each word for the current year and level
            for word in range(0, len(spelling_words[year][level])):
                 print(spelling_words[year][level][word])
    

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

    # Output every word in the list
    print("Display each word along with the year group and level:")
    display_all_words(spelling_words)


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == '__main__':
    main()