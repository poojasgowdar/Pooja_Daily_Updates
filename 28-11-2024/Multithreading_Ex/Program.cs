using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreading_Ex
{
    internal class Program
    {
        public static void Task1()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Task 1 {i}");
                Thread.Sleep(1000);
            }
        }

        public static void Task2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Task 2 {i}");
                Thread.Sleep(1500);
            }
        }
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(Task1);
            Thread thread2 = new Thread(Task2);
            //Start() - Creates a new thread and executes the run() method in that new thread.
            thread1.Start();
            thread2.Start();
            Console.WriteLine("Both task completed");
            Console.ReadKey();

        }
    }
}
