using System;

namespace SumOfNNumbers
{
    class SumOfNNumbers
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            double sum = 0;
            
            for (int i = 0; i < n; i++)
            {
                sum += double.Parse(Console.ReadLine());
            }

            Console.WriteLine(sum);
        }
    }
}
