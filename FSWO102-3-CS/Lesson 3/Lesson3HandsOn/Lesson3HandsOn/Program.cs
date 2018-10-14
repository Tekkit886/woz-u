using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myArray = {"Emily", "Harry", "Rupert", "Clara", "Lily", "Michael"};

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine("Have you seen" + myArray[i] + " " + "?");
            }
            for (int i = 0 - 1; i > myArray.Length; i--)
            {
                Console.WriteLine("Have you seen" + myArray[i] + " " + "?");
            }
        }
    }
}
