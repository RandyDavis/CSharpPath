using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSetsBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            var bigCities = new HashSet<string>
            {
                "New York", "Manchester", "Sheffield", "Paris"
            };
            bool addedSheffield = bigCities.Add("Sheffield");
            bool addedBeijing = bigCities.Add("Beijing");
            Console.WriteLine("Added Sheffield? " + addedSheffield);
            Console.WriteLine("Added Beijing? " + addedBeijing);
            Console.WriteLine();

            //if (!bigCities.Contains("Sheffield"))
            //    bigCities.Add("Sheffield");
            //if (!bigCities.Contains("Beijing"))
            //    bigCities.Add("Beijing");

            foreach (string city in bigCities)
            {
                Console.WriteLine(city);
            }
        }
    }
}
