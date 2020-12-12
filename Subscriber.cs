using System;
using System.Collections.Generic;

namespace Homework.ITAcademy3
{
    public class Subscriber : Human
    {
        public Guid Terminal { get; set; }
        public bool IsAvailable { get; private set; } = true;
        public bool IsBusy { get; private set; } = false;

        public Subscriber(string name, Guid terminal, string surname) : base(name, surname)
        {
            Terminal = terminal;
        }
    }
}