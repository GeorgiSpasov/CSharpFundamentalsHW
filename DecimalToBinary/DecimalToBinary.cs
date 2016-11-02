using System;

namespace DecimalToBinary
{
    class DecimalToBinary
    {
        static void Main(string[] args)
        {
            long decimalNumber = long.Parse(Console.ReadLine());
            string binaryNumber = null;

            while (decimalNumber > 0)
            {
                binaryNumber = Convert.ToString(decimalNumber % 2) + binaryNumber;
                decimalNumber /= 2;
            }

            Console.WriteLine(binaryNumber);
        }
    }
}
