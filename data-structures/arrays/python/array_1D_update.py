# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0


def main():
    # Declare and initialise the list of words
    spelling_words = ["me", "do", "her", "it", "him"]

    # Update the last word stored at index 4
    spelling_words[4] = "log"

    # Output the updated word
    updated_word = spelling_words[4]
    print(f"The last word has been changed to {updated_word}")


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == '__main__':
    main()
