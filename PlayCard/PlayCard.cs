using System;
using System.Linq;

namespace PlayCard
{
    class PlayCard
    {
        static void Main(string[] args)
        {
            string inputCard = Console.ReadLine();

            string[] cardFaces = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

            if (cardFaces.Contains(inputCard))
            {
                Console.WriteLine("yes {0}", inputCard);
            }
            else
            {
                Console.WriteLine("no {0}", inputCard);
            }
        }
    }
}
