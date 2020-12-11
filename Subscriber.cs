using System;
using System.Collections.Generic;
using Homework.ITAcademy3.Peoples;

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

        public void CallTo(Guid number)
        {
            if (IsAvailable == false)
            {
                Console.WriteLine("The subscriber is temporarily unavailable, call back later.");
            }
            if (IsBusy == true)
            {
                Console.WriteLine("The subscriber is busy, call back later.");
            }
            else
            {
                var connection= new Connection();
                connection.DurationOfConversation();
            }
        }

        public void CallTo(string name)
        {

        }
    }
}