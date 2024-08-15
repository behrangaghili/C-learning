using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning
{
    class Forloop
    {
        public static void ForloopMethod()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            //your code goes here

            for (; N > 0; N -= 1)
            {
                sum += N;
            }
            Console.WriteLine(sum);
        }
    }
}