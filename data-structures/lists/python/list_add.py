# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0


def display_astronauts(astronauts):
    """Display the values from the given astronaut list"""

    print("\nAstronauts:")
    
    # Repeat for each value in the list
    for name in astronauts:
        print(name)


def main():
    # Declare and initialise the astronaut list
    astronauts = ["Sergey Prokopyev", "Frank Rubio", "Stephen Bowen"]

    # Ask the user to input another astronaut
    name = input("Enter the name of another astronaut: ")
    
    # Add the name to the end of the list
    astronauts.append(name)

    # Output the astronaut list
    display_astronauts(astronauts)


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    main()
