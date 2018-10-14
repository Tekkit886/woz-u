using System;

namespace blingbong
{
    class partOne
    {
       public static void Counter(string[] args)
        {
            int a, b, i, Sum = 1;
            
           for (i = 1; i < 100; i++)
            {
                a = i % 3;
                b = i % 5;
                Console.WriteLine(Sum);
                if (Sum == a)
                {
                    Console.WriteLine("Bling");
                }
                else if (Sum == b)
                {
                    Console.WriteLine("Bong");
                }
                else
                {
                    Console.WriteLine(Sum);
                }
            }
        }
    }
}