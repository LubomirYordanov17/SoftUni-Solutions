using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            List<string> AllPeople = new List<string>();
            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] commArgs = command.Split(" -> ");
                string nameOfCourse = commArgs[0];
                string person = commArgs[1];
                List<string> People = new List<string>() { person };
                
                if (!courses.ContainsKey(nameOfCourse))
                {
                    AllPeople.Add(person);
                    courses.Add(nameOfCourse, People);
                }
                else
                {
                    if (AllPeople.Contains(person))
                    {
                        command = Console.ReadLine();
                        continue;
                    }
                    var course = courses.FirstOrDefault(x => x.Key == nameOfCourse);
                    AllPeople.Add(person);
                    course.Value.Add(person);
                }

                command = Console.ReadLine();
            }
            courses = courses.ToDictionary(x => x.Key, x => x.Value);
            courses.ToList().ForEach(x =>
            {
                Console.WriteLine($"{x.Key}");
                x.Value.ToList().ForEach(s =>
                {
                    Console.WriteLine($"-- {s}");
                });
            });
        }
    }
}
