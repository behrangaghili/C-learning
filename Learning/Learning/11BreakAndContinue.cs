using System;

namespace learning
{
    public class WhileLoopWithBreakAndContinue
    {
        // Method to demonstrate while loop with break
        public static void DemonstrateWhileLoopWithBreak()
        {
            // Initialize a counter variable
            int counter = 1;

            // Explain what the while loop with break will do
            Console.WriteLine("Demonstrating the while loop with break:");
            Console.WriteLine("This while loop will print numbers from 1 to 10, but will stop when the counter reaches 5.");

            // Start the while loop
            while (counter <= 10)
            {
                // Print the current value of counter
                Console.WriteLine("Counter: " + counter);

                // Break the loop if counter reaches 5
                if (counter == 5)
                {
                    Console.WriteLine("Counter reached 5, breaking the loop.");
                    break;
                }

                // Increment the counter by 1
                counter++;
            }

            Console.WriteLine("The loop has exited due to the break statement.");
            Console.WriteLine(); // Add a blank line for clarity
        }

        // Method to demonstrate while loop with continue
        public static void DemonstrateWhileLoopWithContinue()
        {
            // Initialize a counter variable
            int counter = 0;

            // Explain what the while loop with continue will do
            Console.WriteLine("Demonstrating the while loop with continue:");
            Console.WriteLine("This while loop will print odd numbers from 1 to 10, skipping even numbers.");

            // Start the while loop
            while (counter < 10)
            {
                // Increment the counter by 1
                counter++;

                // Use continue to skip even numbers
                if (counter % 2 == 0)
                {
                    continue;
                }

                // Print the current value of counter (odd numbers only)
                Console.WriteLine("Counter: " + counter);
            }

            Console.WriteLine("The loop has finished, demonstrating the use of the continue statement.");
            Console.WriteLine(); // Add a blank line for clarity
        }

        // Method to explain the differences between break and continue in a loop
        public static void ExplainBreakAndContinue()
        {
            Console.WriteLine("Differences between break and continue in a loop:");
            Console.WriteLine("1. The break statement is used to immediately exit the loop, stopping all further iterations.");
            Console.WriteLine("2. The continue statement is used to skip the current iteration and move to the next one without exiting the loop.");
            Console.WriteLine("3. Use break when you need to end the loop early based on a condition.");
            Console.WriteLine("4. Use continue when you want to skip specific iterations but still complete the loop.");
            Console.WriteLine(); // Add a blank line for clarity
        }
    }
}