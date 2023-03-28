
# Constants for the inner astronaut list values
CRAFT_INDEX = 0
NAME_INDEX = 1
DAYS_INDEX = 2


def output_all_astronauts(astronauts):
    """Output the values from each inner list"""

    # Repeat for each person in the 2D list
    for person in astronauts:
        # Repeat for each value in the inner 1D list
        for value in person:
            print(f"{value}  ", end = "") # Do not print new line
        print() # Print new line


def add_new_astronaut(astronauts, given_craft, given_name, given_days):
    """Append a new astronaut list to the end of the 2D list"""

    # Create a new 1D list for the astronaut
    new_astronaut = [given_craft, given_name, given_days]

    # Append the new astronaut list to the end of the 2D list
    astronauts.append(new_astronaut)

    return astronauts


def add_new_value_to_astronaut(astronauts, astronaut_index, new_value):
    """Append a new value to the end of an astronaut list"""

    # Append the new value to the astronaut list at the given index
    astronauts[astronaut_index].append(new_value)

    return astronauts


# Remove validation for the platform version
def update_days_in_space(astronauts, astronaut_index, new_days):
    """Update the number of days in space for an astronaut"""

    # Check the astronaut index is valid
    if astronaut_index >= 0 and astronaut_index < len(astronauts):
        astronauts[astronaut_index][DAYS_INDEX] = new_days
    else:
        print(f"Astronaut index {astronaut_index} out of range")

    return astronauts


# Think of a better function name?
def find_astronaut_return_index(astronauts, search_name):
    """Find an astronaut that contains the given name"""

    # Return -1 if no astronaut found
    found_index = -1

    # Repeat for all astronauts in the 2D list using index i
    for i in range(len(astronauts)):
        # Substring search for the given name
        if search_name in astronauts[i][NAME_INDEX]:
            # Stop searching and return the index
            found_index = i
            break

    return found_index


# Think of a better function name?
def find_astronaut_return_list(astronauts, search_name):
    """Find an astronaut that contains the given name"""

    # A 2D list to store each astronaut list that contains a name
    found_list = []

    # Repeat for all astronauts in the 2D list using index i
    for i in range(len(astronauts)):
        # Substring search for the given search name
        if search_name in astronauts[i][NAME_INDEX]:
            found_list.append(astronauts[i])

    return found_list


# Remove validation for the platform version
def delete_astronaut(astronauts, astronaut_index):
    """Delete an astronaut at the given index"""

    # Check the astronaut index is valid
    if astronaut_index >= 0 and astronaut_index < len(astronauts):
        del astronauts[astronaut_index]
    else:
        print(f"Astronaut index {astronaut_index} out of range")

    return astronauts


# Remove validation for the platform version
def delete_value_from_astronaut(astronauts, astronaut_index, value_index):
    """Delete a value from an astronaut at the given indices"""

    # Check the astronaut index is valid
    if astronaut_index >= 0 and astronaut_index < len(astronauts):
        # Check the value index of the astronaut is valid
        if value_index >= 0 and value_index < len(astronauts[astronaut_index]):
            del astronauts[astronaut_index][value_index]
        else:
            print(f"Value index {value_index} out of range")
    else:
        print(f"Astronaut index {astronaut_index} out of range")

    return astronauts


def calculate_total_days(astronauts):
    """Calculate the sum of all the astronaut's days in space"""

    total_days = 0

    # Repeat for each person in the 2D list
    for person in astronauts:
        # Add the number of days to the total
        total_days += int(person[DAYS_INDEX])

    return total_days
    

