using System;
using System.Numerics;

namespace Calculate3
{
    class Calculate3
    {
        static void Main(string[] args)
        {
            double n = int.Parse(Console.ReadLine());
            double k = int.Parse(Console.ReadLine());
            double nMinusK = n - k;
            BigInteger factnMk = 1;
            BigInteger factN = 1;
            BigInteger factK = 1;

            for (int i = 1; i <= n; i++)
            {
                if (i <= k && i <= nMinusK)
                {
                    factN *= i;
                    factK *= i;
                    factnMk *= i;
                }
                else if (i <= k && i > nMinusK)
                {
                    factN *= i;
                    factK *= i;
                }
                else if (i > k && i <= nMinusK)
                {
                    factN *= i;
                    factnMk *= i;
                }
                else
                {
                    factN *= i;
                }
            }
            Console.WriteLine(factN / (factK * factnMk));
        }
    }
}
