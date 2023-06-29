# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0


def display_all_words(spelling_words):
    """Display the words of each year and level in the 3D list"""

    # Repeat for each year
    num_years = len(spelling_words)
    for i in range(num_years):
        year_num = i + 1  # Year index starts from 0
        print(f"\n### Year {year_num} ###")
        
        # Repeat for each level
        num_levels = len(spelling_words[i])
        for j in range(num_levels):
            level_num = j + 1  # Level index starts from 0
            print(f"\nLevel {level_num}:")
            
            # Output each word for the current year and level
            num_words = len(spelling_words[i][j])
            for k in range(num_words):
                 print(spelling_words[i][j][k])
    

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
if __name__ == "__main__":
    main()
