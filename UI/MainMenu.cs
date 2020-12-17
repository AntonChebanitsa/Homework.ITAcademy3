using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Threading.Channels;

namespace Homework.ITAcademy3.UI
{
    public static class MainMenu
    {
        public static void Start()
        {
            //if (subscriberMe == null)

            var subscriberMe = new Subscriber("Anton", "Chebanitsa", new Terminal());

            while (true)
            {
                if (subscriberMe.IsAvailable == false)
                {
                    Console.WriteLine("You disconnected. Connect to use your phone\n" + "To connect enter 1");
                    short input = 0;
                    try
                    {
                        input = Convert.ToInt16(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Incorrect input, please try again");
                    }

                    if (input == 1)
                    {
                        subscriberMe.IsAvailable = true;
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Welcome to the main menu");
                    Console.WriteLine("Enter the corresponding request number");
                    Console.WriteLine("1. Show contacts\n" + "2. Search contact\n" + "3. Check information about account\n" + "4. Display call history\n" + "9. Disconnect / Connect phone\n" + "0. Exit the application");

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
                            Information.CheckInformation();
                            break;
                        case 4:
                            var history= new History();
                            history.ShowHistory();
                            break;
                        case 9:
                            subscriberMe.ConnectOrDisconnect();
                            continue;
                        case 0:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Wrong input. Try again");
                            continue;
                    }
                }

                break;
            }
        }
    }
}