using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Generics.Dictionaries
{
    internal class PhoneBookSorted
    {            
            private SortedDictionary<string, SortedDictionary<string, List<string>>> _phoneBook =
                new SortedDictionary<string, SortedDictionary<string, List<string>>>();

            public void AddContact(string group, string name, string phoneNumber)
            {
                
                if (!_phoneBook.ContainsKey(group))
                {
                    _phoneBook[group] = new SortedDictionary<string, List<string>>();
                }

                
                if (!_phoneBook[group].ContainsKey(name))
                {
                    _phoneBook[group][name] = new List<string>();
                }

               
                _phoneBook[group][name].Add(phoneNumber);

                Console.WriteLine($"Success: Added number {phoneNumber} for {name} in group '{group}'.");
            }

            public void FindContact(string name)
            {
                bool found = false;

                foreach (var groupPair in _phoneBook)
                {
                    string groupName = groupPair.Key;
                    var groupContacts = groupPair.Value;

                    if (groupContacts.ContainsKey(name))
                    {
                        List<string> numbers = groupContacts[name];

                        Console.WriteLine($"Founded contact: {name}");
                        Console.WriteLine($"Group: {groupName}");
                        Console.WriteLine($"Numbers: {string.Join(", ", numbers)}");
                        Console.WriteLine(new string('-', 20));

                        found = true;
                    }
                }

                if (!found)
                {
                    Console.WriteLine($"Contact with name  '{name}' is not finded in this group.");
                }
            }

            public void ShowAllContacts()
            {
                if (_phoneBook.Count == 0)
                {
                    Console.WriteLine("Phonebook is empty.");
                    return;
                }

                foreach (var groupPair in _phoneBook)
                {
                    string groupName = groupPair.Key;
                    var groupContacts = groupPair.Value;

                    Console.WriteLine($"Group: {groupName}");


                    foreach (var contactPair in groupContacts)
                    {
                        string name = contactPair.Key;
                        List<string> numbers = contactPair.Value;

                        Console.WriteLine($"Name: {name}: {string.Join(", ", numbers)}");
                    }

                    Console.WriteLine(new string('-', 25));
                }
            }
        }
    }

