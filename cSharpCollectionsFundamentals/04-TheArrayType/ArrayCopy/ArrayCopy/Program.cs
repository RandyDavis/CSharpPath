using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] squares = { 1, 4, 9, 16 };

            //int[] copy = new int[8];
            //squares.CopyTo(copy, 2);  // using .CopyTo()

            int[] copy = squares.ToArray(); // using .ToArray()

            foreach (int value in copy)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine(string.Format("squares == copy? {0}", squares == copy));

        }
    }
}
