using System;

namespace Calculate
{
    class Calculate
    {
        static void Main(string[] args)
        {
            double N = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());

            double sum = 1 + 1 / x;

            long fact = 1;
            for (int i = 2; i <= N; i++)
            {
                fact *= i;
                sum += fact / Math.Pow(x, i);
            }
            Console.WriteLine("{0:F5}", sum);
        }
    }
}
