using System;

namespace ConsoleApp4

{

internal class Program

{

static void Main(string[] args)

{

int num, rev = 0, rem, sum = 0; Console.WriteLine("Ricky 13"); Console.Write("Enter Number here: "); num = Convert.ToInt32(Console.ReadLine()); while (num != 0) {

rem = num % 10; sum = sum + rem; rev = rev * 10 + rem; num = num/10;

}

Console.WriteLine("The Reversed Number is: " + rev); Console.WriteLine("The Sum of Digits is: " + sum);

}

}

}
