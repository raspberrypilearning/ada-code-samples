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

namespace AdaCodeSamples {
    class Pet {
        private string name;
        private string petType;
        private string colour;
        private string mood;
        private bool sleeping;
        
        // Constructor method
        public Pet(string givenName, string givenType, string givenColour) {
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
        
        public string GetName() {
            return name;
        }
        
        public void SetName(string newName) {
            name = newName;
        }
        
        public string GetPetType() {
            return petType;
        }
        
        public void SetPetType(string newType) {
            petType = newType;
        }
        
        public string GetColour() {
            return colour;
        }
        
        public void SetColour(string newColour) {
            colour = newColour;
        }
        
        public string GetMood() {
            return mood;
        }
        
        public bool IsSleeping() {
            return sleeping;
        }
        
        public void Describe() {
            Console.WriteLine($"I am a {mood}, {colour} {petType} called {name}");
        }
    }

    
    class Testing {
        // The Main method is the entry point for all C# programs
        public static void Main() {
            // Ask the user to input the pet's information
            Console.WriteLine("Enter a name for your pet:");
            string petName = Console.ReadLine();

            Console.WriteLine($"What type of animal is {petName}?");
            string petType = Console.ReadLine();

            Console.WriteLine($"What colour is {petName}?");
            string petColour = Console.ReadLine();

            // Make a new pet object
            Pet myPet = new Pet(petName, petType, petColour);

            // Demonstrate how to change the colour using a setter method
            Console.WriteLine("\nLet's change the colour.....");

            Console.WriteLine("What colour do you want your pet to be? ");
            string newColour = Console.ReadLine();
            myPet.SetColour(newColour);

            // Output the new colour using a getter method
            string name = myPet.GetName();
            string colour = myPet.GetColour();
            Console.WriteLine($"{name} is now {colour}");
        }


    }
}