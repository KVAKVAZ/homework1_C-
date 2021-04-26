using System;

namespace HomeWork1_C
{
    class HW1
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Now;
            Console.WriteLine("Введите ваше имя");
            var name = Console.ReadLine();
            Console.WriteLine($"Привет,{name},сегодня {date}");
            Console.ReadLine();
        }
    }
}
