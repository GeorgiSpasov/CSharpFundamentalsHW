using System;

namespace MMSAofNNumbers
{
    class MMSAofNNumbers
    {
        static void Main(string[] args)
        {
            double min = double.MaxValue;
            double max = double.MinValue;
            double sum = 0;

            double n = double.Parse(Console.ReadLine());
            

            for (int i = 0; i < n; i++)
            {
                double numbers = double.Parse(Console.ReadLine());

                if (numbers < min) //starting every number smaller than min
                {
                    min = numbers;
                }

                if (numbers > max) //starting every number bigger than max
                {
                    max = numbers;
                }

                sum += numbers;
            } // end of assignment cycle
            
            Console.WriteLine("min={0:f2}", min);
            Console.WriteLine("max={0:f2}", max);
            Console.WriteLine("sum={0:f2}", sum);
            Console.WriteLine("avg={0:f2}", sum / n);            
        }
    }
}