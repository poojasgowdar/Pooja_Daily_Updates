using System;
using System.Threading;
using System.Threading.Tasks;

namespace Asynchronous_Thread
{
    internal class Program
    {
      static void Main(string[] args)
        {
            Console.WriteLine("Main method Started");
            SomeMethod();
            Console.WriteLine("Main method Ended");
            Console.ReadKey();
        }

        public async static void SomeMethod()
        {
            Console.WriteLine("SomeMethod started");
            await Task.Delay(TimeSpan.FromSeconds(10));
            Console.WriteLine("SomeMethod ended");
        } 

        
    }
}
