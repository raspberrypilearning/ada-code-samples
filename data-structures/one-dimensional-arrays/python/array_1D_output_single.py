# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0


def add_words(spelling_words):
    """Add the spelling words to the list""" 

    # Append 10 words to the list
    spelling_words.append("path")
    spelling_words.append("floor")
    spelling_words.append("sugar")
    spelling_words.append("because")
    spelling_words.append("beautiful")
    spelling_words.append("clothes")
    spelling_words.append("whole")
    spelling_words.append("behind")
    spelling_words.append("move")
    spelling_words.append("busy")


def main():
    """Create a list and output a single word"""

    # Create a list    
    spelling_words = []  # Declare an empty list

    # Add words to the list
    add_words(spelling_words)

    # Output a single word from the list
    print("### Output a single word from the list ###")
    print(spelling_words[2])


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    main()
