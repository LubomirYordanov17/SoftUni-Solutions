using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo
{
    public class Citizen : ICitizen
    {
        public string name;
        public int age;
        public string id;
        public Citizen(string name, int age ,string id)
        {
            Name = name;
            Age = age;
            Id = id;
        }
        public string Name { get => name; set => name=value; }
        public int Age { get => age; set => age=value; }
        public string Id { get => id; set => id=value; }
    }
}
