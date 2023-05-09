# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0


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

    # Output the first astronaut's spacecraft and name
    spacecraft = all_astronauts[0][0]
    name = all_astronauts[0][1]
    print(f"Astronaut {name} is on the {spacecraft}")


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    main()
