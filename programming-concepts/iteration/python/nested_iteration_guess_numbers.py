# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0

def main():
    numbers_to_guess = [1,4,8,3,10]

    print("Guess my numbers, each number is between 1 and 10")

    # Repeat for each number in the list
    for number in numbers_to_guess:
        user_input = input("Enter a number to guess: ")
        guess = int(user_input)

        # Repeat while the user has not guessed the correct number
        while guess != number:
            user_input = input("Incorrect number. Try again: ")
            guess = int(user_input)

        print("Well done, next number to guess")


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == '__main__':
    main()
