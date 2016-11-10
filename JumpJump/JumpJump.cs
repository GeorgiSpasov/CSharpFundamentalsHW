using System;

namespace JumpJump
{
    class JumpJump
    {
        static void Main(string[] args)
        {
            string instructions = Console.ReadLine();
            int i = 0;
            
            do
            {
                if ((i >= 0 && i < instructions.Length) && instructions[i] == '0')
                {
                    Console.WriteLine("Too drunk to go on after {0}!", i); //Too drunk to go on after POSITION!
                    break;
                }
                else if ((i >= 0 && i < instructions.Length) && instructions[i] == '^')
                {
                    Console.WriteLine("Jump, Jump, DJ Tomekk kommt at {0}!", i); //Jump, Jump, DJ Tomekk kommt at POSITION!
                    break;
                }
                if ((i >= 0 && i < instructions.Length) && (instructions[i] - 48) % 2 == 0)
                {
                    i = i + (instructions[i] - 48);
                }
                else if ((i >= 0 && i < instructions.Length) && (instructions[i] - 48) % 2 != 0)
                {
                    i = i - (instructions[i] - 48);
                }
                else if (i < 0 || i >= instructions.Length)
                {
                    Console.WriteLine("Fell off the dancefloor at {0}!", i); //Fell off the dancefloor at POSITION!
                    break;
                }
            } while (i >= int.MinValue && i < int.MaxValue);            
        }
    }
}
