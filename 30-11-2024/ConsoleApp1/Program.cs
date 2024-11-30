using System;
using System.Threading;
namespace pJoin_MethodC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread Started");

            //Main thread creating three child threads
            Thread thread1 = new Thread(Method1);
            Thread thread2 = new Thread(Method2);
            Thread thread3 = new Thread(Method3);

            thread1.Start();
            thread2.Start();
            thread3.Start();

            thread1.Join();//Block Main Thread until thread1 completes its execution
            thread2.Join();//Block Main Thread until thread1 completes its execution
            thread3.Join();//Block Main Thread until thread1 completes its execution

            Console.WriteLine("Main Thread Ended");
            Console.ReadKey();
        }
         static void Method1()
        {
            Console.WriteLine("Method1- Thread1 Started");
            Thread.Sleep(5000);
            Console.WriteLine("Method1- Thread1 Ended");
        }
        static void Method2()
        {
            Console.WriteLine("Method2- Thread2 Started");
            Thread.Sleep(5000);
            Console.WriteLine("Method2- Thread2 Ended");
        }
        static void Method3()
        {
            Console.WriteLine("Method3- Thread3 Started");
            Thread.Sleep(5000);
            Console.WriteLine("Method3- Thread3 Ended");
        }
    }

}

