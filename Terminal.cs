using System;

namespace Homework.ITAcademy3
{
    public class Terminal
    {
        public Guid PhoneNumber { get; private set; }

        public Guid NumberGuid= Guid.NewGuid();

        public Terminal()
        {
            PhoneNumber = NumberGuid;
        }
    }
}