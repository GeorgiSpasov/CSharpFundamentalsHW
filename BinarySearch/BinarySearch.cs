using System;

namespace BinarySearch
{
    class BinarySearch
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(array);
            int x = int.Parse(Console.ReadLine());

            int index = Array.BinarySearch(array, x);
            if (index < 0)
            {
                Console.WriteLine("-1");
            }
            else
            {
                Console.WriteLine(index);
            }
        }
    }
}
