# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0


def check_name_exists(astronauts, search_name):
    """"Return true if the search name is found in the list"""

    i = 0
    is_found = False

    # Repeat while the search name has not been found
    while not is_found and i < len(astronauts):
        # Check if the names match
        if search_name == astronauts[i]:
            is_found = True
        i += 1 # Increment the counter
       
    return is_found


def main():
    # Declare and initialise the astronaut list
    astronauts = ["Frank Rubio", "Stephen Bowen", "Sultan Al Neyadi"]

    # Ask the user for an astronaut's name
    name_to_find = input("Enter the full name of an astronaut to find: ")

    # Check if the name matches a value in the astronaut list
    found = check_name_exists(astronauts, name_to_find)

    # Output the search results
    if found:
        print("Astronaut found!")
    else:
        print("Astronaut not found in this data set")


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    main()
