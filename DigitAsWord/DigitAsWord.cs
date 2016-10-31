using System;

namespace DigitAsWord
{
    class DigitAsWord
    {
        static void Main(string[] args)
        {
            string[] words = { "zero", "one", "two", "three", "four",
                               "five", "six", "seven", "eight", "nine" };
            int digit;

            if ((int.TryParse(Console.ReadLine(), out digit)) && digit >= 0 && digit <= 9)
            {
                Console.WriteLine(words[digit]);
            }
            else
            {
                Console.WriteLine("not a digit");
            }
        }
    }
}
