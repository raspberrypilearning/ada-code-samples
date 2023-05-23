# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0


def display_astronauts(astronauts):
    """Display the values from the given astronaut list"""

    print("Astronauts:")
    
    # Repeat for each value in the list
    for name in astronauts:
        print(name)


def main():
    # Declare and initialise the astronaut list
    astronauts = ["Sergey Prokopyev", "Frank Rubio", "Stephen Bowen", "Sultan Al Neyadi"]

    # Delete the astronaut stored at index 0
    del astronauts[0]

    # Output the astronaut list
    display_astronauts(astronauts)


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    main()
