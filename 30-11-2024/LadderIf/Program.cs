using System;
namespace LadderIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 100;
            if (i == 10)
            {
                Console.WriteLine("i is 10");
            }
            else if (i == 20)
            {
                Console.WriteLine("i is 20");
            }
            else if (i == 100)
            {
                Console.WriteLine("i is 100");
            }
            else
            {
                Console.WriteLine("i is not present");
            }
            Console.ReadKey();
        }
    }
}
