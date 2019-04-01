//comment
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class WorkingWithArrays
    {
        static void Main(string[] Arg)
        {
            int[] someArr = {5, 9, 6, 4 };
            int maxArr = someArr[0];
            //int[] a = new int[4];
            for (int i=0; i < 4; i++)
            {

                for (int j=0; j<4; j++)
                {


                    if (maxArr < someArr[j])
                    {
                        //Console.WriteLine(a[i]);
                        //a[i] = someArr[j];
                        maxArr = someArr[j];
                        Console.WriteLine(someArr[j]);
                        someArr[j] = maxArr;

                    }

                }
               // Console.WriteLine(someArr[i]);
            }
            Console.WriteLine("max number is " + maxArr);
            Console.ReadLine();

//програма виводить найбільше число у масиві
            //int[] someArr = {5, 9, 10, 7};
            //int maxArr = someArr[0];
            //for (int i=1; i<4;i++)
            //{
            //    if (maxArr < someArr[i])
            //    {
            //        maxArr = someArr[i];
            //        someArr[i] = maxArr;
            //    }
            //}
            //Console.WriteLine(maxArr);
            //Console.ReadLine();
            

//програма зчитує те що ввів користувач і виводить на екран перший елемент
            //string[] someWord = new string[5];
            //for (int i=0; i < 5; i++)
            //{
            //    Console.WriteLine("Please enter " + i + " item");
            //    someWord[i] = Console.ReadLine();
            //}
            //Console.WriteLine(someWord[0]);
            //Console.ReadLine();

//Дано масив. Определить, одинаковы ли второй и четвертый символы в нем
//string[] someString = { "g", "h", "b", "G", "H" };
//for (int i = 0; i < 4; i++)
//{
//    someString[i]= someString[i].ToLower();
//}
//if (someString[1]==someString[1])
//{
//    Console.WriteLine("the first and the last items are the same");
//}
//else
//{
//    Console.WriteLine("the first and the last items are not the same");
//}
//Console.ReadLine();

            //програма виводить останній елемент масиву
            //int[] someString = { 1, 5, 8, 35 };
            //int i = someString.Length;
            //Console.WriteLine(someString[i-1]);
            //Console.ReadLine();

            //програма зчитує значення масиву і виводить їх на екран
            //int[] someNumbers = new int[4];
            // for (int j = 0; j < 4; j++)
            // {
            //     Console.WriteLine("Please enter item" + j);
            //     var k = Console.ReadLine();
            //     someNumbers[j] = Convert.ToInt32(k);
            // }
            // int Max = someNumbers[0];
            // for (int i=1; i<4; i++)
            // {
            //     if (someNumbers[i] > Max)
            //     {
            //         Max = someNumbers[i];
            //     }
            // }
            // Console.WriteLine("max number is" + Max);
            // Console.ReadLine();
        }
    }
}
    