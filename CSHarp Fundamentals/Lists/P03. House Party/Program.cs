using System;
using System.Collections.Generic;
using System.Linq;

namespace P03._House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands=int.Parse(Console.ReadLine());
            List<string> guests=new List<string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (command.Length==3)
                {
                    if(guests.Contains(command[0]))
                    {
                        Console.WriteLine($"{command[0]} is already in the list!");
                        continue;
                    }
                    guests.Add(command[0]);
                }
                else if (command.Length==4)
                {
                    if (guests.Contains(command[0]))
                    {
                        guests.Remove(command[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{command[0]} is not in the list!");
                    }
                }
            }
            for (int i = 0; i < guests.Count; i++)
            {
                Console.WriteLine(guests[i]);
            }
        }
    }
}
