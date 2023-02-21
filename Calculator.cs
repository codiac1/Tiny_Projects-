using System;

namespace CalculatorConsoleApp
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey! I am a Calculator :) \n I can do the following operations: + , - , * , / ");
            Console.WriteLine("Enter the first number:");
            string input1 = Console.ReadLine();
            int num1;

            while (!int.TryParse(input1, out num1))
            {
                Console.WriteLine("Oops! Input a valid number:");
                input1 = Console.ReadLine();
            }

            Console.WriteLine("Enter the second number:");
            string input2 = Console.ReadLine();
            int num2;

            while (!int.TryParse(input2, out num2))
            {
                Console.WriteLine("Oops! Input a valid number:");
                input2 = Console.ReadLine();
            }

            Console.WriteLine("Enter the Operator:");
            string op = Console.ReadLine();

            while (!(op == "*" || op == "-" || op == "+" || op == "/"))
            {
                Console.WriteLine("Oops! Input a valid operator:");
                op = Console.ReadLine();
            }

            if (op == "+")
                Console.WriteLine(num1 + num2);
            else if (op == "-")
                Console.WriteLine(num1 - num2);
            else if (op == "*")
                Console.WriteLine(num1 * num2);
            else if (op == "/")
            {
                if (num2 == 0)
                    Console.WriteLine("Oops! Cannot divide by zero");
                else
                    Console.WriteLine(num1 / num2);
            }
        }
    }
}
