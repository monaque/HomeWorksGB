using System;

namespace HW
{
    class Lesson1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как Вас зовут?");
            var name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! Сегодня {DateTime.Now}");
        }
    }
}
