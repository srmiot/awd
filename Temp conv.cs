namespace pract2

internal class Program

static void Main(string[] args)

{

Console.WriteLine("Temperature Converter");

Console.WriteLine("Enter choice: 1)cel to fahr 2) fahr to cel");

int c-Convert.ToInt32(Console.ReadLine());

if (c=1)

{

Console.WriteLine("Enter temperature "); float tem=float.Parse(Console.ReadLine());

float temtofahr = (tem * 9/5) + 32;

Console.WriteLine("the resulted atemperature in fahr is " + temtofahr);

} else if(c=2)

{

Console.WriteLine("Enter temperature "); float tem = float.Parse(Console.ReadLine()); float temtocel = (tem - 32) * 5/9;

} Console.ReadKey();

Console.WriteLine("the resulted temperature in cel is " + temtocel);

}
}
}
