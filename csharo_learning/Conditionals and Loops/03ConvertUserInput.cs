using System;
using System.Collections.Generic;
using System.Text;

namespace learning
{
    class ConvertUserInput
    {
        public static void ConvertUserInputToInt32()
        {
            string name = Console.ReadLine();
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Name: {0}\nAge: {1}", name, age);
        }
    }
}
