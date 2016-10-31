using System;

namespace ExchangeIfGreater
{
    class ExchangeIfGreater
    {
        static void Main(string[] args)
        {
            double numberOne = double.Parse(Console.ReadLine());
            double numberTwo = double.Parse(Console.ReadLine());

            if (numberOne < numberTwo)
            {
                Console.WriteLine("{0} {1}", numberOne, numberTwo);
            }
            else
            {
                Console.WriteLine("{0} {1}", numberTwo, numberOne);
            }
        }
    }
}
