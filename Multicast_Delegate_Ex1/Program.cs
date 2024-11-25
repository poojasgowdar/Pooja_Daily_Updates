using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Serialization;

namespace Multicast_Delegate_Ex1
{
    internal class Program
    {
        public delegate string Message(string name);

        public static string Greetings(string name)
        {
            return "Hello " + name + "Good Morning";
        }
        static void Main(string[] args)
        {
            Message m = Greetings;
            string msg = Greetings("pooja");
            Console.WriteLine(msg);
            Console.ReadKey();
        }

        

      
        
    }
}
