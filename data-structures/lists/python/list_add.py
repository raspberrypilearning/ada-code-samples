# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0


def display_astronaut_details(astronaut):
    """Display the values from the given astronaut list"""

    print("\nAstronaut details:")
    
    # Repeat for each value in the list
    for value in astronaut:
        print(value)


def main():
    # Declare and initialise the astronaut list
    astronaut = ["ISS", "Sergey Prokopyev", "176"]

    # Ask the user to input the astronaut's country of origin
    country = input("Enter the astronaut's country of origin: ")
    
    # Add the country to the end of the list
    astronaut.append(country)

    # Output the astronaut's details
    display_astronaut_details(astronaut)


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    main()
