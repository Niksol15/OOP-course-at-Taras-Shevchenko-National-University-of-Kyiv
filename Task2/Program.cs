using System;
using System.Collections.Generic;

namespace Task2
{
    abstract class Student
    {
        public Student(string initial_name)
        {
            name = initial_name;
            state = "";
        }
        public void Relax()
        {
            state += "Relax ";
        }
        public void Read()
        {
            state += "Read ";
        }
        public void Write()
        {
            state += "Write ";
        }
        public string Name
        {
            get { return name; }                
            set { name = value; }
        }

        public string State
        {
            get { return state; }
            set { state = value; }
        }
        abstract public void Study();
        protected string name;
        protected string state;
    }
    class GoodStudent: Student
    {
        public GoodStudent(string initial_name) : base(initial_name)
        {
            state += "good ";
        }
        public override void Study()
        {
            Read();
            Write();
            Read();
            Write();
            Relax();
        }
    }
    class BadStudent: Student
    {
        public BadStudent(string initial_name): base(initial_name)
        {
            state += "bad ";
        }
        public override void Study()
        {
            for(int i = 0; i < 5; ++i)
            {
                Relax();
            }
        }
    }

    class Group
    {
        public Group(string initial_name)
        {
            name = initial_name;
            students = new List<Student>();
        }
        public void AddStudent(Student st)
        {
            students.Add(st);
        }

        public string GetInfo()
        {
            string res = name + "\nStudents:\n";
            foreach(Student student in students)
            {
                res += student.Name + ", ";
            }
            return res;
        }

        public string GetFullInfo()
        {
            string res = name + "\nStudents:\n";
            foreach (Student student in students)
            {
                res += student.Name + ": " + student.State + "\n";
            }
            return res;
        }
        private string name;
        private List<Student> students;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demonstration of the Task2:\nAdded students to Group...\n");
            Group group = new Group("K-26");
            Student good_studied_student = new GoodStudent("Good Student 1");
            good_studied_student.Study();
            Student bad_studied_student = new GoodStudent("Bad Student 1");
            bad_studied_student.Study();
            group.AddStudent(good_studied_student);
            group.AddStudent(bad_studied_student);
            group.AddStudent(new BadStudent("Bad Student 2"));
            group.AddStudent(new GoodStudent("Good Student 2"));
            Console.WriteLine("Output info about group:\n" + group.GetInfo() + "\n");
            Console.WriteLine("Output full info about group:\n" + group.GetFullInfo());
            Console.ReadKey();
        }
    }
}
