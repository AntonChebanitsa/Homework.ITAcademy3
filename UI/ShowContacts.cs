using System;
using System.Collections.Generic;
using Homework.ITAcademy3.Peoples;

namespace Homework.ITAcademy3.UI
{
    public class ShowContacts
    {
        public void ShowAllContacts(List<Human> contacts)
        {
            foreach (var i in contacts)
            {
                Console.WriteLine(i);
            }
        }
    }
}