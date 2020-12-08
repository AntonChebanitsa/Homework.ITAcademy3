using System;

namespace Homework.ITAcademy3.UI
{
    public class Information
    {
        public void CheckInformation()
        {
            Random balance=new Random();
            Console.WriteLine($"Balance is {balance.Next(-20,100)}\n" +
                              $" ");
        }
    }
}