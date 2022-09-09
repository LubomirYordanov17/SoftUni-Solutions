using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo
{
    public class Smartphone : ICalling, IBrowsing
    {
        public void Browse(string url)
        {
            Console.WriteLine($"Browsing: {url}!");
        }

        public void Call(string number)
        {
            Console.WriteLine($"Calling... {number}");
        }
    }
}
