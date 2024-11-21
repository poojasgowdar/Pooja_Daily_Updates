using System;
namespace MultiCastDelegate
{
    internal class Program
    {
        public delegate void print(string message);

        static void displayMessage(string message)
        {
            Console.WriteLine(message);
        }

        static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
        static void Main(string[] args)
        {
            print p = displayMessage;
            p += ShowMessage;
            Console.WriteLine("Hello");
            Console.ReadKey();

        }
    }
}
