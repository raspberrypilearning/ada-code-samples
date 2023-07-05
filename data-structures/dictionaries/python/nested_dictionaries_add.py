# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0


def add_new_astronaut(astronauts_by_name, given_name,
                      given_spacecraft, given_days):
    """Add a new astronaut dictionary to the nested dictionary"""

    # Create a new dictionary for the astronaut
    new_astronaut = {"craft": given_spacecraft, "days": given_days}

    # Add the new astronaut dictionary to the nested dictionary
    astronauts_by_name[given_name] = new_astronaut


def display_key_value_pairs(astronaut):
    """Display the key-value pairs from the given astronaut dictionary"""

    print("Astronaut dictionary:")
    
    # Repeat for each key-value pair in the dictionary
    for key, value in astronaut.items():
        print(f"Key: {key}, value: {value}")
    

def main():
    # Declare and initialise the nested dictionary of astronauts
    astronauts_by_name = {
        "Sergey Prokopyev": {"craft": "ISS", "days": "176"},
        "Dmitry Petelin": {"craft": "ISS", "days": "176"},
        "Frank Rubio": {"craft": "ISS", "days": "176"},
        "Fei Junlong": {"craft": "Tiangong", "days": "112"},
        "Deng Qingming": {"craft": "Tiangong", "days": "107"},
        "Zhang Lu": {"craft": "Tiangong", "days": "107"},
        "Stephen Bowen": {"craft": "ISS", "days": "54"},
        "Warren Hoburg": {"craft": "ISS", "days": "14"},
        "Sultan Al Neyadi": {"craft": "ISS", "days": "14"},
        "Andrey Fedyaev": {"craft": "ISS", "days": "14"}
    }

    # Ask the user to input the new astronaut's details
    name = input("Enter the astronaut's full name: ")
    spacecraft = input("Enter the name of the spacecraft: ")
    days = input("Enter the current number of days in space: ")

    # Add the new astronaut to the list
    add_new_astronaut(astronauts_by_name, name, spacecraft, days)

    # Output the details of the new astronaut
    print(f"\nAstronaut name: {name}")
    astronaut = astronauts_by_name[name]
    display_key_value_pairs(astronaut)


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    main()
