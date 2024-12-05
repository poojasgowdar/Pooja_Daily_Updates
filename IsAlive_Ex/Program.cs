using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace IsAlive_Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread Started");
            Thread t1 = new Thread(Method1);
            t1.Start();

            if (t1.IsAlive)
            {
                Console.WriteLine("Thread1 Method1 is still executing");
            }
            else
            {
                Console.WriteLine("Thread1 Method1 completed its Execution");
            }
            //Wait Till thread1 to complete its execution
            t1.Join();
            if (t1.IsAlive)
            {
                Console.WriteLine("Thread1 Method1 is still Executing");
            }
            else
            {
                Console.WriteLine("Thread1 Method1 Completed its work");
            }
            Console.WriteLine("Main Thread Ended");
            Console.ReadKey();
        }
        static void Method1()
        {
            Console.WriteLine("Method1 - Thread1 Started");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Console.WriteLine("Method1 - Thread1 Finished");
        }
    }
}
