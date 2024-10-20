namespace pract2

{

internal class Program

{

static void Main(string[] args)

{

Console.WriteLine("Money converter");

Console.WriteLine("Enter choice: 1)$ to INR 2) INR to $");

int c=Convert.ToInt32(Console.ReadLine()); if (c == 1)

{

Console.WriteLine("Enter amount ");

float amount = float. Parse(Console.ReadLine());

float moneydti = amount * 83.77f;

Console.WriteLine("the resulted amount is " + moneydti);

}

else if(c = 2)

{

Console.WriteLine("Enter amount ");

float amount = float.Parse(Console.ReadLine());

float moneyitod amount/83.77f; Console.WriteLine("the resulted amount is " + moneyitod);

}

Console.ReadKey();

}
