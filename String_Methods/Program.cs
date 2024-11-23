using System;
using System.Data.SqlTypes;
using System.Linq;
namespace String_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.Clone The clone method in C# is used to duplicate a string type object.
            // It returns a clone of the same data as the object type.
            //string a = "hello";
            //string b = "Bye";
            //Console.WriteLine(a + b);
            //string a = "hello";
            //string b = (string)a.Clone();
            //Console.WriteLine(b);

            //2.Concat
            //string a = "heypooja ";
            //string b = "pooja ";
            //string c = "hello";
            //Console.WriteLine(string.Concat(a,b,c));
            //Console.WriteLine(b.Contains(a));

            //3.Copy
            //string a1 = "abc";
            //string b2 = string.Copy(a1);
            //Console.WriteLine(b2);


            //4.Substring
            string a = "Good morning.Have a nice day";
            string res = a.Substring(20, 8);
            Console.WriteLine(res);

            //5.Replace
            string word2 = "Good afternoon Alexa";
            string word = word2.Replace("afternoon", "morning");
            Console.WriteLine(word);

            Console.ReadKey();
        }
        
    }
}
