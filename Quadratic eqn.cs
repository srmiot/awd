namespace Console App3

class Program

1

static void FunQequation()

1

Console WriteLine("Enter coefficients (a, b, c) of the quadratic eqn a * x ^ 2 + bx + c = 0 ;^ " )

Console.Write("Enter a: ");

double a Convert. ToDouble(Console.ReadLine());

Console.Write("Enter b: ");

double b Convert. ToDouble(Console.ReadLine ()); double e Convert. ToDouble(Console.ReadLine());

Console.Write("Enter c: ");

double = bb - 4ac ; if (discriminant > 0)

double root1=(-b + Math. Sqrt(discriminant)) (2a)

double root2(-b-Math. Console.WriteLine("Roots art(discriminant)) / (2a) ; = [root]},Root2 = {root2) ");

ernal class Progra

tatic void Maints

Console.Write

Console.Write

int c-Conver

(c - 1)

Console.

1

float term

float term

Console

else if(c

Consc

float

float

Cons

Conso

else if (discriminant = 0)

double root = (- b) / (2a) ; Console.WriteLine($"Roots are real and same.\nRoot =\ root\ ");

else

out:

erat

rch

te

res

{

double realPart = (- b) / (2a) ;

double imaginaryPart = Math.Sqrt(-discriminant) / (2a) ; Console.WriteLine($"Roots are complex.\nRoot1 realPart} + {imaginaryPart}i,

er

Root2 =

(realPart) (imaginary Part) i");

er

}

Console.ReadLine();

}

static void Main(string[] args)

{

FunQequation();

}}}
