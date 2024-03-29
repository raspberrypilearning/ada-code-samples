# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0


class Boat:

    def __init__(self, given_name, given_length, given_capacity, given_berths, given_unit_cost):
        self.__name = given_name
        self.__length = given_length
        self.__capacity = given_capacity
        self.__berths = given_berths
        self.__unit_cost = given_unit_cost


# This code will run if this file is executed directly
# (i.e. not called by another program)
if __name__ == "__main__":
    name = "Sir David Attenborough"
    length = 128.9
    capacity = 88
    berths = 90
    cost = 200000000
    
    # Instantiate a new boat object
    boaty = Boat(name, length, capacity, berths, cost)

    # Show that the boat object has been created
    print(boaty)
