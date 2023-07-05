# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0
    

def main():
    # Declare and initialise the nested dictionary of astronauts
    astronauts_by_name = {
        "Sergey Prokopyev": {"craft": "ISS", "days": "176"},
        "Dmitry Petelin": {"craft": "ISS", "days": "176"},
        "Frank Rubio": {"craft": "ISS", "days": "176"},
        "Fei Junlong": {"craft": "Tiangong", "days": "112"},
        "Deng Qingming": {"craft": "Tiangong", "days": "107"},
        "Zhang Lu": {"craft": "Tiangong", "days": "107"},
        "Stephen Bowen": {"craft": "ISS", "days": "54"},
        "Warren Hoburg": {"craft": "ISS", "days": "14"},
        "Sultan Al Neyadi": {"craft": "ISS", "days": "14"},
        "Andrey Fedyaev": {"craft": "ISS", "days": "14"}
    }

    # Ask the user for the new number of days in space
    input_days = input("Enter the new number of days: ")

    # Update Fei Junlong's days in space
    astronauts_by_name["Fei Junlong"]["days"] = input_days

    # Output the updated number of days
    new_days = astronauts_by_name["Fei Junlong"]["days"]
    print(f"The days in space has been changed to {new_days}")


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    main()
