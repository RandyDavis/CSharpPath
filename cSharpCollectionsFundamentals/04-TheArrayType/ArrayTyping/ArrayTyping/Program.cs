using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTyping
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] objArray = new object[3]
            {
                "Hello World",
                4,
                new Button {Text = "CLick me!" }
            };
            Type objArrType = objArray.GetType();

            string[] strArray = new string[2];
            Type strArrType = strArray.GetType();

            foreach (object item in objArray)
            {
                Console.WriteLine(item);
            }
        }
    }

    internal class Button
    {
        public string Text { get; set; }
    }
}
