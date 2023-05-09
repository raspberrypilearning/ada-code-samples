# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0


# Index values of each astronaut
CRAFT_INDEX = 0
NAME_INDEX = 1
DAYS_INDEX = 2


def calculate_total_days(all_astronauts):
    """Calculate and return the sum of all the astronauts' days in space"""

    total_days = 0

    # Repeat for each astronaut in the outer list
    for astronaut in all_astronauts:
        # Add the number of days to the total
        total_days += int(astronaut[DAYS_INDEX])

    return total_days


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
    
    # Calculate the total number of days in space
    total = calculate_total_days(all_astronauts)
    print(f"Total number of days in space: {total}")


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    main()
