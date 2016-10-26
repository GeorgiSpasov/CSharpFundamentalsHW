using System;

namespace DevideBy7and5
{
    class DevideBy7and5
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(((x % 5 == 0)&&(x % 7 == 0)) ? "true {0}" : "false {0}", x);
        }
    }
}
