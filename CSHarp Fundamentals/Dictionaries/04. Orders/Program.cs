using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> orders = new Dictionary<string, List<double>>();

            string command = Console.ReadLine();
            while (command != "buy")
            {
                string[] data = command.Split();
                string name = data[0];
                double price = double.Parse(data[1]);
                double quantity = double.Parse(data[2]);

                if (orders.ContainsKey(name))
                {
                    orders[name][0] = price;
                    orders[name][1] += quantity;
                }
                else
                {
                    List<double> temporary = new List<double>() { price, quantity };
                    orders.Add(name, temporary);
                }

                command = Console.ReadLine();
            }

            foreach (var item in orders)
            {
                Console.WriteLine($"{item.Key} -> {item.Value.ElementAt(0) * item.Value.ElementAt(1):f2}");
            }
        }
    }
}
