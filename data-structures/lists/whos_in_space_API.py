import requests

def examine_space():
    """API request and display data"""
    r = requests.get('http://api.open-notify.org/astros.json')
    data = r.json()  # Get JSON data
    print(data) # Display whole dataset

    
def examine_space_s2():
    """Demo dictionary methods"""
    r = requests.get('http://api.open-notify.org/astros.json')
    data = r.json()
    print(data.keys()) # Display keys
    print(data.values()) # Display values
    print(data.items()) # Display values

    
def examine_space_s3():
    """Get value for key and f-string"""
    r = requests.get('http://api.open-notify.org/astros.json')
    data = r.json()
    number_of_people = data.get("number") # Get value associated with number key
    print(f"There are {number_of_people} people in space")

    
def examine_space_s4():
    """If statement"""
    r = requests.get('http://api.open-notify.org/astros.json')
    data = r.json()
    msg = data.get("message")
    if msg == "success":
        number_of_people = data.get("number")
        print(f"There are {number_of_people} people in space")
    else:
        print("request failed")

        
def examine_space_s5():
    """For loop"""
    r = requests.get('http://api.open-notify.org/astros.json')
    data = r.json()   
    people = data.get("people") # Gets list of people
    for person in people:
        person_name = person.get("name") # Gets value associated with name key
        person_craft = person.get("craft")
        print(f"{person_name} is on the {person_craft}")

        
if __name__ == '__main__':
    examine_space()
