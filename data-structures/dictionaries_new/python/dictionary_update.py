# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0
    

def main():
    # Declare and initialise the astronaut dictionary
    astronaut = {"craft": "ISS", "name": "Sultan Al Neyadi", "days": "14"}

    # Update the days in space of the astronaut
    astronaut["days"] = 18

    # Output the updated number of days
    new_days = astronaut["days"]
    print(f"The days in space has been changed to {new_days}")


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    main()
