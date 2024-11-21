using System;
namespace PractiseDelegates_Program
{
    internal class Program
    {  // 1]declare a delegate
        public delegate void displayMessage(string name);

        // 2]Method that matches the delegate's signature
        static void ShowMessage(string name)
        {
            Console.WriteLine(name);
        }
        static void Main(string[] args)
        {
            //Instantiate the delegate
            displayMessage dm = ShowMessage;
            dm("Pooja");
            Console.ReadKey();
        }
    }
}
