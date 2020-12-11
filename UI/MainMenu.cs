using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Homework.ITAcademy3.Peoples;

namespace Homework.ITAcademy3.UI
{
    public class MainMenu
    {
        public void Start()
        {
            Console.WriteLine("Welcome to the main menu");
            Console.WriteLine("Enter the corresponding request number");
            Console.WriteLine("1. Show contacts\n" +
                              "2. Search contact\n" +
                              //"3. Check Balance" +
                              "3. Check information about account\n" +
                              "5. Display call history\n" +
                            //  "6. Change tariff plan\n" +
                              "0. Exit the application");

            short input = 0;

            try
            {
                input = Convert.ToInt16(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Wrong input. Try again");
                Start();
            }

            var contacts = new Contacts();
            contacts.FileReader();

            switch (input)
            {
                case 1:
                    Information contactInfo = new Information();
                    contactInfo.CheckInformation();
                    break;
                case 2:

                    break;
                case 3:
                    var balanceInfo = new Information();
                    balanceInfo.CheckInformation();
                    break;
                case 4:
                    break;
                case 0:
                    break;

                default:
                    Console.WriteLine("Wrong input. Try again");
                    Start();
                    break;
            }

        }
    }
}