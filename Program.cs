using System;

class Program
{
    public static void Main(string[] args)
    {
        bool isRunning = true;

        while (isRunning)
        {
            int num1, num2;

            while (true)
            {
                Console.Write("Enter first number: ");
                if (int.TryParse(Console.ReadLine(), out num1))
                    break;

                Console.WriteLine("Invalid input. Please enter a whole number.");
            }

            while (true)
            {
                Console.Write("Enter second number: ");
                if (int.TryParse(Console.ReadLine(), out num2))
                    break;

                Console.WriteLine("Invalid input. Please enter a whole number.");
            }

            char operation;
            bool validOperation = false;

            while (!validOperation)
            {
                Console.Write("Choose operation (+, -, *, /, %, =): ");
                if (!char.TryParse(Console.ReadLine(), out operation))
                {
                    Console.WriteLine("Incorrect Operation Used, please try again");
                    continue;
                }

                if (operation == '+' || operation == '-' || operation == '*' ||
                    operation == '/' || operation == '%' || operation == '=')
                {
                    validOperation = true;

                    var result = Calculate(num1, num2, operation);

                    if (operation == '=')
                    {
                        isRunning = false;
                        break;
                    }

                    if (result != null)
                        Console.WriteLine("Result: " + result);
                }
                else
                {
                    Console.WriteLine("Incorrect Operation Used, please try again");
                }
            }

            Console.WriteLine();
        }

        Console.WriteLine("Program terminated.");
    }

