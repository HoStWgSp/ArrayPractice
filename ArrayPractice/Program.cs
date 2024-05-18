using System.Collections;

namespace ArrayPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var months = new[]
                {
                   "Jan", "Feb", "Mar", "Apr", "May" , "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"
                };

            var numbers = new[]
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12
            };
            // инициализация ArrayList
            var combinedList = new ArrayList();

            //  пробегаемся по массиву чисел
            foreach (var number in numbers)
            {
                // добавляем в ArrayList строку месяца (начинаем с нулевого по индексу)
                combinedList.Add(months[number - 1]);

                // добавляем его порядковый номер
                combinedList.Add(number);
            }

            foreach (var value in combinedList)
                Console.WriteLine(value);

            Console.ReadKey();
        }
    }
}
