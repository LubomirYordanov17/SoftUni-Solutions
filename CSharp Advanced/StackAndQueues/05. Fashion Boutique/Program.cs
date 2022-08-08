using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] clothesInBox = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> clothes = new Stack<int>(clothesInBox);

            int capacityOfRack = int.Parse(Console.ReadLine());
            int currentRackCapacity = capacityOfRack;
            int racksCount = 1;

            while (clothes.Any())
            {
                int cloth = clothes.Pop();
                currentRackCapacity -= cloth;

                if (currentRackCapacity < 0)
                {
                    racksCount += 1;
                    currentRackCapacity = capacityOfRack - cloth;
                }
            }
            Console.WriteLine(racksCount);
        }
    }
}
