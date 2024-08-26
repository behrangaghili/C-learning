using System;

namespace learning
{
    public class LoopExamples
    {
        // Method to demonstrate the for loop
        public static void DemonstrateForLoop()
        {
            // Explain what the for loop will do
            Console.WriteLine("Demonstrating the for loop:");
            Console.WriteLine("This for loop will iterate through numbers from 1 to 5.");

            // for loop to iterate from 1 to 5
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Iteration " + i);
            }

            Console.WriteLine(); // Add a blank line for clarity
        }

        // Method to demonstrate the foreach loop
        public static void DemonstrateForEachLoop()
        {
            // Create an array of strings to demonstrate the foreach loop
            string[] fruits = { "Apple", "Banana", "Cherry", "Date", "Elderberry" };

            // Explain what the foreach loop will do
            Console.WriteLine("Demonstrating the foreach loop:");
            Console.WriteLine("This foreach loop will iterate through each element in the fruits array.");

            // foreach loop to iterate through each element in the array
            foreach (string fruit in fruits)
            {
                Console.WriteLine("Fruit: " + fruit);
            }

            Console.WriteLine(); // Add a blank line for clarity
        }

        // Method to explain the differences between for and foreach loops
        public static void ExplainDifferences()
        {
            Console.WriteLine("Differences between for and foreach loops:");
            Console.WriteLine("1. The for loop is used when you need to iterate a specific number of times, often with an index variable.");
            Console.WriteLine("2. The foreach loop is used to iterate over collections (like arrays or lists) without needing an index.");
            Console.WriteLine("3. In a for loop, you have more control over the iteration process, such as skipping or modifying elements.");
            Console.WriteLine("4. In a foreach loop, you can easily access each element in a collection, but you cannot modify the collection itself during iteration.");
            Console.WriteLine("5. The for loop can be more complex to set up, but it is more flexible for certain tasks.");
            Console.WriteLine("6. The foreach loop is simpler and more readable, especially when working with collections.");
            Console.WriteLine(); // Add a blank line for clarity
        }
    }
}