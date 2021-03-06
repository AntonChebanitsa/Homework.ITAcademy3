﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace Homework.ITAcademy3.UI
{
    public class Contacts
    {
        Dictionary<int, Subscriber> dictionary = new Dictionary<int, Subscriber>();

        public List<Human> FileReader()
        {
            const string pathFN = "C:\\Users\\USER\\source\\repos\\Homework.ITAcademy3\\UI\\Firstnames10.json";
            const string pathLN = "C:\\Users\\USER\\source\\repos\\Homework.ITAcademy3\\UI\\Surnames.json";

            var content1 = File.ReadAllText(pathFN);
            var content2 = File.ReadAllText(pathLN);

            var names = JsonConvert.DeserializeObject<List<string>>(content1);
            var surnames = JsonConvert.DeserializeObject<List<string>>(content2);

            return (from t in names let rnd = new Random() select new Human(t, surnames[rnd.Next(0, surnames.Count)])).ToList();
        }

        public List<Subscriber> HumanToSub(List<Human> listHumans)
        {
            var subs = listHumans.Select(x=>new Subscriber(x.Name,x.Surname,new Terminal())).ToList();
            return subs;
        }
        
        public void ShowAllContacts()
        {
            var sortedUsers = FileReader().OrderBy(u => u.Name).ToList();
            int counter = 0;
            var subs = HumanToSub(sortedUsers);
            foreach (var user in subs)
            {
                ++counter;
                dictionary.Add(counter, user);
                Console.WriteLine($"{counter}. {user.FullName}");
            }
            var x = 0;
            Console.WriteLine("Select someone by number to call");
            try
            {
                x = Convert.ToInt32(Console.ReadLine());
                var call = new Call();
                call.Calling(dictionary[x]);
            }
            catch
            {
                Console.WriteLine("No such contact");
            }
           
        }
        public void Search()
        {
            Console.WriteLine("Search by: ");
            string keyWord = null;
            try
            {
                keyWord = Convert.ToString(Console.ReadLine());
                var searchedUsers = FileReader().Where(r => r.FullName.ToUpper().Contains(keyWord.ToUpper())).ToList();
                var subs = HumanToSub(searchedUsers);

                var counter = 0;
                foreach (var user in subs)
                {
                    ++counter;
                    dictionary.Add(counter, user);
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
                                    var call = new Call();
                                    call.Calling(dictionary[counter]);

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
                                        var call = new Call();
                                        call.Calling(dictionary[x]);
                                    }
                                    catch
                                    {
                                        Console.WriteLine("No such contact");
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
            catch
            {
                Console.WriteLine("Incorrect input");
            }
        }
    }
}