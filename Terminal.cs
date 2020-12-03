using System;

namespace Homework.ITAcademy3
{
    public class Terminal
    {
        public Guid PhoneNumber { get; private set; }

        private readonly Guid _numberGuid= Guid.NewGuid();
        public Terminal()
        {
            PhoneNumber = _numberGuid;
        }

    }
}