using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

            var names = JsonConvert.DeserializeObject<List<string>>(content1);
            var surnames = JsonConvert.DeserializeObject<List<string>>(content2);

            return (from t in names let rnd = new Random() select new Human(t, surnames[rnd.Next(0, surnames.Count)])).ToList();
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
            Console.WriteLine("Search by: ");
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

            var counter = 0;
            foreach (var user in searchedUser)
            {
                ++counter;
                Console.WriteLine($"{counter}. {user.FullName}");
            }

            switch (counter)
            {
                case 0:
                    Console.WriteLine("Nothing found");
                    break;
                case 1:
                    {
                        Console.WriteLine($"Call this contact? press \"y\" or \"n\"");
                        var i = Convert.ToString(Console.ReadLine().ToLower());

                        switch (i)
                        {
                            case "y":
                                //Method Call()
                                break;
                            case "n":
                                Search();
                                break;
                            default:
                                Console.WriteLine("Incorrect input");
                                break;
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine($"Call someone? press \"y\" or \"n\"");
                        var i = Convert.ToString(Console.ReadLine().ToLower());

                        switch (i)
                        {
                            case "y":
                                var x = 0;
                                Console.WriteLine("Select someone by number");
                                try
                                {
                                    x = Convert.ToInt32(Console.ReadLine());
                                }
                                catch
                                {
                                    Console.WriteLine("No such contact");
                                }
                                foreach (var number in searchedUser)
                                {
                                    if (counter == x)
                                    {
                                        Console.WriteLine("Calling");
                                    }
                                }
                                break;
                            case "n":
                                Search();
                                break;
                            default:
                                Console.WriteLine("Incorrect input");
                                break;
                        }
                        break;
                    }
            }
        }
    }
}