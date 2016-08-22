using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimeMinisters;

namespace ReadOnlyDict
{
    class Program
    {
        static void Main(string[] args)
        {
            var primeMinisters = new Dictionary<string, PrimeMinister>()
            {
                {"JC", new PrimeMinister("James Callaghan", 1976) },
                {"MT", new PrimeMinister("Margaret Thatcher", 1979) },
                {"TB", new PrimeMinister("Tony Blair", 1997) }
            };

            var pmsReadOnly = new ReadOnlyDictionary<string, PrimeMinister>(primeMinisters);

            foreach (var pm in pmsReadOnly)
	        {
                Console.WriteLine( pm.Value );
	        }
        }

    }
}
