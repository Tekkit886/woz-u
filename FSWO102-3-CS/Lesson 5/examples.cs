using System;
namespace Exercise {
    public class Greeter {
        public static string[] Greet(Person[] people) {
            string[] results = new string[people.Length];
            for(int i = 0; i < people.Length; i++) {
                Person p = people[i];
                results[i] = "Hello " + p.firstName + " " + p.lastName + "!";
            }
            return results;
        }
    }
}

using System;
namespace Exercise {
    public class Person {
        string firstName;
        string lastName;

        public string FirstName {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName {
            get { return lastName; }
            set { lastName = value; }
        }
        public string FullName {
            get { return firstName + " " + lastName; }
        }

        public Person() {
            this.firstName = "";
            this.lastName = "";
        }
        public Person(string firstName, string lastName) {
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}