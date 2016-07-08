using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddToList
{
    class Program
    {
        static void Main(string[] args)
        {
            var presidents = new List<string>(12)
            {
                "Jimmy Carter",
                "Ronald Reagan",
                "George HW Bush",
                "Bill Clinton",
                "George W Bush"
            };
            Console.WriteLine("Before: ");
            Console.WriteLine("Count= " + presidents.Count);
            Console.WriteLine("Capacity = " + presidents.Capacity + "\r\n");
            presidents.Add("Barack Obama");
            presidents.Add("Bill Gates");
            presidents.Add("Joss Whedon");
            presidents.Add("John Papa");

            /* REMOVE an item
            presidents.Remove("Bill Gates");  // Expensive if item to be removed is at beginning of list
            presidents.RemoveAt(5);  // Always better to use this one
            */
            Console.WriteLine("\r\nAfter adding: ");
            Console.WriteLine("Count= " + presidents.Count);
            Console.WriteLine("Capacity = " + presidents.Capacity + "\r\n");

            // string who = presidents[10];  // Shows out of range exception
            foreach (string president in presidents)
            {
                Console.WriteLine(president);
            }
        }
    }
}
