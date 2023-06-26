# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0


def check_word_exists(spelling_words, search_word):
    """"Return true if the search word is found in the list"""

    i = 0
    is_found = False

    # Repeat while the search word has not been found
    while not is_found and i < len(spelling_words):
        # Check if the names match
        if search_word == spelling_words[i]:
            is_found = True
        i += 1 # Increment the counter
       
    return is_found


def main():
    # Declare and initialise the list of words
    spelling_words = ["me", "do", "her", "it", "him"]

    # Ask the user for a word to find
    word_to_find = input("Enter a word to find: ")

    # Check if the word matches a value in the spelling list
    found = check_word_exists(spelling_words, word_to_find)

    # Output the search results
    if found:
        print("Word found!")
    else:
        print("Word not found in this data set")


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == '__main__':
    main()
