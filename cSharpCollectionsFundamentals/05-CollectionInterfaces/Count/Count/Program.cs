using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek =
           {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            /*
            // ICollection<T> Lesson
            ICollection<string> collection = (ICollection < string >) daysOfWeek;
            Console.WriteLine("Count() = " + collection.Count());  // don't use .Count() unless in situation where you have to
            Console.WriteLine("Count = " + collection.Count);
            Console.WriteLine("Length = " + daysOfWeek.Length);
            */

            // The ICollection<T> IsReadOnly Property Lesson
            ICollection<string> collection = (ICollection<string>)daysOfWeek;
            // collection.Add("FakeDay");  // Will not work, just a demo

            (collection as string[])[5] = "FakeDay";
            if (!collection.IsReadOnly)
                collection.Add("FakeDay");
            else
                Console.WriteLine("Collection is read-only");

            foreach (string day in daysOfWeek)
            {
                Console.WriteLine(day);
            }
        }
    }
}
