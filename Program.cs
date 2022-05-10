using System;
using System.IO;

namespace LuckyTickets
{
    class Program
    {
        static void Main(string[] args)
        {

            // вариант 1: используется цикл
            //Console.WriteLine($" количество счастливых билетов: {Сycle.fullSearch()}");

            /* вариант 2: используется рекурсия
            Recursion lucky = new Recursion();

            for (int n=1;n<5;n++)
            {
                Console.WriteLine(lucky.Run(n));
            }
            */



            // вариант 3: используется динамическое программирование.
            string directore= @"C:\local\Otus_Algoritmy\LuckyTickets\1.Tickets";
            GetTest.runTests(directore, dynamic.count);
           
 
        }
    }
}
