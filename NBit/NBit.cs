using System;

namespace NBit
{
    class NBit
    {
        static void Main(string[] args)
        {
            long p = long.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine()); 
            Console.WriteLine((p>>n)&1);  

        }
    }
}
