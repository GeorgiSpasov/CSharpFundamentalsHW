using System;
//using System.Numerics;

namespace Trailing0inN
{
    class Trailing0inN
    {
        static void Main(string[] args)
        {
            int zeroesCount = 0;
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; Math.Pow(5, j) <= i; j++)
                {
                    if (i % Math.Pow(5, j) == 0) zeroesCount++;
                }
            }
            Console.WriteLine(zeroesCount);


            //not optimal version
            //int n = int.Parse(Console.ReadLine());
            //BigInteger factorial = n;
            //string stringFactorial = null;
            //int zeroesCount = 0;

            ////calculating factorial
            //for (int i = 1; i < n; i++)
            //{
            //    factorial = factorial * i;
            //}

            ////counting zeroes
            //stringFactorial = Convert.ToString(factorial);

            //int j = stringFactorial.Length - 1;
            //while (stringFactorial[j] == '0')
            //{
            //    j--;
            //    zeroesCount++;
            //}

            //Console.WriteLine(zeroesCount);
        }
    }
}
