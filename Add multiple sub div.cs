using System;

namespace BasicOperation

{

    class Program

    {

        static void Main(string[] args)

        {

            Console.WriteLine("Enter the first number:");

            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number:");

            double num2 = Convert.ToDouble(Console.ReadLine());

            double sum = num1 + num2;

            double difference = num1 - num2;

            double product = num1 * num2;

            double quotient = num1 / num2;

            Console.WriteLine($"Addition : {sum}");

            Console.WriteLine($"Subtraction : {difference}");

            Console.WriteLine($"Multiplication : {product}");

            Console.WriteLine($"Division : {quotient}");

            Console.ReadLine();

        }

    }

}
