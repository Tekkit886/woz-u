using System;
namespace ExerciseLoop {
    public class StudentCode {
        public int[] DoubleArray(int[] numbers) {
           int[] results = new int[numbers.Length];
            
            for (int i = 0; i < numbers.Length; i++){
             results[i] = numbers[i]*2;
            }
            return results;
        }
    }
}

namespace ExerciseLoop {
    public class StudentCode {
        public double GetAverage(int[] numbers) {
            double results = 0.0;
            if(numbers.Length > 0) {
                int idx = 0;
                do {
                    results += numbers[idx];
                    idx++;
                }
                while(idx < numbers.Length);
                results /= numbers.Length;
            }
            return results;
        }
    }
}

using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myArray = {"John", "Andrew", "Trey", "Bill", "Brian"};

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine("Where is " + myArray[i] + "today?");
            }
        }
    }
}

namespace ExerciseLoop {
    public class StudentCode {
        public int[] DoubleArray(int[] numbers) {
            int[] results = new int[numbers.Length];
            for(int idx = 0; idx < numbers.Length; idx++) {
                results[idx] = numbers[idx] * 2;
            }
            return results;
        }
    }
}