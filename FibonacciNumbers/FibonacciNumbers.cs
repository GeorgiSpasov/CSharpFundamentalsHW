using System;

namespace FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            
            int a = -1;
            int b = 1;
            int c = 0;

            for (int i = 0; i < (n-1); i++)
            {
                c = a + b;

                Console.Write("{0}, ", c);
                a = b;
                b = c;
            }
            Console.WriteLine(a+b);
        }
    }
}
