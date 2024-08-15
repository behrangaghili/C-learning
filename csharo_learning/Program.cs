using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace learning
{

    /* <summary>
  just learning some new cool things
 */
    public class Program
    {
        static void Main(string[] args)
        {
            new PrintingText();
            PrintingText.PrintingTextMethod();

            //new UserInput();
            //UserInput.GettingUserInput();

            //new ConvertUserInput();
            //ConvertUserInput.ConvertUserInputToInt32();

            //PrintingText.PrintingTextMethod();
            //02UserInput
            //UserInput.GettingUserInput();
            //03ConvertUserInput
            //ConvertUserInput.ConvertUserInputToInt32();
            //04Oprator
            //ArithmeticOprator.OpratorMultiply();


            //new PrefixPostfixIcreamentOprator();
            //PrefixPostfixIcreamentOprator.PostfixOprator();
            //PrefixPostfixIcreamentOprator.PrefixOprator();

            //PrefixPostfixIcreamentOprator.PostfixOprator();
            //PrefixPostfixIcreamentOprator.PrefixOprator();
            //new IfElse();
            //IfElse.IfElseMethod();

            //------------------------------------------------------------------------
            //new SwitchDefult();
            //SwitchDefult.SwitchDefultMethod();


            //// Loop to keep prompting the user until a valid option is selected
            //while (true)
            //{
            //    // Call the SwitchDefultMethod to display options and process user selection
            //    SwitchDefult.SwitchDefultMethod();

            //    // Optionally, ask the user if they want to continue or exit
            //    Console.Write("Would you like to select another option? (y/n): ");
            //    string response = Console.ReadLine();

            //    // Break the loop if the user responds with "n" or "N"
            //    if (response.Equals("n", StringComparison.OrdinalIgnoreCase))
            //    {
            //        break;
            //    }
            //}

            //------------------------------------------------------------------------

            //------------------------------------------------------------------------
            //08 Whileloop.WhileloopMethod();
            //Whileloop.WhileloopMethod();
            //09forloop
            //Forloop.ForloopMethod();
            // 10 Whileloop
            //DoWhile.DoWhileMethod();
            //11 BreakAndContinue
            //BreakAndContinue.BreakAndContinueMethod();
            //SwitchDefult.SwitchDefultMethod();
            var x = new logger();
            string y = "test";
            x.print(y);

        }
    }
}
