# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0

LEVEL1 = 0
LEVEL2 = 1
LEVEL3 = 2

def main():
    spelling_words = [
        ["school", "pull", "where"],
        ["path", "floor", "sugar"],
        ["accident", "answer", "eight"]]

    # Display all of the level 2 words
    for word in range(len(spelling_words[LEVEL2])):
        print(spelling_words[LEVEL2][word])


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == '__main__':
    main()
