using System;
using System.Diagnostics;
using System.Threading;

namespace Homework.ITAcademy3
{
    public class Call
    {
        public void Calling(Subscriber sub)
        {
            if (sub.IsBusy == true)
            {
                Console.WriteLine("The subscriber is busy, call back later.");
            }
            else if (sub.IsAvailable == false)
            {
                Console.WriteLine("The subscriber is not available, try again later.");
            }
            else
            {
                Console.WriteLine("Calling...");
                for (int i = 0; i < 11; i++)
                {
                    Console.Beep(425, 2000); // dont working on my pc. idk why
                    Thread.Sleep(2000);

                    StartCall += StartConversation;

                    StopCall += EndConversation;
                    // Need to add event here

                    if (i != 10) continue;
                    Console.WriteLine("The subscriber is busy, call back later.");
                }
                DurationOfConversation();
            }
        }

        public delegate void MethodContainer();

        public event MethodContainer StartCall;
        public event MethodContainer StopCall;

        Stopwatch conversation = new Stopwatch();

        private void StartConversation()
        {
            conversation.Start();
        }

        private void EndConversation()
        {
            conversation.Stop();
        }

        public double DurationOfConversation()
        {
            return conversation.Elapsed.TotalMinutes;
        }

        public double CallCostCalculator(double duration, double minuteCost)
        {
            return duration * minuteCost;
        }
    }
}
