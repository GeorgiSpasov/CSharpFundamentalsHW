using System;

namespace GCD
{
    class GCD
    {
        static void Main(string[] args)
        {
            string stringNumber1 = null;
            string stringNumber2 = null;

            int a = 0;
            int b = 0;
            int gcd = 0;

            string input = Console.ReadLine();

            //reading numbers
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 32)
                {
                    int shift = i; //shift between the two numbers

                    for (int j = 0; j < shift; j++)
                    {
                        stringNumber1 += input[j];
                    }

                    for (int k = shift+1; k < input.Length; k++)
                    {
                        stringNumber2 += input[k];
                    }
                }
            }

            //comparing and parsing
            if (int.Parse(stringNumber1) > int.Parse(stringNumber2)) 
            {
                a = int.Parse(stringNumber1);
                b = int.Parse(stringNumber2);
            }
            else
            {
                a = int.Parse(stringNumber2);
                b = int.Parse(stringNumber1);
            }

            //calculating GCD
            while ((a != 0) && (b != 0))
            {
                if (a > b)
                {
                    a %= b;
                }
                else
                {
                    b %= a;
                }
            }

            gcd = a > b ? a : b; //choosing the devisor over the 0-remainder
            Console.WriteLine(gcd);
        }
    }
}
