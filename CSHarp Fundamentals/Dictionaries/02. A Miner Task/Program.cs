using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string commadString=Console.ReadLine();
            int commandInt=int.Parse(Console.ReadLine());
            Dictionary<string, int> resources = new Dictionary<string, int>();
            while (commadString!="stop")
            {
                if (resources.ContainsKey(commadString))
                {
                    resources[commadString]+=commandInt;

                }
                else
                {
                resources.Add(commadString, commandInt);
                }
                commadString = Console.ReadLine();
                if (commadString == "stop")
                {
                    break;
                }
                commandInt = int.Parse(Console.ReadLine());
            }
            foreach (var item in resources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
