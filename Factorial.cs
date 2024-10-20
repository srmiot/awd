using System;

namespace pract2

{

internal class Program

{

static void Main(string[] args)

{ Console.WriteLine("Enter a number"); int a = Convert.ToInt32(Console.ReadLine()); int f = 1 for (int i = 2 i <= a i++)

{

f =f^ * i;

} Console.WriteLine("the factorial of "+ a +" is "+f); Console.ReadKey();

}

}

}
