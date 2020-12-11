using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Homework.ITAcademy3.Peoples;
using Newtonsoft.Json;

namespace Homework.ITAcademy3.UI
{
    public class Contacts
    {
        public List<Human> FileReader()
        {
            const string pathFN = "C:\\Users\\USER\\source\\repos\\Homework.ITAcademy3\\UI\\FirstnamesWO_LINQ.json";
            const string pathLN = "C:\\Users\\USER\\source\\repos\\Homework.ITAcademy3\\UI\\Surnames.json";

            var content1 = File.ReadAllText(pathFN);
            var content2 = File.ReadAllText(pathLN);

            var people = new List<Human>();

            var names = JsonConvert.DeserializeObject<List<string>>(content1);
            var surnames = JsonConvert.DeserializeObject<List<string>>(content2);

            for (int i = 0; i < names.Count; i++)
            {
                var rnd = new Random();
                var human = new Human(names[i], surnames[rnd.Next(0, surnames.Count)]);
                people.Add(human);
            }
            return people;
        }

        public void ShowAllContacts()
        {
            var sortedUsers = FileReader().OrderBy(u => u.Name);
            foreach (var i in sortedUsers)
            {
                Console.WriteLine(i);
            }
        }

        public void Search()
        {
            string keyWord = null;
            try
            {
                keyWord = Convert.ToString(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Incorrect input");
            }

            var searchedUser = FileReader().Where(r => r.FullName.ToUpper().Contains(keyWord.ToUpper()));

            foreach (var user in searchedUser)
                Console.WriteLine(user.FullName);

        }
    }
}