# Raspberry Pi Foundation
# Developed as part of Ada Computer Science
# 
# Usage licensed under CC BY-NC-SA 4.0

import random

class Pet:

    # Constructor method
    def __init__(self, given_name, given_type, given_colour):
        self.name = given_name
        self.pet_type = given_type
        self.colour = given_colour
        self.sleeping = False

        # Randomly choose a starting mood
        all_moods = ["playful", "hungry", "tired"]
        self.mood = random.choice(all_moods)

    def get_name(self):
        return self.name

    def set_name(self, new_name):
        self.name = new_name

    def get_pet_type(self):
        return self.pet_type

    def set_pet_type(self, new_type):
        self.pet_type = new_type

    def get_colour(self):
        return self.colour

    def set_colour(self, new_colour):
        self.colour = new_colour

    def get_mood(self):
        return self.mood

    def is_sleeping(self):
        return self.sleeping

    def describe(self):
        print(f"I am a {self.mood}, {self.colour} {self.pet_type} called {self.name}")


def main():
    # Ask the user to input the pet's information
    pet_name = input("Enter the name of your pet: ")
    pet_type = input(f"What type of animal is {pet_name}? ")
    pet_colour = input(f"What colour is {pet_name}? ")

    # Make a new pet object
    my_pet = Pet(pet_name, pet_type, pet_colour)

    # Output the pet attributes using getter methods
    name = my_pet.get_name()
    print(f"\nThe name of your pet is {name}")

    pet_type = my_pet.get_pet_type()
    print(f"Your pet is a {pet_type}")

    colour = my_pet.get_colour()
    print(f"Your pet is {colour}")

    mood = my_pet.get_mood()
    print(f"Your pet is feeling {mood}")
   
if __name__ == "__main__":
    main()
