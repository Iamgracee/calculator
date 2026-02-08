using System;

public static class Calculator
{
       public static object? Calculate(int num1, int num2, char operation)
    {
        switch (operation)
        {
            case '+':
                return num1 + num2;

            case '-':
                return num1 - num2;

            case '*':
                return num1 * num2;

            case '/':
                if (num2 == 0)
                {
                    Console.WriteLine("Cannot divide by zero");
                    return null;
                }
                return (double)num1 / num2;

            case '%':
                if (num2 == 0)
                {
                    Console.WriteLine("Cannot modulo by zero");
                    return null;
                }
                return num1 % num2;

            case '=':
                return null;

            default:
                return null;
        }
    }
}

