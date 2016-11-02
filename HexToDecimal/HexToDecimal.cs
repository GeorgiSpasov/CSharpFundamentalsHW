using System;
using System.Numerics;

namespace HexToDecimal
{
    class HexToDecimal
    {
        static void Main(string[] args)
        {
            BigInteger decimalNumber = 0;
            string hexDigits = "0123456789ABCDEF";
            string hexNumber = Console.ReadLine().ToUpper();

            for (int i = hexNumber.Length - 1, power = 0; i >= 0; i--, power++)
            {
                int hexDigitToDecimal = 0; //restart for every digit

                if (hexNumber[i] != '0')
                {
                    do                     //get the corresponding decimal digit
                    {
                        hexDigitToDecimal++;
                    } while (hexDigits[hexDigitToDecimal] != hexNumber[i]);
                }
                decimalNumber = decimalNumber + hexDigitToDecimal * (long)Math.Pow(16, power);
            }
            Console.WriteLine(decimalNumber);
        }
    }
}
