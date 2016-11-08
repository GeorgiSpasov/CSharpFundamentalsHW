using System;

namespace CompareArrays
{
    class CompareArrays
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array1 = new int[n];
            int[] array2 = new int[n];
            bool equal = true;

            for (int i = 0; i < n; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }
            for (int j = 0; j < n; j++)
            {
                array2[j] = int.Parse(Console.ReadLine());
            }

            for (int k = 0; k < n; k++)
            {
                if (array1[k] != array2[k])
                {
                    equal = false;
                }
            }

            Console.WriteLine(equal ? "Equal" : "Not equal");
        }
    }
}
