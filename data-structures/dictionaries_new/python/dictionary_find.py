# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0
    

def main():
    # Declare and initialise the astronaut dictionary
    astronaut = {"craft": "ISS", "name": "Sultan Al Neyadi",
                 "country": "United Arab Emirates"}

    # Ask the user for a key to find
    input_key = input("Enter a key: ")

    # Check if the key exists in the dictionary
    if input_key in astronaut:
        print("Key exists!")
    else:
        print("That key does not exist")


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    main()
