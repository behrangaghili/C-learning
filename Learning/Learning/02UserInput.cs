using System;

namespace learning
{
    class UserInput
    {
        // This method demonstrates how to get user input for their name and age.
        public static void GettingUserInput()
        {
            // Explain to the user what the program will do.
            Console.WriteLine("I will ask for your name and age. Please enter your name as a string and your age as an integer.\n");

            // Prompt the user to enter their name.
            Console.WriteLine("What is your name?\n");
            string name = Console.ReadLine(); // Read the user's input and store it in the 'name' variable.

            // Prompt the user to enter their age.
            Console.WriteLine("What is your age?\n");
            int age = Convert.ToInt32(Console.ReadLine()); // Read the user's input, convert it to an integer, and store it in the 'age' variable.

            // Output the user's name and age to the console.
            Console.WriteLine("Thank you! Here is the information you provided:");
            Console.WriteLine("Name: {0}\nAge: {1}", name, age);
        }
    }
}

