using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Teacher
    {
        public string teacherName { get; set; }
        public int teacherId { get; set; }

        public Teacher(string name, int id) { teacherName =name; teacherId=id; }

        public void inforteacher()
        {
            Console.WriteLine($"{teacherName}, {teacherId}");
        }
    }
}
