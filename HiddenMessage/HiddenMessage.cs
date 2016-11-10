using System;

namespace HiddenMessage
{
    class HiddenMessage
    {
        static void Main(string[] args)
        {
            int i = 0;
            int skip = 0;
            string line = null;
            string result = null;

            do
            {
                string input = Console.ReadLine();

                //if instead of a number you read end your program should print the hidden message so far and stop
                if (input == "end")
                {
                    Console.WriteLine(result);
                    break;
                }
                else if (input == "") //empty new line
                {
                    continue;
                }
                else
                {
                    i = int.Parse(input);
                }

                skip = int.Parse(Console.ReadLine()); //skip input
                line = Console.ReadLine(); //line input

                //decoding
                if (i < 0)
                {
                    while (line.Length + i >= 0 && i < 0) //-i & -skip
                    {
                        result = result + line[line.Length + i];
                        i = i + skip;
                    }
                }
                else if (i >= 0)
                {
                    if (skip < 0)
                    {
                        while (i >= 0)
                        {
                            result = result + line[i];
                            i = i + skip;
                        }
                    }
                    else if (skip > 0)
                    {
                        while (i >= 0 && i < line.Length)
                        {
                            result = result + line[i];
                            i = i + skip;
                        }
                    }
                }
            } while (true);
        }
    }
}
