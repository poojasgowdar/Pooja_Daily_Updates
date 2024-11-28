using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace Multithreading_Abort_Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(SomeMethod);
            t1.Start();
            Console.WriteLine("Thread is Abort");
            //Abort thread Using Abort() method
            t1.Abort();
            Console.ReadKey();
        }
        public static void SomeMethod()
        {
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
