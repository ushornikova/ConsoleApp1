using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Course
    {
        public string courseName;
        public int courseId;
        public Teacher teacher { get; set; }
        public Student [] student { get; set; }

        public Course (string Name, int id) {  courseName=Name; courseId = id; }

        public void infoCourse ()
        {
            Console.WriteLine($"{courseName}, {courseId}, {teacher} and {student}");
        }
    }
}
