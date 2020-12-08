using System;

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
                DateTime conversationStart = DateTime.Now;
                //waiting end conversation
                DateTime conversationEnds = DateTime.Now;
                TimeSpan durationOfConversation = conversationEnds - conversationStart;
                return durationOfConversation.TotalMinutes;
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