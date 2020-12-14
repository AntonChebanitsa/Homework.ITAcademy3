using System;
using System.Collections.Generic;

namespace Homework.ITAcademy3
{
    public class Subscriber : Human
    {
        public Terminal Terminal { get; set; }
        public bool IsAvailable { get; set; } = true;
        public bool IsBusy { get; set; } = false;

        public Subscriber(string name,  string surname, Terminal terminal) : base(name, surname)
        {
            Terminal = terminal;
        }
        public void ConnectOrDisconnect()
        {
            if (IsAvailable == true)
            {
                IsAvailable = false;
                Console.WriteLine("Disconnected");
            }
            else
            {
                IsAvailable = true;
                Console.WriteLine("Connected");
            }

        }
    }
}