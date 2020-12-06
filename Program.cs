using System;

namespace Homework.ITAcademy3
{
    class Program
    {
        static void Main(string[] args)
        {
           Company com= new Company();

           

           foreach (var sub in com.Contracts)
           {
               Console.WriteLine($"{sub.Name},  {sub.Terminal}");
           }
        }
    }
}
