using System;
using System.Diagnostics;
using System.Threading;

namespace Homework.ITAcademy3
{
    public class Call
    {
        public delegate void MethodContainer();

        public event MethodContainer StartCall;
        public event MethodContainer StopCall;

        public void Calling(Subscriber sub)
        {
            var number = sub.Terminal.PhoneNumber;
            if (sub.IsBusy == true)
            {
                Console.WriteLine("The subscriber is busy, call back later.");
            }
            else if (sub.IsAvailable == false)
            {
                Console.WriteLine("The subscriber is not available, try again later.");
            }
            Console.WriteLine("Calling...");
            for (int i = 0; i < 11; i++)
            {
                Console.Beep(425, 2000); // dont working on my pc. idk why
                Thread.Sleep(2000);

                //MethodContainer += DurationOfConversation();
                //Start();
                // Need to add event here

                if (i != 10) continue;
                Console.WriteLine("The subscriber is busy, call back later.");
            }
            DurationOfConversation();
        }
        public double DurationOfConversation()
        {
            var a = Stopwatch.StartNew();
            //waiting end conversation
            a.Stop();
            return a.Elapsed.TotalMinutes;
        }

        public double CallCostCalculator(double duration, double minuteCost)
        {
            return duration * minuteCost;
        }

    }
}