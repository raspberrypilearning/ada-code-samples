# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0


def add_words(spelling_words):
    """Add the words to the list""" 
    spelling_words=["path", "floor", "sugar", "because", "beautiful", "clothes", "whole", "behind", "move", "busy"]


def output_each_word(spelling_words):
    """Output every word in the list"""
    for word in spelling_words: 
        print(word)


def main():
    # Create a list    
    spelling_words = []  # Declare an empty list

    # Add words to the list
    add_words(spelling_words)

    # Output every word in the list
    print("### Output each word in the list ###")
    output_each_word(spelling_words)


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    main()
