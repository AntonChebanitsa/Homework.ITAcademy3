using System;
using Homework.ITAcademy3.UI;

namespace Homework.ITAcademy3
{
    public static class TariffPlan
    {
        public static double PriceForMinute { get; private set; }
        public static int SubscriptionFee { get; private set; }
        public static int FreeMinutes { get; private set; }

        public static void ChangeTariffPlan()
        {
            var rnd = new Random();
            var days = rnd.Next(1, 60);
            if (days < 30)
                Console.WriteLine($"Changing the tariff plan is possible only after 30 days. left {30-days} day(s)");
            else
            {
                Console.WriteLine("Сhoose a tariff plan\n" +
                                  "1. Minimum\n" +
                                  "2. Middle\n" +
                                  "3. Premium\n" +
                                  "0. Back");
                var x = 0;
                try
                {
                    x = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Incorrect input");
                }

                switch (x)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 0:
                        Information.CheckInformation();
                        break;
                    default:
                        Console.WriteLine("Incorrect input");
                        break;
                }

            }
        }
    }
}