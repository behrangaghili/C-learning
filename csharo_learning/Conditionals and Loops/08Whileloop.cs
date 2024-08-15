using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning
{
    class Whileloop
    {
        public static void WhileloopMethod()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int res = 0;
            //your code goes here
            while (num >= res)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine(res);
                    res = res + 2;

                }
                else if (num % 2 != 0)
                {

                    Console.WriteLine(res);
                    res = res + 2;
                }

            }

        }
    }
}