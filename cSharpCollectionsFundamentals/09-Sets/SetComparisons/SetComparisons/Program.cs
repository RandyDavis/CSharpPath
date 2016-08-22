using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetComparisons
{
    class Program
    {
        static void Main(string[] args)
        {
            var ukCities = new HashSet<string>
            {
                "Sheffield", "Ripon", "Truro", "Manchester"
            };

            var bigUKCities = new HashSet<string>
            {
                "Sheffield", "Manchester"
            };

            var bigCitiesArr = new HashSet<string>
            {
                "New York", "Manchester", "Sheffield", "Paris"
            };

            //bool ukIsSubset = ukCities.IsSubsetOf(bigCitiesArr);
            bool ukIsSubset = bigCitiesArr.IsSupersetOf(ukCities);
            Console.WriteLine("UK cities subset of big cities? " + ukIsSubset);

            //bool bigUKIsSubset = bigUKCities.IsSubsetOf(bigCitiesArr);
            bool bigUKIsSubset = bigCitiesArr.IsSupersetOf(bigUKCities);
            Console.WriteLine("Big UK cities subset of big cities? " + bigUKIsSubset);
        }
    }
}
