using System;

namespace _02._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] command=Console.ReadLine().Split(' ');
            string firstWord=command[0];
            string secondWord=command[1];
            int sum = 0;
            int biggerLength=Math.Max(firstWord.Length, secondWord.Length);
            for (int i = 0; i < biggerLength; i++)
            {
                if (firstWord.Length<secondWord.Length&&i>firstWord.Length-1)
                {
                    sum += (int)secondWord[i];
                }
                else if (firstWord.Length>secondWord.Length&&i>secondWord.Length-1)
                {
                    sum += (int)firstWord[i];
                }
                else
                {
                    sum+=(int)firstWord[i]*(int)secondWord[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
