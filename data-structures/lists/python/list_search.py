# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0


def check_value_exists(astronaut, search_value):
    """"Return true if the search value is found in the list"""

    i = 0
    is_found = False

    # Repeat while the value has not been found
    while not is_found and i < len(astronaut):
        # Check if the values match
        if search_value == astronaut[i]:
            is_found = True
        i += 1 # Increment the counter
       
    return is_found


def main():
    # Declare and initialise the astronaut list
    astronaut = ["ISS", "Sergey Prokopyev", "176"]

    # Ask the user for an astronaut's name
    name_to_find = input("Enter the name of an astronaut to find: ")

    # Check if the name matches a value in the astronaut list
    found = check_value_exists(astronaut, name_to_find)

    # Output the search results
    if found:
        print("Astronaut found!")
    else:
        print("Astronaut not found in this data set")


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    main()
