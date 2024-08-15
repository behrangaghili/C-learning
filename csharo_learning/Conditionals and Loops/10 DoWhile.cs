using System;
using System.Collections.Generic;
using System.Text;

namespace learning
{
    class DoWhile
    {
        public static void DoWhileMethod()
        {
            /*A do-while loop is similar to a while loop, except
             * that a do-while loop is guaranteed to execute 
             * at least one time.*/
            int a = 0;
            do
            {
                Console.WriteLine(a);
                a++;
            } while (a < 5);
        }

    }
}
