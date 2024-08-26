using System;

namespace learning
{
    class ArithmeticOperator
    {
        // This method demonstrates how to multiply two numbers to calculate the area of a rectangle.
        public static void OperatorMultiply()
        {
            // Declare variables for the length and width of the rectangle.
            double length;
            double width;

            // Prompt the user to enter the length of the rectangle.
            Console.WriteLine("Please enter the length of the rectangle (as a number): ");
            length = Convert.ToDouble(Console.ReadLine());  // Convert the user input to a double and assign it to 'length'.

            // Prompt the user to enter the width of the rectangle.
            Console.WriteLine("Please enter the width of the rectangle (as a number): ");
            width = Convert.ToDouble(Console.ReadLine());  // Convert the user input to a double and assign it to 'width'.

            // Calculate the area of the rectangle by multiplying length and width.
            var area = length * width;

            // Output the calculated area to the console.
            Console.WriteLine($"The area of the rectangle with length {length} and width {width} is: {area}");
        }
    }
}
