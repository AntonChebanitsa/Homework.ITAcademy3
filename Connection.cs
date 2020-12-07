using System;

namespace Homework.ITAcademy3
{
    public class Connection
    {
        public Connection()
        {

        }

        public int DurationOfConversation()
        {
            bool _connectionEstablished = false;
            //waiting to be picked up

            if (_connectionEstablished == true)
            {
                DateTime conversationStart = DateTime.Now;
                //waiting end conversation
                DateTime conversationEnds = DateTime.Now;
                TimeSpan durationOfConversation = conversationEnds - conversationStart;
                int x = (int)durationOfConversation.TotalMinutes;
                return x;
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