using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.ITAcademy3
{
    class Company
    {
        public List<Subscriber> Contracts = new List<Subscriber>();

        public void ConcludeANewContract()
        {
            var Ter = new Terminal();

            var sub = new Subscriber("asdasd", "asdasd", Ter);

            Contracts.Add(sub);
        }
    }
}
