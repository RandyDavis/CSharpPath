using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> tasks = new Queue<string>();

            tasks.Enqueue("Do the washing up");
            tasks.Enqueue("Finish the C# Collections Pluralsight Course");
            tasks.Enqueue("Buy some chocolate");
            tasks.Enqueue("Buy some more chocolate");

            Console.WriteLine("\r\nALL TASKS:");
            foreach (string title in tasks)
            {
                Console.WriteLine(title);
            }

            string nextTask = tasks.Dequeue();
            //string nextTask = tasks.Peek();  // can peek an item on the queue and it will tell you what the next item is going to be and won't remove it from th queue
            Console.WriteLine("\r\nNext Task: " + nextTask);

            Console.WriteLine("\r\nALL TASKS:");
            foreach (string title in tasks)
            {
                Console.WriteLine(title);
            }
        }
    }
}
