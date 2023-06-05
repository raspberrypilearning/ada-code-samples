# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0
    

def main():
    # Declare and initialise the astronaut dictionary
    astronaut = {"craft": "ISS", "name": "Sultan Al Neyadi", "days": "14"}

    # Output the name and spacecraft
    name = astronaut["name"]
    spacecraft = astronaut["craft"]
    print(f"Astronaut {name} is on the {spacecraft}")


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    main()
