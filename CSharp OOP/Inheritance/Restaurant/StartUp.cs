using System;

namespace Restaurant
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Cake cake = new Cake("asd");
            Console.WriteLine(cake.Price);
            Console.WriteLine(cake.Calories);
        }
    }
}