using System;
namespace Switch_Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 9;
            switch (x)
            {
                case 1:
                    Console.WriteLine("Choice 1 is");
                    break;
                case 2:
                    Console.WriteLine("Choice 2 is");
                    break;
                case 3:
                    Console.WriteLine("Choice 3 is");
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
            Console.ReadKey();
        }
    }
}
