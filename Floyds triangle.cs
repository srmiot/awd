using System;

namespace BasicOperation

{

    class Program

    {

        static void Main(string[] args)

        {

            Console.WriteLine("Enter the number of rows :");

            int n = Convert.ToInt32(Console.ReadLine());



            int number = 1; 

            for (int i = 1; i <= n; i++)

            {

                for (int j = 1; j <= i; j++)

                {

                    Console.Write(number + " ");

                    number++;

                }

                Console.WriteLine(); 

            }

            Console.ReadLine();

        }



    }

}
