using System;
using System.Text;

namespace _05._Digits__Letters_and_Other
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text=Console.ReadLine();
            StringBuilder letters=new StringBuilder();
            StringBuilder digits=new StringBuilder();
            StringBuilder chars=new StringBuilder();
            foreach (char item in text)
            {
                if (char.IsLetter(item))
                {
                    letters.Append(item);
                }
                else if (char.IsDigit(item))
                {
                    digits.Append(item);
                }
                else 
                {
                    chars.Append(item);
                }
            }
            Console.WriteLine(letters);
            Console.WriteLine(digits);
            Console.WriteLine(chars);
        }
    }
}
