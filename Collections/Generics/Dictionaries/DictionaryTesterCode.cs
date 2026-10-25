using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Generics.Dictionaries
{
    internal class DictionaryTesterCode
    {
        public static void DictionaryRealise()
        {
            Console.WriteLine("------------ SIMPLE DICTIONAY -------------");

            PhoneBook phoneBook = new PhoneBook();

            phoneBook.AddContact("Football", "Bruno", "077777777");
            phoneBook.AddContact("Football", "Bruno", "077777776");
            phoneBook.AddContact("Football", "Bruno", "077777557");
            phoneBook.AddContact("AGroup", "Rooney", "055555855");

            phoneBook.ShowAllContacts();
            phoneBook.FindContact("Rooney");

            Console.WriteLine("------------ Sorted DICTIONAY -------------");

            PhoneBookSorted phoneBookSorted = new PhoneBookSorted();

            phoneBookSorted.AddContact("Football", "Bruno", "077777777");
            phoneBookSorted.AddContact("Football", "Bruno", "077777776");
            phoneBookSorted.AddContact("Football", "Bruno", "077777557");
            phoneBookSorted.AddContact("AGroup", "Rooney", "055555855");

            phoneBookSorted.ShowAllContacts();
            phoneBookSorted.FindContact("Rooney");
        }
    }
}
