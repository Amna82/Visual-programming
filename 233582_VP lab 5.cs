using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    public enum Department
    {
        CSE,
        ECE,
        ME
    }

    public class Person
    {
        private string name;

        public Person()
        {
            this.name = null;
        }

        public Person(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }

    public class Student : Person
    {
        private string regNo;
        private int age;
        private Department program;

        public Student() : base()
        {
            this.regNo = null;
            this.age = 0;
            this.program = Department.CSE;
        }

        public Student(string name, string regNo, int age, Department program) : base(name)
        {
            this.regNo = regNo;
            this.age = age;
            this.program = program;
        }

        public string RegNo
        {
            get { return regNo; }
            set { regNo = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Department Program
        {
            get { return program; }
            set { program = value; }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // Create a Person object
            Person person = new Person("Amna Sajjad");
            Console.WriteLine("Person Name: " + person.Name);

            // Create a Student object
            Student student = new Student("Amna Sajjad", "123456", 20, Department.CSE);
            Console.WriteLine("Student Name: " + student.Name);
            Console.WriteLine("Student RegNo: " + student.RegNo);
            Console.WriteLine("Student Age: " + student.Age);
            Console.WriteLine("Student Program: " + student.Program);
        }
    }
   
