# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0

def main():
    print("Please enter your name: ")
    name = input()

    while name != "Bob":
        print("Try again Bob")
        print("Please enter your name: ")
        name = input()

    print("Hi Bob")


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == '__main__':
    main()
