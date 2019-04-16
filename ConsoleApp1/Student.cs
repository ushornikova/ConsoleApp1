using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string studentEmail { get; set; }
        public int studentId { get; set; }

        public Student(string first, string last, string email, int id)
        {
            firstName = first;
            lastName = last;
            studentEmail = email;
            studentId = id;
        }

        public void info()
        {
            Console.WriteLine($"{firstName},{lastName},{studentEmail}, {studentId}");
        }
    }
}
