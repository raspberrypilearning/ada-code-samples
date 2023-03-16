# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0



# Index values for each level
LEVEL1 = 0 
LEVEL2 = 1
LEVEL3 = 2


def add_words(spelling_list):
    """Add words to create a two-dimensional list or words by level"""

    # Declare and initialise a two-dimensional list
    spelling_list = [["any", "poor", "gold", "wild", "kind"],
                      ["both", "break", "pretty", "floor", "water"],
                      ["sugar", "clothes", "again", "money", "children"]]


def output_each_word(spelling_list):
    """Output every element in a two-dimensional list"""
    
    print("### Output each element in the 2D list ###")

    # Repeat for each level
    for level in range(len(spelling_list)):
        # Output each word for the current level
        for word in level:
             print(spelling_list[level][word])


def main():
    """Create a list and output every element"""

    # Create an empty list
    spelling_list = []
    
    # Add words to list
    add_words(spelling_list)

    # Output every element in the list    
    output_each_word(spelling_list)


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    main()
