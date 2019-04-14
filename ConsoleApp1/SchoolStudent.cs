using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SchoolStudent : Person
    {
        public string className { get; set; }
        public string testDate { get; set; }


        public SchoolStudent(string firstName, string lastName, int age, string className, string testDate)
            : base (firstName, lastName, age)
        {
            Console.WriteLine($"They should take test on + {testDate}"); 
        }
    }
}
