//comment
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class countNumbersinArr
    {
        static void Main(string[] Arg)
        {
           int[] someNumbers = new int[4];
            for (int j = 0; j < 4; j++)
            {
                Console.WriteLine("Please enter item" + j);
                var k = Console.ReadLine();
                someNumbers[j] = Convert.ToInt32(k);
            }
            int Max = someNumbers[0];
            for (int i=1; i<4; i++)
            {
                if (someNumbers[i] > Max)
                {
                    Max = someNumbers[i];
                }
            }
            Console.WriteLine("max number is" + Max);
            Console.ReadLine();
        }
    }
}
    