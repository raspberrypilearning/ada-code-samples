# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0


def output_each_word(spelling_words):
    """Output every word in the list"""

    print("### Output each word in the list ###")
    
    for word in spelling_words: 
        print(word)


def main():
    # Create a list of words
    spelling_words = ["path", "floor", "sugar",
                      "because", "beautiful", "clothes",
                      "whole", "behind", "move", "busy"]


    # Output a single word from the list
    print("*** Displaying a single word from the list ***")
    print(spelling_words[2])


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    main()
