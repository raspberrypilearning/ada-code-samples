# Raspberry Pi Foundation
# Developed to be used alongside Isaac Computer Science,
# part of the National Centre for Computing Education
# Usage licensed under CC BY-SA 4


def main():
    # Demonstrates a runtime error
    with open("highscores.txt", "r") as file_object:
        lines = file_object.readlines()
        print(lines)

    
# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    main()
