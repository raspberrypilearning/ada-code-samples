# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0
    

def main():
    # Declare and initialise the astronaut dictionary
    astronaut = {"craft": "ISS", "name": "Sultan Al Neyadi", "days": "14",
                 "country": "United Arab Emirates"}

    # Ask the user for a key to find
    input_key = input("Enter a key to find: ")

    # Check if the key exists in the dictionary
    if input_key in astronaut:
        print("Key exists!")
        value = astronaut[input_key]
        print(f"Key: {input_key}, value: {value}")
    else:
        print("That key does not exist")


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    main()
