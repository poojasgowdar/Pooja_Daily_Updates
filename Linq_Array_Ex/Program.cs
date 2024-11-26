using System;
using System.Linq;
namespace Linq_Array_Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Arun", "James", "Karan", "Gaurang" };

            //Linq Query
            var myLinqQuery = from name in names
                              where name.Contains('n')
                              select name;

            //Query Execution
            foreach(var name in myLinqQuery)
            {
                Console.WriteLine(name + " ");

            }
            Console.ReadKey();


        }
    }
}
