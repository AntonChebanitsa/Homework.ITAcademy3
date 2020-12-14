using System;

namespace Homework.ITAcademy3.UI
{
    public static class Information
    {
        private enum Plans
        {
        Minimum,
        Middle,
        Premium
        }
        public static void CheckInformation()
        {
            var values = Enum.GetValues(typeof(Plans));
            var random = new Random();
            var randomBar = (Plans)values.GetValue(random.Next(0,2));
            Console.WriteLine($"Your tariff plan is: {randomBar}");

            var balance = new Random();
            Console.WriteLine($"Balance is: {balance.Next(-10, 50)}");

            var rnd = new Random();
            Console.WriteLine($"The rest of the free minutes: {rnd.Next(0, 50)}");

            var myNumber = new Terminal();
            Console.WriteLine($"My number is: {myNumber.NumberGuid}");

            Console.WriteLine("1. Change tariff plan\n" +
                              "0. Back");
            var x = 0;
            try
            {
                x = Convert.ToInt32(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        TariffPlan.ChangeTariffPlan();
                        break;
                    case 0:
                        MainMenu.Start();
                        break;
                    default:
                        Console.WriteLine("Incorrect input");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Incorrect input");
            }

            
        }
    }
}