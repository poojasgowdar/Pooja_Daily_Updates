using System;
namespace SimpleIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter a Number");
            number = int.Parse(Console.ReadLine());
            if (number > 10)
            {
                Console.WriteLine($"{number} is greater than 10");
                Console.WriteLine("End of if block");
            }
            Console.WriteLine("End of Main method");
            Console.ReadKey();
        }
    }
}
