using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Legendary_Farming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Dictionary<string, int> materials = new Dictionary<string, int>()
            {
                {"shards", 0},
                {"motes", 0},
                {"fragments", 0}

            };
            Dictionary<string, int> junk = new Dictionary<string, int>();
            
            
            while (materials["shards"]<250|| materials["fragments"] < 250|| materials["motes"]<250)
            {
                string[] commArgs = Console.ReadLine().Split(" ").ToArray();
                for (int i = 1; i < commArgs.Length; i += 2)
                {
                    if (materials["shards"] >= 250)
                    {
                       
                        
                        break;
                    }
                    else if (materials["fragments"] >= 250)
                    {
                        
                        
                        break;
                    }
                    else if (materials["motes"] >= 250)
                    {
                       
                        
                        break;
                    }
                    if (materials.ContainsKey(commArgs[i].ToLower()))
                    {
                        materials[commArgs[i].ToLower()] += int.Parse(commArgs[i - 1]);
                    }
                    else
                    {
                        if (junk.ContainsKey(commArgs[i].ToLower()))
                        {
                            junk[commArgs[i].ToLower()] += int.Parse(commArgs[i - 1]);
                        }
                        else
                        {
                            junk.Add(commArgs[i].ToLower(), int.Parse(commArgs[i - 1]));
                        }

                    }

                }
                if (materials["shards"] >= 250)
                {
                    Console.WriteLine("Shadowmourne obtained!");
                    materials["shards"] -= 250;
                    break;
                }
                else if (materials["fragments"] >= 250)
                {
                    Console.WriteLine("Valanyr obtained!");
                    materials["fragments"] -= 250;
                    break;
                }
                else if (materials["motes"] >= 250)
                {
                    Console.WriteLine("Dragonwrath obtained!");
                    materials["motes"] -= 250;
                    break;
                }
            }

            foreach (var item in materials)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item in junk)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

        }
    }
}
