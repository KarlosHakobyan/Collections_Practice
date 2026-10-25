using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace Collections.Generics.Dictionaries
{
    internal class PhoneBook
    {
        
        private Dictionary<string, Dictionary<string, List<string>>> _phoneBookDictionary =
            new Dictionary<string, Dictionary<string, List<string>>>();

        public void AddContact(string group, string name, string phoneNumber)
        {
           
            if (!_phoneBookDictionary.ContainsKey(group))
            {
                _phoneBookDictionary[group] = new Dictionary<string, List<string>>();
            }

           if (!_phoneBookDictionary[group].ContainsKey(name))
            {
                _phoneBookDictionary[group][name] = new List<string>();
            }

             _phoneBookDictionary[group][name].Add(phoneNumber);

            Console.WriteLine($"Success: Added number {phoneNumber} for {name} in group '{group}'.");
        }

        public void FindContact(string name)
        {
            bool found = false;

            foreach (var groupPair in _phoneBookDictionary)
            {
                string groupName = groupPair.Key;                  
                Dictionary<string, List<string>> groupContacts = groupPair.Value; 

                
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
            
            if (_phoneBookDictionary.Count == 0)
            {
                Console.WriteLine("Phonebook is empty.");
                return;
            }

            
            foreach (var groupPair in _phoneBookDictionary)
            {
                string groupName = groupPair.Key;                          
                Dictionary<string, List<string>> groupContacts = groupPair.Value; 

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