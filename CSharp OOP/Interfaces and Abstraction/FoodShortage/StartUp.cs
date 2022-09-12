using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodShortage
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<IBuyer> buyers = new List<IBuyer>();
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(' ');
                if (command.Length == 4)
                {
                    Citizen currCitizen = new Citizen(command[0]
                        , int.Parse(command[1]), command[2], command[3]);
                    buyers.Add(currCitizen);
                }
                else if (command.Length == 3)
                {
                    Rebel curRebel = new Rebel(command[0]
                        , int.Parse(command[1]), command[2]);
                    buyers.Add(curRebel);
                }
            }

            string cmd;
            while ((cmd = Console.ReadLine()) != "End")
            {
                IBuyer buyer = buyers.FirstOrDefault(b => b.Name == cmd);

                if (buyer != null)
                {
                    buyer.BuyFood();
                }
            }
            int total = buyers.Sum(b => b.Food);
            Console.WriteLine(total);
        }
    }
}
