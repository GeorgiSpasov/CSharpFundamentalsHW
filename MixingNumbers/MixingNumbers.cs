using System;

namespace MixingNumbers
{
    class MixingNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] intArray = new int[n];

            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = int.Parse(Console.ReadLine());
            }

            //Mixing
            for (int j = 1; j < intArray.Length; j++)
            {
                Console.Write("{0} ", (intArray[j - 1] % 10) * (intArray[j] / 10));
            }
            Console.WriteLine();

            //Subtracting
            for (int k = 1; k < intArray.Length; k++)
            {
                Console.Write("{0} ", Math.Abs(intArray[k - 1] - intArray[k]));
            }
        }
    }
}
