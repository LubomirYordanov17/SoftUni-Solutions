using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
    public class Pet : IPet
    {
        public string name;
       
        public string birthDate;

        public Pet(string name, string brithDate)
        {
            Name = name;
            
            BrithDate = brithDate;
        }

        public string Name { get => name; set => name=value; }
        
        public string BrithDate { get => birthDate; set => birthDate=value; }
    }
}
