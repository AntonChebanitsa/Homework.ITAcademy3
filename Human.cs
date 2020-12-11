using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.ITAcademy3.Peoples
{
    public class Human
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FullName { get; private set; }

        public Human(string name, string surname)
        {
            Name = name;
            Surname = surname;
            FullName = $"{name} {surname}";
        }

        public override string ToString()
        {
            return $"{Name}, {Surname}";
        }
    }
}
