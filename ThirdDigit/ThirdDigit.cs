using System;

namespace ThirdDigit
{
    class ThirdDigit
    {
        static void Main(string[] args)
        {
            int digitEntered = int.Parse(Console.ReadLine());



            if (digitEntered.ToString().Length >= 3 && digitEntered.ToString()[digitEntered.ToString().Length - 3] == '7')
            {
                Console.WriteLine("true");

            }

            else if (digitEntered.ToString().Length >= 3)
            {

                Console.WriteLine("false {0}", digitEntered.ToString()[digitEntered.ToString().Length - 3]);
            }
            else
            {
                Console.WriteLine("false 0");
            }
        }
    }
}
