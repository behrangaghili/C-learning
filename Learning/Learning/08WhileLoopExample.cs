using System;

namespace learning
{
    public class WhileLoopExample
    {
        // Method to demonstrate the while loop
        public static void DemonstrateWhileLoop()
        {
            // Initialize a counter variable
            int counter = 1;

            // Explain what the while loop will do
            Console.WriteLine("This while loop will print numbers from 1 to 5.");

            // Start the while loop
            while (counter <= 5) // The loop continues as long as counter is less than or equal to 5
            {
                // Print the current value of counter
                Console.WriteLine("Counter: " + counter);

                // Increment the counter by 1
                counter++;
            }

            // Explain that the loop has finished
            Console.WriteLine("The loop has finished because the counter exceeded 5.");
        }
    }
}