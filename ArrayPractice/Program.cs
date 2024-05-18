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
        private static Dictionary<string,int> words = new Dictionary<string, int>();
        static void Main(string[] args)
        {
            // читаем весь файл с рабочего стола в строку текста
            string text = File.ReadAllText(@"C:\Users\gridar\Desktop\Text.txt");

            var noPunctuationText = new string(text.Where(c => !char.IsPunctuation(c)).ToArray());
            // Сохраняем символы-разделители в массив
            char[] delimiters = new char[] { ' ', '\r', '\n' };

            // разбиваем нашу строку текста, используя ранее перечисленные символы-разделители
            var allWords = noPunctuationText.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            foreach ( var word in allWords )
            {
                if (words.Keys.Contains(word)) words[word]++;
                else words.Add(word, 1);
            }
            string S = ""; int k = 0;
            //Отбираем 10 наиболее частотных слов и в нашем случае отображем их в сообщении
            foreach (KeyValuePair<string, int> kk in words.OrderByDescending(x => x.Value))
            {
                S += kk.Key + " " + kk.Value.ToString() + "\n";
                k++;
                if (k == 10) break;
            }
            Console.WriteLine(S);
            Console.ReadKey();
        }
    }
}
