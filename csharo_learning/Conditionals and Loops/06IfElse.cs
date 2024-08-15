using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning
{
    // Define a class to demonstrate the use of if-else statements
    class IfElse
    {
        // A method to check if a payment can be made with the given balance
        public static void IfElseMethod()
        {
            // Ask the user to enter the payment amount
            Console.Write("Please enter the payment amount: ");
            double payment = Convert.ToDouble(Console.ReadLine());

            // Ask the user to enter the current balance
            Console.Write("Please enter the current balance: ");
            double balance = Convert.ToDouble(Console.ReadLine());

            // Check if the balance is greater than or equal to the payment amount
            if (balance >= payment)
            {
                // If the condition is true, print a message indicating that the payment is completed
                Console.WriteLine("Completed");
            }
            else
            {
                // If the condition is false, print a message indicating that there are insufficient funds
                Console.WriteLine("Insufficient funds");
            }
        }
    }
}

