using System;

namespace NotDivisibleNumbers
{
    class NotDivisibleNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                if (i % 3 == 0 || i% 7 ==0)
                {
                    continue;
                }
                Console.Write("{0} ", i);

                ////first version
                //int inputNumber = int.Parse(Console.ReadLine());

                //for (int i = 1; i <= inputNumber; i++)
                //{

                //    if (i % 3 != 0 && i % 7 != 0)
                //    {
                //        Console.Write("{0} ", i);
                //    }

                //}
            }
        }
    }
}
