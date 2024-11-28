using System;
using System.Collections.ObjectModel;
using System.Threading;
namespace Multithreading_Ex2
{
    class Program
    {
        static void Method1()
        {
            Console.WriteLine("Method1 Started Using: " + Thread.CurrentThread.Name);
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Method1 :" +i);
            }
            Console.WriteLine("Method1 Ended Using: " + Thread.CurrentThread.Name);

        }
        static void Method2()
        {
            Console.WriteLine("Method2 Started Using: " + Thread.CurrentThread.Name);
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Method2 :" +i);
                if (i == 3)
                {
                    Console.WriteLine("Performing the Database Operation Started");
                    Thread.Sleep(1000);
                    Console.WriteLine("Performing the Database Operation Completed");
                }
            }
            Console.WriteLine("Method2 Ended Using: " + Thread.CurrentThread.Name);

        }
        static void Method3()
        {
            Console.WriteLine("Method3 Started Using:" + Thread.CurrentThread.Name);
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Method3 :" +i);
            }
            Console.WriteLine("Method3 Ended Using: " + Thread.CurrentThread.Name);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread Started");
            Thread t1 = new Thread(Method1)
            {
                Name = "Pooja1"
            };
            Thread t2 = new Thread(Method2)
            {
                Name = "Pooja2"
            };

            Thread t3 = new Thread(Method3)
            {
                Name = "Pooja3"
            };

            t1.Start();
            t2.Start();
            t3.Start();
            Console.WriteLine("Main Thread Ended");

            Console.ReadKey();
        }
    }


}

