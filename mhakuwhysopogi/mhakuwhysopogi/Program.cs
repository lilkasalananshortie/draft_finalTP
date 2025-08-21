// See https://aka.ms/new-console-template for more information
using System;

namespace mhakuwhysopogi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SIMPLE OPERAND CALCULATOR");

            Console.Write("ENTER NUMBER 1: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.Write("ENTER NUMBER 2: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Choose an operator (+, -, *, /): ");
            string Operators = Console.ReadLine();

            if (Operators == "+")
            {
                int answer = num + num1;
                Console.WriteLine("The sum of " + num + " and " + num1 + " is " + answer);
            }
            else if (Operators == "-")
            {
                int answer = num - num1;
                Console.WriteLine("The difference between " + num + " and " + num1 + " is " + answer);
            }
            else if (Operators == "*")
            {
                int answer = num * num1;
                Console.WriteLine("The product of " + num + " and " + num1 + " is " + answer);
            }
            else if (Operators == "/")
            {
                if (num1 == 0)
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
                else
                {
                    double answer = (double)num / num1;
                    Console.WriteLine("The quotient of " + num + " and " + num1 + " is " + answer);
                }
            }
            else
            {
                Console.WriteLine("Invalid operator. Please try again.");
            }
        }
    }
}




