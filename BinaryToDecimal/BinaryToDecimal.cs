using System;

namespace BinaryToDecimal
{
    class BinaryToDecimal
    {
        static void Main(string[] args)
        {
            long decimalNumber = 0;

            string binary = Console.ReadLine();

            for (int index = binary.Length-1, power = 0; index >= 0; index--, power++)
            {
                if ((binary[index] - '0') != 0)
                {
                    decimalNumber = decimalNumber + (binary[index] - '0') * (int)Math.Pow(2, power);
                }
            }

            Console.WriteLine(decimalNumber);
        }
    }
}
