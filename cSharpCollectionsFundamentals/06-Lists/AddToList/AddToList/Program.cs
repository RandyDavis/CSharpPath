using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddToList
{
    class Program
    {
        static void Main(string[] args)
        {
            var presidents = new List<string>
            {
                "Jimmy Carter",
                "Ronald Reagan",
                "George HW Bush",
                "Bill Clinton",
                "George W Bush"
            };
            presidents.Add("Barack Obama");

            foreach (string president in presidents)
            {
                Console.WriteLine(president);
            }
        }
    }
}
