//using System;

//namespace newApp
//{
  //  class Program
    //{
      //  static void Main(string[] args)
        //{
          //  printHelloWorld();
            //greetPerson("Andrew");
        //}
        //public static void printHelloWorld() => Console.WriteLine("Hello World");

        //public static void greetPerson(string personName) => Console.WriteLine("Hello " + personName);
    //}
//}

using System;
namespace Exercise {
    public class StudentCode {
        static void Main(string[] args)
        {
            GreetMe("Brian");
        }
        public static void GreetMe(string name){
            
         Console.WriteLine("Hello " + name);
        }
    }
}

using System;
namespace Exercise {
    public class StudentCode {
        public double GetAverage(double[] numbers) {
            if(numbers.Length == 0) {
                return 0.0;
            }
            double sum = 0;
            for(int idx = 0; idx < numbers.Length; idx++) {
                sum += numbers[idx];
            }
            return sum / numbers.Length;
        }
    }
}

