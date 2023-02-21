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
    class Program
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
            
            // Show that the pet object has been created
            Console.WriteLine(myPet);
        }

        
     }
}