using System;
using Homework.ITAcademy3.UI;

namespace Homework.ITAcademy3
{
    public static class TariffPlan
    {
        public static double PriceForMinute { get; private set; } = 0.5;
        public static int SubscriptionFee { get; private set; }
        public static int FreeMinutes { get; private set; }

        public static void ChangeTariffPlan()
        {
            var rnd = new Random();
            var days = rnd.Next(1, 60);
            if (days < 30)
                Console.WriteLine($"Changing the tariff plan is possible only after 30 days. left {30 - days} day(s)");
            else
            {
                Console.WriteLine("Сhoose a tariff plan\n" +
                                  "1. Minimum\n" +
                                  "2. Middle\n" +
                                  "3. Premium\n" +
                                  "0. Exit");
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
                       Minimum(days);
                        break;
                    case 2:
                        Middle(days);
                        break;
                    case 3:
                        Premium(days);
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Incorrect input");
                        break;
                }

                Console.WriteLine("Tariff plan changed");
                Console.WriteLine($"Minutes left: {FreeMinutes}");
            }

        }
        public static void Minimum(int days)
        {
            SubscriptionFee = 20;
            FreeMinutes = 50 / (days - 30);
        }
        public static void Middle(int days)
        {
            SubscriptionFee = 25;
            FreeMinutes = 125 / (days - 30);
        }
        public static void Premium(int days)
        {
            SubscriptionFee = 30;
            FreeMinutes = 250 / (days - 30);
        }
    }
}