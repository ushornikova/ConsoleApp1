using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Person
    {
        public string firstName { get; set; } //створюю змінні які є однакові для вчителів і студентів
        public string lastName { get; set; }
        public int age { get; set; }

        public Person(string first, string last, int a) //конструктор абстрактного класу
        {
            firstName = first;
            lastName = last;
            age = a;
        }

        public abstract void ShowNameAndAge(); //описала абстрактний клас

    }

        class SchoolTeachers : Person
    {
        public string TeacherClass { get; set; } //описую змінні для класу SchoolTeachers
        public string Speciality { get; set; }
        public string Grade { get; set; }

        public SchoolTeachers(string firstName, string lastName, int age, string teacherclass, string speciality)
            : base(firstName, lastName, age) // конструктор для класу SchoolTeachers, кажу що він унаслідується від Person
        {
            Console.WriteLine($"{firstName} {lastName} has speciality {speciality}");
        }

        public string GradeTest (string grade) // опиую метод у класі SchoolTeachers
        {
            Grade = grade;
            Console.WriteLine($"{firstName} {lastName} set mark {grade}");
            return Grade;
        }

        public override void ShowNameAndAge() // викликаю абстрактний метод, а він не виводить нічого на екран. Чому?
        {
            Console.WriteLine($"Teacher {firstName} + {lastName} + age + {age}");
        }
    }

    class SchoolStudent : Person
    {
        public string className { get; set; }
        public string testDate { get; set; }



        public SchoolStudent(string firstName, string lastName, int age, string className, string testDate)
            : base(firstName, lastName, age)
        {                   
        }

        public string TakeTest (string testdate)
        {
            testDate = testdate;           
            Console.WriteLine($"{firstName} {lastName} should take test on {testdate}");
            return testDate;
        }

        public override void ShowNameAndAge()
        {
            Console.WriteLine($"User {firstName} + {lastName} + age + {age}");
        }
    }
}
