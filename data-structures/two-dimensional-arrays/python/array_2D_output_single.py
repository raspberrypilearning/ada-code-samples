# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0


# Index values for each level
LEVEL1 = 0 
LEVEL2 = 1
LEVEL3 = 2


def main():
    """Create a list and output every element"""

    # Create a two-dimensional list of words
    spelling_list = [["any", "poor", "gold", "wild", "kind"],
                      ["both", "break", "pretty", "floor", "water"],
                      ["sugar", "clothes", "again", "money", "children"]]
    

    # Display every word at level 1
    print(f"*** Displaying a single word from level 2 ***")
    print(spelling_list[LEVEL2][3]


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    main()
