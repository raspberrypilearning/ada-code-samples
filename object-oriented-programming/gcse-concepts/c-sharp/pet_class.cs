/*
Raspberry Pi Foundation
Developed as part of Ada Computer Science 
Usage licensed under CC BY-NC-SA 4.0

Note: This file is designed to be copied out and compiled on your machine.
In order for it to compile properly you need to ensure that the project name is the same as the "namespace" in this file.
To run this file you need to:
1. Copy the contents
2. Paste them into the C# IDE of your choice (Visual Studio, for example)
3. Change the namespace to match your project (if necessary)
4. Compile the program
5. Run the program
*/

using System;

namespace AdaCodeSamples
{
    class Pet
    {
        private string name;
        private string petType;
        private string colour;
        private string mood;
        private bool sleeping;
        
        // Constructor method
        public Pet(string givenName, string givenType, string givenColour)
        {
            name = givenName;
            petType = givenType;
            colour = givenColour;
            sleeping = false;

            // Randomly choose a starting mood
            string[] allMoods = { "playful", "hungry", "sleepy" };
            Random rnd = new Random();
            int index = rnd.Next(allMoods.Length);
            mood = allMoods[index];
        }
        
        public string GetName()
        {
            return name;
        }
        
        public void SetName(string newName)
        {
            name = newName;
        }
        
        public string GetPetType()
        {
            return petType;
        }
        
        public void SetPetType(string newType)
        {
            petType = newType;
        }
        
        public string GetColour()
        {
            return colour;
        }
        
        public void SetColour(string newColour)
        {
            colour = newColour;
        }
        
        public string GetMood()
        {
            return mood;
        }
        
        public bool IsSleeping()
        {
            return sleeping;
        }
        
        public void Describe()
        {
            Console.WriteLine($"I am a {mood}, {colour} {petType} called {name}");
        }
        

        // A method for trying to play with the pet
        public void Play()
        {
            if (sleeping == true) {
                Console.WriteLine("Zzzzzzz. I am sleeping");
            }
            else if (mood == "hungry") {
                Console.WriteLine("I am too hungry to play");
            }
            else if (mood == "tired") {
                Console.WriteLine("I am too tired to play");
            }
            else {
                Console.WriteLine("This is fun, I love playing");  

                // Randomly choose a new mood
                string[] allMoods = { "playful", "hungry", "sleepy" };
                Random rnd = new Random();
                int index = rnd.Next(allMoods.Length);
                mood = allMoods[index];
            }
        }
        

        // A method for trying to feed the pet
        public void Feed()
        {
            if (sleeping == true) {
                Console.WriteLine("Zzzzzzz. I am sleeping");
            }
            else if (mood == "tired") {
                Console.WriteLine("I am too sleepy to eat anything now");
            }
            else if (mood == "playful") {
                Console.WriteLine("I am not hungry - I want to play");
            }
            else {
                Console.WriteLine("Yum - yum - that tastes great");
                mood = "playful";
            }
        }

        
        // A method for trying to put the pet to bed
        public void Sleep()
        {
            if (mood == "playful") {
                Console.WriteLine("I am too playful to sleep");
            }
            else if (mood == "hungry") {
                Console.WriteLine("I need something to eat before I can go to sleep");
            }
            else {
                Console.WriteLine("Zzzzzzzz");
                sleeping = true;
            }
        }
        

        // A method for trying to wake the pet up
        public void Wake()
        {
            if (sleeping == false) {
                Console.WriteLine("I wasn't even asleep!");
            }
            else {
                Console.WriteLine("I am awake and ready to play!");
                sleeping = false;
                mood = "playful";
            }
        }
        
        
    }
}