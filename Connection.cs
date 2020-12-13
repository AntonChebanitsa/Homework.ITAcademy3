using System;
using System.Diagnostics;

namespace Homework.ITAcademy3
{
    public class Connection
    {
        public Connection()
        {

        }

        public double DurationOfConversation()
        {
            bool _connectionEstablished = false;
            //waiting to be picked up

            if (_connectionEstablished == true)
            {
                var a = Stopwatch.StartNew();
                //waiting end conversation
                a.Stop();
                return a.Elapsed.TotalMinutes;
            }
            else
            {
                _connectionEstablished = false;
                Console.WriteLine("The subscriber is busy, call back later.");
                return 0;
            }
        }
    }
}