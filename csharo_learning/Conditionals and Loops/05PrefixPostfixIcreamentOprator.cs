using System;
using System.Collections.Generic;
using System.Text;

namespace learning
{
    class PrefixPostfixIcreamentOprator
    {
        public static void PrefixOprator()
       
        {
            int x = 3;
            int y = ++x;
            Console.WriteLine(x + " " + y);
        }
        public static void PostfixOprator()
        {
            int x = 3;
            int y = x++;
            Console.WriteLine(x + " " + y);
        }
    }
}
