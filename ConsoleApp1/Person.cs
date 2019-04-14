using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }

        public Person(string first, string last, int a)
        {
            firstName = first;
            lastName = last;
            age = a;
        }

        public void ShowNameAndAge()
        {
            Console.WriteLine($"{firstName} + {lastName} + age + {age}");
        }
    }
}
