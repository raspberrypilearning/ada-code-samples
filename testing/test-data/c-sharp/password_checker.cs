/*
Raspberry Pi Foundation
Developed as part of Ada Computer Science 
Usage licensed under CC BY-NC-SA 4.0

Note: This file is designed to be copied out and compiled on your machine.
In order for it to compile properly you need to ensure that the project name is the same as the "namespace" in this file.
To run this file you need to:
1. Copy the contents
2. Paste them into the C# IDE of your choice (Microsoft Visual Studio, for example)
3. Change the namespace to match your project (if necessary)
4. Compile the program
5. Run the program
*/

using System;

namespace AdaCodeSamples {
    class TestData {
        // The Main method is the entry point for all C# programs
        public static void Main() {
            string passwordToCheck = "test";
            bool result = CheckPassword(passwordToCheck);
            Console.WriteLine($"Valid password? {result}");
        }
        

        // Checks that a password length is between 8 and 14 characters. Returns True if valid
        public static bool CheckPassword(string password) {
            bool isValid = true;
            
            if (password.Length < 8 || password.Length > 14) {
                isValid = false;
            }

            return isValid;
        }


    }
}