using System;

namespace Calcualtor
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;
            Console.WriteLine("Console Calculator in C#/r");
            Console.WriteLine("-----------------------\n");

            while (!endApp)
            {
                string numInput1 = "";
                string numinput2 = "";
                double result = 0;

                Console.Write("Type a number, and the press Enter: ");
                numInput1 = Console.ReadLine();

                double cleanNum1 = 0;
                while (!double.TryParse(numInput1, out cleanNum1))
                {
                    Console.Write("This is not a valid input. Please enter an interger value: ");
                    numInput1 = Console.ReadLine();
                }

                Console.WriteLine("Type another number, then press Enter ");
                numinput2 = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(numinput2, out cleanNum2))
                {
                    Console.WriteLine(" This is not valid input. Please enter an Integer");
                    numinput2 = Console.ReadLine();
                }

                Console.WriteLine("Choose an operator from the following list:");
                Console.WriteLine("\ta - Add");
                Console.WriteLine("\ts -Subtract");
                Console.WriteLine("\tm - Multiply");
                Console.WriteLine("\td - Divide");

                string op = Console.ReadLine();

                try
                {
                    result = Calculator.DoOperation(cleanNum1, cleanNum2, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("This operation will result in a mathematical error");
                    }
                    else Console.WriteLine("Your result: {0:0.##}\n", result);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Oh no! An exception occured trying to do the math");
                }

                Console.WriteLine("---------------\n");

                Console.WriteLine("Press 'n' and Enter to close the app, or press any othher key");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n");
            }
            return;
            }
        }
    }

