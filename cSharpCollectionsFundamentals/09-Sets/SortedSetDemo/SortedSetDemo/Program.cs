using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedSetDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var bigCities = new SortedSet<string>
                (new UncasedStringComparer())
            {
                "New York", "Manchester", "Sheffield", "Paris"
            };

            bigCities.Add("SHEFFIELD");
            bigCities.Add("BEIJING");

            foreach (string city in bigCities)
            {
                Console.WriteLine(city);
            }
        }
    }

    class UncasedStringComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return string.Compare(x, y, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}
