using System;

namespace Final
{
    class Program
    {
        static void Main(string[] args)
        {
            Task tasks = new Task();

            tasks.add();
            tasks.remove();
            tasks.mark();
            tasks.list();
            tasks.option();
            tasks.listen();
        }

        public interface Manager{
            
        }
        public interface TasksManager: Manager{
            void add();
            void remove();
            void mark();
            void list();
            void option();
        }

        public class Task{
            public void add(){
                Console.WriteLine("1. Add a task");
            }
            public void remove(){
                Console.WriteLine("2. Remove a task");
            }
            public void mark(){
                Console.WriteLine("3. Mark a task complete");
            }
            public void list(){
                Console.WriteLine("4. List the tasks");
            }
            public void option(){
                Console.WriteLine("What would you like to do");
            }

            public void listen(){
                
               input = Console.ReadLine();
                if (input = "1"){
                    Console.WriteLine("Add Task");
                    Console.ReadLine();
                }
                else if (input = "2"){
                    Console.WriteLine("Which task to remove?");
                    Console.ReadLine();
                }
                else if (input = "3"){
                    Console.WriteLine("Which task to mark complete");
                    Console.ReadLine();
                }
                else if (input = "4"){
                    Console.WriteLine(); //List All Tasks
                }
                else {
                    Console.WriteLine("That is an invaild input");
                }
            }
        }
    }
}
