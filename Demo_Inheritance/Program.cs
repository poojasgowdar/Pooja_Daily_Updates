using System;
namespace Demo_Inheritance
{
    class University
    {
        public void CollectFee(int fee)
        {
            Console.WriteLine("Fee:" +fee);
        }
    }

    class College : University
    {
        public void CollectTutionFee(int cost)
        {
            Console.WriteLine("Cost:" +cost);
        }
    }

    class Fest : College
    {
        public void ConductFest(string name)
        {
            Console.WriteLine("Name:" +name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Fest f = new Fest();
            f.ConductFest("Spoorti");
            f.CollectTutionFee(5000);
            f.CollectFee(200);
            Console.ReadKey();
        }
    }
    
}
