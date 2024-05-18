using System.Collections;
using System.Collections.Generic;
using System.Text;
using static ArrayPractice.Program;

namespace ArrayPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Contact> list = new List<Contact>();
            list.Add(new Contact("Алекс", 89995864123, "авыаы"));
            list.Add(new Contact("Миша", 89664555921, "deqdwfa"));



            AddUnique(new Contact("Алfesdaекс", 89995864123, "авыаы"), list);

            Console.ReadKey();
        }
        public class Contact // модель класса
        {
            public Contact(string name, long phoneNumber, String email) // метод-конструктор
            {
                Name = name;
                PhoneNumber = phoneNumber;
                Email = email;
            }

            public String Name { get; }
            public long PhoneNumber { get; }
            public String Email { get; }
        }
        private static void AddUnique(Contact newContact, List<Contact> phoneBook)
        {
            bool alreadyExists = false;

            // пробегаемся по списку и смотрим, есть ли уже с таким именем
            foreach (var contact in phoneBook)
            {
                if (contact.Name == newContact.Name)
                {
                    //  если вдруг находим  -  выставляем флаг и прерываем цикл
                    alreadyExists = true;
                    break;
                }
            }

            if (!alreadyExists)
                phoneBook.Add(newContact);

            //  сортируем список по имени
            phoneBook.Sort((x, y) => String.Compare(x.Name, y.Name, StringComparison.Ordinal));

            foreach (var contact in phoneBook)
                Console.WriteLine(contact.Name + ": " + contact.PhoneNumber);
        }
    }
}
