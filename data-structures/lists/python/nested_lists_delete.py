# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0


def delete_astronaut(all_astronauts, astronaut_index):
    """Delete an astronaut list at the given index"""

    del all_astronauts[astronaut_index]
    

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

    # Output the details of each astronaut in the list
    print("Details of each astronaut in the list:")
    display_all_astronauts(all_astronauts)

    # Delete the astronaut stored at index 0
    position = 0
    print(f"\nDelete the astronaut at position {position}")
    delete_astronaut(all_astronauts, position)

    # Output the details of each astronaut in the list
    print("\nDetails of each astronaut in the list:")
    display_all_astronauts(all_astronauts)


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    main()
