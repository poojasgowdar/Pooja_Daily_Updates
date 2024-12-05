using System;
using System.Threading;

namespace Single_Thread
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting the application");
            LongThread();
            Console.WriteLine("Ending the application");
            Console.ReadKey();
        }

        static void LongThread()
        {
            Console.WriteLine("First thread running");
            Thread.Sleep(3000);
            Console.WriteLine("Second thread running");
           
        }
    }
}
