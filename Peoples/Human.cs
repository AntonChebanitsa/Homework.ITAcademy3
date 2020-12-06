using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.ITAcademy3.Peoples
{
    class Human
    {
        private string Name { get; set; }
        private string Surname { get; set; }

        public Human(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public override string ToString()
        {
            return $"{Name}, {Surname}";
        }
    }
}
