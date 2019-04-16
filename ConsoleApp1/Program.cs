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
            Console.WriteLine("Please enter dergee");
            var dergee = Console.ReadLine();
            Degree degree = new Degree(dergee, 1);


            Console.WriteLine($"please enter teacher name");
            var teachername = Console.ReadLine();
            Teacher teacher1 = new Teacher(teachername,1);
            teacher1.inforteacher();

            Console.WriteLine($"please enter student first name");
            var studentfirstname = Console.ReadKey();
            string studentfirstname1 = Convert.ToString(studentfirstname);
            Console.WriteLine($"please enter student last name");
            var studentlastname = Console.ReadKey();
            string studentlastname1 = Convert.ToString(studentlastname);
            Console.WriteLine($"please enter student email");
            var studentemail = Console.ReadKey();
            string studentemail1 = Convert.ToString(studentemail);
            Student student = new Student(studentfirstname1, studentlastname1, studentemail1, 1);


            Console.WriteLine($"please enter course name");
            var coursename = Console.ReadLine();
            Course programing = new Course(coursename,1);
            programing.teacher = teacher1;
            programing.student[1] = new Student(studentfirstname1, studentlastname1, studentemail1, 1);
            //student.info();
            programing.infoCourse();
  

            //SchoolStudent schoolstudent1 = new SchoolStudent("Tom", "Soyer", 10, "1A", "15.05.2019"); //створюю обєкт  schoolstudent
            //SchoolTeachers schoolteacher1 = new SchoolTeachers("Mariya", "Ivanvna", 25, "1A", "math"); //створюю обєкт schoolteacher
            //schoolstudent1.TakeTest("12.02.2020"); //викликаю метод TakeTest з параметром  12.02.2020
            //schoolteacher1.GradeTest("5"); //викликаю метод GradeTest з параметром 5
            //schoolstudent1.ShowNameAndAge();
            Console.ReadKey();       



        }
    }
}
    