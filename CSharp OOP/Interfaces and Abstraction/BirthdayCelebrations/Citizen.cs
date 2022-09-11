using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
    public class Citizen : ICitizen
    {
        public string name;
        public int age;
        public string id;
        public string birthDate;

        public Citizen(string name, int age, string id, string birthDate)
        {
            Name = name;
            Age = age;
            Id = id;
            BirthDate = birthDate;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age=value; }
        public string Id { get => id; set => id=value; }
        public string BirthDate { get => birthDate; set => birthDate=value; }
    }
}
