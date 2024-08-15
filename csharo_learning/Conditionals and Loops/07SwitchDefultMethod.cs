using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning
{
    class SwitchDefult
    {
        public static void SwitchDefultMethod()
        {
            // Display the options to the user
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1 - Sports");
            Console.WriteLine("2 - Politics");
            Console.WriteLine("3 - Business");
            Console.WriteLine("4 - Technology");
            Console.WriteLine("5 - Art");

            // Read the selected option from the user

            // Loop until a valid integer is entered
            int num = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                Console.Write("Please enter a number corresponding to an option: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out num) && num >= 1 && num <= 5)
                {
                    break; // Exit the loop if a valid number is entered
                }

                Console.WriteLine("Invalid entry! Please enter a number between 1 and 5.");
            }

            // Switch statement to handle the user's selection
            switch (num)
            {
                case 1:
                    Console.WriteLine("Sports");
                    break;
                case 2:
                    Console.WriteLine("Politics");
                    break;
                case 3:
                    Console.WriteLine("Business");
                    break;
                case 4:
                    Console.WriteLine("Technology");
                    break;
                case 5:
                    Console.WriteLine("Art");
                    break;
                default:
                    // If the user enters a number that's not an option, print a message indicating that it's not an option
                    Console.WriteLine("Not An Option");
                    break;
            }
        }
    }
}
