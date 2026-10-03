using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uneversity
{
    class Person
    {
        public string Name;
        public string Email;

        public void DisplayBasicInfo()
        {
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Email : {Email}\n ");

        }
        public Person(string name, string Email)
        {
            Name = name;
            this.Email = Email;
            Console.WriteLine("Person Constructor");
        }

    }

    class Student : Person
    {
        public int StudentId { get; }
        private double GPA;
        public double gpa
        {
            get
            {
                return GPA;
            }
            private set
            {
                if (value <= 4 && value >= 0)
                    GPA = value;
                else
                    Console.WriteLine("Warning :  GPA! Must be between 0 and 4.");

            }
        }

        public Student(string name, string Email, int studentid, double gpa) : base(name, Email)
        {
            StudentId = studentid;
            this.gpa = gpa;
            Console.WriteLine("Student Constructor");
        }
    }

    class Employee : Person
    {
        public int EmployeeId { get; }
        private double Salary;
        public double salary
        {
            get
            {
                return Salary;
            }
            private set
            {
                if (value <= 10000 && value >= 1000)
                    Salary = value;
                else
                    Console.WriteLine("Warning : Salary! Must be between 1000 and 10000.");
            }
        }

        public Employee(string name, string Email, int employeeid, double salary) : base(name, Email)
        {
            EmployeeId = employeeid;
            this.salary = salary;
            Console.WriteLine("Employee Constructor");

        }

    }
    class Teacher : Employee
    {
        public string CourseName;

        public Teacher(string name, string Email, int employeeid, double salary, string coursename) : base(name, Email, employeeid, salary)
        {
            CourseName = coursename;
            Console.WriteLine("Teacher Constructor");
        }
        public void Teach()
        {
            Console.WriteLine($"Teacher teaches  : {CourseName}");
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student");
            Student s1 = new Student("Ahmed", "Ahmed@outlook.sa", 1772, 726);
            s1.DisplayBasicInfo();

            Console.WriteLine("\n Teacher");
            Teacher t1 = new Teacher("Nawaf", "Nawaf@Gmail.com", 1293, 5350, "Programming");
            t1.DisplayBasicInfo();
            t1.Teach();


        }
    }
}
