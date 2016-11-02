using System;

namespace MatrixOfNumbers
{
    class MatrixOfNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            int counter = n;

            for (int i = 1; i <= n; i++)
            {
                counter++;

                for (int j = i; j < counter; j++)
                {
                    Console.Write("{0} ",j);
                }
                Console.WriteLine();
            }
        }
    }
}
