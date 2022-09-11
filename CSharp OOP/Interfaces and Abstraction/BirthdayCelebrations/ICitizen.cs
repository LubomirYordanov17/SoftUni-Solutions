using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
    public interface ICitizen
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Id { get; set; }
        public string BirthDate { get; set; }
    }
}
