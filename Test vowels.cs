using System;

namespace Vowel

{

internal class Program

{

static void Main(string[] args) { Console.WriteLine("Ricky 13"); String[] ary = { "a", "e", "i", "o", "u" };

int flag = 0;

Console.Write("Enter Letter here: "); String str = Console.ReadLine();

for (int i = 0; i < ary.Length; i++)

{

if (str.ToLower() = ary[i])

{

}

flag = 1;

}

if (flag == 1) {

Console.WriteLine(str + " is A Vowel"); }

else

{ Console.WriteLine(str + " is A Consonant");

}

}

}
