using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using static ArrayPractice.Program;

namespace ArrayPractice
{
    internal class Program
    {
        public static Stack<string> words = new Stack<string>();

        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово и нажмите Enter, чтобы добавить его в стек.");
            Console.WriteLine();

            while (true)
            {
                string input = Console.ReadLine();


                

                switch (input)
                {
                    //   если  команда pop - пробуем достать элемент
                    case "pop":
                        words.TryPop(out string popResult);
                        Console.WriteLine("Удалено: {0}", popResult);
                        break;
                    //   если  команда peek - пробуем  просмотреть элемент
                    case "peek":
                        words.TryPeek(out string peekResult);
                        Console.WriteLine("rgfewgdfgdgd {0}",peekResult);
                        break;
                    default:
                        // если ни одна из команд не распознана - простов стек добавляем то что введено
                        if (string.IsNullOrEmpty(input)) break;
                        break;
                }
                words.Push(input);
                Console.WriteLine();
                Console.WriteLine("В стеке:");

                foreach (var word in words)
                {
                    Console.WriteLine(" " + word);
                }
            }

            Console.ReadKey();
        }
        
    }
}
