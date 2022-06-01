using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int cans = int.Parse(Console.ReadLine());
            double sum = 1;
            double biggestSum = 0;
            string biggestNum = "";
            for (int i = 0; i < cans; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                double hight = double.Parse(Console.ReadLine());

                sum = Math.PI * radius * radius * hight;
                if (sum>biggestSum)
                {
                    biggestSum = sum;
                    biggestNum = model;
                }
            }
            Console.WriteLine($"{biggestNum}");
        }
    }
}
