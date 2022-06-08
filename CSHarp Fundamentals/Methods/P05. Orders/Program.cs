using System;

namespace P05._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Drinks();
        }
        static void Drinks(double coffee=1.50,double water=1.00,double coke=1.40,double snacks=2.00)
        {
            string drink=Console.ReadLine();
            int times = int.Parse(Console.ReadLine());
            double sum = 0;
            switch (drink)
            {
                case "coffee":
                    sum =times* coffee;
                    break;
                case "water":
                    sum = times * water;
                    break;
                case "coke":
                    sum = times * coke;
                    break;
                case "snacks":
                    sum = times * snacks;
                    break;
                
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
