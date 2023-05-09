# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0


# Index values of each astronaut
CRAFT_INDEX = 0
NAME_INDEX = 1
DAYS_INDEX = 2


def update_days_in_space(all_astronauts, astronaut_index, new_days):
    """Update the number of days in space for an astronaut"""
    
    all_astronauts[astronaut_index][DAYS_INDEX] = new_days


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
    
    # Set the position to be the first astronaut at index 0
    position = 0

    # Ask the user for the new number of days in space
    new_days = input("Enter the new number of days: ")

    # Update the number of days in space
    update_days_in_space(all_astronauts, position, new_days)

    # Output the updated number of days
    print(f"The days has been updated to {all_astronauts[position][DAYS_INDEX]}")


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    main()
