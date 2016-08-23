using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDimenstionArray
{
    class Program
    {
        static void Main(string[] args)
        {
            float[,] tempsGrid = new float[4, 3];
            float[] array1d = tempsGrid;  // Won't work
        }
    }
}
