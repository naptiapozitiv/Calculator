using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int num1 = 0;
                int num2 = 0;
                double result = 0;

                Console.WriteLine("Calculator Pragram");

                Console.Write("Enter number 1: ");
                while (!int.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("Invalid input. Please enter an integer");
                    Console.Write("Enter number 1: ");
                }
                Console.WriteLine("Enter an option:");
                Console.WriteLine("\t+ : Add");
                Console.WriteLine("\t- : Subtrack");
                Console.WriteLine("\t* : Multiply");
                Console.WriteLine("\t/ : Divide");
                Console.WriteLine("Enter an option:");
                string function = Console.ReadLine();

                Console.Write("Enter number 2: ");
                while (!int.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("Invalid input. Please enter an integer.");
                    Console.Write("Enter number 2:");
                }

                switch (function)
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"Your result: {num1} + {num2}= " + result);
                        break;

                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Your result: {num1} - {num2}= " + result);
                        break;

                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"Your result: {num1} * {num2}= " + result);
                        break;

                    case "/":
                        // now we should check num2 shoud not be zero to avoid division by zero
                        if (num2 != 0)
                        {
                            //for result to be in double even if num 1 and num2 in int
                            result = (double)num1 / num2;
                            Console.WriteLine($"Your result: {num1} / {num2}= " + result);
                        }
                        else
                        {
                            Console.WriteLine("Error: Division by zero is not allowed.");
                        }
                        break;
                    default:

                        Console.WriteLine("That was not a valid option");
                        break;

                }
                //Loop in case they would like to continue using calculator
                Console.WriteLine("Would you like to continue (Y = yes, N = no)");
                // If user will put capital letter
            } while (Console.ReadLine().ToUpper() == "Y");



            //in case they would like to exit calculator 4
            Console.WriteLine("Bye!");

        }
    }
}
