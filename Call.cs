using System;
using System.Diagnostics;

namespace Homework.ITAcademy3
{
    public class Call
    {
        public void Calling(Subscriber sub)
        {
            var number = sub.Terminal.PhoneNumber;
            if (sub.IsBusy == true)
            {
                Console.WriteLine("The subscriber is busy, call back later.");
            }
            else if (sub.IsAvailable==false)
            {
                Console.WriteLine("The subscriber is not available, try again later.");
            }
            else if (sub.IsBusy == false && sub.IsAvailable == true)
            {
                Console.WriteLine("Calling...");
                for (int i = 0; i < 5; i++)
                {
                    Console.Beep(425, 2000); // dont working on my pc. idk why
                    // Need to add event here
                }
                DurationOfConversation();
            }
            else
            {
                Console.WriteLine("Unknown connection error");
            }

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