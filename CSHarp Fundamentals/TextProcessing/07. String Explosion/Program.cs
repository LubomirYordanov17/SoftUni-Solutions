using System;
using System.Text;

namespace _07._String_Explosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input=Console.ReadLine();
            StringBuilder output=new StringBuilder();
            int bombpower=0;
            for (int i = 0; i < input.Length; i++)
            {
                char currCh = input[i];
                if (currCh == '>')
                {
                    int currentBombPower = Get(input[i+1]);
                    output.Append(currCh);
                    bombpower+=currentBombPower;
                }
                else
                {
                    if (bombpower>0)
                    {
                        bombpower--;
                    }
                    else
                    {
                        output.Append(currCh);
                    }
                }
            }
            Console.WriteLine(output);

        }
        static int Get(char ch)
        {
            return (int)ch - 48;
        }
    }
}
