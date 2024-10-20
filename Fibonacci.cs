using System;

namespace Pract1._4Fibonacci

{

public class Fibonacci

{

static void Main()

{

int n = 0 s = 1 , t, c;

Console.WriteLine("Ricky 13");

Console.Write("Enter the count of numbers: ");

c = Convert.ToInt32(Console.ReadLine());

Console.Write("\n");

Console.WriteLine("The generated Fibonacci Series is: ");

Console.Write(n + " " + s + " ");

for (int i = 2 i < c i++)

{

t = n + s

Console.Write(t + " ");

n = s;

s = t

}

Console.WriteLine("\n");

}

}

}
