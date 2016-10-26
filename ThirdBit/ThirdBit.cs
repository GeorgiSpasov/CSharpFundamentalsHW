using System;

namespace ThirdBit
{
    class ThirdBit
    {
        static void Main(string[] args)
        {
            int p = 3;
            int x = int.Parse(Console.ReadLine());
            int mask = 1 << p;
            int xAndMask = x & mask;
            int bit = xAndMask >> p;
            Console.WriteLine(bit);


        }
    }
}
