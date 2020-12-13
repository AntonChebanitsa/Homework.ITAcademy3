using System;

namespace Homework.ITAcademy3.UI
{
    public static class Information
    {
        public static void CheckInformation()
        {
            var balance = new Random();
            Console.WriteLine($"Balance is {balance.Next(-10, 50)}");
            Console.WriteLine($"The rest of the free minutes {TariffPlan.FreeMinutes}");
            var myNumber = new Terminal();
            Console.WriteLine($"My number is: {myNumber.NumberGuid}");

            Console.WriteLine("If you want to change tariff plan press 1");
            var x = 0;
            try
            {
                x = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("No such contact");
            }

            if (x == 1)
            {
                TariffPlan.ChangeTariffPlan();
            }
        }
    }
}