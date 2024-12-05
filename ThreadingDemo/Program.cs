using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CurrentThread static property return type is Thread
            Thread t = Thread.CurrentThread;
            t.Name = "Main Thread";
            Console.WriteLine("Current Executing Thread Name:" + t.Name);
            Console.WriteLine("Current Executing Thread Name:" + Thread.CurrentThread.Name);
            Console.ReadKey();
        }
    }
}
