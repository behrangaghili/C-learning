using System;

namespace learning
{
    public class RefAndOutExample
    {
        // Method to run all ref and out examples
        public static void DemonstrateRefAndOut()
        {
            ExplainRef();
            DemonstrateRef();

            ExplainOut();
            DemonstrateOut();

            CompareRefAndOut();
            ExplainKeyDifferences();
        }

        private static void ExplainRef()
        {
            Console.WriteLine("Demonstrating ref:");
            Console.WriteLine("ref means the variable already has a value, and the method may read or modify it.");
            Console.WriteLine("The method works with the original variable, not a copy.");
            Console.WriteLine(); // Add a blank line for clarity
        }

        private static void DemonstrateRef()
        {
            int playerHealth = 100;

            Console.WriteLine("Scenario for ref: a player takes damage in a game.");
            Console.WriteLine("Before damage: " + playerHealth);

            // We must write ref in the method call because TakeDamage receives
            // the original playerHealth variable and changes that same variable.
            TakeDamage(ref playerHealth, 30);

            Console.WriteLine("After damage: " + playerHealth);
            Console.WriteLine(); // Add a blank line for clarity
        }

        private static void TakeDamage(ref int health, int damage)
        {
            // Because health is a ref parameter, this changes the original variable
            // that was passed to the method.
            health = health - damage;
        }

        private static void ExplainOut()
        {
            Console.WriteLine("Demonstrating out:");
            Console.WriteLine("out means the variable does not need a value before the method call.");
            Console.WriteLine("The method promises to assign a value before it finishes.");
            Console.WriteLine(); // Add a blank line for clarity
        }

        private static void DemonstrateOut()
        {
            int result;

            Console.WriteLine("Scenario for out: a method calculates a rectangle area and returns it as an extra value.");

            // result is not initialized before this call.
            // That is allowed because GetRectangleArea uses out and must assign result.
            GetRectangleArea(5, 10, out result);

            Console.WriteLine("Area: " + result);
            Console.WriteLine(); // Add a blank line for clarity
        }

        private static bool GetRectangleArea(int width, int height, out int area)
        {
            // This assignment is required. If an out parameter is not assigned
            // before the method ends, C# gives a compiler error.
            area = width * height;
            return true;
        }

        private static void CompareRefAndOut()
        {
            Console.WriteLine("Comparing ref and out:");

            int a = 5;
            AddTen(ref a);
            Console.WriteLine("ref example after AddTen: " + a);

            int b;
            CreateNumber(out b);
            Console.WriteLine("out example after CreateNumber: " + b);
            Console.WriteLine(); // Add a blank line for clarity
        }

        private static void AddTen(ref int number)
        {
            number += 10;
        }

        private static void CreateNumber(out int number)
        {
            number = 50;
        }

        private static void ExplainKeyDifferences()
        {
            Console.WriteLine("Key differences between ref and out:");
            Console.WriteLine("1. ref requires the variable to already have a value.");
            Console.WriteLine("2. out does not require the variable to already have a value.");
            Console.WriteLine("3. ref is useful when you want to modify existing data.");
            Console.WriteLine("4. out is useful when a method must return extra values.");
            Console.WriteLine("Mental model for ref: I already have a value; modify it.");
            Console.WriteLine("Mental model for out: Please create or fill the value for me.");
            Console.WriteLine(); // Add a blank line for clarity
        }
    }
}
