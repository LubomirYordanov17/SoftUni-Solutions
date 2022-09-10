using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo
{
    public interface ICitizen
    { 
        public string Name { get; set; }
        public int Age { get; set; }
        public string Id { get; set; }
    }
}
