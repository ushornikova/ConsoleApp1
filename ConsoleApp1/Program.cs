//comment
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class UProgram
    {
        static void Main(string[] Arg)
        {

            SchoolStudent schoolstudent1 = new SchoolStudent("Tom", "Soyer", 10, "1A", "15.05.2019"); //створюю обєкт  schoolstudent
            SchoolTeachers schoolteacher1 = new SchoolTeachers("Mariya", "Ivanvna", 25, "1A", "math"); //створюю обєкт schoolteacher
            schoolstudent1.TakeTest("12.02.2020"); //викликаю метод TakeTest з параметром  12.02.2020
            schoolteacher1.GradeTest("5"); //викликаю метод GradeTest з параметром 5
            Console.ReadKey();



        }
    }
}
    