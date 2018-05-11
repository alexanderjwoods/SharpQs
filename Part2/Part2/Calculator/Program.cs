using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator App");
            for (; ; )
            {
                Console.WriteLine();
                Console.WriteLine("Select an operator");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Square Root");
                Console.WriteLine("6. Power");
                Console.WriteLine("7. Exit");
                Console.Write("Operator: ");

                string response = Console.ReadLine();

                if (Int32.TryParse(response, out int selection))
                {
                    double answer = -1;
                    Calculations calculations = new Calculations();
                    switch(selection)
                    {
                        case 1:
                            answer = calculations.Add();
                            break;
                        case 2:
                            answer = calculations.Subtract();
                            break;
                        case 3:
                            answer = calculations.Multiply();
                            break;
                        case 4:
                            answer = calculations.Divide();
                            break;
                        case 5:
                            answer = calculations.Square();
                            break;
                        case 6:
                            answer = calculations.Power();
                            break;
                        case 7:
                            Console.WriteLine("Thanks for using!  Goodbye!");
                            Console.ReadLine();
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid Entry");
                            break;
                    }

                    Console.WriteLine($"The answer is {answer}");
                }
                else
                {
                    Console.WriteLine("Invalid Entry");
                }
            }
        }
    }
}