using System;

namespace ModifyBit
{
    class ModifyBit
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            byte position = byte.Parse(Console.ReadLine());
            byte value = byte.Parse(Console.ReadLine());

            if (value == 1)
            {
                int mask = 1 << position;
                int result = number | mask; 
                Console.WriteLine(result);
            }
            else
            {
                int mask = ~(1 << position);
                int result = number & mask;     
                Console.WriteLine(result);                        
            }                                                          



            //number ^= (-value ^ number) & (1 << position);

            //Console.WriteLine(number);

            
        }
    }
}
