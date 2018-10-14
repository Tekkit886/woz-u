using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isSunny;
            isSunny = true;
            string wear;
            wear = "Wear sunglasses!";
            string dontWear;
            dontWear = "Wou don't need to wear sunglasses";
            bool atBeach;
            atBeach = true;
            string sunblock;
            sunblock = "Sunblock is a good idea";
            string noSunblock;
            noSunblock = "Sunblock isn't needed.";
            bool goTomorrow = true;
            string going;
            going = "Awesome! Glad you don't mind clouds!";
            string nextTime;
            nextTime = "No worries! Hopefully next time we will have some sun!";


        if (isSunny == true && atBeach == true && goTomorrow == true) {
            Console.WriteLine(wear);
            Console.WriteLine(sunblock);
            Console.WriteLine(going);
        }
        else {
            Console.WriteLine(dontWear);
            Console.WriteLine(noSunblock);
            Console.WriteLine(nextTime);
        }

        }
    }
}
