using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary < string,List<string>> courses=new Dictionary<string, List<string>>();
            string command = Console.ReadLine();
            while (command!="end")
            {
                string[] commArgs = command.Split(" : ");
                string nameOfCourse= commArgs[0];
                string person= commArgs[1];
                
                if (!courses.ContainsKey(nameOfCourse))
                {
                    List<string> People = new List<string>() { person };
                    courses.Add(nameOfCourse, People);
                }
                else
                {
                    var course = courses.FirstOrDefault(x => x.Key == nameOfCourse);
                    course.Value.Add(person);
                }

                command = Console.ReadLine();
            }
            courses = courses.ToDictionary(x => x.Key, x => x.Value);
            courses.ToList().ForEach(x =>
            {
                Console.WriteLine($"{x.Key}: {x.Value.Count}");
                x.Value.ToList().ForEach(s =>
                {
                    Console.WriteLine($"-- {s}");
                });
            });
        }
    }
}
