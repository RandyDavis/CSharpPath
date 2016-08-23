using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerateWhileChanging
{
    class Program
    {
        static void Main(string[] args)
        {
            //var days = new List<string>
            var days = new string[]
            {
                "Monday",
                "Tuesday",
                "Wednesday"
            };

            foreach (string day in days)
            {
                days[1] = "2nd day";
                Console.WriteLine(day);
            }
        }
    }
}
