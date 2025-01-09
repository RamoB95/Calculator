namespace Calculator
{
    using System;

    public class Calculator
    {
        public static void Main(string[] args)
        {
            bool continueCalculation = true;

            while (continueCalculation)
            {
                Console.WriteLine("Enter first number:");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter second number:");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Select operation (+, -, *, /):");
                char operation = Convert.ToChar(Console.ReadLine());

                double result = 0;

                switch (operation)
                {
                    case '+':
                        result = num1 + num2;
                        break;
                    case '-':
                        result = num1 - num2;
                        break;
                    case '*':
                        result = num1 * num2;
                        break;
                    case '/':
                        if (num2 == 0)
                        {
                            Console.WriteLine("Error: Division by zero is not allowed.");
                        }
                        else
                        {
                            result = num1 / num2;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid operation.");
                        break;
                }

                Console.WriteLine("Result: " + result);

                Console.WriteLine("Do you want to continue? (y/n)");
                char choice = Convert.ToChar(Console.ReadLine());

                if (choice == 'n' || choice == 'N')
                {
                    continueCalculation = false;
                }
            }

            Console.WriteLine("Calculator stopped.");
        }
    }
}
