# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0


# Index values of each astronaut
CRAFT_INDEX = 0
NAME_INDEX = 1
DAYS_INDEX = 2


def get_astronauts_by_spacecraft(all_astronauts, given_spacecraft):
    """Return a list of astronauts that are on a given spacecraft"""

    # Declare a list to store the found astronauts in
    found_list = []

    # Repeat for all astronauts in the outer list using index i
    for i in range(len(all_astronauts)):
        # Check if the astronaut is in the spacecraft
        if given_spacecraft == all_astronauts[i][CRAFT_INDEX]:
            found_list.append(all_astronauts[i])

    return found_list
    

def display_all_astronauts(all_astronauts):
    """Display the values of each astronaut in the nested list"""

    # Repeat for each astronaut in the outer list
    for astronaut in all_astronauts:
        # Repeat for each value in the inner list
        for value in astronaut:
            print(f"{value}  ", end = "") # Do not print new line
        print() # Print a new line after each astronaut


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
   
    # Find all the astronauts on a spacecraft
    print("Get a list of all astronauts that are on a specific spacecraft")
    spacecraft = input("Enter the spacecraft name: ")
    found_astronauts = get_astronauts_by_spacecraft(all_astronauts, spacecraft)
    
    # Output the search results
    if len(found_astronauts) == 0:
        print(f"\nNo astronauts found in the spacecraft {spacecraft}")
    else:
        print("\nAstronauts found:")
        display_all_astronauts(found_astronauts)


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    main()
