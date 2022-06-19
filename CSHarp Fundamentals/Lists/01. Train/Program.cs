using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int capacity=int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
           
                while (command!="end")
             {
                List<string> firstCom = command.Split(' ').ToList();
                if (firstCom[0]=="Add")
                {
                    int index = int.Parse(firstCom[1]);
                    wagons.Add(index);
                    command = Console.ReadLine();
                    continue;
                }
                int number=int.Parse(command);
                for (int i = 0; i < wagons.Count; i++)
                {
                    if ((wagons[i]+number)<=capacity)
                    {
                        wagons[i] += number;
                        i++;
                        break;
                    }
                }


               command = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ",wagons));
        }
    }
}
