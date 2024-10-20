using System;

namespace ConsoleApp4

{

internal class Program

{

static void Main(string[] args)

{

Console.WriteLine("Ricky 13");

int[] ary = {1, 2, 3, 4, 5, 6, 7 };

foreach (int i in ary)

{

Console.WriteLine("The Square of " + i + " is: " + (i * i));

}

}

}

}
