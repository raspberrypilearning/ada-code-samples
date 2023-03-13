# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0

def main():
    first_name = input("Please enter the first name: ")

    while first_name == "":
        print("Error: First name is required")
        first_name = input("Please enter the first name: ")


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    main()
