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
            {
                {"JC", new PrimeMinister("James Callaghan", 1976) },
                {"MT", new PrimeMinister("Margaret Thatcher", 1979) },
                {"TB", new PrimeMinister("Tony Blair", 1997) }
            };

            /*
            foreach (var pm in primeMinisters)
            {
                Console.WriteLine(pm.Key + ",   " + pm.Value);
            }
            */

            //PrimeMinister pm = primeMinisters["TB"];
            //Console.WriteLine("Value is: " + pm.ToString() + "\r\n");

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

        }
    }
}
