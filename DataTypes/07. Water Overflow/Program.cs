using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            const int Capacy= 255;
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= number; i++)
            {
                int litersAdded = int.Parse(Console.ReadLine());
                sum += litersAdded;
                if (sum>Capacy)
                {
                    sum -= litersAdded;
                    Console.WriteLine("Insufficient capacity!");
                }
                
            }
            Console.WriteLine(sum);
        }
    }
}
