# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0


def calculate_total_days(astronauts_by_name):
    """Calculate and return the sum of all the astronauts' days in space"""

    total_days = 0

    # Repeat for each astronaut in the outer dictionary
    for name, astronaut in astronauts_by_name.items():
        # Add the number of days to the total
        total_days += int(astronaut["days"])

    return total_days
    

def main():
    # Declare and initialise the nested dictionary of astronauts
    astronauts_by_name = {
        "Sergey Prokopyev": {"craft": "ISS", "days": "176"},
        "Dmitry Petelin": {"craft": "ISS", "days": "176"},
        "Frank Rubio": {"craft": "ISS", "days": "176"},
        "Fei Junlong": {"craft": "Shenzhou 15", "days": "112"},
        "Deng Qingming": {"craft": "Shenzhou 15", "days": "107"},
        "Zhang Lu": {"craft": "Shenzhou 15", "days": "107"},
        "Stephen Bowen": {"craft": "ISS", "days": "54"},
        "Warren Hoburg": {"craft": "ISS", "days": "14"},
        "Sultan Al Neyadi": {"craft": "ISS", "days": "14"},
        "Andrey Fedyaev": {"craft": "ISS", "days": "14"}
    }
    
    # Calculate the total number of days in space
    total = calculate_total_days(astronauts_by_name)
    print(f"Total number of days in space: {total}")


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    main()
