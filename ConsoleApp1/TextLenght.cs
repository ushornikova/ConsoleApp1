using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class TextLenght
    {
        private void Main(string[] args)
        {
            string a;
            Console.WriteLine("Please enter a text");
            a = Console.ReadLine();
            int strlength = a.Length;
            Console.WriteLine("The text length is", strlength);
            Console.ReadKey();
            //some comment
        }
    }
}
