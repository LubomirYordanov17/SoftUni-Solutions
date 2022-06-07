using System;

namespace _02._Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Grades();
            
        }
        static void Grades()
        {
            double a = double.Parse(Console.ReadLine());
            if (a < 3)
            {
                Console.WriteLine("Fail");
            }
            else if (a<3.50)
            {
                Console.WriteLine("Poor");
            }
            else if (a<4.50)
            {
                Console.WriteLine("Good");
            }
            else if (a < 5.50)
            {
                Console.WriteLine("Very good");

            }else if (a < 6)
            {
                Console.WriteLine("Excellent");
            }
        }
    }
}
