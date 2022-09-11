using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
    public class BirthDates
    {
        public string day;
        public string month;
        public string year;

        public BirthDates(string day, string month, string year)
        {
            Day = day;
            Month = month;
            Year = year;
           
        }

        public string Day{ get; set; }
        public string Month{ get; set; }
        public string Year{ get; set; }
       
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            
                sb.AppendLine($"{Day}/{Month}/{Year}");
            
           
           
            return sb.ToString();
        }
    }
}
