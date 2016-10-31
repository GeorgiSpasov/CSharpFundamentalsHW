using System;

namespace BiggestOf3
{
    class BiggestOf3
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());

            if (num1>num2 && num1>num3)
            {
                Console.WriteLine(num1);
            }
            else if (num1<num2 && num2>num3)
            {
                Console.WriteLine(num2);
            }
            else
            {
                Console.WriteLine(num3);
            }
        }
    }
}
