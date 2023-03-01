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


