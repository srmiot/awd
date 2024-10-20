using System;

namespace pract2

{ class Problem2

{

public int Add(int x,int y) {

}

return x + y

public float Add(float x, int y)

{

return x + y

}

public int Add(int x, int y, int z)

{

return x + y + z

}

}

internal class Program

{

static void Main(string[] args)

{ Problem2 problem new Problem2(); Console.WriteLine("enter 3 int no."); int a = Convert.ToInt32(Console.ReadLine()); int b = Convert.ToInt32(Console.ReadLine()); int c = Convert.ToInt32(Console.ReadLine()); Console.WriteLine("enter float value"); float X = float.Parse(Console.ReadLine()); Console.WriteLine("Addition of 2 no.is"); Console.WriteLine(problem.Add(a, b)); Console.WriteLine("Addition of 2 no.is with different data type"); Console.WriteLine(problem.Add(x,c)); Console.WriteLine("Addition of 3 no.is"); Console.WriteLine(problem.Add(a,b,c));

Console.ReadKey();

}

}

}
