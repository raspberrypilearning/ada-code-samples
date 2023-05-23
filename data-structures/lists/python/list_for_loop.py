# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0


def display_astronauts(astronauts):
    """Display the values from the given astronaut list"""

    print("Astronauts:")
    
    # Repeat for all the values in the list using the index i
    num_astronauts = len(astronauts)
    for i in range(num_astronauts):
        print(f"Index {i} contains the value {astronauts[i]}")
    print(f"There are {num_astronauts} astronauts in the list")


def main():
    # Declare and initialise the astronaut list
    astronauts = ["Frank Rubio", "Stephen Bowen", "Sultan Al Neyadi"]

    # Output the astronaut list
    display_astronauts(astronauts)


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    main()
