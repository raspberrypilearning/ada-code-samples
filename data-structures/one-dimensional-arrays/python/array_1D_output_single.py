# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0


def add_words(spelling_words):
    """Add the words to the list""" 
    spelling_words=["path", "floor", "sugar", "because", "beautiful", "clothes", "whole", "behind", "move", "busy"]


def main():    
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
