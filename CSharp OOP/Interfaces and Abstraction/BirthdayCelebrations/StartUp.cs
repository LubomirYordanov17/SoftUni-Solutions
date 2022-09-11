using System;
using System.Collections.Generic;

namespace BirthdayCelebrations
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split(" ");
            List<string> list = new List<string>();
            List<BirthDates> birthDates = new List<BirthDates>();
            while (command[0]!="End")
            {
                if (command[0]=="Pet")
                {
                    Pet pet = new Pet(command[1],command[2]);
                    list.Add(pet.birthDate);
                }
                else if (command[0]=="Citizen")
                {
                    Citizen citizen = new Citizen(command[1], int.Parse(command[2]), command[3], command[4]);
                    list.Add(citizen.birthDate);
                }

                command = Console.ReadLine().Split(" ");
            }
            string year = Console.ReadLine();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].EndsWith(year))
                {
                    string[] birthDay = list[i].Split('/');
                    BirthDates birthdates = new BirthDates(birthDay[0], birthDay[1], birthDay[2]);
                    birthDates.Add(birthdates);
                }

            }
            //if (command[0] == "Pet")
            //{
            //    Pet pet = new Pet(command[1], command[2]);
            //    string[] birthDay = pet.birthDate.Split('\\');
            //    BirthDates birthdates = new BirthDates(birthDay[0], birthDay[1], birthDay[2]);
            //    birthDates.Add(birthdates);
            //}
            //else if (command[0] == "Citizen")
            //{
            //    Citizen citizen = new Citizen(command[1], int.Parse(command[2]), command[3], command[4]);
            //    string[] birthDay = citizen.birthDate.Split('\\');
            //    BirthDates birthdates = new BirthDates(birthDay[0], birthDay[1], birthDay[2]);
            //    birthDates.Add(birthdates);
            //}

            foreach (var item in birthDates)
            {
                Console.WriteLine($"{item.Day}/{item.Month}/{item.Year}");
            }
        }
    }
}
