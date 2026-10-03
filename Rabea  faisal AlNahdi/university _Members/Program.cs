using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace university__Members
{
    class Person
    {
        public string Name { get; set; }

        public virtual void DisPlayInfo()
        {
            Console.WriteLine($"Name : {Name} ");
        }
        public Person(string Name)
        {
            this.Name = Name;
        }
    }

    class student : Person
    {
        public int Id { get; set; }
        public override void DisPlayInfo()
        {
            base.DisPlayInfo();
            Console.WriteLine($"Id : {Id} \n ");
        }
        public student(string Name, int Id) : base(Name)
        {
            this.Id = Id;
        }
    }

    class Employee : Person
    {
        public double Salary { get; set; }

        public override void DisPlayInfo()
        {
            base.DisPlayInfo();
            Console.WriteLine($" Employee Salary : {Salary} \n");
        }
        public Employee(string Name, double Salary) : base(Name)
        {
            this.Salary = Salary;
        }

    }

    class Teacher : Person
    {
        public string CourseName { get; set; }

        public override void DisPlayInfo()
        {
            base.DisPlayInfo();
            Console.WriteLine($"Course Name  : {CourseName} \n ");
        }

        public Teacher(string Name, string CourseName) : base(Name)
        {
            this.CourseName = CourseName;
        }
    }

    //
    class PrintPersonInfo
    {
        public void print(Person p)
        {
            p.DisPlayInfo();
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {

            List<Person> people = new List<Person>
            {
                new student ("Ahmed",6651),
                new Employee ("Ali", 8750),
                new Teacher ("Rabea", "Programing"),
            };

            foreach (Person person in people)
            {
                Console.WriteLine("Runtime Type: " + person.GetType() + "\n");
                person.DisPlayInfo();

            }

            PrintPersonInfo pr = new PrintPersonInfo();

            pr.print(new student("sara", 8872));


        }
    }
}
