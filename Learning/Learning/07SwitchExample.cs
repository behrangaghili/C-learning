using System;

namespace learning
{
    class SwitchExample
    {
        public static void SwitchExampleMethod()
        {
            // Display the options to the user
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1 - Sports");
            Console.WriteLine("2 - Politics");
            Console.WriteLine("3 - Business");
            Console.WriteLine("4 - Technology");
            Console.WriteLine("5 - Art");

            int num;

            // Loop until a valid integer between 1 and 5 is entered
            while (true)
            {
                Console.Write("Please enter a number corresponding to an option (1-5): ");
                string input = Console.ReadLine();

                // Try to parse the input into an integer and check if it's within the valid range
                if (int.TryParse(input, out num) && num >= 1 && num <= 5)
                {
                    break; // Exit the loop if a valid number is entered
                }

                // Inform the user of the invalid entry
                Console.WriteLine("Invalid entry! Please enter a number between 1 and 5.");
            }

            // Switch statement to handle the user's selection
            switch (num)
            {
                case 1:
                    Console.WriteLine("You selected Sports.");
                    break;
                case 2:
                    Console.WriteLine("You selected Politics.");
                    break;
                case 3:
                    Console.WriteLine("You selected Business.");
                    break;
                case 4:
                    Console.WriteLine("You selected Technology.");
                    break;
                case 5:
                    Console.WriteLine("You selected Art.");
                    break;
                default:
                    // The default case should never be reached due to validation, but it's good practice to include it
                    Console.WriteLine("Not An Option");
                    break;
            }
        }
    }

}
