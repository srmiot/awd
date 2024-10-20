using System;

namespace BoxingUnboxingDemo

{

    class Program

    {

        static void Main(string[] args)

        {

            // Value type

            int valueType = 123;



            // Boxing: Converting value type to reference type (object)

            object boxedValue = valueType;

            Console.WriteLine($"Boxed Value: {boxedValue}");



            // Unboxing: Converting reference type (object) back to value type

            int unboxedValue = (int)boxedValue;

            Console.WriteLine($"Unboxed Value: {unboxedValue}");



            // Demonstrating the difference

            valueType = 456;

            Console.WriteLine($"Original Value Type after modification: {valueType}");

            Console.WriteLine($"Boxed Value after valueType modification: {boxedValue}");



            Console.ReadLine();

        }

    }

}

