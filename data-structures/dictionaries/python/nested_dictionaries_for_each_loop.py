# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0


def display_all_astronauts(astronauts_by_name):
    """Display the key-value pairs of each astronaut in the nested dictionary"""

    # Repeat for each astronaut in the outer dictionary
    for name, astronaut in astronauts_by_name.items():
        print(name)
        # Repeat for each key-value pair in the inner dictionary
        for key, value in astronaut.items():
            print(f"{key} : {value}")
        print() # Print an extra line after each astronaut
    

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

    # Output the details of each astronaut in the dictionary
    print("Details of each astronaut:")
    display_all_astronauts(astronauts_by_name)


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    main()
