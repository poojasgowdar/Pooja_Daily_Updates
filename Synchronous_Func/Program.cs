using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synchronous_Func
{
    internal class Program
    {

        public void Task1()
        {
            Console.WriteLine("Task 1 is running...");
            System.Threading.Thread.Sleep(3000);  // Simulate a time-consuming task (3 seconds)
            Console.WriteLine("Task 1 completed.");
            Console.WriteLine("End of main.");  
        }

        public void Task2()
        {
            Console.WriteLine("Task 2 is running...");
            System.Threading.Thread.Sleep(2000);  // Simulate a time-consuming task (2 seconds)
            Console.WriteLine("Task 2 completed.");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Start task 1");
            p.Task1();
            Console.WriteLine("Start task 1");
            p.Task2();
        }
    }
}
