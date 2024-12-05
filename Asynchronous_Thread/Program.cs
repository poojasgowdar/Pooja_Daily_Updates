using System;
using System.Runtime.InteropServices;
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
//The SomeMethod() function starts executing and prints SomeMethod started.
//When the await Task.Delay(TimeSpan.FromSeconds(10)) line is reached, the method pauses asynchronously for 10 seconds without blocking the main thread.
//Control returns to the Main method while the delay is ongoing.
        public async static void SomeMethod()
        {
            Console.WriteLine("SomeMethod started");
            await Task.Delay(TimeSpan.FromSeconds(10));
            Console.WriteLine("SomeMethod ended");
        } 

        
    }
}
