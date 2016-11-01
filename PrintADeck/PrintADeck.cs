using System;

namespace PrintADeck
{
    class PrintADeck
    {
        static void Main(string[] args)
        {
            string[] faces = { "2", "3", "4", "5", "6", "7", "8", "9", "10",
                               "J", "Q", "K", "A" };
            string[] suits = { "spades", "clubs", "hearts", "diamonds" };
            
            string cardFace = Console.ReadLine().ToUpper();

            int i = -1; //index of faces
            int j = 0; //index of suits

            do
            {
                i++; //to print the final card face

                for (j = 0; j < 3; j++) //j<3 to omit the comma at the end
                {
                    Console.Write("{0} of {1}, ", faces[i], suits[j]);
                }
                Console.WriteLine("{0} of {1}", faces[i], suits[j]); //final card without a comma at the end

            } while (cardFace != "2" && cardFace != faces[i]);
        }
    }
}