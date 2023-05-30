# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0


def display_key_value_pairs(astronaut):
    """Display the key-value pairs from the given astronaut dictionary"""

    print("Astronaut dictionary:")
    
    # Repeat for each key-value pair in the dictionary
    for key, value in astronaut.items():
        print(f"Key: {key}, value: {value}")
    

def main():
    # Declare and initialise the astronaut dictionary
    astronaut = {"craft": "ISS", "name": "Sultan Al Neyadi",
                 "country": "United Arab Emirates"}

    # Output the astronaut dictionary
    display_key_value_pairs(astronaut)


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    main()
