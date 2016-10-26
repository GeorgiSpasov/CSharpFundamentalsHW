using System;

namespace PrimeCheck
{
    class PrimeCheck
    {
        static void Main(string[] args)
        {
            
            int x = int.Parse(Console.ReadLine());
            if ((x > 1) && (x < 100))
            {
                int divider = 2;
                int maxDivider = (int)Math.Sqrt(x);
                bool check = true;


                while (check && (divider <= maxDivider))
                {
                    if ((x % divider) == 0)
                    {
                        check = false;
                    }
                    divider++;
                }
                
                Console.WriteLine(check.ToString().ToLower());
            }
            else
            {
                Console.WriteLine("false");
            }
        }
 
    }
}