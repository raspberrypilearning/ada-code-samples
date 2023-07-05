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

    # Ask the user for a key to find
    input_key = input("Enter a key (astronaut name): ")

    # Check if the key exists in the nested dictionary
    if input_key in astronauts_by_name:
        print("Key exists!")
        value = astronauts_by_name[input_key]
        print(f"Key: {input_key}, value: {value}")
    else:
        print("That key does not exist")


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    main()
