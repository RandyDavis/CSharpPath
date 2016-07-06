using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAsRefTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x1 = { 1, 4, 9, 16 };
            var x2 = x1;
            // x1[0] = -3;
            //Console.WriteLine("RefEquals(x1, x2): " + ReferenceEquals(x1, x2));

            int[] x3 = { 1, 4, 9, 16 };
            Console.WriteLine(string.Format("x1==x2 is {0}", x1== x2));
            Console.WriteLine(string.Format("x1==x3 is {0}", x1== x3));
        }
    }
}
