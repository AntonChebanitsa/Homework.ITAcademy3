using System;
using System.Linq.Expressions;

namespace Homework.ITAcademy3.UI
{
    public class MainMenu
    {
        public void Start()
        {
            Console.WriteLine("Welcome to the main menu");
            Console.WriteLine("Enter the corresponding request number");
            Console.WriteLine("1. Show Contacts\n" +
                              "2. Check information about account\n" +
                              "3. Display call history\n" +
                              "4. Change tariff plan\n" +
                              "0. Exit the application");

            short input=0;

            try
            {
               input= Convert.ToInt16(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Wrong input. Try again");
                Start();
            }

            switch (input)
            {
                case 1:
                    var contacts=new Contacts();
                    contacts.Reader();
                    break;
                case 2:
                    var info= new Information();
                    info.CheckInformation();
                        break;
                case 3:
                    break;
                case 0:
                    break;
                    
                default:
                    break;
                    
            }
            
        }
    }
}