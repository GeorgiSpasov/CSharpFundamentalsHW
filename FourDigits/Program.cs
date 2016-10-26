using System;

namespace FourDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            // Calculates the sum of the digits
            int runner = inputNumber;
            int sum = 0;
            while (runner != 0)
            {
                sum += runner % 10;
                runner /= 10;
            }
            Console.WriteLine(sum);


            // Prints on the console the number in reversed order
            int left = inputNumber;
            int rev = 0;
            while (left > 0)
            {
                int r = left % 10;
                rev = rev * 10 + r;
                left = left / 10;
            }
            Console.WriteLine("{0:0000}", rev);


            // Puts the last digit in the first position
            int lastFirst = inputNumber;
            int lastDigit = lastFirst % 10 * 1000;
            lastFirst = lastFirst / 10 + lastDigit;
            Console.WriteLine("{0:0000}", lastFirst);


            // Exchanges the second and the third digits
            int[] numberToMix = new int[4];
            for (int i = 3; i >= 0; i--)
            {
                numberToMix[i] = inputNumber % 10;
                inputNumber /= 10;
            }

            int bufferNumberX = numberToMix[1];

            numberToMix[1] = numberToMix[2];
            numberToMix[2] = bufferNumberX;

            Console.WriteLine("{0}", string.Join("", numberToMix));
        }
    }
}
