using System;
using System.Threading.Tasks;
namespace Asynchronous_Thread_using_await
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main thread Started");
            SomeMethod();
            Console.WriteLine("Main thread Stopped");
            Console.ReadKey();
        }
        public async static void SomeMethod()
        {
            await Task.Delay(1000);
            Console.WriteLine("Task is delayed");
        }
    }
}
