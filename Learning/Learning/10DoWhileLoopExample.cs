using System;

namespace learning
{
    public class DoWhileLoopExample
    {
        // Method to demonstrate the do-while loop
        public static void DemonstrateDoWhileLoop()
        {
            // Initialize a counter variable
            int counter = 1;

            // Explain what the do-while loop will do
            Console.WriteLine("Demonstrating the do-while loop:");
            Console.WriteLine("This do-while loop will print numbers from 1 to 5.");

            // Start the do-while loop
            do
            {
                // Print the current value of counter
                Console.WriteLine("Counter: " + counter);

                // Increment the counter by 1
                counter++;
            }
            while (counter <= 5); // The loop continues as long as counter is less than or equal to 5

            Console.WriteLine("The do-while loop has finished because the counter exceeded 5.");
            Console.WriteLine(); // Add a blank line for clarity
        }

        // Method to demonstrate the while loop for comparison
        public static void DemonstrateWhileLoop()
        {
            // Initialize a counter variable
            int counter = 1;

            // Explain what the while loop will do
            Console.WriteLine("Demonstrating the while loop:");
            Console.WriteLine("This while loop will print numbers from 1 to 5.");

            // Start the while loop
            while (counter <= 5) // The loop continues as long as counter is less than or equal to 5
            {
                // Print the current value of counter
                Console.WriteLine("Counter: " + counter);

                // Increment the counter by 1
                counter++;
            }

            Console.WriteLine("The while loop has finished because the counter exceeded 5.");
            Console.WriteLine(); // Add a blank line for clarity
        }

        // Method to explain the differences between do-while and while loops
        public static void ExplainDifferences()
        {
            Console.WriteLine("Differences between do-while and while loops:");
            Console.WriteLine("1. The do-while loop always executes the loop body at least once, even if the condition is false initially.");
            Console.WriteLine("2. The while loop checks the condition before executing the loop body, so if the condition is false initially, the loop body may never execute.");
            Console.WriteLine("3. Use a do-while loop when you need to ensure the loop body runs at least once.");
            Console.WriteLine("4. Use a while loop when you want the loop to execute only if the condition is true from the start.");
            Console.WriteLine(); // Add a blank line for clarity
        }
    }
}