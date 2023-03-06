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

class Pet {
    private String name;
    private String petType;
    private String colour;
    private String mood;
    private boolean sleeping;

    // Constructor method
    public Pet(String givenName, String givenType, String givenColour) {
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

    public String getName() {
        return name;
    }

    public void setName(String newName) {
        name = newName;
    }

    public String getPetType() {
        return petType;
    }

    public void setPetType(String newType) {
        petType = newType;
    }

    public String getColour() {
        return colour;
    }

    public void setColour(String newColour) {
        colour = newColour;
    }

    public String getMood() {
        return mood;
    }

    public boolean isSleeping() {
        return sleeping;
    }

    public void describe() {
        System.out.println("I am a " + mood + ", " + colour + " " + petType + " called " + name);
    }


    // A method for trying to play with the pet
    public void play() {
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
    public void feed() {
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
    public void sleep() {
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
    public void wake() {
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