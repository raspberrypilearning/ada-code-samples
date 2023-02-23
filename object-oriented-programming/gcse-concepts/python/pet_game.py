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

    def play(self):
        """A method for trying to play with the pet"""
        if self.sleeping == True:
            print("Zzzzzzz. I am sleeping")
        elif self.mood == "hungry":
            print("I am too hungry to play")
        elif self.mood == "tired":
            print("I am too tired to play")
        else:
            print("This is fun, I love playing")

            # Randomly choose a new mood
            all_moods = ["playful", "hungry", "tired"]
            self.mood = random.choice(all_moods)

    def feed(self):
        """A method for trying to feed the pet"""
        if self.sleeping == True:
            print("Zzzzzzz. I am sleeping")
        elif self.mood == "tired":
            print("I am too sleepy to eat anything now")
        elif self.mood == "playful":
            print("I am not hungry - I want to play")
        else:
            print("Yum - yum - that tastes great")
            self.mood = "playful"

    def sleep(self):
        """A method for trying to put the pet to bed"""
        if self.mood == "playful":
            print("I am too playful to sleep")
        elif self.mood == "hungry":
            print("I need something to eat before I can go to sleep")
        else:
            print("Zzzzzzzz")
            self.sleeping = True

    def wake(self):
        """A method for trying to wake the pet up"""
        if self.sleeping == False:
           print("I wasn't even asleep!")
        else:
            print("I am awake and ready to play!")
            self.sleeping = False
            self.mood = "playful"



def change_pet(my_pet):
    """Allows pet to be changed"""

    # Ask the user to change the pet's name
    answer = input("\nDo you want to change the name of your pet(y/n)? ")
    if answer.lower() == "y":         
        new_name = input("Enter a new name for your pet ")
        my_pet.set_name(new_name)

    # Ask the user to change the pet's type
    answer = input("\nDo you want to change the type of pet you have(y/n)? ")
    if answer.lower() == "y":
        pet_name = my_pet.get_name()
        new_type = input(f"What type of animal is {pet_name}? ")
        my_pet.set_type(new_type)

    # Ask the user to change the pet's colour
    answer = input("\nDo you want to change the colour of your pet(y/n)? ")
    if answer.lower() == "y":
        pet_name = my_pet.get_name()
        new_colour = input(f"What colour is {pet_name}? ")
        my_pet.set_colour(new_colour)

    print()
    my_pet.describe()

def show_game_options():
    """Display options for playing game"""
    
    print()
    print(" 1. Feed your pet")
    print(" 2. Play with your pet")
    print(" 3. Put your pet to bed")
    print(" 4. Wake your pet up")
    print(" 5. Change pet")
    print(" 6. Finish the game")
    
def main():
    # Ask the user to input the pet's information
    pet_name = input("Enter a name for your pet: ")
    pet_type = input(f"What type of animal is {pet_name}? ")
    pet_colour = input(f"What colour is {pet_name}? ")

    # Make a new pet object
    my_pet = Pet(pet_name, pet_type, pet_colour)

    # Game loop for playing the game
    finished = False
    while finished == False:
        show_game_options()

        # Run a method depending on the user choice
        choice = input("What do you want to do? ")
        print()
        
        if choice == "1":
            my_pet.feed()
        elif choice == "2":
            my_pet.play()
        elif choice == "3":
            my_pet.sleep()
        elif choice == "4":
            my_pet.wake()
        elif choice == "5":
            change_pet(my_pet)
        elif choice == "6":
            # This will cause game to end
            finished = True
            print ("Thanks for playing the pet game")
        else:
            print("That is not a menu option")    

if __name__ == "__main__":
    main()
