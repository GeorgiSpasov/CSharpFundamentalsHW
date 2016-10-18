using System;

namespace Age
{
    class Age
    {
        static void Main(string[] args)
        {
            var today = DateTime.Today;
            var a = (today.Year * 100 + today.Month) * 100 + today.Day;

            DateTime birthDate = DateTime.ParseExact(Console.ReadLine(), "MM.dd.yyyy", null);
            var b = (birthDate.Year * 100 + birthDate.Month) * 100 + birthDate.Day;

            var age = (a - b) / 10000;

            Console.WriteLine(age);
            Console.WriteLine(age+10);
        }
    }
}