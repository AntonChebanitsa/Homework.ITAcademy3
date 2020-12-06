using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Channels;
using Homework.ITAcademy3.Peoples;
using Newtonsoft.Json;


namespace Homework.ITAcademy3

{
    public class FileReader
    {
        public void Reader()
        {
            var pathFN = "C:\\Users\\USER\\source\\repos\\Homework.ITAcademy3\\Peoples\\firstnames.json";
            var pathLN = "C:\\Users\\USER\\source\\repos\\Homework.ITAcademy3\\Peoples\\surnames.json";

            var content1 = File.ReadAllText(pathFN);
            var content2 = File.ReadAllText(pathLN);

            List<Human> people= new List<Human>();

            List<string> names = JsonConvert.DeserializeObject<List<string>>(content1);
            List<string> surnames = JsonConvert.DeserializeObject<List<string>>(content2);

            for (int i = 0; i < surnames.Count; i++)
            {
                var human=new Human(names[i],surnames[i]);
                people.Add(human);
            }
            foreach (var i in people)
            {
                Console.WriteLine(i);
            }
        }
    }
}