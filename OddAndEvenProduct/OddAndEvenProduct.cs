using System;

namespace OddAndEvenProduct
{
    class OddAndEvenProduct
    {
        static void Main(string[] args)
        {
            int counter = 1;
            long productOdd = 1;
            long productEven = 1;

            int n = int.Parse(Console.ReadLine());
            string numbers = Console.ReadLine();          

            foreach (var item in numbers)
            {
                if ((int)item != 32)
                {
                    if (counter % 2 == 1)
                    {
                        productOdd *= (int)item - 48;
                    }
                    else
                    {
                        productEven *= (int)item - 48;
                    }

                    counter++;
                }
                else
                {
                    continue;
                }
            }

            if (productOdd == productEven)
            {
                Console.WriteLine("yes {0}", productEven);
            }
            else
            {
                Console.WriteLine("no {0} {1}", productOdd, productEven);
            }
        }
    }
}
