using System;

namespace Lesson8HandsOn
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog maddox = new Dog();
            Cat kitty = new Cat();
            Cow jerry = new Cow();

            maddox.speak();
            maddox.run();
            maddox.eat();
            kitty.speak();
            kitty.run();
            kitty.eat();
            jerry.speak();
            jerry.run();
            jerry.eat();
        }

        public interface Animal{
            void eat();
        }
        public interface Mammal: Animal{
            void speak();
            void run();
            void eat();
        }

        public class Dog: Mammal{
            public void speak(){
                Console.WriteLine("Bark!");
		    }
            public void run(){
                Console.WriteLine("Dogs can run at a top speed of 45 mph");
            }
            public void eat(){
                Console.WriteLine("Dogs eat bones.");
            }
        }
        public class Cat: Mammal{
            public void speak(){
                Console.WriteLine("Meow!");
            }
            public void run(){
                Console.WriteLine("Cats can run at a top speed of 30 mph!");
            }
            public void eat(){
                Console.WriteLine("Cats Eat Mice.");
            }
        }
        public class Cow: Mammal{
            public void speak(){
                Console.WriteLine("Moo!");
            }
            public void run(){
                Console.WriteLine("Cows can run at a top speed of 25 mph!");
            }
            public void eat(){
                Console.WriteLine("Cows eat grass.");
            }
        }
    }
}
