using System;
using System.Numerics;

namespace CalculateAgain
{
    class CalculateAgain
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger k = BigInteger.Parse(Console.ReadLine());

            BigInteger fact = 1;

            for (BigInteger i = n; i > k; i--)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);
        }
    }
}
