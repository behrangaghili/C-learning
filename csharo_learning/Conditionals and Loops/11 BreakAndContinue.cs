using System;
using System.Collections.Generic;
using System.Text;

namespace learning
{
    class BreakAndContinue
    {
        public static void BreakAndContinueMethod()
        {

            int maxBid = Convert.ToInt32(Console.ReadLine());

            //your code goes here
            while (true)
            {
                int bid = Convert.ToInt32(Console.ReadLine());
                if (bid > maxBid)
                {
                    Console.WriteLine("Sold: " + bid);
                    break;
                }
                else
                {
                     Console.WriteLine("Bid Higher");
                }
            }
        }
    }
}
