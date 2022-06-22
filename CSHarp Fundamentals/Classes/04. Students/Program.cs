using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
        public Student(string firstName,string lastName,double grade)
        {
            FirstName = firstName;
            LastName = lastName;    
            Grade = grade;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student>students=new List<Student>();   
            int numOfStudents = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfStudents; i++)
            {
                string[] command = Console.ReadLine().Split(" ").ToArray();
                Student student = new Student(command[0],command[1],double.Parse(command[2]));
                students.Add(student);
                

            }
            List<Student> orderedStudents = students.OrderByDescending(x => x.Grade).ToList();
            foreach (var student in orderedStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName }: {student.Grade:f2}");
            }
        }
    }
}
