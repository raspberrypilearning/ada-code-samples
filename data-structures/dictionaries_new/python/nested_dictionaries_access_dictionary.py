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
        "Fei Junlong": {"craft": "Shenzhou 15", "days": "112"},
        "Deng Qingming": {"craft": "Shenzhou 15", "days": "107"},
        "Zhang Lu": {"craft": "Shenzhou 15", "days": "107"},
        "Stephen Bowen": {"craft": "ISS", "days": "54"},
        "Warren Hoburg": {"craft": "ISS", "days": "14"},
        "Sultan Al Neyadi": {"craft": "ISS", "days": "14"},
        "Andrey Fedyaev": {"craft": "ISS", "days": "14"}
    }

    # Retrieve the dictionary for Fei Junlong
    astronaut = astronauts_by_name["Fei Junlong"]

    # Output the astronaut's spacecraft and days
    spacecraft = astronaut["craft"]
    days = astronaut["days"]
    print(f"Fei Junlong has spent {days} days on the {spacecraft}")


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    main()
