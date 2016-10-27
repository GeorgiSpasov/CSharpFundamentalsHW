using System;

namespace ModifyBit
{
    class ModifyBit
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            byte position = byte.Parse(Console.ReadLine());
            byte value = byte.Parse(Console.ReadLine());

            number ^= (-value ^ number) & (1 << position);

            Console.WriteLine(number);

            
        }
    }
}
