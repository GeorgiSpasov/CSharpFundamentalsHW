using System;

namespace BirdsAndFeathers
{
    class BirdsAndFeathers
    {
        static void Main(string[] args)
        {
            double numberOfBirds = double.Parse(Console.ReadLine());
            double totalNumberOfFeathers = double.Parse(Console.ReadLine());
            double avgNumberOfFeathers = totalNumberOfFeathers / numberOfBirds;
            
            if (numberOfBirds % 2 == 0)
            {
                Console.WriteLine("{0:f4}", avgNumberOfFeathers * 123123123123);
            }
            else
            {
                Console.WriteLine("{0:f4}", avgNumberOfFeathers / 317);
            }
        }
    }
}
