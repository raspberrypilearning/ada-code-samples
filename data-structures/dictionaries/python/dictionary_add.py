# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0
    

def main():
    # Declare and initialise the astronaut dictionary
    astronaut = {"craft": "ISS", "name": "Sultan Al Neyadi", "days": "14"}

    # Ask the user for the country of origin
    input_country = input("Enter the astronaut's country: ")

    # Add the country key-value pair to the dictionary
    astronaut["country"] = input_country

    # Output the country of origin
    new_country = astronaut["country"]
    print(f"The country {new_country} has been added")


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    main()
