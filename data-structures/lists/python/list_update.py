# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0


def main():
    # Declare and initialise the astronaut list
    astronauts = ["Sergey Prokopyev", "Frank Rubio", "Fei Junlong"]

    # Update the name of the astronaut stored at index 2
    astronauts[2] = "Stephen Bowen"

    # Output the updated name
    print(f"The astronaut name has been changed to {astronauts[2]}")


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    main()
