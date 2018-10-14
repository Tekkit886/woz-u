using System;

namespace myApp
{
    class Student
    {
        string firstName;
        string lastName;
        string courseFocus;

        // Declare a FirstName property of type string
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        // Declare a LastName property of type string
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        // Declare a CourseFocus property of type string
        public string CourseFocus
        {
            get
            {
                return courseFocus;
            }
            set
            {
                courseFocus = value;
            }
        }

        public override string ToString()
        {
            return "Course Focus = " + courseFocus +", Name = " + firstName + " " + lastName;
        }

    }

    class Program
    {
        public static void Main(string[] args)
        {
            Student s = new Student();
            s.CourseFocus = "C#";
            s.FirstName = "John";
            s.LastName = "Slaw";
            Console.WriteLine("Student info: {0}", s);
        }

    }
}
