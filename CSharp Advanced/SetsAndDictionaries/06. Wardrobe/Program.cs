using System;
using System.Collections.Generic;

namespace _06._Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string,Dictionary<string,int>>wardrobe= new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(" -> ");
                string[] clothesComm = command[1].Split(",");
                Dictionary<string,int>clothes=new Dictionary<string,int>();
                for (int j = 0; j < clothesComm.Length; j++)
                {
                    if (!clothes.ContainsKey(clothesComm[j]))
                    {
                        clothes.Add(clothesComm[j], 1);
                    }
                    else
                    {
                        clothes[clothesComm[j]]++;
                    }
                }
                if (!wardrobe.ContainsKey(command[0]))
                {
                    wardrobe.Add(command[0], clothes);

                }
                else
                {
                    foreach (var item in clothes)
                    {
                        if (wardrobe[command[0]].ContainsKey(item.Key))
                        {
                            wardrobe[command[0]][item.Key]+=item.Value;
                        }
                        else
                        {
                            wardrobe[command[0]].Add(item.Key, 1);
                        }
                    }
                }
                
                
            }
            string[] searchedCloth = Console.ReadLine().Split();
            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");
                foreach (var cloth in color.Value)
                {
                    if (color.Key == searchedCloth[0]&&cloth.Key==searchedCloth[1])
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
                    }
                }
            }
        }
    }
}
