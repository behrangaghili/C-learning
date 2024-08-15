using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning
{
    class UserInput
    {
        public static void GettingUserInput()
        {
            Console.WriteLine("I will ask your name and age , please enter your name as string and your age as int \n ");
            Console.WriteLine("what is your Name?\n ");
            string name = Console.ReadLine();
            Console.WriteLine("what is your Age?\n ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Name: {0}\nAge: {1}", name, age);
        
        }
    }

}
