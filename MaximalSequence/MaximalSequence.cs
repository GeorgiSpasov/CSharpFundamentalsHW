using System;

namespace MaximalSequence
{
    class MaximalSequence
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] intArray = new int[n];

            int counter = 1;
            int current = 1;
            int longest = 0;

            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = int.Parse(Console.ReadLine());
            }

            for (int k = 1; k < intArray.Length; k++)
            {
                if (intArray[k] != intArray[k-1])
                {
                    counter = 1;
                }
                else
                {
                    counter++;
                    current = counter;
                }
                if (longest < current)
                {
                    longest = current;
                }
            }

            Console.WriteLine(longest);
        }
    }
}
