using System;

namespace QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double discriminant = b*b - 4*a*c;

            if (discriminant > 0)
            {
                Console.WriteLine("{0:f2}",((-b) - Math.Sqrt(discriminant)) / (2 * a));
                Console.WriteLine("{0:f2}",((-b) + Math.Sqrt(discriminant)) / (2 * a));
            }
            else if (discriminant == 0)
            {
                Console.WriteLine("{0:f2}", ((-b) - Math.Sqrt(discriminant)) / (2 * a));
            }
            else
            {
                Console.WriteLine("no real roots");
            }

        }
    }
}
