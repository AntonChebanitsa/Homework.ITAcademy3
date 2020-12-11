using System;

namespace Homework.ITAcademy3.UI
{
    public class Information
    {
        public void CheckInformation()
        {
            var balance = new Random();
            Console.WriteLine($"Balance is {balance.Next(-20, 100)}\n");

            var myNumber = new Terminal();
            Console.WriteLine($"My number is: {myNumber.NumberGuid}");
        }
    }
}