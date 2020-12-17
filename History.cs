using System;
using System.Collections.Generic;
using Homework.ITAcademy3.UI;

namespace Homework.ITAcademy3
{
    public class History
    {
        public void ShowHistory()
        {
            Console.WriteLine("Calls History:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Name: {CreateSubscriber()}. Date: {RandomDateTime()[i]}. Duration: {RandomDuration()}");
            }
        }

        public string CreateSubscriber()
        {
            var reader = new Contacts();
            reader.FileReader();
            var subscribers = reader.HumanToSub(reader.FileReader());
            var rnd = new Random();
            var i = rnd.Next(0,subscribers.Count);
            return subscribers[i].FullName;
        }

        public List<DateTime> RandomDateTime()
        {
            var start = new DateTime(2020, 7, 1);
            var rnd = new Random();
            var range = (DateTime.Today - start).Days;

            var list= new List<DateTime>();
            for (int i = 0; i < 12; i++)
            {
                list.Add(start.AddDays(rnd.Next(range)).AddHours(rnd.Next(0, 24)).AddMinutes(rnd.Next(0, 60)));
            }
            list.Sort();
            return list;
        }

        public int RandomDuration()
        {
            Random rnd = new Random();
            var mins = rnd.Next(1, 60);
            return mins;
        }
    }
}