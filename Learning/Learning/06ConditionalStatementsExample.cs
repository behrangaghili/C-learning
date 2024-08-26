using System;

namespace learning
{
    public class ConditionalStatementsExample
    {
        // Method to demonstrate basic if statement
        public static void DemonstrateIfStatement()
        {
            int number = 10;

            Console.WriteLine("Demonstrating if statement: int number = 10;");
            Console.WriteLine("Checking if the number is greater than 5...");

            if (number > 5)
            {
                Console.WriteLine("The number is greater than 5.");
            }

            Console.WriteLine(); // Add a blank line for clarity
        }

        // Method to demonstrate if-else statement
        public static void DemonstrateIfElseStatement()
        {
            int number = 3;

            Console.WriteLine("Demonstrating if-else statement: int number = 3;");
            Console.WriteLine("Checking if the number is greater than or equal to 5...");

            if (number >= 5)
            {
                Console.WriteLine("The number is greater than or equal to 5.");
            }
            else
            {
                Console.WriteLine("The number is less than 5.");
            }

            Console.WriteLine(); // Add a blank line for clarity
        }

        // Method to demonstrate if-else if-else statement
        public static void DemonstrateIfElseIfElseStatement()
        {
            int number = 7;

            Console.WriteLine("Demonstrating if-else if-else statement: int number = 7;");
            Console.WriteLine("Checking the range of the number...");

            if (number > 10)
            {
                Console.WriteLine("The number is greater than 10.");
            }
            else if (number > 5)
            {
                Console.WriteLine("The number is greater than 5 but less than or equal to 10.");
            }
            else
            {
                Console.WriteLine("The number is 5 or less.");
            }

            Console.WriteLine(); // Add a blank line for clarity
        }
    }

     
}