def main():
    # Data set accurate on Thursday 16th March 2023
    # Inner list values: craft, name, days in space

    # Initialise the 2D list of astronauts currently in space
    all_astronauts = [
        ["ISS", "Sergey Prokopyev", "176"],
        ["ISS", "Dmitry Petelin", "176"],
        ["ISS", "Frank Rubio", "176"],
        ["Shenzhou 15", "Fei Junlong", "112"],
        ["Shenzhou 15", "Deng Qingming", "107"],
        ["Shenzhou 15", "Zhang Lu", "107"],
        ["ISS", "Stephen Bowen", "54"],
        ["ISS", "Warren Hoburg", "14"],
        ["ISS", "Sultan Al Neyadi", "14"],
        ["ISS", "Andrey Fedyaev", "14"]
    ]

    ### DEMO for the platform ###
    print("Testing")
    astronaut_index = 6

    # Output the list for astronaut at given index
    astronaut = all_astronauts[astronaut_index]
    print(astronaut)

    # Output name of astronaut at given index
    name = all_astronauts[astronaut_index][NAME_INDEX]
    print(name)


    ### APPEND NEW ASTRONAUT LIST ###
    # Append a new astronaut list to the end of the 2D list
    print("\nAdd a new astronaut to the 2D list")

    # Ask the user to input the new astronaut's details
    craft = input("Enter the craft's name: ")
    name = input("Enter the astronaut's full name: ")
    days = input("Enter the current number of days in space: ")

    # Add the new astronaut to the 2D list
    all_astronauts = add_new_astronaut(all_astronauts, craft, name, days)

    # Output the list for the new astronaut
    last_index = len(all_astronauts) - 1
    astronaut = all_astronauts[last_index]
    print(astronaut)


    ### APPEND NEW VALUE TO ASTRONAUT LIST ###
    print("\nAdd the country of origin to an astronaut")

    # Ask the user to input the astronaut's index and country of origin
    index = int(input("Enter the astronaut's index: "))
    country = input("Enter the astronaut's country of origin: ")
    
    # Append the country of origin to the astronaut
    add_new_value_to_astronaut(all_astronauts, index, country)
    
    print(all_astronauts[index]) # Testing


    ### UPDATE DAYS ###
    print("\nUpdate the number of days an astronaut has been in space")
    
    # Update the number of days currently in space
    index = int(input("Enter the index of the astronaut: "))
    new_days = input("Enter the new number of days: ")
    all_astronauts = update_days_in_space(all_astronauts, index, new_days)
    #all_astronauts[6][DAYS_INDEX] = "62"

    # Output days in space of astronaut at the given index
    astronaut = all_astronauts[index]
    print(astronaut)


    ### LOOP 2D LIST ###
    print("\nOuput each astronaut list and the values of each list")
    
    # Output each astronaut list and the values of each list
    output_all_astronauts(astronauts)


    ### LOOP CALCULATION ###
    # Calculate the total number of days in space
    total = calculate_total_days(all_astronauts)
    print(f"Total number of days in space: {total}")


    ### FIND NAME SUBSTRING (index) ###
    print("\nSearch for an astronaut that contains a given name")
    print("If more than one astronaut contains the substring, the first index will be returned")
    
    # Check whether one of the astronaut lists contains a name substring
    name_to_find = input("Enter the name of an astronaut to find: ")
    index = find_astronaut_return_index(all_astronauts, name_to_find)
    
    # Output the search results
    if index == -1:
        print("Astronaut not found in this data set")
    else:
        print(f"Astronaut found at index: {index}")
        print(all_astronauts[index])


    ### FIND NAME SUBSTRING (list) ###
    print("\nSearch for any astronauts that contain a given name")
    print("Return a list of all astronauts that contain the name substring")
   
    # Find v2 - search for "an"
    found_astronauts = find_astronaut_return_list(all_astronauts, name_to_find)
    
    # Output the search results
    if len(found_astronauts) == 0:
        print(f"No astronauts found with a name containing {name_to_find}")
    else:
        print(f"Astronauts found:")
        output_all_astronauts(found_astronauts)


    ### DELETE BY NAME ###
    print("\nDelete an astronaut list based on their name")
    
    # Delete the first astronaut with a given name
    name_to_find = input("Enter the name of an astronaut to delete: ")
    found_index = find_astronaut_return_index(all_astronauts, name_to_find)
    all_astronauts = delete_astronaut(all_astronauts, found_index)


    ### DELETE BY INDEX ###
    print("\nDelete an astronaut list at a given index")
    
    # Delete an astronaut list at a given index
    delete_at_index = int(input("Enter the index of the list to delete: "))
    all_astronauts = delete_astronaut(all_astronauts, delete_at_index)

    # Delete a value of an astronaut list at the given indices
    print("\nDelete an astronaut list at a given index")
    astronaut_index = int(input("Enter the index of the astronaut list: "))
    value_index = int(input("Enter the index value of the astronaut delete: "))
    all_astronauts = delete_value_from_astronaut(all_astronauts, astronaut_index, value_index)


    ### TESTING ###
    # Output each astronaut list and the values of each list
    print("\nOuput each astronaut list and the values of each list")
    output_all_astronauts(astronauts)


    ### NOTES: ###
    # Include list.remove("value") as well?


if __name__ == "__main__":
    main()
