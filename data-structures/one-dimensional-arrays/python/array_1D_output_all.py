# Isaac Computer Science
# Usage licensed under the Open Government Licence v3.0


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
if __name__ == '__main__':
    main()
