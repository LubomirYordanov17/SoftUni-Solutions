using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int numOfCourses = 0;
            
            numOfCourses = n / p;
            if (n%p!=0)
            {
                numOfCourses += 1;
            }
            Console.WriteLine(numOfCourses);
        }
    }
}
