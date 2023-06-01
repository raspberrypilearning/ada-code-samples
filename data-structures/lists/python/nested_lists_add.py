# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0


def add_new_astronaut(all_astronauts, given_spacecraft, given_name, given_days):
    """Add a new astronaut list to the end of the nested list"""

    # Create a new list for the astronaut
    new_astronaut = [given_spacecraft, given_name, given_days]

    # Add the new astronaut list to the end of the nested list
    all_astronauts.append(new_astronaut)


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

    # Ask the user to input the new astronaut's details
    spacecraft = input("Enter the name of the spacecraft: ")
    name = input("Enter the astronaut's full name: ")
    days = input("Enter the current number of days in space: ")

    # Add the new astronaut to the list
    add_new_astronaut(all_astronauts, spacecraft, name, days)

    # Output the details of the new astronaut
    last_index = len(all_astronauts) - 1
    astronaut = all_astronauts[last_index]
    display_astronaut_details(astronaut)


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    main()
