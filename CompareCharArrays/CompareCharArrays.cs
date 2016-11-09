using System;

namespace CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main(string[] args)
        {
            string charArray1 = Console.ReadLine();
            string charArray2 = Console.ReadLine();

            string result = "=";

            int length = Math.Min(charArray1.Length, charArray2.Length);

            for (int index = 0; index < length; index++)
            {
                if (charArray1[index] < charArray2[index])
                {
                    result = "<";
                    break;
                }
                else if (charArray1[index] > charArray2[index])
                {
                    result = ">";
                    break;
                }
                else
                {
                    if (charArray1.Length > charArray2.Length)
                    {
                        result = ">";
                    }
                    else if (charArray1.Length < charArray2.Length)
                    {
                        result = "<";
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
