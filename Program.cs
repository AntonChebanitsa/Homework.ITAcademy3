using System;

namespace Homework.ITAcademy3
{
    class Program
    {
        static void Main(string[] args)
        {
           Company com= new Company();

           com.ConcludeANewContract();
           com.ConcludeANewContract();
           com.ConcludeANewContract();
           com.ConcludeANewContract();
           com.ConcludeANewContract();

           foreach (var VARIABLE in com.Contracts)
           {
               Console.WriteLine(VARIABLE);
           }
        }
    }
}
