# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0
    

def main():
    # Declare and initialise the astronaut list
    astronaut = ["ISS", "Sergey Prokopyev", "176"]

    # Output the astronaut's spacecraft and name
    spacecraft = astronaut[0]
    name = astronaut[1]
    print(f"Astronaut {name} is on the {spacecraft}")


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    main()
