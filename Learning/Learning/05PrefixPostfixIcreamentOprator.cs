using System;
using System.Collections.Generic;
using System.Text;

namespace learning
{
    class PrefixPostfixIncrementOperator
    {
        // This method demonstrates the prefix increment operator (++x)
        public static void PrefixOperator()
        {
            Console.WriteLine("Prefix Increment Operator Demonstration:");

            int x = 3;    // Initialize x with the value 3
            Console.WriteLine("Initial value of x: " + x);

            int y = ++x;  // Prefix increment: x is incremented to 4, then y is assigned the value of x
            Console.WriteLine("After applying ++x (prefix increment): x is incremented to 4, y is assigned the value of x");

            Console.WriteLine("x: " + x + ", y: " + y); // Output: 4 4
            Console.WriteLine(); // For a blank line between outputs
        }

        // This method demonstrates the postfix increment operator (x++)
        public static void PostfixOperator()
        {
            Console.WriteLine("Postfix Increment Operator Demonstration:");

            int x = 3;    // Initialize x with the value 3
            Console.WriteLine("Initial value of x: " + x);

            int y = x++;  // Postfix increment: y is assigned the value of x (3), then x is incremented to 4
            Console.WriteLine("After applying x++ (postfix increment): y is assigned the value of x (before increment), then x is incremented");

            Console.WriteLine("x: " + x + ", y: " + y); // Output: 4 3
            Console.WriteLine(); // For a blank line between outputs
        }
    }
}
