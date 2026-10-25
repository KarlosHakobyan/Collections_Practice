using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Generics.QueueStack
{
    internal class QueueStack
    {
        public static void RunSimulation()
        {
            Queue<string> printerQueue = new Queue<string>();
            Stack<string> docsPrintHistory = new Stack<string>();

            Console.WriteLine("Insert first document: ");
            printerQueue.Enqueue(Console.ReadLine());

            printerQueue.Enqueue("Presentation.pptx");
            printerQueue.Enqueue("Protocole.docx");
            printerQueue.Enqueue("Document.PDF");

            Console.WriteLine("Insert last document: ");
            printerQueue.Enqueue(Console.ReadLine());


            Console.WriteLine("\n------------------ Your QUEUE by using foreach ---------------");
            foreach (string doc in printerQueue)
            {
                Console.WriteLine(doc);
            }


            Console.WriteLine("\n------------------ Your QUEUE by using Peek ---------------");
            string first = printerQueue.Peek();
            Console.WriteLine($"Waiting for print: {first}");
            Console.WriteLine($"Count in the queue: {printerQueue.Count}");


            Console.WriteLine("\n------------------ Your QUEUE by using Dequeue & STACK history ---------------");

            while (printerQueue.Count > 0)
            {
                string currentDoc = printerQueue.Dequeue();


                docsPrintHistory.Push(currentDoc);

                if (printerQueue.Count > 0)
                {
                    string nextFile = printerQueue.Peek();
                    Console.WriteLine($"Printing file: {currentDoc}. In the queue: {printerQueue.Count}. Next file: {nextFile}");
                }
                else
                {
                    Console.WriteLine($"Printing file: {currentDoc}. In the queue: 0. Next file: Empty (Queue is clear)");
                }
            }


            Console.WriteLine("\n------------------ Your STACK history (LIFO order) ---------------");
            foreach (string doc in docsPrintHistory)
            {
                Console.WriteLine($"In history: {doc}");
            }
        }

    }
}
