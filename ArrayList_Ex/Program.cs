using System;
using System.Collections;
namespace ArrayList_Ex
{
    internal class Program
    {

        static void Main(string[] args)
        {
            ArrayList arraylist = new ArrayList
            {
                101,
                "Pooja",
                null,
                "pooja"
            };
            

            foreach(var item in arraylist)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

        }
    }
}
