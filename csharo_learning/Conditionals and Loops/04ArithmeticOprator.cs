using System;
using System.Collections.Generic;
using System.Text;

namespace learning
{
    class ArithmeticOprator
    {
        public static void OpratorMultiply()
        {
            
                //sides of the room
                double length;
                double width;
                length = Convert.ToDouble(Console.ReadLine());
                width = Convert.ToDouble(Console.ReadLine());
                var rectangular = length * width;
                Console.WriteLine(rectangular);
                //output the area

            
        }
    }
}
