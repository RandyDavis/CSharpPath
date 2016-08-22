using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intersect
{
    class Program
    {
        static void Main(string[] args)
        {
            var bigCities = new HashSet<string>
            {
                "New York", "Manchester", "Sheffield", "Paris"
            };

            string[] citiesInUK = { "Sheffield", "Ripon", "Truro", "Manchester" };

            //bigCities.IntersectWith(citiesInUK);
            //foreach (string city in bigCities)
            //{
            //    Console.WriteLine(city);
            //}


            // Use LINQ instead of commented out code above
            //var newCities = bigCities.Intersect(citiesInUK);
            //foreach (string city in newCities)
            //{
            //    Console.WriteLine(city);
            //}


            // UnionWith
            //bigCities.UnionWith(citiesInUK);
            //foreach (string city in bigCities)
            //{
            //    Console.WriteLine(city);
            //}

            // SymmetricExceptWith
            //bigCities.SymmetricExceptWith(citiesInUK);
            //foreach (string city in bigCities)
            //{
            //    Console.WriteLine(city);
            //}

            bigCities.ExceptWith(citiesInUK);
            foreach (string city in bigCities)
            {
                Console.WriteLine(city);
            }
        }
    }
}
