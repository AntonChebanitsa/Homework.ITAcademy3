using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;

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
                              "3. Check information about account\n" +
                              "4. Display call history\n" +
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
                    contacts.ShowAllContacts();
                    break;
                case 2:
                    contacts.Search();
                    break;
                case 3:
                    var balanceInfo = new Information();
                    balanceInfo.CheckInformation();
                    break;
                case 4:
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Wrong input. Try again");
                    Start();
                    break;
            }
        }
    }
}