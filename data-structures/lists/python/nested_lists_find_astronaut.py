# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0


# Index values of each astronaut
CRAFT_INDEX = 0
NAME_INDEX = 1
DAYS_INDEX = 2


def find_position_of_astronaut(all_astronauts, search_name):
    """Return the index of the astronaut that contains the given name"""

    i = 0
    found_index = -1  # Return -1 if no astronaut found

    # Repeat while the astronaut has not been found
    while found_index == -1 and i < len(all_astronauts):
        # Check if the name value contains the search name substring
        if search_name in all_astronauts[i][NAME_INDEX]:
            # Stop searching and return the index
            found_index = i
        i += 1 # Increment the counter
       
    return found_index


def display_astronaut_details(astronaut):
    """Display the values from the given astronaut list"""

    print("\nAstronaut details:")
    
    # Repeat for each value in the list
    for value in astronaut:
        print(value)


def main():
    # Declare and initialise the nested list of astronauts
    all_astronauts = [
        ["ISS", "Sergey Prokopyev", "176"],
        ["ISS", "Dmitry Petelin", "176"],
        ["ISS", "Frank Rubio", "176"],
        ["Tiangong", "Fei Junlong", "112"],
        ["Tiangong", "Deng Qingming", "107"],
        ["Tiangong", "Zhang Lu", "107"],
        ["ISS", "Stephen Bowen", "54"],
        ["ISS", "Warren Hoburg", "14"],
        ["ISS", "Sultan Al Neyadi", "14"],
        ["ISS", "Andrey Fedyaev", "14"]
    ]
    
    # Check if one of the astronaut lists contains a name substring
    name_to_find = input("Enter the name of an astronaut to find: ")
    position = find_position_of_astronaut(all_astronauts, name_to_find)
    
    # Output the search results
    if position == -1:
        print("Astronaut not found in this data set")
    else:
        print(f"Astronaut found at position: {position}")
        display_astronaut_details(all_astronauts[position])


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    main()
