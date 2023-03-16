# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0


# Index values for each level
LEVEL1 = 0 
LEVEL2 = 1
LEVEL3 = 2


def display_each_word(spelling_list):
    """Display every word in the two-dimensional list"""
    
    print("### Displaying each word in the 2D list ###")

    # For each row
    for row in spelling_list:
        # Output each word in the row
        for word in row:
             print(word)


def display_each_word_by_level(spelling_list):
    """Display every word by level in the two-dimensional list"""
    
    print("### Displaying each word by level ###")

    # For each row
    for row in spelling_list:
        print("\n")
        print("New level")
        # Output each word in the row
        for word in row:
             print(word)
        


def main():
    """Create a list and output every element"""

    # Create a two-dimensional list of words
    spelling_list = [["any", "poor", "gold", "wild", "kind"],
                      ["both", "break", "pretty", "floor", "water"],
                      ["sugar", "clothes", "again", "money", "children"]]
    

    # Display every word in the list    
    display_each_word(spelling_list)

    # Display every word in the list by level
    display_each_word_by_level(spelling_list)


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    main()
