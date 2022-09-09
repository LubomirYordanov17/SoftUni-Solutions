using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo
{
    public class StationaryPhone : ICalling
    {
        public void Call(string number)
        {
            Console.WriteLine($"Dialing... {number}");
        }
    }
}
