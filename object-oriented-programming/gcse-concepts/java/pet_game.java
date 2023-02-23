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


    // A method for trying to play with the pet
    public void play()
    {
        if (sleeping == true) {
            System.out.println("Zzzzzzz. I am sleeping");
        }
        else if ("hungry".equals(mood)) {
            System.out.println("I am too hungry to play");
        }
        else if ("tired".equals(mood)) {
            System.out.println("I am too tired to play");
        }
        else {
            System.out.println("This is fun, I love playing");

            // Randomly choose a new mood
            String[] allMoods = { "playful", "hungry", "tired" };
            Random rnd = new Random();
            int index = rnd.nextInt(allMoods.length);
            mood = allMoods[index];
        }
    }


    // A method for trying to feed the pet
    public void feed()
    {
        if (sleeping == true) {
            System.out.println("Zzzzzzz. I am sleeping");
        }
        else if ("tired".equals(mood)) {
            System.out.println("I am too sleepy to eat anything now");
        }
        else if ("playful".equals(mood)) {
            System.out.println("I am not hungry - I want to play");
        }
        else {
            System.out.println("Yum - yum - that tastes great");
            mood = "playful";
        }
    }


    // A method for trying to put the pet to bed
    public void sleep()
    {
        if ("playful".equals(mood)) {
            System.out.println("I am too playful to sleep");
        }
        else if ("hungry".equals(mood)) {
            System.out.println("I need something to eat before I can go to sleep");
        }
        else {
            System.out.println("Zzzzzzzz");
            sleeping = true;
        }
    }


    // A method for trying to wake the pet up
    public void wake()
    {
        if (sleeping == false) {
            System.out.println("I wasn't even asleep!");
        }
        else {
            System.out.println("I am awake and ready to play!");
            sleeping = false;
            mood = "playful";
        }
    }


}


class TestingPetGame
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

        // Game loop for playing the game
        boolean finished = false;
        while (finished == false) {
            showGameOptions();

            // Run a method depending on the user choice
            System.out.println("What do you want to do? ");
            String choice = scanner.nextLine();
            System.out.println();

            if ("1".equals(choice)) {
                myPet.feed();
            }
            else if ("2".equals(choice)) {
                myPet.play();
            }
            else if ("3".equals(choice)) {
                myPet.sleep();
            }
            else if ("4".equals(choice)) {
                myPet.wake();
            }
            else if ("5".equals(choice)) {
                changePet(myPet);
            }
            else if ("6".equals(choice)) {
                // This will cause game to end
                finished = true;
                System.out.println("Thanks for playing the pet game");
            }
            else {
                System.out.println("That is not a menu option");
            }
        }
    }


    // Display options for playing game
    public static void showGameOptions()
    {
        System.out.println();
        System.out.println(" 1. Feed your pet");
        System.out.println(" 2. Play with your pet");
        System.out.println(" 3. Put your pet to bed");
        System.out.println(" 4. Wake your pet up");
        System.out.println(" 5. Change pet");
        System.out.println(" 6. Finish the game");
    }


    // Allows pet to be changed
    public static void changePet(Pet myPet)
    {
        // Use Scanner for reading user input from the console
        Scanner scanner = new Scanner(System.in);

        // Ask the user to change the pet's name
        System.out.println("\nDo you want to change the name of your pet (y/n)?");
        String answer = scanner.nextLine();

        if ("y".equalsIgnoreCase(answer)) {
            System.out.println("Enter a new name for your pet ");
            String newName = scanner.nextLine();
            myPet.setName(newName);
        }

        // Ask the user to change the pet's type
        System.out.println("\nDo you want to change the type of pet you have (y/n)?");
        answer = scanner.nextLine();

        if ("y".equalsIgnoreCase(answer)) {
            String petName = myPet.getName();
            System.out.println("What type of animal is " + petName + "?");
            String newType = scanner.nextLine();
            myPet.setPetType(newType);
        }

        // Ask the user to change the pet's colour
        System.out.println("\nDo you want to change the colour of your pet (y/n)?");
        answer = scanner.nextLine();

        if ("y".equalsIgnoreCase(answer)) {
            String petName = myPet.getName();
            System.out.println("What colour is " + petName + "?");
            String newColour = scanner.nextLine();
            myPet.setColour(newColour);
        }

        System.out.println();
        myPet.describe();
    }


}