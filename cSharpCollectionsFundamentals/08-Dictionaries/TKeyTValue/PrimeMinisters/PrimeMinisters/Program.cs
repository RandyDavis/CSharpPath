using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeMinisters
{
    class Program
    {
        static void Main(string[] args)
        {
            var primeMinisters = new Dictionary<string, PrimeMinister>
                (StringComparer.InvariantCultureIgnoreCase) // Added for lesson Comparing Keys with IEqualityComparer<T>
            {
                {"JC", new PrimeMinister("James Callaghan", 1976) },
                {"MT", new PrimeMinister("Margaret Thatcher", 1979) },
                {"TB", new PrimeMinister("Tony Blair", 1997) }
            };

            /* Enumerating Dictionary Items
            foreach (var pm in primeMinisters)
            {
                Console.WriteLine(pm.Key + ",   " + pm.Value);
            }
            */

            //PrimeMinister pm = primeMinisters["TB"];
            //Console.WriteLine("Value is: " + pm.ToString() + "\r\n");

            /* Looking up Dictionary Items
            // Same code as above but tries to lookup value without throwing an exception
            PrimeMinister pm;
            bool found = primeMinisters.TryGetValue("DC", out pm);
            if (found)
            {
                Console.WriteLine("Value is: " + pm.ToString() + "\r\n");
            }
            else
            {
                Console.WriteLine("Value is not in the dictionary");
            }
            */

            /*
            // Modifying the Dictionary
            primeMinisters["JC"] = new PrimeMinister("Jim Callaghan", 1976);
            primeMinisters.Remove("JC");
            primeMinisters["JM"] = new PrimeMinister("John Major", 1990);
            primeMinisters.Add("GB", new PrimeMinister("Gordon Brown", 2007));

            foreach (var pm in primeMinisters)
            {
                Console.WriteLine(pm);
            }
            */

            /* 
            // Line below is from Comparing Keys with IEqualityComparer<T>
            */
            Console.WriteLine(primeMinisters["tb"]);
        }
    }

    /* 
    // class below is Still part of Comparing Keys with IEqualityComparer<T>
    */
    class UncasedStringEqualityComparer : IEqualityComparer<string>
    {
        public bool Equals(string x, string y)
        {
            return x.ToUpper() == y.ToUpper();
        }

        public int GetHashCode(string obj)
        {
            throw new NotImplementedException();
        }
    }
}
