# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0


# Index values for each level
LEVEL1 = 0 
LEVEL2 = 1
LEVEL3 = 2


def display_words_by_level(spelling_list, level):
    """Display every word from a single level"""

    display_level = level + 1 # Indexing is from 0

    print(f"*** Displaying words for level {display_level} ***")
    for word in spelling_list[level]:
         print(word)
      


def main():
    
    # Create a two-dimensional list of words
    spelling_list = [["any", "poor", "gold", "wild", "kind"],
                      ["both", "break", "pretty", "floor", "water"],
                      ["sugar", "clothes", "again", "money", "children"]]
    

    # Display every word at level 1
    display_words_by_level(spelling_list, LEVEL1)


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    main()
