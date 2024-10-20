using System;



namespace DelegateDemo

{

    delegate int MathOperation(int x, int y);



    class Program

    {

        static void Main(string[] args)

        {

            int Add(int x, int y)

            {

                return x + y;

            }



            int Subtract(int x, int y)

            {

                return x - y;

            }



            MathOperation addOperation = new MathOperation(Add);

            MathOperation subtractOperation = new MathOperation(Subtract);



            int a = 10;

            int b = 5;



            int additionResult = addOperation(a, b);

            int subtractionResult = subtractOperation(a, b);



            Console.WriteLine($"Addition of {a} and {b} is: {additionResult}");

            Console.WriteLine($"Subtraction of {a} and {b} is: {subtractionResult}");



            Console.ReadLine();

        }

    }

}
