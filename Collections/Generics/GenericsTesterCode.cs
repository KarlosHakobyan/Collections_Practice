using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Generics
{
    internal class GenericsTesterCode
    {
        public static void GenericRealiser()
        {
            Box<string> stringBox = new Box<string>();
            Box<int> intBox = new Box<int>();

            Console.WriteLine("Add String to the Box: ");
            stringBox.PutItem(Console.ReadLine());
            Console.WriteLine("Add Number to the Box: ");
            string input = Console.ReadLine();


            if (int.TryParse(input, out int number))
            {
                intBox.PutItem(number);
            }
            else
            {
                Console.WriteLine("Error!!! / Add the number please.");
            }


            stringBox.PutItem("Test");
            stringBox.PutItem("Test2");
            stringBox.PutItem("Test3");
            stringBox.PutItem("Test4");
            stringBox.PutItem("Test5");


            Console.WriteLine("--------------- YOUR BOX INFO BY YSING ShowBoxInfo()---------------");
            stringBox.ShowBoxInfo();
            intBox.ShowBoxInfo();

            Console.WriteLine("--------------- YOUR BOX INFO BY USING Foreach / GetItem() ---------------");
            foreach (string stringItem in stringBox)
            {
                string item = stringBox.GetItem(stringItem);
                Console.WriteLine(item);
            }

            foreach (int intItem in intBox)
            {
                int item = intBox.GetItem(intItem);
                Console.WriteLine(item);
            }
        }
    }
}
