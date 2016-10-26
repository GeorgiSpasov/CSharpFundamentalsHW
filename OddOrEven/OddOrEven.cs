using System;

namespace OddOrEven
{
    class OddOrEven
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine((x%2==0)? "even {0}": "odd {0}", x);
        }
    }
}
