# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0


def display_astronaut_details(astronaut):
    """Display the values from the given astronaut list"""

    print("\nAstronaut details:")
    
    # Repeat for all of the values in the list using the index i
    for i in range(len(astronaut)):
        print(f"Index {i} contains the value {astronaut[i]}")


def main():
    # Declare and initialise the astronaut list
    astronaut = ["ISS", "Sergey Prokopyev", "176"]

    # Output the astronaut's details
    display_astronaut_details(astronaut)


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    main()
