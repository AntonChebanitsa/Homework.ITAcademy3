using System;
using System.Collections.Generic;

namespace Homework.ITAcademy3
{
    public class Subscriber
    {
        public string Name { get; set; }
        public Guid Terminal { get; set; }

        public Subscriber(string name, Guid terminal)
        {
            Name = name;
            Terminal = terminal;
        }


    }
}