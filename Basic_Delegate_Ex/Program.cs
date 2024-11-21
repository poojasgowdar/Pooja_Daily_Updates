using System;
namespace Basic_Delegate_Ex
{
    internal class Program
    {
        public delegate void PrintMessage(string message);

        //static void ShowMessage(string message)
        //{
        //    Console.WriteLine(message);
        //}
        static void Main(string[] args)
        {
            PrintMessage pm = delegate (string message)
            {
                Console.WriteLine(message);
            };
            pm("Good Morning");
            Console.ReadKey();
        }
    }
}
