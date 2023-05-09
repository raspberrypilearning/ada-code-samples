# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0


def main():
    # Declare and initialise the astronaut list
    astronaut = ["ISS", "Sergey Prokopyev", "176"]
    
    # Ask the user for the new number of days in space
    new_days = input("Enter the new number of days: ")

    # Update the number of days value stored at index 2
    astronaut[2] = new_days

    # Output the updated number of days
    print(f"The days has been updated to {astronaut[2]}")


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    main()
