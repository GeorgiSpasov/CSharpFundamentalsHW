using System;

namespace IntDoubleAndString
{
    class IntDoubleAndString
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string variable = Console.ReadLine();

            switch (type)
            {
                case "integer":
                    Console.WriteLine(int.Parse(variable) + 1);
                    break;

                case "real":
                    Console.WriteLine("{0:f2}", double.Parse(variable) + 1);
                    break;

                case "text":
                    Console.WriteLine(variable + "*");
                    break;
            }
        }
    }
}
