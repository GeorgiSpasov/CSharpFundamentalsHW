using System;

namespace DecimalToHex
{
    class DecimalToHex
    {
        static void Main(string[] args)
        {
            long decimalNumber = long.Parse(Console.ReadLine());
            string numbers = "0123456789ABCDEF";
            string hexNumber = null;

            while (decimalNumber > 0)
            {
                hexNumber = numbers[Convert.ToInt32(decimalNumber % 16)] + hexNumber;
                decimalNumber /= 16;
            }

            Console.WriteLine(hexNumber);
        }
    }
}
