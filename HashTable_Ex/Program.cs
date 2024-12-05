using System;
using System.Collections;
namespace HashTable_Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("EmpId", 1001);
            hashtable.Add("EmpName", 1001);
            hashtable.Add("EmpSal", null);
            hashtable.Add("EmpAge", 1001);

            foreach(DictionaryEntry entry in hashtable)
            {
                Console.WriteLine(entry.Key+ ":"+ entry.Value);
            }
            Console.ReadKey();
        }
    }
}
