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
            string[] allMoods = { "playful", "hungry", "tired" };
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
                string[] allMoods = { "playful", "hungry", "tired" };
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


    class TestingPetGame
    {
        // The Main method is the entry point for all C# programs
        public static void Main()
        {
            // Ask the user to input the pet's information
            Console.WriteLine("Enter a name for your pet:");
            string petName = Console.ReadLine();

            Console.WriteLine($"What type of animal is {petName}?");
            string petType = Console.ReadLine();

            Console.WriteLine($"What colour is {petName}?");
            string petColour = Console.ReadLine();

            // Make a new pet object
            Pet myPet = new Pet(petName, petType, petColour);
            
            // Game loop for playing the game
            bool finished = false;
            while (finished == false) {
                ShowGameOptions();

                // Run a method depending on the user choice
                Console.WriteLine("What do you want to do? ");
                string choice = Console.ReadLine();
                Console.WriteLine();
                
                if (choice == "1") {
                    myPet.Feed();
                }
                else if (choice == "2") {
                    myPet.Play();
                }
                else if (choice == "3") {
                    myPet.Sleep();
                }
                else if (choice == "4") {
                    myPet.Wake();
                }
                else if (choice == "5") {
                    ChangePet(myPet);
                }
                else if (choice == "6") {
                    // This will cause game to end
                    finished = true;
                    Console.WriteLine("Thanks for playing the pet game");
                }
                else {
                    Console.WriteLine("That is not a menu option");
                }
            }
        }
        
        
        // Display options for playing game
        public static void ShowGameOptions()
        {
            Console.WriteLine();
            Console.WriteLine(" 1. Feed your pet");
            Console.WriteLine(" 2. Play with your pet");
            Console.WriteLine(" 3. Put your pet to bed");
            Console.WriteLine(" 4. Wake your pet up");
            Console.WriteLine(" 5. Change pet");
            Console.WriteLine(" 6. Finish the game");
        }
        
        
        // Allows pet to be changed
        public static void ChangePet(Pet myPet)
        {
            // Ask the user to change the pet's name
            Console.WriteLine("\nDo you want to change the name of your pet (y/n)?");
            string answer = Console.ReadLine();

            if (answer.ToLower() == "y") {
                Console.WriteLine("Enter a new name for your pet ");
                string newName = Console.ReadLine();
                myPet.SetName(newName);
            }

            // Ask the user to change the pet's type
            Console.WriteLine("\nDo you want to change the type of pet you have (y/n)?");
            answer = Console.ReadLine();

            if (answer.ToLower() == "y") {
                string petName = myPet.GetName();
                Console.WriteLine($"What type of animal is {petName}?");
                string newType = Console.ReadLine();
                myPet.SetPetType(newType);
            }

            // Ask the user to change the pet's colour
            Console.WriteLine("\nDo you want to change the colour of your pet (y/n)?");
            answer = Console.ReadLine();
            
            if (answer.ToLower() == "y") {
                string petName = myPet.GetName();
                Console.WriteLine($"What colour is {petName}?");
                string newColour = Console.ReadLine();
                myPet.SetColour(newColour);
            }

            Console.WriteLine();
            myPet.Describe();
        }


    }
}