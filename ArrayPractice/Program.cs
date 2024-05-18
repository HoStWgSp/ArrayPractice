using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using static ArrayPractice.Program;

namespace ArrayPractice
{
    internal class Program
    {
        // объявим список в виде статической переменной
        public static LinkedList<string> LinkedList = new LinkedList<string>();


        static void Main(string[] args)
        {
            //  создаём пустой список с типом данных Contact
            var phoneBook = new List<Contact>();

            // добавляем контакты
            phoneBook.Add(new Contact("Игорь", 79990000000, "igor@example.com"));

            // Добавим несколько элементов
            LinkedList.AddFirst("Лиса");
            LinkedList.AddFirst("Волк");
            // запускаем новый таймер
            var stopWatch = Stopwatch.StartNew();

            LinkedList.AddFirst("Заяц");

            // смотрим, сколько операция заняла, в миллисекундах
            Console.WriteLine("Добавление в LinkedList<T> составляет {0} мс",stopWatch.Elapsed.TotalMilliseconds);


            // запускаем новый таймер
            stopWatch = Stopwatch.StartNew();
            // добавляем контакты
            phoneBook.Add(new Contact("Антон", 79990000000, "igor@example.com"));
            // смотрим, сколько операция заняла, в миллисекундах
            Console.WriteLine("Добавление в List<T> составляет {0} мс", stopWatch.Elapsed.TotalMilliseconds);

            Console.ReadKey();
        }
    }
}
