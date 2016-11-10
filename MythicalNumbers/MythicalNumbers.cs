using System;

namespace MythicalNumbers
{
    class MythicalNumbers
    {
        static void Main(string[] args)
        {
            double digit1 = Convert.ToDouble(Console.Read()) - '0';
            double digit2 = Convert.ToDouble(Console.Read()) - '0';
            double digit3 = Convert.ToDouble(Console.Read()) - '0';

            if (digit3 == 0)
            {
                Console.WriteLine("{0:f2}", digit1 * digit2);
            }
            else if (digit3 > 0 && digit3 <= 5)
            {
                Console.WriteLine("{0:f2}", (digit1 * digit2) / digit3);
            }
            else
            {
                Console.WriteLine("{0:f2}", (digit1 + digit2) * digit3);
            }
        }
    }
}
