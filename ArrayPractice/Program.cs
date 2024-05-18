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
                var input = Console.ReadLine();

                words.Push(input); // Изменить здесь


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
