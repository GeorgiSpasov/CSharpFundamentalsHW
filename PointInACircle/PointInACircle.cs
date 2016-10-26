using System;

namespace PointInACircle
{
    class PointInACircle
    {
        static void Main(string[] args)
        {
            double dotX = double.Parse(Console.ReadLine());
            double dotY = double.Parse(Console.ReadLine());
            double circleCenter_x = 0;
            double circleCenter_y = 0;

            double dx = Math.Abs(dotX - circleCenter_x);
            double dy = Math.Abs(dotY - circleCenter_y);
            double Radius = 2;


            if (Radius >= Math.Sqrt(dx * dx + dy * dy))
            {
                Console.Write("yes ");
            }
            else
            {
                Console.Write("no ");
            }
            Console.WriteLine("{0:F2}", Math.Round(Math.Sqrt(dx * dx + dy * dy), 2));

        }
    }
}
