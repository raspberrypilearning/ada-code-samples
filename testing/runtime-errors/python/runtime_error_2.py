# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0


def main():
    # Demonstrates a runtime error
    with open("highscores.txt", "r") as file_object:
        lines = file_object.readlines()
        print(lines)

    
# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    main()
