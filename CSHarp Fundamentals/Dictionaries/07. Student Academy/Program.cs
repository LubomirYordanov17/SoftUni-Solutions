using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();
            int n=int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();
                double mark=double.Parse(Console.ReadLine());
                
                if (students.ContainsKey(command))
                {
                    students[command].Add(mark);
                }
                else
                {
                    List<double> marks = new List<double>() { mark };
                    students.Add(command, marks);
                }
            }
            students = students
               .ToList()
               .Where(x => x.Value.Average() >= 4.50d)
               .ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in students)
            {
                Console.WriteLine($"{item.Key} -> {item.Value.Average():f2}");
            }
        }
    }
}
