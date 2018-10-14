using System;

namespace blingbong
{
    class counter
    {
        static void Main(string[] args)
        {
            int a, b, i, Sum = 0;
            for (i = 1; i < 100; i++)
            {
                a = i % 3;
                b = i % 5;
                if (a == 0)
                {
                    Console.WriteLine("Bling");
                }
                if (b == 0)
                { 
                    Console.WriteLine("Bong");
                }
            }

            
        }
    }
}