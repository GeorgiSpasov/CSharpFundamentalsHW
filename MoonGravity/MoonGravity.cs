using System;

namespace MoonGravity
{
    class MoonGravity
    {
        static void Main(string[] args)
        {
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:f3}",weight*0.17);
        }
    }
}
