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

            ICollection<string> collection = (ICollection < string >) daysOfWeek;
            Console.WriteLine("Count() = " + collection.Count());  // don't use .Count() unless in situation where you have to
            Console.WriteLine("Count = " + collection.Count);
            Console.WriteLine("Length = " + daysOfWeek.Length);
        }
    }
}
