using System;

namespace IndexOfLetters
{
    class IndexOfLetters
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            char start = 'a';
            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine((int)word[i] - (int)start);
            }
        }
    }
}
