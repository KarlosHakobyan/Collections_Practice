using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections.Generics
{
    public class Box<T> : IEnumerable<T> //where T : class (only Reference types)  / where T : struct (only Value types) / where T : new() (Type must have Empty constructor) 
        // / where T: any interface (Type must realise any interface).


    {
       private List<T> _items = new List<T>();

        
        public void PutItem(T newItem)
        {
            _items.Add(newItem);
        }

        
        public T GetItem(T _items)
        {
            return _items;
        }

        
        public void ShowBoxInfo()
        {
            if (_items.Count == 0)
            {
                Console.WriteLine("Box is empty.");
            }
            else
            {
                Console.WriteLine($"Items in box: {string.Join(", ", _items)}");
            }
        }

       
        public IEnumerator<T> GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}