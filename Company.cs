﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.ITAcademy3
{
    class Company
    {
        public List<Subscriber> Contracts = new List<Subscriber>();

        public void ConcludeANewContract()
        {
            Terminal Ter = new Terminal();

            var sub = new Subscriber("asdasd asdasd", Guid.NewGuid());

            Contracts.Add(sub);

            Console.WriteLine(Ter.PhoneNumber);
        }

    }
}
