# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0
    

def display_all_astronauts(all_astronauts):
    """Display the values of each astronaut in the nested list"""

    # Repeat for each astronaut in the outer list
    for astronaut in range(0, len(all_astronauts)):
        # Repeat for each value in the inner list
        for value in range(0, len(all_astronauts[astronaut])):
            print(all_astronauts[astronaut][value])
        print() # Print a new line after each astronaut


def main():
    # Declare and initialise the nested list of astronauts
    all_astronauts = [
        ["ISS", "Sergey Prokopyev", "176"],
        ["ISS", "Dmitry Petelin", "176"],
        ["ISS", "Frank Rubio", "176"],
        ["Tiangong", "Fei Junlong", "112"],
        ["Tiangong", "Deng Qingming", "107"],
        ["Tiangong", "Zhang Lu", "107"],
        ["ISS", "Stephen Bowen", "54"],
        ["ISS", "Warren Hoburg", "14"],
        ["ISS", "Sultan Al Neyadi", "14"],
        ["ISS", "Andrey Fedyaev", "14"]
    ]

    # Output the details of each astronaut in the list
    print("Details of each astronaut in the list:")
    display_all_astronauts(all_astronauts)


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    main()
