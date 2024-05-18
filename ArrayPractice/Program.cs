namespace ArrayPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // читаем весь файл с рабочего стола в строку текста
            string text = File.ReadAllText(@"C:\Users\gridar\Desktop\Text.txt");

            // Сохраняем символы-разделители в массив
            char[] delimiters = new char[] { ' ', '\r', '\n' };

            // разбиваем нашу строку текста, используя ранее перечисленные символы-разделители
            var words = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            // выводим количество
            Console.WriteLine(words.Length);

            Console.ReadKey();
        }
    }
}
