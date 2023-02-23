/*
Raspberry Pi Foundation
Developed as part of Ada Computer Science
Usage licensed under CC BY-NC-SA 4.0

Note: This file is designed to be copied out and compiled on your machine.
In order for the program to compile properly in some IDEs, you need to ensure that the
class filename is the same as the class name with the main method in it.

To run this file you need to:
1. Copy the contents
2. Create a Java project in the IDE of your choice (Eclipse, for example)
3. Create a new Java Class that uses the same name as the class containing the main method in this program
4. Paste the contents into the new Java Class
5. Save and run the program
*/

import java.util.Random;
import java.util.Scanner;

class Pet
{
    private String name;
    private String petType;
    private String colour;
    private String mood;
    private boolean sleeping;

    // Constructor method
    public Pet(String givenName, String givenType, String givenColour)
    {
        name = givenName;
        petType = givenType;
        colour = givenColour;
        sleeping = false;

        // Randomly choose a starting mood
        String[] allMoods = { "playful", "hungry", "tired" };
        Random rnd = new Random();
        int index = rnd.nextInt(allMoods.length);
        mood = allMoods[index];
    }

    public String getName()
    {
        return name;
    }

    public void setName(String newName)
    {
        name = newName;
    }

    public String getPetType()
    {
        return petType;
    }

    public void setPetType(String newType)
    {
        petType = newType;
    }

    public String getColour()
    {
        return colour;
    }

    public void setColour(String newColour)
    {
        colour = newColour;
    }

    public String getMood()
    {
        return mood;
    }

    public boolean isSleeping()
    {
        return sleeping;
    }

    public void describe()
    {
        System.out.println("I am a " + mood + ", " + colour + " " + petType + " called " + name);
    }
}


class Testing
{
    // The main method is the entry point for all Java programs
    public static void main(String[] args)
    {
        // Use Scanner for reading user input from the console
        Scanner scanner = new Scanner(System.in);

        // Ask the user to input the pet's information
        System.out.println("Enter a name for your pet:");
        String petName = scanner.nextLine();

        System.out.println("What type of animal is " + petName + "?");
        String petType = scanner.nextLine();

        System.out.println("What colour is " + petName + "?");
        String petColour = scanner.nextLine();

        // Make a new pet object
        Pet myPet = new Pet(petName, petType, petColour);

        // Output the pet attributes using getter methods
        String name = myPet.getName();
        System.out.println("\nThe name of your pet is " + name);

        String type = myPet.getPetType();
        System.out.println("Your pet is a " + type);

        String colour = myPet.getColour();
        System.out.println("Your pet is " + colour);

        String mood = myPet.getMood();
        System.out.println("Your pet is feeling " + mood);
    }


}