using System;

namespace FrequentNumber
{
    class FrequentNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 1;
            int currectCount = 1;
            int[] numberSequence = new int[n + 1];
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                numberSequence[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(numberSequence);
            for (int i = 0; i < n; i++)
            {

                if (numberSequence[i] == numberSequence[i + 1])
                {
                    currectCount++;
                    if (currectCount >= count)
                    {
                        count = currectCount;
                        index = numberSequence[i];
                    }
                }
                else
                {
                    currectCount = 1;
                }
            }
            Console.WriteLine("{0} ({1} times)", index, count);
        }
    }
}
