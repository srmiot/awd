using System;
namespace InterfaceDemo
{
   public interface Shape
    {
        double GetArea();

        double GetPerimeter();
    }
    public class Rectangle : Shape

    {
        public double Width;

        public double Height;

        public Rectangle(double width, double height)

        {

            Width = width;

            Height = height;

        }

        public double GetArea()

        {

            return Width * Height;

        }

        public double GetPerimeter()

        {

            return 2 * (Width + Height);

        }

    }

    public class Circle : Shape

    {

        public double Radius;

        public Circle(double radius)

        {

            Radius = radius;

        }

        public double GetArea()

        {

            return Math.PI * Radius * Radius;

        }

        public double GetPerimeter()

        {

            return 2 * Math.PI * Radius;

        }

    }

    class Program

    {

        static void Main(string[] args)

        {

            Shape rectangle = new Rectangle(5.0, 4.0);

            Shape circle = new Circle(3.0);

            Console.WriteLine("Rectangle:");

            Console.WriteLine($"Area: {rectangle.GetArea()}");

            Console.WriteLine($"Perimeter: {rectangle.GetPerimeter()}");

            Console.WriteLine("\nCircle:");

            Console.WriteLine($"Area: {circle.GetArea()}");

            Console.WriteLine($"Perimeter: {circle.GetPerimeter()}");

            Console.ReadLine();

        }

    }

}
