using learning.Learning;
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
            //If we compile and run this program with command-line arguments like:
            //Program.exe Salam Khobi
            /*the out put is :
             Command-line arguments:
             Salam
             Khobi
             */
            if (args.Length > 0)
            {
                Console.WriteLine("Command-line arguments:");
                foreach (string arg in args)
                {
                    Console.WriteLine(arg);
                }
            }
            else
            {
                Console.WriteLine("No command-line arguments provided.");
            }
            //00PartialClass
            Greeting greeting = new Greeting();
            greeting.PrintHello();
            greeting.PrintWorld();
            //01 PrintingText
            PrintingText.PrintingTextMethod();
            //02UserInput
            UserInput.GettingUserInput();
            //03StringMethodsExample
            StringMethodsExample.DemonstrateStringMethods();
            //04Oprator
            ArithmeticOperator.OperatorMultiply();

            //05PrefixPostfixIcreamentOprator

            PrefixPostfixIncrementOperator.PrefixOperator();
            PrefixPostfixIncrementOperator.PostfixOperator();
            //06 Call methods to demonstrate if, if-else, and if-else if-else statements
            ConditionalStatementsExample.DemonstrateIfStatement();
            ConditionalStatementsExample.DemonstrateIfElseStatement();
            ConditionalStatementsExample.DemonstrateIfElseIfElseStatement();
            //07 Call the SwitchExampleMethod to demonstrate the switch statement
            SwitchExample.SwitchExampleMethod();

            //08 Call the DemonstrateWhileLoop method to show how the while loop works
            WhileLoopExample.DemonstrateWhileLoop();

            //09 Call the DemonstrateForLoop method to show how the for loop works
            LoopExamples.DemonstrateForLoop();

            //09 Call the DemonstrateForEachLoop method to show how the foreach loop works
            LoopExamples.DemonstrateForEachLoop();

            //09 Call the ExplainDifferences method to explain the differences between for and foreach loops
            LoopExamples.ExplainDifferences();


            //10 Call the DemonstrateDoWhileLoop method to show how the do-while loop works
            DoWhileLoopExample.DemonstrateDoWhileLoop();

            //10 Call the DemonstrateWhileLoop method to show how the while loop works
            DoWhileLoopExample.DemonstrateWhileLoop();

            //10 Call the ExplainDifferences method to explain the differences between do-while and while loops
            DoWhileLoopExample.ExplainDifferences();


            //11 Call the DemonstrateWhileLoopWithBreak method to show how break works in a while loop
            WhileLoopWithBreakAndContinue.DemonstrateWhileLoopWithBreak();

            //11 Call the DemonstrateWhileLoopWithContinue method to show how continue works in a while loop
            WhileLoopWithBreakAndContinue.DemonstrateWhileLoopWithContinue();

            //11 Call the ExplainBreakAndContinue method to explain the differences between break and continue
            WhileLoopWithBreakAndContinue.ExplainBreakAndContinue();
            //12 Create an instance of the Logger class
            var logger = new Logger();

            //12 Log a message using the Print method
            logger.Print("This is an informational message.");

            //12 Log another message
            logger.Print("Another log entry demonstrating Serilog usage.");

            //12 Wait for user input before closing the console window
            Console.ReadLine();
        }
    }
}
