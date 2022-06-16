using System;
using System.Collections.Generic;
using System.Linq;

namespace P07._List_Manipulation_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<string> fullCommand = Console.ReadLine().Split(' ').ToList();
            string command = fullCommand[0];
            while (command != "end")
            {
                if (command == "Contains")
                {
                    string a = fullCommand[1];
                    int numberForCommand = int.Parse(a);
                    if (numbers.Contains(numberForCommand))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (command == "PrintEven")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        int a = numbers[i];
                        if (a%2==0)
                        {
                            Console.Write($"{a} ");
                        }
                    }
                    
                }
                else if (command == "PrintOdd")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        int a = numbers[i];
                        if (a % 2 != 0)
                        {
                            Console.Write($"{a} ");
                        }
                    }
                }
                else if (command == "Filter")
                {
                    
                }
                fullCommand = Console.ReadLine().Split(' ').ToList();
                command = fullCommand[0];

            }
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
