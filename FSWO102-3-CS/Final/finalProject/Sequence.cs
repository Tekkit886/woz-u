using System;

namespace sequence
{
    class partTwo
    {
        public static int Sequence(int n)
        {
           int a = 0;
           int b = 1;
           for (int i =0; i < n; i++)
           {
               int temp =a;
               a = b;
               b =temp + b;
           }
           return a;
        }
        static void SequenceTwo()
        {
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine(Sequence(i));
            }
        }
    }
}