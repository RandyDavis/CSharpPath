using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sortedDays =
           {
                "Friday",
                "Monday",
                "Saturday",
                "Sunday",
                "Thursday",
                "Tuesday",
                "Wednesday"
            };

            int indexOfSun = Array.BinarySearch(sortedDays, "Sunday");
            // int indexOfSun = Array.IndexOf(sortedDays, "Sunday");
            Console.WriteLine("Index is: " + indexOfSun);
        }
    }
}
